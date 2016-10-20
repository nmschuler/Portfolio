namespace Lab9
{
    partial class DateForm
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.monthButton = new System.Windows.Forms.Button();
            this.dayButton = new System.Windows.Forms.Button();
            this.yearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(55, 29);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date:";
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.Location = new System.Drawing.Point(94, 24);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.dateOutputLabel.TabIndex = 1;
            this.dateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(12, 81);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 2;
            this.monthLabel.Text = "Month:";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(23, 107);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(29, 13);
            this.dayLabel.TabIndex = 3;
            this.dayLabel.Text = "Day:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(20, 135);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year:";
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(58, 78);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthTextBox.TabIndex = 5;
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(58, 107);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(58, 135);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 7;
            // 
            // monthButton
            // 
            this.monthButton.Location = new System.Drawing.Point(164, 78);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(92, 23);
            this.monthButton.TabIndex = 8;
            this.monthButton.Text = "Update Month";
            this.monthButton.UseVisualStyleBackColor = true;
            this.monthButton.Click += new System.EventHandler(this.monthButton_Click);
            // 
            // dayButton
            // 
            this.dayButton.Location = new System.Drawing.Point(164, 107);
            this.dayButton.Name = "dayButton";
            this.dayButton.Size = new System.Drawing.Size(92, 23);
            this.dayButton.TabIndex = 9;
            this.dayButton.Text = "Update Day";
            this.dayButton.UseVisualStyleBackColor = true;
            this.dayButton.Click += new System.EventHandler(this.dayButton_Click);
            // 
            // yearButton
            // 
            this.yearButton.Location = new System.Drawing.Point(164, 136);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(92, 23);
            this.yearButton.TabIndex = 10;
            this.yearButton.Text = "Update Year";
            this.yearButton.UseVisualStyleBackColor = true;
            this.yearButton.Click += new System.EventHandler(this.yearButton_Click);
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 175);
            this.Controls.Add(this.yearButton);
            this.Controls.Add(this.dayButton);
            this.Controls.Add(this.monthButton);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.dateLabel);
            this.Name = "DateForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button monthButton;
        private System.Windows.Forms.Button dayButton;
        private System.Windows.Forms.Button yearButton;
    }
}

