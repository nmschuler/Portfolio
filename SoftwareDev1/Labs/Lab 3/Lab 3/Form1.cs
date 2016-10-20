/* Nicholas Schuler
 * Lab 3
 * Due September 28, 2014
 * CIS 199-01
 * This program takes a user inputted number representing the price of the bill, 
 *      hit calculate, then the program gives 3 different tip prices, 15, 18, and 20 percent. */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTipButton_Click(object sender, EventArgs e)
        {
           
            double mealPrice;
            
            //all caps makes displays as variable
            const double LOWTIPRATE = .15;
            double lowTip;

            const double MEDIUMTIPRATE = .18;
            double mediumTip;

            const double HIGHTIPRATE = .20;
            double highTip;

            mealPrice = double.Parse(mealPriceTextbox.Text);
           
            //calculate what the output is based on the VARIABLES
            lowTip = mealPrice * LOWTIPRATE;
            mediumTip = mealPrice * MEDIUMTIPRATE;
            highTip = mealPrice * HIGHTIPRATE;
            
            //ToString means turn to string. c is how to make it currency format
            lowTipAnswerLabel.Text = lowTip.ToString("c");
            mediumTipAnswerLabel.Text = mediumTip.ToString("c");
            highTipAnswerLabel.Text = highTip.ToString("c");

          

           


        }
    }
}
