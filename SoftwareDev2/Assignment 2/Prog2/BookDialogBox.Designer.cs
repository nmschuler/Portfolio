namespace LibraryItems
{
    partial class BookDialogBox
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
            this.titlePromptLabel = new System.Windows.Forms.Label();
            this.publisherPromptLabel = new System.Windows.Forms.Label();
            this.copyrightYearPromptLabel = new System.Windows.Forms.Label();
            this.loanPeriodPromptLabel = new System.Windows.Forms.Label();
            this.callNumberPromptLabel = new System.Windows.Forms.Label();
            this.authorPromptLabel = new System.Windows.Forms.Label();
            this.titleInputTextBox = new System.Windows.Forms.TextBox();
            this.publisherInputTextBox = new System.Windows.Forms.TextBox();
            this.copyrightYearInputTextBox = new System.Windows.Forms.TextBox();
            this.loanPeriodInputTextBox = new System.Windows.Forms.TextBox();
            this.callNumberInputTextBox = new System.Windows.Forms.TextBox();
            this.authorInputTextBox = new System.Windows.Forms.TextBox();
            this.clearBookButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePromptLabel
            // 
            this.titlePromptLabel.AutoSize = true;
            this.titlePromptLabel.Location = new System.Drawing.Point(73, 20);
            this.titlePromptLabel.Name = "titlePromptLabel";
            this.titlePromptLabel.Size = new System.Drawing.Size(30, 13);
            this.titlePromptLabel.TabIndex = 0;
            this.titlePromptLabel.Text = "Title:";
            // 
            // publisherPromptLabel
            // 
            this.publisherPromptLabel.AutoSize = true;
            this.publisherPromptLabel.Location = new System.Drawing.Point(50, 51);
            this.publisherPromptLabel.Name = "publisherPromptLabel";
            this.publisherPromptLabel.Size = new System.Drawing.Size(53, 13);
            this.publisherPromptLabel.TabIndex = 1;
            this.publisherPromptLabel.Text = "Publisher:";
            // 
            // copyrightYearPromptLabel
            // 
            this.copyrightYearPromptLabel.AutoSize = true;
            this.copyrightYearPromptLabel.Location = new System.Drawing.Point(24, 82);
            this.copyrightYearPromptLabel.Name = "copyrightYearPromptLabel";
            this.copyrightYearPromptLabel.Size = new System.Drawing.Size(79, 13);
            this.copyrightYearPromptLabel.TabIndex = 2;
            this.copyrightYearPromptLabel.Text = "Copyright Year:";
            // 
            // loanPeriodPromptLabel
            // 
            this.loanPeriodPromptLabel.AutoSize = true;
            this.loanPeriodPromptLabel.Location = new System.Drawing.Point(36, 116);
            this.loanPeriodPromptLabel.Name = "loanPeriodPromptLabel";
            this.loanPeriodPromptLabel.Size = new System.Drawing.Size(67, 13);
            this.loanPeriodPromptLabel.TabIndex = 3;
            this.loanPeriodPromptLabel.Text = "Loan Period:";
            // 
            // callNumberPromptLabel
            // 
            this.callNumberPromptLabel.AutoSize = true;
            this.callNumberPromptLabel.Location = new System.Drawing.Point(36, 150);
            this.callNumberPromptLabel.Name = "callNumberPromptLabel";
            this.callNumberPromptLabel.Size = new System.Drawing.Size(67, 13);
            this.callNumberPromptLabel.TabIndex = 4;
            this.callNumberPromptLabel.Text = "Call Number:";
            // 
            // authorPromptLabel
            // 
            this.authorPromptLabel.AutoSize = true;
            this.authorPromptLabel.Location = new System.Drawing.Point(62, 181);
            this.authorPromptLabel.Name = "authorPromptLabel";
            this.authorPromptLabel.Size = new System.Drawing.Size(41, 13);
            this.authorPromptLabel.TabIndex = 5;
            this.authorPromptLabel.Text = "Author:";
            // 
            // titleInputTextBox
            // 
            this.titleInputTextBox.Location = new System.Drawing.Point(109, 17);
            this.titleInputTextBox.Name = "titleInputTextBox";
            this.titleInputTextBox.Size = new System.Drawing.Size(148, 20);
            this.titleInputTextBox.TabIndex = 6;
            this.titleInputTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TitleInput_Validating);
            this.titleInputTextBox.Validated += new System.EventHandler(this.TitleInput_Validated);
            // 
            // publisherInputTextBox
            // 
            this.publisherInputTextBox.Location = new System.Drawing.Point(109, 48);
            this.publisherInputTextBox.Name = "publisherInputTextBox";
            this.publisherInputTextBox.Size = new System.Drawing.Size(148, 20);
            this.publisherInputTextBox.TabIndex = 7;
            this.publisherInputTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PublishInput_Validating);
            this.publisherInputTextBox.Validated += new System.EventHandler(this.PublishInput_Validated);
            // 
            // copyrightYearInputTextBox
            // 
            this.copyrightYearInputTextBox.Location = new System.Drawing.Point(109, 79);
            this.copyrightYearInputTextBox.Name = "copyrightYearInputTextBox";
            this.copyrightYearInputTextBox.Size = new System.Drawing.Size(148, 20);
            this.copyrightYearInputTextBox.TabIndex = 8;
            this.copyrightYearInputTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.copyrightYearInput_Validating);
            this.copyrightYearInputTextBox.Validated += new System.EventHandler(this.copyrightYearInput_Validated);
            // 
            // loanPeriodInputTextBox
            // 
            this.loanPeriodInputTextBox.Location = new System.Drawing.Point(109, 113);
            this.loanPeriodInputTextBox.Name = "loanPeriodInputTextBox";
            this.loanPeriodInputTextBox.Size = new System.Drawing.Size(148, 20);
            this.loanPeriodInputTextBox.TabIndex = 9;
            this.loanPeriodInputTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.LoanPeriodInput_Validating);
            this.loanPeriodInputTextBox.Validated += new System.EventHandler(this.LoanPeriodInput_Validated);
            // 
            // callNumberInputTextBox
            // 
            this.callNumberInputTextBox.Location = new System.Drawing.Point(109, 147);
            this.callNumberInputTextBox.Name = "callNumberInputTextBox";
            this.callNumberInputTextBox.Size = new System.Drawing.Size(148, 20);
            this.callNumberInputTextBox.TabIndex = 10;
            this.callNumberInputTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CallNumberInput_Validating);
            this.callNumberInputTextBox.Validated += new System.EventHandler(this.CallNumberInput_Validated);
            // 
            // authorInputTextBox
            // 
            this.authorInputTextBox.Location = new System.Drawing.Point(109, 178);
            this.authorInputTextBox.Name = "authorInputTextBox";
            this.authorInputTextBox.Size = new System.Drawing.Size(148, 20);
            this.authorInputTextBox.TabIndex = 11;
            this.authorInputTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AuthorInput_Validating);
            this.authorInputTextBox.Validated += new System.EventHandler(this.AuthorInput_Validated);
            // 
            // clearBookButton
            // 
            this.clearBookButton.Location = new System.Drawing.Point(163, 228);
            this.clearBookButton.Name = "clearBookButton";
            this.clearBookButton.Size = new System.Drawing.Size(88, 37);
            this.clearBookButton.TabIndex = 12;
            this.clearBookButton.Text = "Clear";
            this.clearBookButton.UseVisualStyleBackColor = true;
            this.clearBookButton.Click += new System.EventHandler(this.clearBookButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(47, 228);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(88, 37);
            this.addBookButton.TabIndex = 13;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BookDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 292);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.clearBookButton);
            this.Controls.Add(this.authorInputTextBox);
            this.Controls.Add(this.callNumberInputTextBox);
            this.Controls.Add(this.loanPeriodInputTextBox);
            this.Controls.Add(this.copyrightYearInputTextBox);
            this.Controls.Add(this.publisherInputTextBox);
            this.Controls.Add(this.titleInputTextBox);
            this.Controls.Add(this.authorPromptLabel);
            this.Controls.Add(this.callNumberPromptLabel);
            this.Controls.Add(this.loanPeriodPromptLabel);
            this.Controls.Add(this.copyrightYearPromptLabel);
            this.Controls.Add(this.publisherPromptLabel);
            this.Controls.Add(this.titlePromptLabel);
            this.Name = "BookDialogBox";
            this.Text = "Enter Book Information";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlePromptLabel;
        private System.Windows.Forms.Label publisherPromptLabel;
        private System.Windows.Forms.Label copyrightYearPromptLabel;
        private System.Windows.Forms.Label loanPeriodPromptLabel;
        private System.Windows.Forms.Label callNumberPromptLabel;
        private System.Windows.Forms.Label authorPromptLabel;
        private System.Windows.Forms.TextBox titleInputTextBox;
        private System.Windows.Forms.TextBox publisherInputTextBox;
        private System.Windows.Forms.TextBox copyrightYearInputTextBox;
        private System.Windows.Forms.TextBox loanPeriodInputTextBox;
        private System.Windows.Forms.TextBox callNumberInputTextBox;
        private System.Windows.Forms.TextBox authorInputTextBox;
        private System.Windows.Forms.Button clearBookButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}