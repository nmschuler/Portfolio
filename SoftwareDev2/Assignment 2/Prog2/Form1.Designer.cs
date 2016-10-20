namespace LibraryItems
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnSubMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronListSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemListSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedOutItemsSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.insertMenuItem,
            this.itemMenuItem,
            this.reportMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSubMenuItem,
            this.exitSubMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileMenuItem.Text = "&File";
            // 
            // aboutSubMenuItem
            // 
            this.aboutSubMenuItem.Name = "aboutSubMenuItem";
            this.aboutSubMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutSubMenuItem.Text = "&About";
            this.aboutSubMenuItem.Click += new System.EventHandler(this.aboutSubMenuItem_Click);
            // 
            // exitSubMenuItem
            // 
            this.exitSubMenuItem.Name = "exitSubMenuItem";
            this.exitSubMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitSubMenuItem.Text = "&Exit";
            this.exitSubMenuItem.Click += new System.EventHandler(this.exitSubMenuItem_Click);
            // 
            // insertMenuItem
            // 
            this.insertMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patronSubMenuItem,
            this.bookSubMenuItem});
            this.insertMenuItem.Name = "insertMenuItem";
            this.insertMenuItem.Size = new System.Drawing.Size(48, 20);
            this.insertMenuItem.Text = "&Insert";
            // 
            // patronSubMenuItem
            // 
            this.patronSubMenuItem.Name = "patronSubMenuItem";
            this.patronSubMenuItem.Size = new System.Drawing.Size(106, 22);
            this.patronSubMenuItem.Text = "&Patron";
            this.patronSubMenuItem.Click += new System.EventHandler(this.patronSubMenuItem_Click);
            // 
            // bookSubMenuItem
            // 
            this.bookSubMenuItem.Name = "bookSubMenuItem";
            this.bookSubMenuItem.Size = new System.Drawing.Size(106, 22);
            this.bookSubMenuItem.Text = "&Book";
            this.bookSubMenuItem.Click += new System.EventHandler(this.bookSubMenuItem_Click);
            // 
            // itemMenuItem
            // 
            this.itemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkOutSubMenuItem,
            this.returnSubMenuItem1});
            this.itemMenuItem.Name = "itemMenuItem";
            this.itemMenuItem.Size = new System.Drawing.Size(41, 20);
            this.itemMenuItem.Text = "I&tem";
            // 
            // checkOutSubMenuItem
            // 
            this.checkOutSubMenuItem.Name = "checkOutSubMenuItem";
            this.checkOutSubMenuItem.Size = new System.Drawing.Size(124, 22);
            this.checkOutSubMenuItem.Text = "&Check Out";
            this.checkOutSubMenuItem.Click += new System.EventHandler(this.checkOutSubMenuItem_Click);
            // 
            // returnSubMenuItem1
            // 
            this.returnSubMenuItem1.Name = "returnSubMenuItem1";
            this.returnSubMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.returnSubMenuItem1.Text = "&Return";
            this.returnSubMenuItem1.Click += new System.EventHandler(this.returnSubMenuItem1_Click);
            // 
            // reportMenuItem
            // 
            this.reportMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patronListSubMenuItem,
            this.itemListSubMenuItem,
            this.checkedOutItemsSubMenuItem});
            this.reportMenuItem.Name = "reportMenuItem";
            this.reportMenuItem.Size = new System.Drawing.Size(52, 20);
            this.reportMenuItem.Text = "&Report";
            // 
            // patronListSubMenuItem
            // 
            this.patronListSubMenuItem.Name = "patronListSubMenuItem";
            this.patronListSubMenuItem.Size = new System.Drawing.Size(166, 22);
            this.patronListSubMenuItem.Text = "&Patron List";
            this.patronListSubMenuItem.Click += new System.EventHandler(this.patronListSubMenuItem_Click);
            // 
            // itemListSubMenuItem
            // 
            this.itemListSubMenuItem.Name = "itemListSubMenuItem";
            this.itemListSubMenuItem.Size = new System.Drawing.Size(166, 22);
            this.itemListSubMenuItem.Text = "&Item List";
            this.itemListSubMenuItem.Click += new System.EventHandler(this.itemListSubMenuItem_Click);
            // 
            // checkedOutItemsSubMenuItem
            // 
            this.checkedOutItemsSubMenuItem.Name = "checkedOutItemsSubMenuItem";
            this.checkedOutItemsSubMenuItem.Size = new System.Drawing.Size(166, 22);
            this.checkedOutItemsSubMenuItem.Text = "&Checked Out Items";
            this.checkedOutItemsSubMenuItem.Click += new System.EventHandler(this.checkedOutItemsSubMenuItem_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 27);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextBox.Size = new System.Drawing.Size(486, 470);
            this.outputTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 509);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitSubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patronSubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookSubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutSubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemListSubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedOutItemsSubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnSubMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patronListSubMenuItem;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

