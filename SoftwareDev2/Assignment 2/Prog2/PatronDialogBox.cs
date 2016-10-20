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
    public partial class PatronDialogBox : Form
    {
        public PatronDialogBox()
        {
            InitializeComponent();
        }
        //Preconditions: click clear button  
        //Postconditions: clears all user inputted text
        private void clearPatronButton_Click(object sender, EventArgs e)
        {
            nameInputTextBox.Text = "";
            idInputTextBox.Text = "";
        }
        //Preconditions: click add button
        //Postconditions: continues
        private void addPatronButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        public string AddPatronName
        {
            //Preconditions: none
            //Postconditions: patron name has been returned
            get { return nameInputTextBox.Text; }

            //Preconditions: none
            //Postconditions: patron name has been set to specified value
            set { nameInputTextBox.Text = value; }
        }

        public string AddPatronID
        {
            //Preconditions: none
            //Postconditions: patron ID has been returned
            get { return idInputTextBox.Text; }

            //Preconditions: none
            //Postconditions: patronID has been set to specified value
            set { idInputTextBox.Text = value; }
        }
//----------------------------------------------------------------------------------------------------------------
                        //VALIDATE PATRON NAME
        //Preconditions: patroninputtextbox Validating succeeded
        //Postconditions: any error message has been cleared. Focus can now change
        private void PatronInputTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameInputTextBox, string.Empty);
        }

        //Preconditions: attempting to switch focus from patroninputtextbox without entering any information
        //Postconditions:doesnt let user switch focus. displays message saying to enter information
        private void PatronInputTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nameInputTextBox.Text == String.Empty)
            {
                e.Cancel = true; 

                errorProvider1.SetError(nameInputTextBox, "Enter a patron name!");
            }
        }
//---------------------------------------------------------------------------------------------------------------------
                        //VALIDATE PATRON ID
        //Preconditions: idinputtextbox validating succeeded
        //Postconditions: any error message has been cleared. can now change focus
        private void IDInputTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(idInputTextBox, string.Empty);
        }

        //Preconditions: attempting to change focus from idinputtextbox without entering any information
        //Postconditions: doesnt let user switch focus. displays message saying to enter information
        private void IDInputTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (idInputTextBox.Text == string.Empty)
            {
                e.Cancel = true;

                errorProvider1.SetError(idInputTextBox, "Enter a patron ID!");
            }
        }
    }
}
