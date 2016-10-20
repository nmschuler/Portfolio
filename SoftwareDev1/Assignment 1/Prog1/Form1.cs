/* Nicholas Schuler
 * Program 1
 * Due October 1, 2014
 * CIS 199-01 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal sqftInput; //to hold sqft of wall to cover
            decimal coatsInput; //to hold how many coats of paint
            decimal priceOfPaintInput; //to hold how much paint is per gallon
            decimal sqftOutput; //to hold how much total sqft to paint
            decimal gallonsNeeded; //to hold how many gallons of paint they need
            decimal hoursWorkedOutput; //to hold how many hours to paint
            decimal totalPriceOfPaintOutput; //to hold how much to spend on paint
            decimal totalPriceOfLabor; //to hold how much money for labor
            decimal totalJobPrice; //to hold the total job price
            decimal gallonsNeededCeiling; //to hold value of gallons ceiling

            const decimal PRICE_PER_HOUR = 10.10m; //to hold 10.10 for labor per hour
            const decimal HOURS_PER_GALLON = 8.0m; // to hold 8.0 ofr how long painting per gallon
            const decimal SQFT_PER_GALLON = 325.0m; // to hold 325.0 for how much 1 gallon covers

            //get the user inputs from text boxes
            sqftInput = decimal.Parse(sqftInputTextBox.Text);
            coatsInput = decimal.Parse(coatsInputTextBox.Text);
            priceOfPaintInput = decimal.Parse(priceOfPaintInputTextBox.Text);

            //do the math to get the values of variables
            sqftOutput = sqftInput * coatsInput;
            gallonsNeeded = sqftOutput / SQFT_PER_GALLON;
            hoursWorkedOutput = gallonsNeeded * HOURS_PER_GALLON;
            gallonsNeededCeiling = Math.Ceiling(gallonsNeeded);
            totalPriceOfPaintOutput = gallonsNeededCeiling * priceOfPaintInput; 
            totalPriceOfLabor = hoursWorkedOutput * PRICE_PER_HOUR;
            totalJobPrice = totalPriceOfPaintOutput + totalPriceOfLabor;

            //the variables with values (obtained from above) being displayed in the output labels
            sqftOutputLabel.Text = sqftOutput.ToString("n1");
            hoursWorkedOutputLabel.Text = hoursWorkedOutput.ToString("n1");
            gallonsNeededOutputLabel.Text = gallonsNeededCeiling.ToString("n0");
            totalPriceOfPaintOutputLabel.Text = totalPriceOfPaintOutput.ToString("c");
            totalPriceOfLaborOutputLabel.Text = totalPriceOfLabor.ToString("c");
            totalJobPriceLabel.Text = totalJobPrice.ToString("c");






        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            sqftInputTextBox.Text = " ";
            coatsInputTextBox.Text = " ";
            priceOfPaintInputTextBox.Text = " ";
            sqftOutputLabel.Text = " ";
            hoursWorkedOutputLabel.Text = " ";
            gallonsNeededOutputLabel.Text = " ";
            totalPriceOfPaintOutputLabel.Text = " ";
            totalPriceOfLaborOutputLabel.Text = " ";
            totalJobPriceLabel.Text = " ";


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
