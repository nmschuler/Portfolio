using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class BookDialogBox : Form
    {
        public BookDialogBox()
        {
            InitializeComponent();
        }

        private int copyrightYearNum;   //holds the copyright year
        private int loanPeriodNum;      //holds the loan period

        //Preconditions: click clear button
        //Postconditions: clears all the text boxes
        private void clearBookButton_Click(object sender, EventArgs e)
        {
            titleInputTextBox.Text = "";
            publisherInputTextBox.Text = "";
            copyrightYearInputTextBox.Text = "";
            loanPeriodInputTextBox.Text = "";
            callNumberInputTextBox.Text = "";
            authorInputTextBox.Text = "";
        }

        public string AddTitle
        {
            //Preconditions: none
            //Postconditions: the title has been returned
            get { return titleInputTextBox.Text; }

            //Preconditions: none
            //Postconditions: the title has been set to the specified value
            set { titleInputTextBox.Text = value; }
        }

        public string AddPublisher
        {
            //Preconditions: none
            //Postconditions: the publisher has been returned
            get { return publisherInputTextBox.Text; }

            //Preconditions: none
            //Postconditions: the publisher has been set to your specified value
            set { publisherInputTextBox.Text = value; }
        }

        public int AddCopyrightYear
        {
            //Preconditions: none
            //Postconditions: copyright year has been returned
            get 
            {
                return copyrightYearNum = int.Parse(copyrightYearInputTextBox.Text);
            }

            //Preconditions: none
            //Postconditions: copyright year has been set to specified value
            set { copyrightYearNum = value; }
        }

        public int AddLoanPeriod
        {
            //Preconditions: none 
            //Postconditions: loan period has been returned
            get { return loanPeriodNum = int.Parse(loanPeriodInputTextBox.Text); }

            //Preconditions: none
            //Postconditions: loan period has been set to the specified value
            set { loanPeriodNum = value; }
        }

        public string AddCallNumber
        {
            //Preconditions: none
            //Postconditions: call number has been returned
            get { return callNumberInputTextBox.Text; }

            //Preconditions: none
            //Postconditions: the call number has been set tot he specified value
            set { callNumberInputTextBox.Text = value; }
        }

        public string AddAuthor
        {
            //Preconditions: none
            //Postconditions: the author has been returned
            get { return authorInputTextBox.Text; }

            //Preconditions: none
            //Postconditions: the author has been set tot he specified value
            set { authorInputTextBox.Text = value; }
        }

        //Preconditions: click add button
        //Postconditions: continues
        private void addBookButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
//----------------------------------------------------------------------------------------------------------------------------
                   //VALIDATE TITLE
        //Preconditions: titeinput_validating succeeded
        //Postconditions: any error messages have been cleared, focus can now be changed
        private void TitleInput_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(titleInputTextBox, string.Empty);
        }
        
        //Preconditions: attempting to change focus from titleinput without entering information
        //Postconditions: doesnt let user switch focus. displays error message to enter information
        private void TitleInput_Validating(object sender, CancelEventArgs e)
        {
            if (titleInputTextBox.Text == string.Empty)
            {
                e.Cancel = true; 
                

                errorProvider1.SetError(titleInputTextBox, "Please enter a title"); 
            }
        }
//----------------------------------------------------------------------------------------------------------------------------
                    //VALIDATE PUBLISHER
        //Preconditions: publishinput_validating succeeded
        //Postconditions: any error message has been cleared, focus can now change
        private void PublishInput_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(publisherInputTextBox, string.Empty);
        }

        //Preconditions: attempting to change focus from publishinput without entering info
        //Postconditions: doesnt let user switch focus. displays message saying to enter information
        private void PublishInput_Validating(object sender, CancelEventArgs e)
        {
            if (publisherInputTextBox.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(publisherInputTextBox, "Please enter a publisher");
            }
        }
//-----------------------------------------------------------------------------------------------------------------------------
                    //VALIDATE COPYRIGHT YEAR
        //Preconditions: copyrightyearinput_validating succeeded
        //Postconditions: any error message has been cleared. focus can now change
        private void copyrightYearInput_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(copyrightYearInputTextBox, string.Empty);
        }

        //Preconditions: attempting to change focus from copyrightyearinput without entering any info
        //Postconditions: doesnt let user switch focus. displays message saying to enter information
        private void copyrightYearInput_Validating(object sender, CancelEventArgs e)
        {
            int number;      //holds the number to validate

            if (!int.TryParse(copyrightYearInputTextBox.Text, out number))
            {
                e.Cancel = true; 

                errorProvider1.SetError(copyrightYearInputTextBox, "Please enter the copyright year"); // Set error message
            }
            else
            {
                if (number < 0)
                {
                    e.Cancel = true;

                    errorProvider1.SetError(copyrightYearInputTextBox, "Enter a non-negative integer!"); // Set error message
                }
            }
        }
//----------------------------------------------------------------------------------------------------------------------------
                        //VALIDATE LOAN PERIOD
        //Preconditions: loadperiodinput_validating succeeded
        //Postconditions: any error message has been cleared. focus can now change
        private void LoanPeriodInput_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(loanPeriodInputTextBox, string.Empty);
        }

        //Preconditions: attempting t change focus from loanperiodinput w/o entering any info
        //Postconditions: doesnt elt user switch focus. displays message saying to enter information
        private void LoanPeriodInput_Validating(object sender, CancelEventArgs e)
        {
            int number;       //holds number to validate

            if (!int.TryParse(loanPeriodInputTextBox.Text, out number))
            {
                e.Cancel = true;

                errorProvider1.SetError(loanPeriodInputTextBox, "Please enter the loan period");
            }
            else
            {
                if (number < 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(loanPeriodInputTextBox, "Loan period must be greater than zero");
                }
            }
        }
//--------------------------------------------------------------------------------------------------------------------------
                    //VALIDATE CALL NUMBER
        //Preconditions: callnumberinput_validating succeeded
        //Postconditions: clears any error messages. focus can now be changed
        private void CallNumberInput_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(callNumberInputTextBox, string.Empty);
        }

        //Preconditions: attempting to change focus from callnumberinput without entering any information
        //Postconditions: doesnt let user switch focus. displays error message saying to enter information
        private void CallNumberInput_Validating(object sender, CancelEventArgs e)
        {
            if (callNumberInputTextBox.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(callNumberInputTextBox, "Please enter a call number");
            }
        }
//--------------------------------------------------------------------------------------------------------------------------
                        //AUTHOR VALIDATE
        //Preconditions: authorinout_validating succeeded
        //Postconditions: any error message has been clear3ed. focus can now be changed
        private void AuthorInput_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(authorInputTextBox, string.Empty);
        }

        //Preconditions: attempting to change focus from authorinput without ewntering any information
        //Postconditions: doesnt elt user switch focus. displays message saying to enter information
        private void AuthorInput_Validating(object sender, CancelEventArgs e)
        {
            if (authorInputTextBox.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(authorInputTextBox, "Please enter an author");
            }
        }
    }
}
