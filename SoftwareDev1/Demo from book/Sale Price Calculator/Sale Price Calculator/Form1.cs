using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice; //The items original price
            decimal discountPercentage; //the items discount percentage
            decimal discountAmount; //the items discount amount
            decimal salePrice; // the items sale price

            //get the items original price
            originalPrice = decimal.Parse(originalPriceTextBox.Text);

            //get the discount percentage
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);

            //move percentage decimal over 2 spaces
            discountPercentage = discountPercentage / 100;

            //calculate the amount of the discount
            discountAmount = originalPrice * discountPercentage;

            //calculate the sale price
            salePrice = originalPrice - discountAmount;

            //display the sale price
            salePriceLabel.Text = salePrice.ToString("c");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
