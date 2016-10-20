namespace Exam2EC
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
            this.idPromptLabel = new System.Windows.Forms.Label();
            this.purchasePriceLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.purchaseInputTextBox = new System.Windows.Forms.TextBox();
            this.claculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idPromptLabel
            // 
            this.idPromptLabel.AutoSize = true;
            this.idPromptLabel.Location = new System.Drawing.Point(12, 28);
            this.idPromptLabel.Name = "idPromptLabel";
            this.idPromptLabel.Size = new System.Drawing.Size(115, 13);
            this.idPromptLabel.TabIndex = 0;
            this.idPromptLabel.Text = "Enter your customer ID";
            // 
            // purchasePriceLabel
            // 
            this.purchasePriceLabel.AutoSize = true;
            this.purchasePriceLabel.Location = new System.Drawing.Point(12, 74);
            this.purchasePriceLabel.Name = "purchasePriceLabel";
            this.purchasePriceLabel.Size = new System.Drawing.Size(79, 13);
            this.purchasePriceLabel.TabIndex = 1;
            this.purchasePriceLabel.Text = "Purchase Price";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(136, 25);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // purchaseInputTextBox
            // 
            this.purchaseInputTextBox.Location = new System.Drawing.Point(136, 67);
            this.purchaseInputTextBox.Name = "purchaseInputTextBox";
            this.purchaseInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.purchaseInputTextBox.TabIndex = 3;
            // 
            // claculateButton
            // 
            this.claculateButton.Location = new System.Drawing.Point(16, 131);
            this.claculateButton.Name = "claculateButton";
            this.claculateButton.Size = new System.Drawing.Size(124, 49);
            this.claculateButton.TabIndex = 4;
            this.claculateButton.Text = "Calculate";
            this.claculateButton.UseVisualStyleBackColor = true;
            this.claculateButton.Click += new System.EventHandler(this.claculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 195);
            this.Controls.Add(this.claculateButton);
            this.Controls.Add(this.purchaseInputTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.purchasePriceLabel);
            this.Controls.Add(this.idPromptLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idPromptLabel;
        private System.Windows.Forms.Label purchasePriceLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox purchaseInputTextBox;
        private System.Windows.Forms.Button claculateButton;
    }
}

