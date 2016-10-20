namespace Flags
{
    partial class flagsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flagsForm));
            this.countryLabel = new System.Windows.Forms.Label();
            this.finlandPictureBox = new System.Windows.Forms.PictureBox();
            this.francePictureBox = new System.Windows.Forms.PictureBox();
            this.germanyPictureBox = new System.Windows.Forms.PictureBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // countryLabel
            // 
            this.countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(50, 180);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(341, 23);
            this.countryLabel.TabIndex = 0;
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finlandPictureBox
            // 
            this.finlandPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finlandPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("finlandPictureBox.Image")));
            this.finlandPictureBox.Location = new System.Drawing.Point(12, 82);
            this.finlandPictureBox.Name = "finlandPictureBox";
            this.finlandPictureBox.Size = new System.Drawing.Size(122, 72);
            this.finlandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.finlandPictureBox.TabIndex = 1;
            this.finlandPictureBox.TabStop = false;
            this.finlandPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // francePictureBox
            // 
            this.francePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.francePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("francePictureBox.Image")));
            this.francePictureBox.Location = new System.Drawing.Point(160, 82);
            this.francePictureBox.Name = "francePictureBox";
            this.francePictureBox.Size = new System.Drawing.Size(122, 72);
            this.francePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.francePictureBox.TabIndex = 2;
            this.francePictureBox.TabStop = false;
            this.francePictureBox.Click += new System.EventHandler(this.francePictureBox_Click);
            // 
            // germanyPictureBox
            // 
            this.germanyPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.germanyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("germanyPictureBox.Image")));
            this.germanyPictureBox.Location = new System.Drawing.Point(308, 82);
            this.germanyPictureBox.Name = "germanyPictureBox";
            this.germanyPictureBox.Size = new System.Drawing.Size(122, 72);
            this.germanyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.germanyPictureBox.TabIndex = 3;
            this.germanyPictureBox.TabStop = false;
            this.germanyPictureBox.Click += new System.EventHandler(this.germanyPictureBox_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(116, 24);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(209, 13);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "Click a flag to see the name of the country.";
            // 
            // flagsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 221);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.germanyPictureBox);
            this.Controls.Add(this.francePictureBox);
            this.Controls.Add(this.finlandPictureBox);
            this.Controls.Add(this.countryLabel);
            this.Name = "flagsForm";
            this.Text = "Flags";
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.PictureBox finlandPictureBox;
        private System.Windows.Forms.PictureBox francePictureBox;
        private System.Windows.Forms.PictureBox germanyPictureBox;
        private System.Windows.Forms.Label instructionLabel;
    }
}

