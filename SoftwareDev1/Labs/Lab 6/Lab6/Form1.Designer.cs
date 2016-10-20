namespace Lab6
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
            this.chooseCalculateButton = new System.Windows.Forms.GroupBox();
            this.sphereVolRadioButton = new System.Windows.Forms.RadioButton();
            this.sphereSARadioButton = new System.Windows.Forms.RadioButton();
            this.circleAreaRadioButton = new System.Windows.Forms.RadioButton();
            this.radiusPromptLabel = new System.Windows.Forms.Label();
            this.radiusInputTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.answerOutputLabel = new System.Windows.Forms.Label();
            this.chooseCalculateButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseCalculateButton
            // 
            this.chooseCalculateButton.Controls.Add(this.sphereVolRadioButton);
            this.chooseCalculateButton.Controls.Add(this.sphereSARadioButton);
            this.chooseCalculateButton.Controls.Add(this.circleAreaRadioButton);
            this.chooseCalculateButton.Location = new System.Drawing.Point(26, 12);
            this.chooseCalculateButton.Name = "chooseCalculateButton";
            this.chooseCalculateButton.Size = new System.Drawing.Size(133, 119);
            this.chooseCalculateButton.TabIndex = 0;
            this.chooseCalculateButton.TabStop = false;
            this.chooseCalculateButton.Text = "Choose Calculation";
            // 
            // sphereVolRadioButton
            // 
            this.sphereVolRadioButton.AutoSize = true;
            this.sphereVolRadioButton.Location = new System.Drawing.Point(6, 87);
            this.sphereVolRadioButton.Name = "sphereVolRadioButton";
            this.sphereVolRadioButton.Size = new System.Drawing.Size(97, 17);
            this.sphereVolRadioButton.TabIndex = 2;
            this.sphereVolRadioButton.TabStop = true;
            this.sphereVolRadioButton.Text = "Sphere Volume";
            this.sphereVolRadioButton.UseVisualStyleBackColor = true;
            // 
            // sphereSARadioButton
            // 
            this.sphereSARadioButton.AutoSize = true;
            this.sphereSARadioButton.Location = new System.Drawing.Point(6, 54);
            this.sphereSARadioButton.Name = "sphereSARadioButton";
            this.sphereSARadioButton.Size = new System.Drawing.Size(124, 17);
            this.sphereSARadioButton.TabIndex = 1;
            this.sphereSARadioButton.TabStop = true;
            this.sphereSARadioButton.Text = "Sphere Surface Area";
            this.sphereSARadioButton.UseVisualStyleBackColor = true;
            // 
            // circleAreaRadioButton
            // 
            this.circleAreaRadioButton.AutoSize = true;
            this.circleAreaRadioButton.Location = new System.Drawing.Point(6, 19);
            this.circleAreaRadioButton.Name = "circleAreaRadioButton";
            this.circleAreaRadioButton.Size = new System.Drawing.Size(76, 17);
            this.circleAreaRadioButton.TabIndex = 0;
            this.circleAreaRadioButton.TabStop = true;
            this.circleAreaRadioButton.Text = "Circle Area";
            this.circleAreaRadioButton.UseVisualStyleBackColor = true;
            // 
            // radiusPromptLabel
            // 
            this.radiusPromptLabel.AutoSize = true;
            this.radiusPromptLabel.Location = new System.Drawing.Point(23, 140);
            this.radiusPromptLabel.Name = "radiusPromptLabel";
            this.radiusPromptLabel.Size = new System.Drawing.Size(40, 13);
            this.radiusPromptLabel.TabIndex = 3;
            this.radiusPromptLabel.Text = "Radius";
            // 
            // radiusInputTextBox
            // 
            this.radiusInputTextBox.Location = new System.Drawing.Point(77, 137);
            this.radiusInputTextBox.Name = "radiusInputTextBox";
            this.radiusInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.radiusInputTextBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(59, 173);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // answerOutputLabel
            // 
            this.answerOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerOutputLabel.Location = new System.Drawing.Point(8, 199);
            this.answerOutputLabel.Name = "answerOutputLabel";
            this.answerOutputLabel.Size = new System.Drawing.Size(169, 39);
            this.answerOutputLabel.TabIndex = 6;
            this.answerOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 244);
            this.Controls.Add(this.answerOutputLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.radiusPromptLabel);
            this.Controls.Add(this.radiusInputTextBox);
            this.Controls.Add(this.chooseCalculateButton);
            this.Name = "Form1";
            this.Text = "Lab 6";
            this.chooseCalculateButton.ResumeLayout(false);
            this.chooseCalculateButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox chooseCalculateButton;
        private System.Windows.Forms.RadioButton sphereVolRadioButton;
        private System.Windows.Forms.RadioButton sphereSARadioButton;
        private System.Windows.Forms.RadioButton circleAreaRadioButton;
        private System.Windows.Forms.Label radiusPromptLabel;
        private System.Windows.Forms.TextBox radiusInputTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label answerOutputLabel;
    }
}

