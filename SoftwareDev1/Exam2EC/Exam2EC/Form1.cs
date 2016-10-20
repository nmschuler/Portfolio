/* Nick Schuler
 * CIS 199-01
 * Exam 2 Extra Credit */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2EC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void claculateButton_Click(object sender, EventArgs e)
        {
            const double BEST_CUST_DISC = 0.3;
            const double REG_CUST_DISC = 0.2;

            double discount;
            double total;
            
            string customerID = idTextBox.Text;
            double purchasePrice = double.Parse(purchaseInputTextBox.Text);
            
            string[] bestCustomers = { "A1234", "A6543", "B7890", "C5678", "B4321", "A9090", 
                                         "D8765", "J1122", "E3456", "Z7777" };

            bool found = false;
            int index = 0;
            int position = -1;

            while (!found && index < bestCustomers.Length)
            {
                if(bestCustomers[index] == customerID)
                {
                    found = true;
                    position = index;
                    discount = purchasePrice * BEST_CUST_DISC;
                    total = purchasePrice - discount;

                    MessageBox.Show("Your discount is " + discount.ToString("C") + ". Your total sale price is " +
                        total.ToString("C"));
                }
                
                else
                {
                    index++;

                }
                discount = purchasePrice * REG_CUST_DISC;
                total = purchasePrice - discount;

                MessageBox.Show("Your discount is " + discount.ToString("C") + ". Your total sale price is " +
                   total.ToString("C"));
                break;

            }


        }
    }
}
