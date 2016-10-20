namespace FinalEC
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
            this.areaCodePromptLabel = new System.Windows.Forms.Label();
            this.minutesPromptLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceOutputLabel = new System.Windows.Forms.Label();
            this.areaCodeTextBox = new System.Windows.Forms.TextBox();
            this.minutesTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // areaCodePromptLabel
            // 
            this.areaCodePromptLabel.AutoSize = true;
            this.areaCodePromptLabel.Location = new System.Drawing.Point(12, 28);
            this.areaCodePromptLabel.Name = "areaCodePromptLabel";
            this.areaCodePromptLabel.Size = new System.Drawing.Size(88, 13);
            this.areaCodePromptLabel.TabIndex = 0;
            this.areaCodePromptLabel.Text = "Enter Area Code:";
            // 
            // minutesPromptLabel
            // 
            this.minutesPromptLabel.AutoSize = true;
            this.minutesPromptLabel.Location = new System.Drawing.Point(12, 78);
            this.minutesPromptLabel.Name = "minutesPromptLabel";
            this.minutesPromptLabel.Size = new System.Drawing.Size(131, 13);
            this.minutesPromptLabel.TabIndex = 1;
            this.minutesPromptLabel.Text = "How many minutes is call?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your charge will be:";
            // 
            // priceOutputLabel
            // 
            this.priceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceOutputLabel.Location = new System.Drawing.Point(118, 129);
            this.priceOutputLabel.Name = "priceOutputLabel";
            this.priceOutputLabel.Size = new System.Drawing.Size(119, 23);
            this.priceOutputLabel.TabIndex = 3;
            this.priceOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // areaCodeTextBox
            // 
            this.areaCodeTextBox.Location = new System.Drawing.Point(118, 25);
            this.areaCodeTextBox.Name = "areaCodeTextBox";
            this.areaCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.areaCodeTextBox.TabIndex = 4;
            // 
            // minutesTextBox
            // 
            this.minutesTextBox.Location = new System.Drawing.Point(149, 75);
            this.minutesTextBox.Name = "minutesTextBox";
            this.minutesTextBox.Size = new System.Drawing.Size(100, 20);
            this.minutesTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(90, 169);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 36);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 217);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.minutesTextBox);
            this.Controls.Add(this.areaCodeTextBox);
            this.Controls.Add(this.priceOutputLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minutesPromptLabel);
            this.Controls.Add(this.areaCodePromptLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label areaCodePromptLabel;
        private System.Windows.Forms.Label minutesPromptLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label priceOutputLabel;
        private System.Windows.Forms.TextBox areaCodeTextBox;
        private System.Windows.Forms.TextBox minutesTextBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

