namespace LibraryItems
{
    partial class EditPatronForm
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
            this.patronSelectComboBox = new System.Windows.Forms.ComboBox();
            this.selectPatronButton = new System.Windows.Forms.Button();
            this.patronEditPromptLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // patronSelectComboBox
            // 
            this.patronSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patronSelectComboBox.FormattingEnabled = true;
            this.patronSelectComboBox.Location = new System.Drawing.Point(154, 26);
            this.patronSelectComboBox.Name = "patronSelectComboBox";
            this.patronSelectComboBox.Size = new System.Drawing.Size(159, 21);
            this.patronSelectComboBox.TabIndex = 0;
            this.patronSelectComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.patronSelectCombo_Validating);
            this.patronSelectComboBox.Validated += new System.EventHandler(this.patronSelectCombo_Validated);
            // 
            // selectPatronButton
            // 
            this.selectPatronButton.Location = new System.Drawing.Point(64, 84);
            this.selectPatronButton.Name = "selectPatronButton";
            this.selectPatronButton.Size = new System.Drawing.Size(84, 40);
            this.selectPatronButton.TabIndex = 1;
            this.selectPatronButton.Text = "Select this patron";
            this.selectPatronButton.UseVisualStyleBackColor = true;
            this.selectPatronButton.Click += new System.EventHandler(this.selectPatronButton_Click);
            // 
            // patronEditPromptLabel
            // 
            this.patronEditPromptLabel.AutoSize = true;
            this.patronEditPromptLabel.Location = new System.Drawing.Point(12, 29);
            this.patronEditPromptLabel.Name = "patronEditPromptLabel";
            this.patronEditPromptLabel.Size = new System.Drawing.Size(136, 13);
            this.patronEditPromptLabel.TabIndex = 2;
            this.patronEditPromptLabel.Text = "Select which patron to edit:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditPatronForm
            // 
            this.AcceptButton = this.selectPatronButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 163);
            this.Controls.Add(this.patronEditPromptLabel);
            this.Controls.Add(this.selectPatronButton);
            this.Controls.Add(this.patronSelectComboBox);
            this.Name = "EditPatronForm";
            this.Text = "EditPatronForm";
            this.Load += new System.EventHandler(this.EditPatronForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox patronSelectComboBox;
        private System.Windows.Forms.Button selectPatronButton;
        private System.Windows.Forms.Label patronEditPromptLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}