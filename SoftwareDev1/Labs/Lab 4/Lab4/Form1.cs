/*Nicholas Schuler
 * Lab 4
 * Due October 5, 2014
 * CIS 199-01
 * This program uses user inputted gpa and admission scores when applying for college, and has a pop up message box
 *      saying if they were accepted or declined from admission to the college. It also keeps a running total
 *      of how many accepts and declines there were (untill cleared). */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        const double GPA_REQUIREMENT = 3.0;
        const int LOW_ADMISSION_SCORE = 60;
        const int HIGH_ADMISSION_SCORE = 80;

        private int accepted = 0;
        private int declined = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double gpaInput;
            int admissionScore;
           
            

            gpaInput = double.Parse(gpaInputTextBox.Text);
            admissionScore = int.Parse(admissionScoreInputTextBox.Text);

            if (gpaInput >= GPA_REQUIREMENT && admissionScore >= LOW_ADMISSION_SCORE)
            {
                MessageBox.Show("Accepted");
                accepted += 1;
            }
            else if (gpaInput < GPA_REQUIREMENT && admissionScore >= HIGH_ADMISSION_SCORE)
            {
                MessageBox.Show("Accepted");
                accepted += 1;
            }
            else if (gpaInput >= GPA_REQUIREMENT && admissionScore < LOW_ADMISSION_SCORE)
            {
                MessageBox.Show("Declined");
                declined += 1;
            }
            else if (gpaInput < GPA_REQUIREMENT && admissionScore < HIGH_ADMISSION_SCORE)
            {
                MessageBox.Show("Declined");
                declined += 1;
            }
            applicantsAcceptedOutputLabel.Text = accepted.ToString();
            applicantsDeclinedOutputLabel.Text = declined.ToString();


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            gpaInputTextBox.Text = (" ");
            admissionScoreInputTextBox.Text = (" ");
            applicantsAcceptedOutputLabel.Text = (" ");
            applicantsDeclinedOutputLabel.Text = (" ");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
