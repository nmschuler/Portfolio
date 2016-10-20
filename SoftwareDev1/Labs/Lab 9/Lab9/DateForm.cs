/* Nick Schuler
 * Lab 9
 * Due December 7, 2014
 * CIS 199-01
 * This program starts off with a preset date (01/01/2000) and the user enters new numbers. when the user 
 *      clicks the update button, the month will update just that number, rather than the entire date */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class DateForm : Form
    {
       //date starting at 01/01/2000
        private Date updateDate = new Date(01, 01, 2000);
        
        public DateForm()
        {
            InitializeComponent();
        }

        private void DateForm_Load(object sender, EventArgs e)
        {
            //what to do here? is this right?
            dateOutputLabel.Text = updateDate.ToString();
        }

        private void monthButton_Click(object sender, EventArgs e)
        {
            int month;

            if (int.TryParse(monthTextBox.Text, out month))
            {
                updateDate.Month = month;

                dateOutputLabel.Text = updateDate.ToString();

                monthTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Invalid Month");
            }
        }

        private void dayButton_Click(object sender, EventArgs e)
        {
            int day;

            if (int.TryParse(dayTextBox.Text, out day))
            {
                updateDate.Day = day;

                dateOutputLabel.Text = updateDate.ToString();

                dayTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Invalid Day");
            }
        }

        private void yearButton_Click(object sender, EventArgs e)
        {
            int year;

            if (int.TryParse(yearTextBox.Text, out year))
            {
                updateDate.Year = year;

                dateOutputLabel.Text = updateDate.ToString();

                yearTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Invalid Year");
            }
        }


    }
}
