using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class EditPatronForm : Form
    {
        private List<LibraryPatron> patrons; // List of patrons

        //Preconditions: none
        //Postconditions: none
        public EditPatronForm(List<LibraryPatron> patronList)
        {
            InitializeComponent();

            patrons = patronList;
        }

        //Preconditions: when the edit patron form loads
        //Postconditions: populates the combo box
        private void EditPatronForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryPatron patron in patrons)
                patronSelectComboBox.Items.Add(patron.PatronName + ", " + patron.PatronID);
        }
        
        //Preconditions: none
        //Postconditions: returns the index of the selected item in the combo box
        public int PatronIndex
        {
            get
            {
                return patronSelectComboBox.SelectedIndex;
            }
        }

        //Preconditions: switch focus from combo box without selecting anything
        //Postconditions: doesnt let you switch focus, error message pops up
        private void patronSelectCombo_Validating(object sender, CancelEventArgs e)
        {
            if (patronSelectComboBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(patronSelectComboBox, "Please select a patron");
            }
        }

        //Preconditions: validating not cancelled, so ok
        //Postconditions: error removed. allowed to switch focus
        private void patronSelectCombo_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(patronSelectComboBox, "");
        }

        //Preconditions: user must click the button
        //Postconditions: validates returns ok, continues
        private void selectPatronButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) // If all controls validate
                this.DialogResult = DialogResult.OK; // Causes form to close and return OK result            
        }
    }
}
