/*Nick Schuler
 * Program 4
 * Due: December 8,2014
 * CIS 199-01 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog4
{
    public partial class Form1 : Form
    {
        //list to hold LibraryBook objects
        List<LibraryBook> bookList = new List<LibraryBook>();

        public Form1()
        {
            InitializeComponent();
        }

        //Preconditions: copyright year must be greater than 0, then pull out the user inputted data
        //Postconditions: if the cr year is 0 or higher, then it will work. if it is not, it will tell
                    //the user to input a year greater than 0
        private void GetBookData(out LibraryBook book)
        {
            int crYear;
            book = null;
           
            if (int.TryParse(copyYearTextBox.Text, out crYear))
            {
                if (crYear >= 0)
                {
                    string title = titleTextBox.Text;
                    string author = authorTextBox.Text;
                    string publisher = publisherTextBox.Text;
                    string callNumber = callNumTextBox.Text;

                    book = new LibraryBook(title, author, publisher, crYear, callNumber);
                }
                else { MessageBox.Show("Enter a year greater than 0"); }

            }
            else { MessageBox.Show("Invalid Year"); }
        }

        //Preconditions: create an object, have it retireve the data the user entered, add it to the list, then
                //have it clear the text boxes to be ready for a new one
        //Postconditions: user enters the data, this adds it to the lsit and clears text boxes
        private void addButton_Click(object sender, EventArgs e)
        {
            //create object
            LibraryBook myBook;

            //get book data
            GetBookData(out myBook);
            
            //if not null do this
            //create array
            //string[] userInput = { titleTextBox.Text, authorTextBox.Text, publisherTextBox.Text, 
            //                         callNumTextBox.Text, (string)copyYearTextBox.Text };
            //foreach (string val in userInput)
            //{
            //    if (val = "")
            //    {
            //        MessageBox.Show("Please fill out all text boxes.");
            //    }
            //}
            

            //add to list
            bookList.Add(myBook);

            //add entry to listbox
            bookTitleListBox.Items.Add(myBook.Title);

            //clear textbox controls
            titleTextBox.Clear();
            authorTextBox.Clear();
            publisherTextBox.Clear();
            copyYearTextBox.Clear();
            callNumTextBox.Clear();
        }

        //Preconditions: the selected index must be > -1, if it is not, that means user hasnt selected anything
                //so it will throw them an error to select a book
        //Postconditions: user clicks a book title, and it displays the information
        private void detailsButton_Click(object sender, EventArgs e)
        {
            //get index of the book
            int index = bookTitleListBox.SelectedIndex;

            if (bookTitleListBox.SelectedIndex > -1)
            {
                MessageBox.Show(bookList[index].ToString());
            }
            else
            {
                MessageBox.Show("Please select a book!");
            }
        }

        //Preconditions: makes sure index is > -1 so a book is selected. Make sure the book is not already
                        //checked out. if it is already checked out, error message pops up
        //Postconditions: checks the book out if it is not already checked out
        private void checkOutButton_Click(object sender, EventArgs e)
        {
            int index = bookTitleListBox.SelectedIndex;
            if (bookTitleListBox.SelectedIndex > -1)
            {
                if (bookList[index].IsCheckedOut() == false)
                {
                    bookList[index].CheckOut();

                    MessageBox.Show("This book has been checked out!");
                }
                else
                {
                    MessageBox.Show("This book is already checked out!");
                }
            }
            else
            {
                MessageBox.Show("Please select a book!");
            }
        }

        //Preconditions: makes sure selected index is > -1 so you have a title selected. makes sure the book
        //              is already checked out. if the book is not checked out, a message will pop saying
        //              it is not checked out
        //Postconditions: will return the book
        private void returnButton_Click(object sender, EventArgs e)
        {
            int index = bookTitleListBox.SelectedIndex;

            if (bookTitleListBox.SelectedIndex > -1)
            {
                if (bookList[index].IsCheckedOut() == true)
                {
                    bookList[index].ReturnToShelf();

                    MessageBox.Show("This book has been returned to the shelf!");
                }
                else
                {
                    MessageBox.Show("This book is already returned!");
                }
            }
            else
            {
                MessageBox.Show("Please select a book!");
            }
        }

        //Preconditions: none
        //Postconditions: clears the text boxes incase they wanted to start over
        private void clearButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Clear();
            authorTextBox.Clear();
            publisherTextBox.Clear();
            copyYearTextBox.Clear();
            callNumTextBox.Clear();

        }


    }
}
