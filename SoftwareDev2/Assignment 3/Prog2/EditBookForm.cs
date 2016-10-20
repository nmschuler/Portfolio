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
    public partial class EditBookForm : Form
    {
        private List<LibraryItem> items;   //reference to the list

        //Preconditions: none
        //Postconditions: none
        public EditBookForm(List<LibraryItem> itemList)
        {
            InitializeComponent();

            items = itemList;
        }

        //Preconditions: user loads the form
        //Postconditions: populates the combobox with BOOKS
        private void EditBookForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryItem item in items)
            {
                if (item is LibraryBook)
                {
                    editBookComboBox.Items.Add(item.Title + ", " + item.CallNumber);
                } 
            }
        }

        //Preconditions: none
        //Postconditions: returns the index of the item
        public int ItemIndex
        {
            get
            {
                return editBookComboBox.SelectedIndex;
            }
        }

        //Preconditions: user must click the button
        //Postconditions: validates returns ok, continues
        private void selectBookButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) // If all controls validate
                this.DialogResult = DialogResult.OK; // Causes form to close and return OK result            
        }

        //Preconditions: switch focus from combo box without selecting anything
        //Postconditions: doesnt let you switch focus, error message pops up
        private void editBookCombo_Validating(object sender, CancelEventArgs e)
        {
            if (editBookComboBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(editBookComboBox, "Please select a book from the list!");
            }
        }

        //Preconditions: validating not cancelled, so ok
        //Postconditions: error removed. allowed to switch focus
        private void editBook_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(editBookComboBox, "");
        }
    }
}
