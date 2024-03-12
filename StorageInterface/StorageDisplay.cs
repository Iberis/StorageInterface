using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using System.Data.SqlTypes;

namespace StorageInterface
{
    public partial class StorageDisplay : Form
    {
        private SQLiteCommander sQLiteCommander;
        private UpdateValueForm activeSubForm = null;

        public StorageDisplay()
        {
            InitializeComponent();
            sQLiteCommander = new SQLiteCommander();
        }

        private void StorageDisplay_Load(object sender, EventArgs e)
        {
            string[] keys = sQLiteCommander.SelectionChoices.Keys.ToArray();
            comboBoxColumnSelector1.Items.AddRange(keys);
            comboBoxColumnSelector2.Items.AddRange(keys);
            comboBoxColumnSelector3.Items.AddRange(keys);

            comboBoxColumnSelector1.SelectedIndex = 0;
            ReadoutSQLite();
        }

        #region Read From SQLite

        /*
         * Executes a SQLite Query, accounting for any limitations
         * through set user controls.
         * The data is then stored and displayed in the DataGridView.
         */
        private void ReadoutSQLite()
        {
            using (SQLiteDataReader dataReader = sQLiteCommander.ReadoutSQLite(GetSelectionCriteria(), GetConditions()))
            {
                // Initialise DataGridView Columns
                DataGridViewColumnCollection columns = dataGridViewDisplay.Columns;
                columns.Clear();
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    columns.Add(dataReader.GetOriginalName(i), dataReader.GetName(i));
                }

                // Parse data and populate DataGridView
                while (dataReader.Read())
                {
                    string[] values = new string[dataReader.FieldCount];
                    dataReader.GetValues().CopyTo(values, 0);
                    dataGridViewDisplay.Rows.Add(values);
                }
            }
            sQLiteCommander.CloseConnection();
        }

        /* Checks for any set conditions and returns them.
         * Results are split between two Collections based on
         * the value type the user input.
         * One, non, or both can be empty.
         */
        private List<GenericValueCondition> GetConditions()
        {
            List<GenericValueCondition> conditions = new List<GenericValueCondition>
            {
                ParseConditionInput(comboBoxColumnSelector1, textBoxConstraint1),
                ParseConditionInput(comboBoxColumnSelector2, textBoxConstraint2),
                ParseConditionInput(comboBoxColumnSelector3, textBoxConstraint3)
            };

            for (int i = conditions.Count() - 1; i >= 0; i--)
            {
                if (conditions[i] is null)
                {
                    conditions.RemoveAt(i);
                }
            }

            return conditions;
        }

        /*
         * Reads out a ComboBox and TextBox pair and returns a Condition object
         * parsed from the user input.
         * If unable to create a valid Condition, returns null.
         */
        private GenericValueCondition ParseConditionInput(ComboBox columnWithOperator, TextBox inputTextBox)
        {
            string sanitisedUserInput = inputTextBox.Text.Trim();
            if (sanitisedUserInput.Equals(string.Empty))
                return null;

            Condition valuelessCondition = sQLiteCommander.SelectionChoices[columnWithOperator.Text];

            if (int.TryParse(sanitisedUserInput, out int integer))
                return new ValueCondition<int>(valuelessCondition, integer);
            else
                return new StringCondition(valuelessCondition, sanitisedUserInput);
        }

        /* Checks selected columns for use in the SQLRequest
         * and returns them. 
         */
        private List<string> GetSelectionCriteria()
        {
            List<string> columns = new List<string>();
            // Controls abfrage und Formatierung

            return columns;
        }
        #endregion
        #region Events
            #region Condition Input
        private void ComboBoxColumnSelector2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxConstraint2.Visible = true;
        }

        private void ComboBoxColumnSelector3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxConstraint3.Visible = true;
        }

        private void TextBoxConstraint1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxConstraint1.Text == string.Empty)
            {
                comboBoxColumnSelector2.Enabled = false;
                textBoxConstraint2.Enabled = false;
            }
            else
            {
                comboBoxColumnSelector2.Enabled = true;
                textBoxConstraint2.Enabled = true;
            }
        }

        private void TextBoxConstraint2_CustomStateChanged(object sender, EventArgs e)
        {
            if (!textBoxConstraint2.Enabled || textBoxConstraint2.Text == string.Empty)
            {
                comboBoxColumnSelector3.Enabled = false;
                textBoxConstraint3.Enabled = false;
            }
            else
            {
                comboBoxColumnSelector3.Enabled = true;
                textBoxConstraint3.Enabled = true;
                comboBoxColumnSelector3.Visible = true;
            }
        }
            #endregion
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            ReadoutSQLite();
        }

        private void ButtonUpdateWindow_Click(object sender, EventArgs e)
        {
            if (activeSubForm is null || activeSubForm.IsDisposed)
            {
                activeSubForm = new UpdateValueForm(sQLiteCommander);
                activeSubForm.Show();
            }
                
            activeSubForm.BringToFront();
        }

        private void StorageDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            sQLiteCommander.Dispose();
        }

        #endregion
    }
}