namespace Lab7
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
            this.yearsInputTextBox = new System.Windows.Forms.TextBox();
            this.futureValueInputTextbox = new System.Windows.Forms.TextBox();
            this.interestRateInputTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.answerOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yearsInputTextBox
            // 
            this.yearsInputTextBox.Location = new System.Drawing.Point(109, 19);
            this.yearsInputTextBox.Name = "yearsInputTextBox";
            this.yearsInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearsInputTextBox.TabIndex = 0;
            // 
            // futureValueInputTextbox
            // 
            this.futureValueInputTextbox.Location = new System.Drawing.Point(109, 68);
            this.futureValueInputTextbox.Name = "futureValueInputTextbox";
            this.futureValueInputTextbox.Size = new System.Drawing.Size(100, 20);
            this.futureValueInputTextbox.TabIndex = 1;
            // 
            // interestRateInputTextbox
            // 
            this.interestRateInputTextbox.Location = new System.Drawing.Point(109, 120);
            this.interestRateInputTextbox.Name = "interestRateInputTextbox";
            this.interestRateInputTextbox.Size = new System.Drawing.Size(100, 20);
            this.interestRateInputTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter years";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter future value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter interest rate";
            // 
            // answerOutputLabel
            // 
            this.answerOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerOutputLabel.Location = new System.Drawing.Point(73, 170);
            this.answerOutputLabel.Name = "answerOutputLabel";
            this.answerOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.answerOutputLabel.TabIndex = 6;
            this.answerOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 205);
            this.Controls.Add(this.answerOutputLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interestRateInputTextbox);
            this.Controls.Add(this.futureValueInputTextbox);
            this.Controls.Add(this.yearsInputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yearsInputTextBox;
        private System.Windows.Forms.TextBox futureValueInputTextbox;
        private System.Windows.Forms.TextBox interestRateInputTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label answerOutputLabel;
    }
}

