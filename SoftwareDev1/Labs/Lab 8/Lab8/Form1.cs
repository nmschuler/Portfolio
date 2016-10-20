/* Nick Schuler
 * Lab 8
 * Due November 16, 2014
 * CIS 199-01
 * Calculates the price the user will pay depending on how many miles they go, using array matching*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Preconditions: distance cannot be less than zero, no cap on distance travelled
        //Postconditions: takes and displays how much the user must pay per distance they travelled.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            int distance; //to hold distance they travel
            int priceForTrip; //to hold how much the trip will cost the user

            if (int.TryParse(distanceInputTextBox.Text, out distance) && distance >=0) //incase user type error
            {
                
                int[] distanceRangeLowLimit = { 0, 100, 300, 500 };  //low range for travel
                
                double[] price = { 25.00, 40.00, 55.00, 70.00 };   //how much for each distance tier

                int sub = distanceRangeLowLimit.Length - 1;

                while (sub >= 0 && distance < distanceRangeLowLimit[sub])
                {
                    --sub;
                }

                priceForTrip = (int) price[sub];

                outputLabel.Text = priceForTrip.ToString("c");
            }
            else
            {
                MessageBox.Show("Enter a non negative, whole number.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)    //close the application
        {
            this.Close();
        }
    }
}
