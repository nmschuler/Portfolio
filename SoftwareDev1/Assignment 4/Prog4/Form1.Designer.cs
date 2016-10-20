namespace Prog4
{
    partial class Form1
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
            this.bookAddGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.copyYearTextBox = new System.Windows.Forms.TextBox();
            this.callNumTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.copyrightYearLabel = new System.Windows.Forms.Label();
            this.callNumberLabel = new System.Windows.Forms.Label();
            this.bookInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.bookTitleListBox = new System.Windows.Forms.ListBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.bookAddGroupBox.SuspendLayout();
            this.bookInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookAddGroupBox
            // 
            this.bookAddGroupBox.Controls.Add(this.clearButton);
            this.bookAddGroupBox.Controls.Add(this.addButton);
            this.bookAddGroupBox.Controls.Add(this.titleTextBox);
            this.bookAddGroupBox.Controls.Add(this.authorTextBox);
            this.bookAddGroupBox.Controls.Add(this.publisherTextBox);
            this.bookAddGroupBox.Controls.Add(this.copyYearTextBox);
            this.bookAddGroupBox.Controls.Add(this.callNumTextBox);
            this.bookAddGroupBox.Controls.Add(this.titleLabel);
            this.bookAddGroupBox.Controls.Add(this.authorLabel);
            this.bookAddGroupBox.Controls.Add(this.publisherLabel);
            this.bookAddGroupBox.Controls.Add(this.copyrightYearLabel);
            this.bookAddGroupBox.Controls.Add(this.callNumberLabel);
            this.bookAddGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAddGroupBox.Location = new System.Drawing.Point(12, 12);
            this.bookAddGroupBox.Name = "bookAddGroupBox";
            this.bookAddGroupBox.Size = new System.Drawing.Size(325, 194);
            this.bookAddGroupBox.TabIndex = 0;
            this.bookAddGroupBox.TabStop = false;
            this.bookAddGroupBox.Text = "Add Book";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(233, 108);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(233, 67);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add Book";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(110, 26);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(110, 55);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorTextBox.TabIndex = 2;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(110, 85);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(100, 20);
            this.publisherTextBox.TabIndex = 3;
            // 
            // copyYearTextBox
            // 
            this.copyYearTextBox.Location = new System.Drawing.Point(110, 115);
            this.copyYearTextBox.Name = "copyYearTextBox";
            this.copyYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.copyYearTextBox.TabIndex = 4;
            // 
            // callNumTextBox
            // 
            this.callNumTextBox.Location = new System.Drawing.Point(110, 149);
            this.callNumTextBox.Name = "callNumTextBox";
            this.callNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.callNumTextBox.TabIndex = 5;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(22, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(22, 58);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Author:";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(22, 88);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(53, 13);
            this.publisherLabel.TabIndex = 3;
            this.publisherLabel.Text = "Publisher:";
            // 
            // copyrightYearLabel
            // 
            this.copyrightYearLabel.AutoSize = true;
            this.copyrightYearLabel.Location = new System.Drawing.Point(22, 118);
            this.copyrightYearLabel.Name = "copyrightYearLabel";
            this.copyrightYearLabel.Size = new System.Drawing.Size(79, 13);
            this.copyrightYearLabel.TabIndex = 4;
            this.copyrightYearLabel.Text = "Copyright Year:";
            // 
            // callNumberLabel
            // 
            this.callNumberLabel.AutoSize = true;
            this.callNumberLabel.Location = new System.Drawing.Point(22, 152);
            this.callNumberLabel.Name = "callNumberLabel";
            this.callNumberLabel.Size = new System.Drawing.Size(67, 13);
            this.callNumberLabel.TabIndex = 5;
            this.callNumberLabel.Text = "Call Number:";
            // 
            // bookInfoGroupBox
            // 
            this.bookInfoGroupBox.Controls.Add(this.bookTitleListBox);
            this.bookInfoGroupBox.Controls.Add(this.returnButton);
            this.bookInfoGroupBox.Controls.Add(this.checkOutButton);
            this.bookInfoGroupBox.Controls.Add(this.detailsButton);
            this.bookInfoGroupBox.Location = new System.Drawing.Point(343, 12);
            this.bookInfoGroupBox.Name = "bookInfoGroupBox";
            this.bookInfoGroupBox.Size = new System.Drawing.Size(299, 194);
            this.bookInfoGroupBox.TabIndex = 0;
            this.bookInfoGroupBox.TabStop = false;
            this.bookInfoGroupBox.Text = "Book Information";
            // 
            // bookTitleListBox
            // 
            this.bookTitleListBox.FormattingEnabled = true;
            this.bookTitleListBox.Location = new System.Drawing.Point(15, 19);
            this.bookTitleListBox.Name = "bookTitleListBox";
            this.bookTitleListBox.Size = new System.Drawing.Size(184, 160);
            this.bookTitleListBox.TabIndex = 1;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(205, 149);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 10;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(205, 85);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(75, 23);
            this.checkOutButton.TabIndex = 9;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(205, 26);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 23);
            this.detailsButton.TabIndex = 8;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 253);
            this.Controls.Add(this.bookInfoGroupBox);
            this.Controls.Add(this.bookAddGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.bookAddGroupBox.ResumeLayout(false);
            this.bookAddGroupBox.PerformLayout();
            this.bookInfoGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bookAddGroupBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label copyrightYearLabel;
        private System.Windows.Forms.Label callNumberLabel;
        private System.Windows.Forms.GroupBox bookInfoGroupBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox copyYearTextBox;
        private System.Windows.Forms.TextBox callNumTextBox;
        private System.Windows.Forms.ListBox bookTitleListBox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button detailsButton;
    }
}

