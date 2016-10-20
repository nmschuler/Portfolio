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
    public partial class ReturnItemDialogBox : Form
    {
        private List<LibraryItem> items;      //references the lsit

        //Preconditions: none
        //Postconditions: steps through the list and populates combo box with information
        public ReturnItemDialogBox(List<LibraryItem> i)
        {
            InitializeComponent();

            items = i;

            foreach (LibraryItem item in items)
            {
                returnItemComboBox.Items.Add(item.Title + ", " + item.CallNumber);
            }
        }

        //Preconditions: click cancel button
        //Postconditions: closes the form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            returnItemComboBox.SelectedIndex = -1;
            this.Close();
        }

        //Preconditions: click return button
        //Postconditions: continues
        private void returnButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public int ReturnItem    
        {
            //Preconditions: none
            //Postconditions: selected index has been returned
            get
            {
                return returnItemComboBox.SelectedIndex;
            }
            //Preconditions: none
            //Postconditions: selected index has been set to a value
            set
            {
                returnItemComboBox.SelectedIndex = value;
            }
        }
//-------------------------------------------------------------------------------------------------------------------------
                        //VALIDATE RETURNING ITEM
        //Preconditions: ReturnItemComboBox validated succeeded
        //Postconditions: any error message has been cleared. can now change focus
        private void ReturnItemCombo_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(returnItemComboBox, string.Empty);
        }
        //Preconditions: attempting to change from return item combo box without selecting one
        //Postconditions: doesnt let user switch focus. displays message saying to enter information
        private void ReturnItemCombo_Validating(object sender, CancelEventArgs e)
        {
            if (returnItemComboBox.SelectedIndex < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(returnItemComboBox, "Please select an item to return");
            }
        }

    }
}
