using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class flagsForm : Form
    {
        public flagsForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Finland";
        }

        private void francePictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "France";
        }

        private void germanyPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Germany";
        }
    }
}
