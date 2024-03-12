namespace StorageInterface
{
    partial class StorageDisplay
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.comboBoxColumnSelector1 = new System.Windows.Forms.ComboBox();
            this.labelConstrains = new System.Windows.Forms.Label();
            this.textBoxConstraint1 = new System.Windows.Forms.TextBox();
            this.comboBoxColumnSelector2 = new System.Windows.Forms.ComboBox();
            this.textBoxConstraint2 = new System.Windows.Forms.TextBox();
            this.comboBoxColumnSelector3 = new System.Windows.Forms.ComboBox();
            this.textBoxConstraint3 = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonUpdateWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.AllowUserToAddRows = false;
            this.dataGridViewDisplay.AllowUserToDeleteRows = false;
            this.dataGridViewDisplay.AllowUserToOrderColumns = true;
            this.dataGridViewDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.ReadOnly = true;
            this.dataGridViewDisplay.RowHeadersWidth = 51;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(344, 426);
            this.dataGridViewDisplay.TabIndex = 0;
            // 
            // comboBoxColumnSelector1
            // 
            this.comboBoxColumnSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColumnSelector1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxColumnSelector1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumnSelector1.Location = new System.Drawing.Point(379, 31);
            this.comboBoxColumnSelector1.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.comboBoxColumnSelector1.Name = "comboBoxColumnSelector1";
            this.comboBoxColumnSelector1.Size = new System.Drawing.Size(133, 21);
            this.comboBoxColumnSelector1.TabIndex = 2;
            // 
            // labelConstrains
            // 
            this.labelConstrains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConstrains.AutoSize = true;
            this.labelConstrains.Enabled = false;
            this.labelConstrains.Location = new System.Drawing.Point(379, 12);
            this.labelConstrains.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.labelConstrains.Name = "labelConstrains";
            this.labelConstrains.Size = new System.Drawing.Size(37, 13);
            this.labelConstrains.TabIndex = 1;
            this.labelConstrains.Text = "Filters:";
            // 
            // textBoxConstraint1
            // 
            this.textBoxConstraint1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConstraint1.Location = new System.Drawing.Point(519, 31);
            this.textBoxConstraint1.Name = "textBoxConstraint1";
            this.textBoxConstraint1.Size = new System.Drawing.Size(269, 20);
            this.textBoxConstraint1.TabIndex = 3;
            this.textBoxConstraint1.WordWrap = false;
            this.textBoxConstraint1.TextChanged += new System.EventHandler(this.TextBoxConstraint1_TextChanged);
            // 
            // comboBoxColumnSelector2
            // 
            this.comboBoxColumnSelector2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColumnSelector2.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxColumnSelector2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumnSelector2.Enabled = false;
            this.comboBoxColumnSelector2.Location = new System.Drawing.Point(379, 58);
            this.comboBoxColumnSelector2.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.comboBoxColumnSelector2.Name = "comboBoxColumnSelector2";
            this.comboBoxColumnSelector2.Size = new System.Drawing.Size(133, 21);
            this.comboBoxColumnSelector2.TabIndex = 4;
            this.comboBoxColumnSelector2.SelectedIndexChanged += new System.EventHandler(this.ComboBoxColumnSelector2_SelectedIndexChanged);
            // 
            // textBoxConstraint2
            // 
            this.textBoxConstraint2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConstraint2.Enabled = false;
            this.textBoxConstraint2.Location = new System.Drawing.Point(519, 59);
            this.textBoxConstraint2.Name = "textBoxConstraint2";
            this.textBoxConstraint2.Size = new System.Drawing.Size(269, 20);
            this.textBoxConstraint2.TabIndex = 5;
            this.textBoxConstraint2.Visible = false;
            this.textBoxConstraint2.WordWrap = false;
            this.textBoxConstraint2.EnabledChanged += new System.EventHandler(this.TextBoxConstraint2_CustomStateChanged);
            this.textBoxConstraint2.TextChanged += new System.EventHandler(this.TextBoxConstraint2_CustomStateChanged);
            // 
            // comboBoxColumnSelector3
            // 
            this.comboBoxColumnSelector3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColumnSelector3.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxColumnSelector3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumnSelector3.Enabled = false;
            this.comboBoxColumnSelector3.Location = new System.Drawing.Point(379, 85);
            this.comboBoxColumnSelector3.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.comboBoxColumnSelector3.Name = "comboBoxColumnSelector3";
            this.comboBoxColumnSelector3.Size = new System.Drawing.Size(133, 21);
            this.comboBoxColumnSelector3.TabIndex = 6;
            this.comboBoxColumnSelector3.Visible = false;
            this.comboBoxColumnSelector3.SelectedIndexChanged += new System.EventHandler(this.ComboBoxColumnSelector3_SelectedIndexChanged);
            // 
            // textBoxConstraint3
            // 
            this.textBoxConstraint3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConstraint3.Enabled = false;
            this.textBoxConstraint3.Location = new System.Drawing.Point(519, 86);
            this.textBoxConstraint3.Name = "textBoxConstraint3";
            this.textBoxConstraint3.Size = new System.Drawing.Size(269, 20);
            this.textBoxConstraint3.TabIndex = 7;
            this.textBoxConstraint3.Visible = false;
            this.textBoxConstraint3.WordWrap = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(713, 112);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 99;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // buttonUpdateWindow
            // 
            this.buttonUpdateWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateWindow.Location = new System.Drawing.Point(712, 142);
            this.buttonUpdateWindow.Name = "buttonUpdateWindow";
            this.buttonUpdateWindow.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateWindow.TabIndex = 100;
            this.buttonUpdateWindow.Text = "Update Entries";
            this.buttonUpdateWindow.UseVisualStyleBackColor = true;
            this.buttonUpdateWindow.Click += new System.EventHandler(this.ButtonUpdateWindow_Click);
            // 
            // StorageDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdateWindow);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxConstraint3);
            this.Controls.Add(this.comboBoxColumnSelector3);
            this.Controls.Add(this.textBoxConstraint2);
            this.Controls.Add(this.comboBoxColumnSelector2);
            this.Controls.Add(this.textBoxConstraint1);
            this.Controls.Add(this.labelConstrains);
            this.Controls.Add(this.comboBoxColumnSelector1);
            this.Controls.Add(this.dataGridViewDisplay);
            this.MinimumSize = new System.Drawing.Size(695, 220);
            this.Name = "StorageDisplay";
            this.Text = "StorageDisplay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StorageDisplay_FormClosed);
            this.Load += new System.EventHandler(this.StorageDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.ComboBox comboBoxColumnSelector1;
        private System.Windows.Forms.Label labelConstrains;
        private System.Windows.Forms.TextBox textBoxConstraint1;
        private System.Windows.Forms.ComboBox comboBoxColumnSelector2;
        private System.Windows.Forms.TextBox textBoxConstraint2;
        private System.Windows.Forms.ComboBox comboBoxColumnSelector3;
        private System.Windows.Forms.TextBox textBoxConstraint3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonUpdateWindow;
    }
}

