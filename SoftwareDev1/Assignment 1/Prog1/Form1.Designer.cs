namespace Prog1
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
            this.sqftInputTextBox = new System.Windows.Forms.TextBox();
            this.coatsInputTextBox = new System.Windows.Forms.TextBox();
            this.priceOfPaintInputTextBox = new System.Windows.Forms.TextBox();
            this.sqftPromptLabel = new System.Windows.Forms.Label();
            this.coatsOfPaintPromptLabel = new System.Windows.Forms.Label();
            this.paintPricePromptLabel = new System.Windows.Forms.Label();
            this.sqftTotalLabel = new System.Windows.Forms.Label();
            this.hoursLaborLabel = new System.Windows.Forms.Label();
            this.gallonsNeededLabel = new System.Windows.Forms.Label();
            this.paintCostLabel = new System.Windows.Forms.Label();
            this.laborCostLabel = new System.Windows.Forms.Label();
            this.jobCostLabel = new System.Windows.Forms.Label();
            this.sqftOutputLabel = new System.Windows.Forms.Label();
            this.hoursWorkedOutputLabel = new System.Windows.Forms.Label();
            this.gallonsNeededOutputLabel = new System.Windows.Forms.Label();
            this.totalPriceOfPaintOutputLabel = new System.Windows.Forms.Label();
            this.totalPriceOfLaborOutputLabel = new System.Windows.Forms.Label();
            this.totalJobPriceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sqftInputTextBox
            // 
            this.sqftInputTextBox.Location = new System.Drawing.Point(159, 28);
            this.sqftInputTextBox.Name = "sqftInputTextBox";
            this.sqftInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.sqftInputTextBox.TabIndex = 0;
            // 
            // coatsInputTextBox
            // 
            this.coatsInputTextBox.Location = new System.Drawing.Point(159, 99);
            this.coatsInputTextBox.Name = "coatsInputTextBox";
            this.coatsInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.coatsInputTextBox.TabIndex = 1;
            // 
            // priceOfPaintInputTextBox
            // 
            this.priceOfPaintInputTextBox.Location = new System.Drawing.Point(159, 168);
            this.priceOfPaintInputTextBox.Name = "priceOfPaintInputTextBox";
            this.priceOfPaintInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceOfPaintInputTextBox.TabIndex = 2;
            // 
            // sqftPromptLabel
            // 
            this.sqftPromptLabel.AutoSize = true;
            this.sqftPromptLabel.Location = new System.Drawing.Point(12, 31);
            this.sqftPromptLabel.Name = "sqftPromptLabel";
            this.sqftPromptLabel.Size = new System.Drawing.Size(130, 13);
            this.sqftPromptLabel.TabIndex = 3;
            this.sqftPromptLabel.Text = "How many Sq. Ft. of wall?";
            // 
            // coatsOfPaintPromptLabel
            // 
            this.coatsOfPaintPromptLabel.AutoSize = true;
            this.coatsOfPaintPromptLabel.Location = new System.Drawing.Point(12, 99);
            this.coatsOfPaintPromptLabel.Name = "coatsOfPaintPromptLabel";
            this.coatsOfPaintPromptLabel.Size = new System.Drawing.Size(130, 13);
            this.coatsOfPaintPromptLabel.TabIndex = 4;
            this.coatsOfPaintPromptLabel.Text = "How many coats of paint?";
            // 
            // paintPricePromptLabel
            // 
            this.paintPricePromptLabel.AutoSize = true;
            this.paintPricePromptLabel.Location = new System.Drawing.Point(5, 171);
            this.paintPricePromptLabel.Name = "paintPricePromptLabel";
            this.paintPricePromptLabel.Size = new System.Drawing.Size(148, 13);
            this.paintPricePromptLabel.TabIndex = 5;
            this.paintPricePromptLabel.Text = "How much does paint cost? $";
            // 
            // sqftTotalLabel
            // 
            this.sqftTotalLabel.AutoSize = true;
            this.sqftTotalLabel.Location = new System.Drawing.Point(322, 28);
            this.sqftTotalLabel.Name = "sqftTotalLabel";
            this.sqftTotalLabel.Size = new System.Drawing.Size(137, 13);
            this.sqftTotalLabel.TabIndex = 6;
            this.sqftTotalLabel.Text = "Total Sq. Ft. to be covered:";
            // 
            // hoursLaborLabel
            // 
            this.hoursLaborLabel.AutoSize = true;
            this.hoursLaborLabel.Location = new System.Drawing.Point(342, 61);
            this.hoursLaborLabel.Name = "hoursLaborLabel";
            this.hoursLaborLabel.Size = new System.Drawing.Size(117, 13);
            this.hoursLaborLabel.TabIndex = 7;
            this.hoursLaborLabel.Text = "Hours of labor required:";
            // 
            // gallonsNeededLabel
            // 
            this.gallonsNeededLabel.AutoSize = true;
            this.gallonsNeededLabel.Location = new System.Drawing.Point(337, 90);
            this.gallonsNeededLabel.Name = "gallonsNeededLabel";
            this.gallonsNeededLabel.Size = new System.Drawing.Size(122, 13);
            this.gallonsNeededLabel.TabIndex = 8;
            this.gallonsNeededLabel.Text = "Gallons of paint needed:";
            // 
            // paintCostLabel
            // 
            this.paintCostLabel.AutoSize = true;
            this.paintCostLabel.Location = new System.Drawing.Point(364, 119);
            this.paintCostLabel.Name = "paintCostLabel";
            this.paintCostLabel.Size = new System.Drawing.Size(95, 13);
            this.paintCostLabel.TabIndex = 9;
            this.paintCostLabel.Text = "Total cost of paint:";
            // 
            // laborCostLabel
            // 
            this.laborCostLabel.AutoSize = true;
            this.laborCostLabel.Location = new System.Drawing.Point(364, 146);
            this.laborCostLabel.Name = "laborCostLabel";
            this.laborCostLabel.Size = new System.Drawing.Size(95, 13);
            this.laborCostLabel.TabIndex = 10;
            this.laborCostLabel.Text = "Total cost of labor:";
            // 
            // jobCostLabel
            // 
            this.jobCostLabel.AutoSize = true;
            this.jobCostLabel.Location = new System.Drawing.Point(385, 175);
            this.jobCostLabel.Name = "jobCostLabel";
            this.jobCostLabel.Size = new System.Drawing.Size(74, 13);
            this.jobCostLabel.TabIndex = 11;
            this.jobCostLabel.Text = "Total job cost:";
            // 
            // sqftOutputLabel
            // 
            this.sqftOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqftOutputLabel.Location = new System.Drawing.Point(465, 25);
            this.sqftOutputLabel.Name = "sqftOutputLabel";
            this.sqftOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.sqftOutputLabel.TabIndex = 12;
            this.sqftOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursWorkedOutputLabel
            // 
            this.hoursWorkedOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursWorkedOutputLabel.Location = new System.Drawing.Point(465, 60);
            this.hoursWorkedOutputLabel.Name = "hoursWorkedOutputLabel";
            this.hoursWorkedOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.hoursWorkedOutputLabel.TabIndex = 13;
            this.hoursWorkedOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gallonsNeededOutputLabel
            // 
            this.gallonsNeededOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsNeededOutputLabel.Location = new System.Drawing.Point(465, 89);
            this.gallonsNeededOutputLabel.Name = "gallonsNeededOutputLabel";
            this.gallonsNeededOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.gallonsNeededOutputLabel.TabIndex = 14;
            this.gallonsNeededOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPriceOfPaintOutputLabel
            // 
            this.totalPriceOfPaintOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOfPaintOutputLabel.Location = new System.Drawing.Point(465, 118);
            this.totalPriceOfPaintOutputLabel.Name = "totalPriceOfPaintOutputLabel";
            this.totalPriceOfPaintOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalPriceOfPaintOutputLabel.TabIndex = 15;
            this.totalPriceOfPaintOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPriceOfLaborOutputLabel
            // 
            this.totalPriceOfLaborOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOfLaborOutputLabel.Location = new System.Drawing.Point(465, 145);
            this.totalPriceOfLaborOutputLabel.Name = "totalPriceOfLaborOutputLabel";
            this.totalPriceOfLaborOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalPriceOfLaborOutputLabel.TabIndex = 16;
            this.totalPriceOfLaborOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalJobPriceLabel
            // 
            this.totalJobPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalJobPriceLabel.Location = new System.Drawing.Point(465, 171);
            this.totalJobPriceLabel.Name = "totalJobPriceLabel";
            this.totalJobPriceLabel.Size = new System.Drawing.Size(100, 23);
            this.totalJobPriceLabel.TabIndex = 17;
            this.totalJobPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(46, 228);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(127, 55);
            this.calculateButton.TabIndex = 18;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(244, 228);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(127, 55);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(425, 228);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(127, 55);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 300);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalJobPriceLabel);
            this.Controls.Add(this.totalPriceOfLaborOutputLabel);
            this.Controls.Add(this.totalPriceOfPaintOutputLabel);
            this.Controls.Add(this.gallonsNeededOutputLabel);
            this.Controls.Add(this.hoursWorkedOutputLabel);
            this.Controls.Add(this.sqftOutputLabel);
            this.Controls.Add(this.jobCostLabel);
            this.Controls.Add(this.laborCostLabel);
            this.Controls.Add(this.paintCostLabel);
            this.Controls.Add(this.gallonsNeededLabel);
            this.Controls.Add(this.hoursLaborLabel);
            this.Controls.Add(this.sqftTotalLabel);
            this.Controls.Add(this.paintPricePromptLabel);
            this.Controls.Add(this.coatsOfPaintPromptLabel);
            this.Controls.Add(this.sqftPromptLabel);
            this.Controls.Add(this.priceOfPaintInputTextBox);
            this.Controls.Add(this.coatsInputTextBox);
            this.Controls.Add(this.sqftInputTextBox);
            this.Name = "Form1";
            this.Text = "Project 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sqftInputTextBox;
        private System.Windows.Forms.TextBox coatsInputTextBox;
        private System.Windows.Forms.TextBox priceOfPaintInputTextBox;
        private System.Windows.Forms.Label sqftPromptLabel;
        private System.Windows.Forms.Label coatsOfPaintPromptLabel;
        private System.Windows.Forms.Label paintPricePromptLabel;
        private System.Windows.Forms.Label sqftTotalLabel;
        private System.Windows.Forms.Label hoursLaborLabel;
        private System.Windows.Forms.Label gallonsNeededLabel;
        private System.Windows.Forms.Label paintCostLabel;
        private System.Windows.Forms.Label laborCostLabel;
        private System.Windows.Forms.Label jobCostLabel;
        private System.Windows.Forms.Label sqftOutputLabel;
        private System.Windows.Forms.Label hoursWorkedOutputLabel;
        private System.Windows.Forms.Label gallonsNeededOutputLabel;
        private System.Windows.Forms.Label totalPriceOfPaintOutputLabel;
        private System.Windows.Forms.Label totalPriceOfLaborOutputLabel;
        private System.Windows.Forms.Label totalJobPriceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

