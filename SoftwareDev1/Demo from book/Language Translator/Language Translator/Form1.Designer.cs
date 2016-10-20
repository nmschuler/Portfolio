namespace Language_Translator
{
    partial class languageTranslator
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
            this.italianButton = new System.Windows.Forms.Button();
            this.spanishButton = new System.Windows.Forms.Button();
            this.germanButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // italianButton
            // 
            this.italianButton.Location = new System.Drawing.Point(33, 113);
            this.italianButton.Name = "italianButton";
            this.italianButton.Size = new System.Drawing.Size(94, 34);
            this.italianButton.TabIndex = 0;
            this.italianButton.Text = "Italian";
            this.italianButton.UseVisualStyleBackColor = true;
            this.italianButton.Click += new System.EventHandler(this.italianButton_Click);
            // 
            // spanishButton
            // 
            this.spanishButton.Location = new System.Drawing.Point(169, 113);
            this.spanishButton.Name = "spanishButton";
            this.spanishButton.Size = new System.Drawing.Size(94, 34);
            this.spanishButton.TabIndex = 1;
            this.spanishButton.Text = "Spanish";
            this.spanishButton.UseVisualStyleBackColor = true;
            this.spanishButton.Click += new System.EventHandler(this.spanishButton_Click);
            // 
            // germanButton
            // 
            this.germanButton.Location = new System.Drawing.Point(307, 113);
            this.germanButton.Name = "germanButton";
            this.germanButton.Size = new System.Drawing.Size(94, 34);
            this.germanButton.TabIndex = 2;
            this.germanButton.Text = "German";
            this.germanButton.UseVisualStyleBackColor = true;
            this.germanButton.Click += new System.EventHandler(this.germanButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(101, 30);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(226, 13);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "Select a language and I will say Good Morning";
            // 
            // translationLabel
            // 
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationLabel.Location = new System.Drawing.Point(33, 62);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(368, 23);
            this.translationLabel.TabIndex = 5;
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // languageTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 159);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.germanButton);
            this.Controls.Add(this.spanishButton);
            this.Controls.Add(this.italianButton);
            this.Name = "languageTranslator";
            this.Text = "Language Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button italianButton;
        private System.Windows.Forms.Button spanishButton;
        private System.Windows.Forms.Button germanButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label translationLabel;
    }
}

