namespace LibraryItems
{
    partial class CheckOutDialogBox
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
            this.components = new System.ComponentModel.Container();
            this.libraryItemComboBox = new System.Windows.Forms.ComboBox();
            this.patronComboBox = new System.Windows.Forms.ComboBox();
            this.selectLibraryItemPromptLabel = new System.Windows.Forms.Label();
            this.selectPatronPromptLabel = new System.Windows.Forms.Label();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryItemComboBox
            // 
            this.libraryItemComboBox.FormattingEnabled = true;
            this.libraryItemComboBox.Location = new System.Drawing.Point(142, 26);
            this.libraryItemComboBox.Name = "libraryItemComboBox";
            this.libraryItemComboBox.Size = new System.Drawing.Size(121, 21);
            this.libraryItemComboBox.TabIndex = 0;
            this.libraryItemComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.LibraryItemCombo_Validating);
            this.libraryItemComboBox.Validated += new System.EventHandler(this.LibraryItemCombo_Validated);
            // 
            // patronComboBox
            // 
            this.patronComboBox.FormattingEnabled = true;
            this.patronComboBox.Location = new System.Drawing.Point(142, 80);
            this.patronComboBox.Name = "patronComboBox";
            this.patronComboBox.Size = new System.Drawing.Size(121, 21);
            this.patronComboBox.TabIndex = 1;
            this.patronComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.PatronCombo_Validating);
            this.patronComboBox.Validated += new System.EventHandler(this.PatronCombo_Validated);
            // 
            // selectLibraryItemPromptLabel
            // 
            this.selectLibraryItemPromptLabel.AutoSize = true;
            this.selectLibraryItemPromptLabel.Location = new System.Drawing.Point(12, 29);
            this.selectLibraryItemPromptLabel.Name = "selectLibraryItemPromptLabel";
            this.selectLibraryItemPromptLabel.Size = new System.Drawing.Size(94, 13);
            this.selectLibraryItemPromptLabel.TabIndex = 2;
            this.selectLibraryItemPromptLabel.Text = "Select Library Item";
            // 
            // selectPatronPromptLabel
            // 
            this.selectPatronPromptLabel.AutoSize = true;
            this.selectPatronPromptLabel.Location = new System.Drawing.Point(35, 83);
            this.selectPatronPromptLabel.Name = "selectPatronPromptLabel";
            this.selectPatronPromptLabel.Size = new System.Drawing.Size(71, 13);
            this.selectPatronPromptLabel.TabIndex = 3;
            this.selectPatronPromptLabel.Text = "Select Patron";
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(31, 130);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(97, 41);
            this.checkOutButton.TabIndex = 4;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(154, 130);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(97, 41);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CheckOutDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 196);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.selectPatronPromptLabel);
            this.Controls.Add(this.selectLibraryItemPromptLabel);
            this.Controls.Add(this.patronComboBox);
            this.Controls.Add(this.libraryItemComboBox);
            this.Name = "CheckOutDialogBox";
            this.Text = "CheckOutDialogBox";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox libraryItemComboBox;
        private System.Windows.Forms.ComboBox patronComboBox;
        private System.Windows.Forms.Label selectLibraryItemPromptLabel;
        private System.Windows.Forms.Label selectPatronPromptLabel;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}