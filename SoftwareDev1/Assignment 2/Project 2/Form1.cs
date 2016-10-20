/*Nick Schuler
 * Program 2
 * Due October 27, 2014
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

namespace Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            char lastNameLetter;
            

            if (char.TryParse(studentLastTextBox.Text, out lastNameLetter))
            {
                lastNameLetter = char.ToLower(lastNameLetter);

                const string TIME_ONE = "8:30 am"; //to hold first time registering per day
                const string TIME_TWO = "10:00am";  //to hold second time registering per day
                const string TIME_THREE = "11:30 am";  //to hold third time registering per day
                const string TIME_FOUR = "2:00 pm";  //to hold fourth time registering per day
                const string TIME_FIVE = "4:00 pm";  //to hold fifth time registering per day

                const string SENIOR_DAY = "November 7"; //to hold day Seniors can register
                const string JUNIOR_DAY = "November 10";  //to hold day Juniors can register
                const string SOPHOMORE_ONE = "November 11"; //to hold first day sophomores can register
                const string SOPHOMORE_TWO = "November 12";  //to hold second day sophomores can register
                const string FRESHMAN_ONE = "November 13";  //to hold first day freshman can register
                const string FRESHMAN_TWO = "November 14";  //to hold second day freshman can register

                if (seniorRadioButton.Checked)
                {
                    dayOutputLabel.Text = SENIOR_DAY; //seniors register 1 day, so they all will have this date

                    if (lastNameLetter >= 's' && lastNameLetter <= 'z')
                    { timeOutputLabel.Text = TIME_ONE; }
                    else if (lastNameLetter >= 'a' && lastNameLetter <= 'd')
                    { timeOutputLabel.Text = TIME_TWO; }
                    else if (lastNameLetter >= 'e' && lastNameLetter <= 'i')
                    { timeOutputLabel.Text = TIME_THREE; }
                    else if (lastNameLetter >= 'j' && lastNameLetter <= 'o')
                    { timeOutputLabel.Text = TIME_FOUR; }
                    else if (lastNameLetter >= 'p' && lastNameLetter <= 'r')
                    { timeOutputLabel.Text = TIME_FIVE; }
                }
                else if (juniorRadioButton.Checked)
                {
                    dayOutputLabel.Text = JUNIOR_DAY; //juniors have 1 day to register, so they will all have this date

                    if (lastNameLetter >= 's' && lastNameLetter <= 'z')
                    { timeOutputLabel.Text = TIME_ONE; }
                    else if (lastNameLetter >= 'a' && lastNameLetter <= 'd')
                    { timeOutputLabel.Text = TIME_TWO; }
                    else if (lastNameLetter >= 'e' && lastNameLetter <= 'i')
                    { timeOutputLabel.Text = TIME_THREE; }
                    else if (lastNameLetter >= 'j' && lastNameLetter <= 'o')
                    { timeOutputLabel.Text = TIME_FOUR; }
                    else if (lastNameLetter >= 'p' && lastNameLetter <= 'o')
                    { timeOutputLabel.Text = TIME_FIVE; }
                }
                else if (sophomoreRadioButton.Checked)
                {
                    //sophomore first day to register
                    if (lastNameLetter >= 's' && lastNameLetter <= 't')
                    {
                        timeOutputLabel.Text = TIME_ONE;
                        dayOutputLabel.Text = SOPHOMORE_ONE;
                    }
                    else if (lastNameLetter >= 'u' && lastNameLetter <= 'v')
                    {
                        timeOutputLabel.Text = TIME_TWO;
                        dayOutputLabel.Text = SOPHOMORE_ONE;
                    }
                    else if (lastNameLetter >= 'w' && lastNameLetter <= 'z')
                    {
                        timeOutputLabel.Text = TIME_THREE;
                        dayOutputLabel.Text = SOPHOMORE_ONE;
                    }
                    else if (lastNameLetter >= 'a' && lastNameLetter <= 'b')
                    {
                        timeOutputLabel.Text = TIME_FOUR;
                        dayOutputLabel.Text = SOPHOMORE_ONE;
                    }
                    else if (lastNameLetter >= 'c' && lastNameLetter <= 'd')
                    {
                        timeOutputLabel.Text = TIME_FIVE;
                        dayOutputLabel.Text = SOPHOMORE_ONE;
                    }
                    //now this is code for sophomore second day to register
                    else if (lastNameLetter >= 'e' && lastNameLetter <= 'f')
                    {
                        timeOutputLabel.Text = TIME_ONE;
                        dayOutputLabel.Text = SOPHOMORE_TWO;
                    }
                    else if (lastNameLetter >= 'g' && lastNameLetter <= 'i')
                    {
                        timeOutputLabel.Text = TIME_TWO;
                        dayOutputLabel.Text = SOPHOMORE_TWO;
                    }
                    else if (lastNameLetter >= 'j' && lastNameLetter <= 'l')
                    {
                        timeOutputLabel.Text = TIME_THREE;
                        dayOutputLabel.Text = SOPHOMORE_TWO;
                    }
                    else if (lastNameLetter >= 'm' && lastNameLetter <= 'o')
                    {
                        timeOutputLabel.Text = TIME_FOUR;
                        dayOutputLabel.Text = SOPHOMORE_TWO;
                    }
                    else if (lastNameLetter >= 'p' && lastNameLetter <= 'r')
                    {
                        timeOutputLabel.Text = TIME_FIVE;
                        dayOutputLabel.Text = SOPHOMORE_TWO;
                    }
                }

                else if (freshmanRadioButton.Checked)
                {
                    //freshman first day to register
                    if (lastNameLetter >= 's' && lastNameLetter <= 't')
                    {
                        timeOutputLabel.Text = TIME_ONE;
                        dayOutputLabel.Text = FRESHMAN_ONE;
                    }
                    else if (lastNameLetter >= 'u' && lastNameLetter <= 'v')
                    {
                        timeOutputLabel.Text = TIME_TWO;
                        dayOutputLabel.Text = FRESHMAN_ONE;
                    }
                    else if (lastNameLetter >= 'w' && lastNameLetter <= 'z')
                    {
                        timeOutputLabel.Text = TIME_THREE;
                        dayOutputLabel.Text = FRESHMAN_ONE;
                    }
                    else if (lastNameLetter >= 'a' && lastNameLetter <= 'b')
                    {
                        timeOutputLabel.Text = TIME_FOUR;
                        dayOutputLabel.Text = FRESHMAN_ONE;
                    }
                    else if (lastNameLetter >= 'c' && lastNameLetter <= 'd')
                    {
                        timeOutputLabel.Text = TIME_FIVE;
                        dayOutputLabel.Text = FRESHMAN_ONE;
                    }
                    //freshman second day to register
                    else if (lastNameLetter >= 'e' && lastNameLetter <= 'f')
                    {
                        timeOutputLabel.Text = TIME_ONE;
                        dayOutputLabel.Text = FRESHMAN_TWO;
                    }
                    else if (lastNameLetter >= 'g' && lastNameLetter <= 'i')
                    {
                        timeOutputLabel.Text = TIME_TWO;
                        dayOutputLabel.Text = FRESHMAN_TWO;
                    }
                    else if (lastNameLetter >= 'j' && lastNameLetter <= 'l')
                    {
                        timeOutputLabel.Text = TIME_THREE;
                        dayOutputLabel.Text = SOPHOMORE_TWO;
                    }
                    else if (lastNameLetter >= 'm' && lastNameLetter <= 'o')
                    {
                        timeOutputLabel.Text = TIME_FOUR;
                        dayOutputLabel.Text = FRESHMAN_TWO;
                    }
                    else if (lastNameLetter >= 'p' && lastNameLetter <= 'r')
                    {
                        timeOutputLabel.Text = TIME_FIVE;
                        dayOutputLabel.Text = FRESHMAN_TWO;
                    }
                }
                studentLastTextBox.Focus();
            }
            else // incase someone accidentally puts in full last name or more than 1 letter
                MessageBox.Show("Enter only the first letter of your last name.");
        }

        private void exitButton_Click(object sender, EventArgs e) //closes the program
        {
            this.Close();
        }
    }
}
