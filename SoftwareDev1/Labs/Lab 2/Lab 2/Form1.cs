/* Nick Schuler
 * Lab 2
 * Due: 9/21/14
 * CIS 199-01
 * A program with our picture and clickable buttons to get to know us. A GUI from Lab 1. */




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hobbiesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Going to the movies, being with friends, playing video games.");
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lord of the Rings series, The Hobbit, Game of Thrones Series.");
        }

        private void movieButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is a lot, but maybe the Lord of the Rings series or the Hobbit.");
        }
    }
}
