//Nick Schuler

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_2
{
    public partial class Exam2Form : Form
    {
        public Exam2Form()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nicholas Schuler");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            string input = inputTextBox.Text;

            if (input != "")
            {
                string[] values = new string[]
                {
                    input
                };

                inputTextBox.Text = "";

                selectComboBox.Items.Add(values);
            }
            else
            {
                MessageBox.Show("Please enter a value for the text box");
            }
        }
    }
}
