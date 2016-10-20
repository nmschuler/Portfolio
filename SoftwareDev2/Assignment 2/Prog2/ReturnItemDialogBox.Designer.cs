namespace LibraryItems
{
    partial class ReturnItemDialogBox
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
            this.returnItemPromptLabel = new System.Windows.Forms.Label();
            this.returnItemComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // returnItemPromptLabel
            // 
            this.returnItemPromptLabel.AutoSize = true;
            this.returnItemPromptLabel.Location = new System.Drawing.Point(12, 23);
            this.returnItemPromptLabel.Name = "returnItemPromptLabel";
            this.returnItemPromptLabel.Size = new System.Drawing.Size(102, 13);
            this.returnItemPromptLabel.TabIndex = 0;
            this.returnItemPromptLabel.Text = "Item to be returned: ";
            // 
            // returnItemComboBox
            // 
            this.returnItemComboBox.FormattingEnabled = true;
            this.returnItemComboBox.Location = new System.Drawing.Point(120, 20);
            this.returnItemComboBox.Name = "returnItemComboBox";
            this.returnItemComboBox.Size = new System.Drawing.Size(121, 21);
            this.returnItemComboBox.TabIndex = 1;
            this.returnItemComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ReturnItemCombo_Validating);
            this.returnItemComboBox.Validated += new System.EventHandler(this.ReturnItemCombo_Validated);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(135, 61);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 37);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(15, 61);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(89, 37);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ReturnItemDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 132);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.returnItemComboBox);
            this.Controls.Add(this.returnItemPromptLabel);
            this.Name = "ReturnItemDialogBox";
            this.Text = "ReturnItemDialogBox";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label returnItemPromptLabel;
        private System.Windows.Forms.ComboBox returnItemComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}