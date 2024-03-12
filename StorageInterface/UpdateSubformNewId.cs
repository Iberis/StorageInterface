using System;
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
    public partial class UpdateSubformNewId : Form
    {
        SQLiteCommander sQLiteCommander;

        public UpdateSubformNewId(SQLiteCommander sQLiteCommander)
        {
            this.sQLiteCommander = sQLiteCommander;
            InitializeComponent();
        }

        private void Commit()
        {
            if (!Int32.TryParse(textBoxId.Text, out int id))
            {
                MessageBox.Show("Only numerical IDs are supported.");
                return;
            }

            string name = textBoxName.Text.Trim();

            if (name.Equals(string.Empty))
            {
                MessageBox.Show("Name Cannot Be Empty");
                return;
            }

            int amount = (int)numericUpDownAmount.Value;

            string errorCode = sQLiteCommander.AddNewEntry(id, name, amount);

            if (errorCode.Equals(string.Empty))
            {
                MessageBox.Show("Operation Sucessful");
            }
            else
            {
                MessageBox.Show("Operation Failed\n" + errorCode);
            }
        }

        private void ButtonCommit_Click(object sender, EventArgs e)
        {
            Commit();
        }
    }
}
