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
    public partial class CheckOutDialogBox : Form
    {

        Library theLibrary = new Library();  //creates library for the class to use

        private List<LibraryItem> items;          //reference to list
        private List<LibraryPatron> patrons;      //reference to lsit

        //Precondition: none
        //Postcondition: loops through the lsit and displays items in the combo box
        public CheckOutDialogBox(List<LibraryItem> i, List<LibraryPatron> p)
        {
            InitializeComponent();

            items = i;
            patrons = p;

            foreach (LibraryItem item in items)
            {
                libraryItemComboBox.Items.Add(item.Title + ", " + item.CallNumber);
            }

            foreach (LibraryPatron patron in patrons)
            {
                patronComboBox.Items.Add(patron.PatronName + ", " + patron.PatronID);
            }
        }

        //Preconditions: Click close button
        //Postconditions: closes the form
        private void closeButton_Click(object sender, EventArgs e)
        {
            libraryItemComboBox.SelectedIndex = -1;
            patronComboBox.SelectedIndex = -1;
            this.Close();
        }

        public int ItemCheckedOut
        {
            //Preconditions: none
            //Postconditions: the selected index has been returned
            get { return libraryItemComboBox.SelectedIndex; }

            //Preconditions: none
            //Postconditions: the selected index has been set to the specified value
            set { libraryItemComboBox.SelectedIndex = value; }
        }

        public int PatronCheckedOut
        {
            //Preconditions: none
            //Postconditions: the selected index has been returned
            get { return patronComboBox.SelectedIndex; }

            //Preconditions: none
            //Postconditions: the selected index has been set to the specified value
            set { patronComboBox.SelectedIndex = value; }
        }

        //Preconditions: none
        //Postconditions: continues 
        private void checkOutButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
//-------------------------------------------------------------------------------------------------------------------------
                        //VALIDATE LIBRARY ITEM
        //Preconditions: libraryitemcombo validating has succeeded
        //Postconditions: any error message has been cleared and user can now switch focus
        private void LibraryItemCombo_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(libraryItemComboBox, string.Empty);
        }

        //Preconditions: attempting to change focus from library item combo without selecting
        //Postconditions: doesnt let user continue and displays error message
        private void LibraryItemCombo_Validating(object sender, CancelEventArgs e)
        {
            if (libraryItemComboBox.SelectedIndex < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(libraryItemComboBox, "Please select an item");
            }
        }
//-------------------------------------------------------------------------------------------------------------------------
                        //VALIDATE PATRON
        //Preconditions: patroncombo has validating succeeded
        //Postconditions: any error message has been cleared. focus can now change
        private void PatronCombo_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(patronComboBox, string.Empty);
        }

        //Preconditions: attempting to change focus from patroncombo without selecting
        //Postconditions: doesnt let user switch focus. displays message saying to enter information
        private void PatronCombo_Validating(object sender, CancelEventArgs e)
        {
            if (patronComboBox.SelectedIndex < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(patronComboBox, "Please select a patron");
            }
        }
    }
}
