namespace Birth_Date_String
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
            this.dayOfWeekPromptLabel = new System.Windows.Forms.Label();
            this.monthPromptLabel = new System.Windows.Forms.Label();
            this.dayOfmonthPromptLabel = new System.Windows.Forms.Label();
            this.yearPromptLabel = new System.Windows.Forms.Label();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.dayOfWeekTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayOfMonthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.showDateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayOfWeekPromptLabel
            // 
            this.dayOfWeekPromptLabel.AutoSize = true;
            this.dayOfWeekPromptLabel.Location = new System.Drawing.Point(81, 24);
            this.dayOfWeekPromptLabel.Name = "dayOfWeekPromptLabel";
            this.dayOfWeekPromptLabel.Size = new System.Drawing.Size(129, 13);
            this.dayOfWeekPromptLabel.TabIndex = 0;
            this.dayOfWeekPromptLabel.Text = "Enter the day of the week";
            // 
            // monthPromptLabel
            // 
            this.monthPromptLabel.AutoSize = true;
            this.monthPromptLabel.Location = new System.Drawing.Point(69, 60);
            this.monthPromptLabel.Name = "monthPromptLabel";
            this.monthPromptLabel.Size = new System.Drawing.Size(141, 13);
            this.monthPromptLabel.TabIndex = 1;
            this.monthPromptLabel.Text = "Enter the name of the month";
            // 
            // dayOfmonthPromptLabel
            // 
            this.dayOfmonthPromptLabel.AutoSize = true;
            this.dayOfmonthPromptLabel.Location = new System.Drawing.Point(38, 97);
            this.dayOfmonthPromptLabel.Name = "dayOfmonthPromptLabel";
            this.dayOfmonthPromptLabel.Size = new System.Drawing.Size(172, 13);
            this.dayOfmonthPromptLabel.TabIndex = 2;
            this.dayOfmonthPromptLabel.Text = "Enter the numeric day of the month";
            // 
            // yearPromptLabel
            // 
            this.yearPromptLabel.AutoSize = true;
            this.yearPromptLabel.Location = new System.Drawing.Point(137, 131);
            this.yearPromptLabel.Name = "yearPromptLabel";
            this.yearPromptLabel.Size = new System.Drawing.Size(73, 13);
            this.yearPromptLabel.TabIndex = 3;
            this.yearPromptLabel.Text = "Enter the year";
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.Location = new System.Drawing.Point(12, 172);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(326, 23);
            this.dateOutputLabel.TabIndex = 4;
            this.dateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayOfWeekTextBox
            // 
            this.dayOfWeekTextBox.Location = new System.Drawing.Point(217, 17);
            this.dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            this.dayOfWeekTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayOfWeekTextBox.TabIndex = 5;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(217, 53);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthTextBox.TabIndex = 6;
            // 
            // dayOfMonthTextBox
            // 
            this.dayOfMonthTextBox.Location = new System.Drawing.Point(217, 90);
            this.dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            this.dayOfMonthTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayOfMonthTextBox.TabIndex = 7;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(217, 128);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 8;
            // 
            // showDateButton
            // 
            this.showDateButton.Location = new System.Drawing.Point(12, 216);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(99, 45);
            this.showDateButton.TabIndex = 9;
            this.showDateButton.Text = "Show Date";
            this.showDateButton.UseVisualStyleBackColor = true;
            this.showDateButton.Click += new System.EventHandler(this.showDateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(124, 216);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(99, 45);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(239, 216);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 45);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 273);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayOfMonthTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayOfWeekTextBox);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.yearPromptLabel);
            this.Controls.Add(this.dayOfmonthPromptLabel);
            this.Controls.Add(this.monthPromptLabel);
            this.Controls.Add(this.dayOfWeekPromptLabel);
            this.Name = "Form1";
            this.Text = "Birth Date String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayOfWeekPromptLabel;
        private System.Windows.Forms.Label monthPromptLabel;
        private System.Windows.Forms.Label dayOfmonthPromptLabel;
        private System.Windows.Forms.Label yearPromptLabel;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.TextBox dayOfWeekTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayOfMonthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

