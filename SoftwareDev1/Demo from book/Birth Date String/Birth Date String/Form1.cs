using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            //Declare a string variable
            string output;

            //Concatenate the input and build the output string
            output = dayOfWeekTextBox.Text + ", " +
                monthTextBox.Text + " " +
                dayOfMonthTextBox.Text + ", " +
                yearTextBox.Text;

            //Display the output string in the Label control
            dateOutputLabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the TextBoxes
            dayOfWeekTextBox.Text = " ";
            monthTextBox.Text = " ";
            dayOfMonthTextBox.Text = " ";
            yearTextBox.Text = " ";

            //Clear the dateOutputLabel
            dateOutputLabel.Text = " ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
