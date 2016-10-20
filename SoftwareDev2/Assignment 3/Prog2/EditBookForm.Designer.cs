namespace LibraryItems
{
    partial class EditBookForm
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
            this.editBookPromptLabel = new System.Windows.Forms.Label();
            this.editBookComboBox = new System.Windows.Forms.ComboBox();
            this.selectBookButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // editBookPromptLabel
            // 
            this.editBookPromptLabel.AutoSize = true;
            this.editBookPromptLabel.Location = new System.Drawing.Point(12, 26);
            this.editBookPromptLabel.Name = "editBookPromptLabel";
            this.editBookPromptLabel.Size = new System.Drawing.Size(117, 13);
            this.editBookPromptLabel.TabIndex = 0;
            this.editBookPromptLabel.Text = "Select the book to edit:";
            // 
            // editBookComboBox
            // 
            this.editBookComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editBookComboBox.FormattingEnabled = true;
            this.editBookComboBox.Location = new System.Drawing.Point(135, 23);
            this.editBookComboBox.Name = "editBookComboBox";
            this.editBookComboBox.Size = new System.Drawing.Size(165, 21);
            this.editBookComboBox.TabIndex = 1;
            this.editBookComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.editBookCombo_Validating);
            this.editBookComboBox.Validated += new System.EventHandler(this.editBook_Validated);
            // 
            // selectBookButton
            // 
            this.selectBookButton.Location = new System.Drawing.Point(76, 73);
            this.selectBookButton.Name = "selectBookButton";
            this.selectBookButton.Size = new System.Drawing.Size(114, 43);
            this.selectBookButton.TabIndex = 2;
            this.selectBookButton.Text = "Edit this book";
            this.selectBookButton.UseVisualStyleBackColor = true;
            this.selectBookButton.Click += new System.EventHandler(this.selectBookButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 213);
            this.Controls.Add(this.selectBookButton);
            this.Controls.Add(this.editBookComboBox);
            this.Controls.Add(this.editBookPromptLabel);
            this.Name = "EditBookForm";
            this.Text = "EditBookForm";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editBookPromptLabel;
        private System.Windows.Forms.ComboBox editBookComboBox;
        private System.Windows.Forms.Button selectBookButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}