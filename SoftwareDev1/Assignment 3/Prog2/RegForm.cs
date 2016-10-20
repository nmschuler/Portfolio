/*Nick Schuler
 * Program 3
 * Due November 21, 2014 (had extension)
 * CIS 199-01
 * 
 * I want to give a BIG SHOUT OUT TO PROFESSOR WRIGHT for providing me the starting code for this project!
 * 
 * this project is the same as project 2, except using arrays to find registration dates and times
 *          to determine when you can register, rather than if-else statements (prog 2) */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }
        //Preconditions: user enters last name, we must single out only the first letter then capitalize it,
        //          must be a letter entered in first position of the input textbox
        //Postconditions: will return the date and time the user can register for classes
        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            const string DAY1 = "November 7";  // 1st day of registration
            const string DAY2 = "November 10"; // 2nd day of registration
            const string DAY3 = "November 11"; // 3rd day of registration
            const string DAY4 = "November 12"; // 4th day of registration
            const string DAY5 = "November 13"; // 5th day of registration
            const string DAY6 = "November 14"; // 6th day of registration

            const string TIME1 = "8:30 AM";  // 1st time block
            const string TIME2 = "10:00 AM"; // 2nd time block
            const string TIME3 = "11:30 AM"; // 3rd time block
            const string TIME4 = "2:00 PM";  // 4th time block
            const string TIME5 = "4:00 PM";  // 5th time block

            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration

            lastNameStr = lastNameTxt.Text;

            if (lastNameStr == "") // Empty text box
                MessageBox.Show("Please enter last name!");
            else
            {
                lastNameLetterCh = lastNameStr[0]; // As in text, p. 466-467

                if (!char.IsLetter(lastNameLetterCh)) // Is it a letter or not?
                    MessageBox.Show("Please ensure a letter is in first position of last name!");
                else
                {
                    lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                    // Juniors and Seniors share same schedule but different days
                    if (juniorBtn.Checked || seniorBtn.Checked)
                    {
                        if (seniorBtn.Checked)
                            dateStr = DAY1;
                        else // Must be juniors
                            dateStr = DAY2;
                        char[] junSenArray = { 'A', 'E', 'J', 'P', 'S' }; //beginning letters of last name
                        string[] times = { TIME2, TIME3, TIME4, TIME5, TIME1 }; //times associated with letters (above)
                        int sub = junSenArray.Length - 1; //get the subscript for the array

                        while (sub >= 0 && lastNameLetterCh < junSenArray[sub]) //while loop to find location of letter
                        {
                            --sub;  //reduce sub by 1 to continue looking
                        }
                        timeStr = times[sub];   //displays time to register based on times array with subscript from junSenArray
                    }
                    // Sophomores and Freshmen
                    else // Must be soph/fresh
                    {
                        if (sophBtn.Checked)
                        {
                            // C-O on one day
                            if ((lastNameLetterCh >= 'E') && // >= E and
                                (lastNameLetterCh <= 'R'))   // <= R
                                dateStr = DAY4;
                            else // All other letters on previous day
                                dateStr = DAY3;
                        }
                        else // must be freshman
                        {
                            // C-O on one day
                            if ((lastNameLetterCh >= 'E') && // >= E and
                                (lastNameLetterCh <= 'R'))   // <= R
                                dateStr = DAY6;
                            else // All other letters on previous day
                                dateStr = DAY5;
                        }
                        char[] freshSophArray={'A','C','E','G','J','M','P','S','U','W'}; //last names for fresh or soph
                        string[] times ={TIME4,TIME5,TIME1,TIME2,TIME3,TIME4,
                                            TIME5,TIME1,TIME2,TIME3};  //times associated with last name
                        int sub = freshSophArray.Length - 1; //get subscript

                        while (sub >= 0 && lastNameLetterCh < freshSophArray[sub])  //look for last name
                        {
                            --sub; //reduce sub by 1 to continue looking
                        }
                        timeStr = times[sub]; //displays register time
                    }
                    dateTimeLbl.Text = dateStr + " at " + timeStr;
                }
            }
        }
    }
}
