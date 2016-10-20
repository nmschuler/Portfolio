namespace Lab_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.hobbiesButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.movieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(83, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 166);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(100, 172);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Nick Schuler";
            // 
            // hobbiesButton
            // 
            this.hobbiesButton.Location = new System.Drawing.Point(12, 213);
            this.hobbiesButton.Name = "hobbiesButton";
            this.hobbiesButton.Size = new System.Drawing.Size(68, 36);
            this.hobbiesButton.TabIndex = 2;
            this.hobbiesButton.Text = "Hobbies";
            this.hobbiesButton.UseVisualStyleBackColor = true;
            this.hobbiesButton.Click += new System.EventHandler(this.hobbiesButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(103, 213);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(79, 36);
            this.bookButton.TabIndex = 3;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // movieButton
            // 
            this.movieButton.Location = new System.Drawing.Point(209, 213);
            this.movieButton.Name = "movieButton";
            this.movieButton.Size = new System.Drawing.Size(71, 36);
            this.movieButton.TabIndex = 4;
            this.movieButton.Text = "Movie";
            this.movieButton.UseVisualStyleBackColor = true;
            this.movieButton.Click += new System.EventHandler(this.movieButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.movieButton);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.hobbiesButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Lab 2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button hobbiesButton;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button movieButton;
    }
}

