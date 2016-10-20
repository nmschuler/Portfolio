namespace LibraryItems
{
    partial class PatronDialogBox
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
            this.namePromptLabel = new System.Windows.Forms.Label();
            this.idPromptLabel = new System.Windows.Forms.Label();
            this.nameInputTextBox = new System.Windows.Forms.TextBox();
            this.idInputTextBox = new System.Windows.Forms.TextBox();
            this.clearPatronButton = new System.Windows.Forms.Button();
            this.addPatronButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // namePromptLabel
            // 
            this.namePromptLabel.AutoSize = true;
            this.namePromptLabel.Location = new System.Drawing.Point(23, 36);
            this.namePromptLabel.Name = "namePromptLabel";
            this.namePromptLabel.Size = new System.Drawing.Size(38, 13);
            this.namePromptLabel.TabIndex = 0;
            this.namePromptLabel.Text = "Name:";
            // 
            // idPromptLabel
            // 
            this.idPromptLabel.AutoSize = true;
            this.idPromptLabel.Location = new System.Drawing.Point(23, 71);
            this.idPromptLabel.Name = "idPromptLabel";
            this.idPromptLabel.Size = new System.Drawing.Size(21, 13);
            this.idPromptLabel.TabIndex = 1;
            this.idPromptLabel.Text = "ID:";
            // 
            // nameInputTextBox
            // 
            this.nameInputTextBox.Location = new System.Drawing.Point(67, 36);
            this.nameInputTextBox.Name = "nameInputTextBox";
            this.nameInputTextBox.Size = new System.Drawing.Size(133, 20);
            this.nameInputTextBox.TabIndex = 2;
            this.nameInputTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PatronInputTextBox_Validating);
            this.nameInputTextBox.Validated += new System.EventHandler(this.PatronInputTextBox_Validated);
            // 
            // idInputTextBox
            // 
            this.idInputTextBox.Location = new System.Drawing.Point(67, 68);
            this.idInputTextBox.Name = "idInputTextBox";
            this.idInputTextBox.Size = new System.Drawing.Size(133, 20);
            this.idInputTextBox.TabIndex = 3;
            this.idInputTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.IDInputTextBox_Validating);
            this.idInputTextBox.Validated += new System.EventHandler(this.IDInputTextBox_Validated);
            // 
            // clearPatronButton
            // 
            this.clearPatronButton.Location = new System.Drawing.Point(125, 109);
            this.clearPatronButton.Name = "clearPatronButton";
            this.clearPatronButton.Size = new System.Drawing.Size(75, 30);
            this.clearPatronButton.TabIndex = 5;
            this.clearPatronButton.Text = "Clear";
            this.clearPatronButton.UseVisualStyleBackColor = true;
            this.clearPatronButton.Click += new System.EventHandler(this.clearPatronButton_Click);
            // 
            // addPatronButton
            // 
            this.addPatronButton.Location = new System.Drawing.Point(26, 109);
            this.addPatronButton.Name = "addPatronButton";
            this.addPatronButton.Size = new System.Drawing.Size(75, 30);
            this.addPatronButton.TabIndex = 4;
            this.addPatronButton.Text = "Add Patron";
            this.addPatronButton.UseVisualStyleBackColor = true;
            this.addPatronButton.Click += new System.EventHandler(this.addPatronButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PatronDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 167);
            this.Controls.Add(this.addPatronButton);
            this.Controls.Add(this.clearPatronButton);
            this.Controls.Add(this.idInputTextBox);
            this.Controls.Add(this.nameInputTextBox);
            this.Controls.Add(this.idPromptLabel);
            this.Controls.Add(this.namePromptLabel);
            this.Name = "PatronDialogBox";
            this.Text = "PatronDialogBox";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namePromptLabel;
        private System.Windows.Forms.Label idPromptLabel;
        private System.Windows.Forms.TextBox nameInputTextBox;
        private System.Windows.Forms.TextBox idInputTextBox;
        private System.Windows.Forms.Button clearPatronButton;
        private System.Windows.Forms.Button addPatronButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}