namespace Lab4
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
            this.gpaInputTextBox = new System.Windows.Forms.TextBox();
            this.admissionScoreInputTextBox = new System.Windows.Forms.TextBox();
            this.gpaInputLabel = new System.Windows.Forms.Label();
            this.admissionScoreLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.applicantsAcceptedLabel = new System.Windows.Forms.Label();
            this.applicantsAcceptedOutputLabel = new System.Windows.Forms.Label();
            this.applicantsDeclinedLabel = new System.Windows.Forms.Label();
            this.applicantsDeclinedOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpaInputTextBox
            // 
            this.gpaInputTextBox.Location = new System.Drawing.Point(156, 40);
            this.gpaInputTextBox.Name = "gpaInputTextBox";
            this.gpaInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.gpaInputTextBox.TabIndex = 0;
            // 
            // admissionScoreInputTextBox
            // 
            this.admissionScoreInputTextBox.Location = new System.Drawing.Point(156, 78);
            this.admissionScoreInputTextBox.Name = "admissionScoreInputTextBox";
            this.admissionScoreInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.admissionScoreInputTextBox.TabIndex = 1;
            // 
            // gpaInputLabel
            // 
            this.gpaInputLabel.AutoSize = true;
            this.gpaInputLabel.Location = new System.Drawing.Point(27, 40);
            this.gpaInputLabel.Name = "gpaInputLabel";
            this.gpaInputLabel.Size = new System.Drawing.Size(57, 13);
            this.gpaInputLabel.TabIndex = 2;
            this.gpaInputLabel.Text = "Enter GPA";
            // 
            // admissionScoreLabel
            // 
            this.admissionScoreLabel.AutoSize = true;
            this.admissionScoreLabel.Location = new System.Drawing.Point(12, 85);
            this.admissionScoreLabel.Name = "admissionScoreLabel";
            this.admissionScoreLabel.Size = new System.Drawing.Size(130, 13);
            this.admissionScoreLabel.TabIndex = 3;
            this.admissionScoreLabel.Text = "Enter admission test score";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(4, 196);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(100, 196);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(192, 196);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // applicantsAcceptedLabel
            // 
            this.applicantsAcceptedLabel.AutoSize = true;
            this.applicantsAcceptedLabel.Location = new System.Drawing.Point(27, 124);
            this.applicantsAcceptedLabel.Name = "applicantsAcceptedLabel";
            this.applicantsAcceptedLabel.Size = new System.Drawing.Size(105, 13);
            this.applicantsAcceptedLabel.TabIndex = 7;
            this.applicantsAcceptedLabel.Text = "Applicants Accepted";
            // 
            // applicantsAcceptedOutputLabel
            // 
            this.applicantsAcceptedOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.applicantsAcceptedOutputLabel.Location = new System.Drawing.Point(156, 119);
            this.applicantsAcceptedOutputLabel.Name = "applicantsAcceptedOutputLabel";
            this.applicantsAcceptedOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.applicantsAcceptedOutputLabel.TabIndex = 8;
            this.applicantsAcceptedOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // applicantsDeclinedLabel
            // 
            this.applicantsDeclinedLabel.AutoSize = true;
            this.applicantsDeclinedLabel.Location = new System.Drawing.Point(31, 152);
            this.applicantsDeclinedLabel.Name = "applicantsDeclinedLabel";
            this.applicantsDeclinedLabel.Size = new System.Drawing.Size(101, 13);
            this.applicantsDeclinedLabel.TabIndex = 9;
            this.applicantsDeclinedLabel.Text = "Applicants Declined";
            // 
            // applicantsDeclinedOutputLabel
            // 
            this.applicantsDeclinedOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.applicantsDeclinedOutputLabel.Location = new System.Drawing.Point(156, 152);
            this.applicantsDeclinedOutputLabel.Name = "applicantsDeclinedOutputLabel";
            this.applicantsDeclinedOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.applicantsDeclinedOutputLabel.TabIndex = 10;
            this.applicantsDeclinedOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 231);
            this.Controls.Add(this.applicantsDeclinedOutputLabel);
            this.Controls.Add(this.applicantsDeclinedLabel);
            this.Controls.Add(this.applicantsAcceptedOutputLabel);
            this.Controls.Add(this.applicantsAcceptedLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.admissionScoreLabel);
            this.Controls.Add(this.gpaInputLabel);
            this.Controls.Add(this.admissionScoreInputTextBox);
            this.Controls.Add(this.gpaInputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gpaInputTextBox;
        private System.Windows.Forms.TextBox admissionScoreInputTextBox;
        private System.Windows.Forms.Label gpaInputLabel;
        private System.Windows.Forms.Label admissionScoreLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label applicantsAcceptedLabel;
        private System.Windows.Forms.Label applicantsAcceptedOutputLabel;
        private System.Windows.Forms.Label applicantsDeclinedLabel;
        private System.Windows.Forms.Label applicantsDeclinedOutputLabel;
    }
}

