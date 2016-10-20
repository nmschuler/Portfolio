/* Nick Schuler
 * CIS 199-01
 * Final Extra Credit */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalEC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int areaCode = int.Parse(areaCodeTextBox.Text);
            double minutes = double.Parse(minutesTextBox.Text);
            
            int[] codes = { 262, 414, 608, 715, 815, 920 };
            double[] rates = { .07, .1, .05, .16, .24, .14 };

            bool found = false;
            int index = 0;
            int position = -1;

            //search the array
            while (!found && index < codes.Length)
            {
                if (codes[index] == areaCode)
                {
                    found = true;
                    position = index;
                }
                else
                {
                    index++;
                }
            }

            if (found == false)
            {
                MessageBox.Show("This company does not support this Area Code yet");
            }
            else
            {
                double rate = rates[index];

                double answer = minutes * rate;

                priceOutputLabel.Text = answer.ToString("c");
            }

        }
    }
}
