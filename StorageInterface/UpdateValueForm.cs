using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageInterface
{
    public partial class UpdateValueForm : Form
    {
        private readonly SQLiteCommander sQLiteCommander;
        private readonly IList collection;
        private UpdateSubformNewId subformNewId;

        public UpdateValueForm(SQLiteCommander sQLiteCommander)
        {
            this.sQLiteCommander = sQLiteCommander;
            InitializeComponent();

            collection = listBoxChanges.Items;
            comboBoxActionChoice.SelectedIndex = 0;
        }

        #region New Id

        private void NewIdDialogue()
        {
            if (subformNewId is null || subformNewId.IsDisposed)
            {
                subformNewId = new UpdateSubformNewId(sQLiteCommander);
                AddOwnedForm(subformNewId);
                subformNewId.Show();
            }
            subformNewId.BringToFront();
        }

        #endregion
        #region User Input

        private void ParseChange()
        {
            if (!Int32.TryParse(textBoxItemId.Text, out int id))
            {
                MessageBox.Show("Only numerical IDs are supported.");
                return;
            }

            bool overwrite = comboBoxActionChoice.SelectedIndex == 1;
            int amount = (int)numericUpDownAmount.Value;

            bool doNotSum = overwrite;
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                Item element = collection[i] as Item;
                if (element.StorageId.Equals(id))
                {
                    if (!doNotSum)
                    {
                        amount += element.Amount;
                        if (element.Overwrite)
                            overwrite = true;
                    }

                    collection.RemoveAt(i);
                }
            }

            collection.Add(new Item(id, amount, overwrite));
        }

        private void DeleteSelected()
        {
            ListBox.SelectedIndexCollection items = listBoxChanges.SelectedIndices;
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (items.Contains(i))
                {
                    collection.RemoveAt(i);
                }
            }            
        }

        #endregion

        #region Commit

        private void Commit()
        {
            int result = sQLiteCommander.PushSQLiteUpdate(GetItems());

            string message = "No changes made.\n" 
                + "Confirm input or database";
            if (result > 0)
            {
                message = "Operation successful.\n" + result + " rows changed.";
            }
            collection.Clear();
            MessageBox.Show(message);
        }

        private Item[] GetItems()
        {
            ClearInvalidEntries();

            Item[] items = new Item[collection.Count];
            collection.CopyTo(items, 0);

            return items;
        }

        private void ClearInvalidEntries()
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                Item element = collection[i] as Item;
                if (element.IsInvalid)
                    collection.RemoveAt(i);
            }
        }

        #endregion

        #region Events

        private void ButtonAddChange_Click(object sender, EventArgs e)
        {
            ParseChange();
        }

        private void NumericUpDownAmmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Return))
                ButtonAddChange_Click(sender, e);
        }

        private void TextBoxItemId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Return))
                ButtonAddChange_Click(sender, e);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteSelected();
        }

        private void ButtonCommit_Click(object sender, EventArgs e)
        {
            if (collection.Count > 0)
                Commit();
        }

        private void ButtonNewId_Click(object sender, EventArgs e)
        {
            NewIdDialogue();
        }

        #endregion
    }
}
