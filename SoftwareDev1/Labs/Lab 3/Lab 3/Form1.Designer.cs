namespace Lab_3
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
            this.mealPriceLabel = new System.Windows.Forms.Label();
            this.mealPriceTextbox = new System.Windows.Forms.TextBox();
            this.lowTipLabel = new System.Windows.Forms.Label();
            this.mediumTipLabel = new System.Windows.Forms.Label();
            this.highTipLabel = new System.Windows.Forms.Label();
            this.lowTipAnswerLabel = new System.Windows.Forms.Label();
            this.mediumTipAnswerLabel = new System.Windows.Forms.Label();
            this.highTipAnswerLabel = new System.Windows.Forms.Label();
            this.calculateTipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mealPriceLabel
            // 
            this.mealPriceLabel.AutoSize = true;
            this.mealPriceLabel.Location = new System.Drawing.Point(35, 36);
            this.mealPriceLabel.Name = "mealPriceLabel";
            this.mealPriceLabel.Size = new System.Drawing.Size(97, 13);
            this.mealPriceLabel.TabIndex = 0;
            this.mealPriceLabel.Text = "Enter Price of Meal";
            // 
            // mealPriceTextbox
            // 
            this.mealPriceTextbox.Location = new System.Drawing.Point(138, 33);
            this.mealPriceTextbox.Name = "mealPriceTextbox";
            this.mealPriceTextbox.Size = new System.Drawing.Size(100, 20);
            this.mealPriceTextbox.TabIndex = 1;
            // 
            // lowTipLabel
            // 
            this.lowTipLabel.AutoSize = true;
            this.lowTipLabel.Location = new System.Drawing.Point(105, 73);
            this.lowTipLabel.Name = "lowTipLabel";
            this.lowTipLabel.Size = new System.Drawing.Size(27, 13);
            this.lowTipLabel.TabIndex = 2;
            this.lowTipLabel.Text = "15%";
            // 
            // mediumTipLabel
            // 
            this.mediumTipLabel.AutoSize = true;
            this.mediumTipLabel.Location = new System.Drawing.Point(105, 117);
            this.mediumTipLabel.Name = "mediumTipLabel";
            this.mediumTipLabel.Size = new System.Drawing.Size(27, 13);
            this.mediumTipLabel.TabIndex = 3;
            this.mediumTipLabel.Text = "18%";
            // 
            // highTipLabel
            // 
            this.highTipLabel.AutoSize = true;
            this.highTipLabel.Location = new System.Drawing.Point(105, 155);
            this.highTipLabel.Name = "highTipLabel";
            this.highTipLabel.Size = new System.Drawing.Size(27, 13);
            this.highTipLabel.TabIndex = 4;
            this.highTipLabel.Text = "20%";
            // 
            // lowTipAnswerLabel
            // 
            this.lowTipAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowTipAnswerLabel.Location = new System.Drawing.Point(138, 72);
            this.lowTipAnswerLabel.Name = "lowTipAnswerLabel";
            this.lowTipAnswerLabel.Size = new System.Drawing.Size(100, 23);
            this.lowTipAnswerLabel.TabIndex = 5;
            // 
            // mediumTipAnswerLabel
            // 
            this.mediumTipAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mediumTipAnswerLabel.Location = new System.Drawing.Point(138, 116);
            this.mediumTipAnswerLabel.Name = "mediumTipAnswerLabel";
            this.mediumTipAnswerLabel.Size = new System.Drawing.Size(100, 23);
            this.mediumTipAnswerLabel.TabIndex = 6;
            // 
            // highTipAnswerLabel
            // 
            this.highTipAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highTipAnswerLabel.Location = new System.Drawing.Point(138, 155);
            this.highTipAnswerLabel.Name = "highTipAnswerLabel";
            this.highTipAnswerLabel.Size = new System.Drawing.Size(100, 23);
            this.highTipAnswerLabel.TabIndex = 7;
            // 
            // calculateTipButton
            // 
            this.calculateTipButton.Location = new System.Drawing.Point(83, 214);
            this.calculateTipButton.Name = "calculateTipButton";
            this.calculateTipButton.Size = new System.Drawing.Size(115, 36);
            this.calculateTipButton.TabIndex = 8;
            this.calculateTipButton.Text = "Calculate Tip";
            this.calculateTipButton.UseVisualStyleBackColor = true;
            this.calculateTipButton.Click += new System.EventHandler(this.calculateTipButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.calculateTipButton);
            this.Controls.Add(this.highTipAnswerLabel);
            this.Controls.Add(this.mediumTipAnswerLabel);
            this.Controls.Add(this.lowTipAnswerLabel);
            this.Controls.Add(this.highTipLabel);
            this.Controls.Add(this.mediumTipLabel);
            this.Controls.Add(this.lowTipLabel);
            this.Controls.Add(this.mealPriceTextbox);
            this.Controls.Add(this.mealPriceLabel);
            this.Name = "Form1";
            this.Text = "Lab 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealPriceLabel;
        private System.Windows.Forms.TextBox mealPriceTextbox;
        private System.Windows.Forms.Label lowTipLabel;
        private System.Windows.Forms.Label mediumTipLabel;
        private System.Windows.Forms.Label highTipLabel;
        private System.Windows.Forms.Label lowTipAnswerLabel;
        private System.Windows.Forms.Label mediumTipAnswerLabel;
        private System.Windows.Forms.Label highTipAnswerLabel;
        private System.Windows.Forms.Button calculateTipButton;
    }
}

