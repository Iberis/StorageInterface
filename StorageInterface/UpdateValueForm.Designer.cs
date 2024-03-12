namespace StorageInterface
{
    partial class UpdateValueForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxChanges = new System.Windows.Forms.ListBox();
            this.textBoxItemId = new System.Windows.Forms.TextBox();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.labelStorageId = new System.Windows.Forms.Label();
            this.comboBoxActionChoice = new System.Windows.Forms.ComboBox();
            this.buttonAddChange = new System.Windows.Forms.Button();
            this.buttonCommit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNewId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxChanges
            // 
            this.listBoxChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxChanges.FormattingEnabled = true;
            this.listBoxChanges.Location = new System.Drawing.Point(12, 65);
            this.listBoxChanges.MultiColumn = true;
            this.listBoxChanges.Name = "listBoxChanges";
            this.listBoxChanges.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxChanges.Size = new System.Drawing.Size(308, 277);
            this.listBoxChanges.Sorted = true;
            this.listBoxChanges.TabIndex = 4;
            this.listBoxChanges.TabStop = false;
            // 
            // textBoxItemId
            // 
            this.textBoxItemId.Location = new System.Drawing.Point(12, 39);
            this.textBoxItemId.Name = "textBoxItemId";
            this.textBoxItemId.Size = new System.Drawing.Size(100, 20);
            this.textBoxItemId.TabIndex = 0;
            this.textBoxItemId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxItemId_KeyPress);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(119, 39);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAmount.TabIndex = 2;
            this.numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAmount.ThousandsSeparator = true;
            this.numericUpDownAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericUpDownAmmount_KeyPress);
            // 
            // labelStorageId
            // 
            this.labelStorageId.AutoSize = true;
            this.labelStorageId.Location = new System.Drawing.Point(9, 20);
            this.labelStorageId.Name = "labelStorageId";
            this.labelStorageId.Size = new System.Drawing.Size(61, 13);
            this.labelStorageId.TabIndex = 99;
            this.labelStorageId.Text = "Storage ID:";
            // 
            // comboBoxActionChoice
            // 
            this.comboBoxActionChoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxActionChoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxActionChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActionChoice.Items.AddRange(new object[] {
            "Amount changed by:",
            "Total amount set to:"});
            this.comboBoxActionChoice.Location = new System.Drawing.Point(119, 12);
            this.comboBoxActionChoice.Name = "comboBoxActionChoice";
            this.comboBoxActionChoice.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActionChoice.TabIndex = 1;
            // 
            // buttonAddChange
            // 
            this.buttonAddChange.Location = new System.Drawing.Point(245, 37);
            this.buttonAddChange.Name = "buttonAddChange";
            this.buttonAddChange.Size = new System.Drawing.Size(75, 23);
            this.buttonAddChange.TabIndex = 3;
            this.buttonAddChange.Text = "Confirm";
            this.buttonAddChange.UseVisualStyleBackColor = true;
            this.buttonAddChange.Click += new System.EventHandler(this.ButtonAddChange_Click);
            // 
            // buttonCommit
            // 
            this.buttonCommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCommit.Location = new System.Drawing.Point(327, 303);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(75, 38);
            this.buttonCommit.TabIndex = 10;
            this.buttonCommit.TabStop = false;
            this.buttonCommit.Text = "Commit Changes";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.ButtonCommit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(327, 274);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete Change";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonNewId
            // 
            this.buttonNewId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewId.Location = new System.Drawing.Point(327, 65);
            this.buttonNewId.Name = "buttonNewId";
            this.buttonNewId.Size = new System.Drawing.Size(75, 23);
            this.buttonNewId.TabIndex = 100;
            this.buttonNewId.Text = "New ID";
            this.buttonNewId.UseVisualStyleBackColor = true;
            this.buttonNewId.Click += new System.EventHandler(this.ButtonNewId_Click);
            // 
            // UpdateValueForm
            // 
            this.AcceptButton = this.buttonAddChange;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 356);
            this.Controls.Add(this.buttonNewId);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCommit);
            this.Controls.Add(this.buttonAddChange);
            this.Controls.Add(this.comboBoxActionChoice);
            this.Controls.Add(this.labelStorageId);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.textBoxItemId);
            this.Controls.Add(this.listBoxChanges);
            this.MinimumSize = new System.Drawing.Size(343, 189);
            this.Name = "UpdateValueForm";
            this.Text = "Update Storage Amounts";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxChanges;
        private System.Windows.Forms.TextBox textBoxItemId;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label labelStorageId;
        private System.Windows.Forms.ComboBox comboBoxActionChoice;
        private System.Windows.Forms.Button buttonAddChange;
        private System.Windows.Forms.Button buttonCommit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNewId;
    }
}