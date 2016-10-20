using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles; //to hold miles driven
            double gallons; //to hold gallons used
            double mpg; //to hold mpg

            //get the miles driven and assign it to the miles variable
            miles = double.Parse(milesTextBox.Text);

            //get the gallons used and assign it to get the gallons variable
            gallons = double.Parse(gallonsTextBox.Text);

            //calculate MPG
            mpg = miles / gallons;

            //display the mpgLabel control
            mpgLabel.Text = mpg.ToString(); 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
