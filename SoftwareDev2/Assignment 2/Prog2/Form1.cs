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
    public partial class Form1 : Form
    {
        Library theLibrary = new Library();  //creates library for the class to use

        public Form1()
        {
            InitializeComponent();

             //Test data - Magic numbers allowed here
            theLibrary.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
                "ZZ25 3G", "Andrew Wright");
            theLibrary.AddLibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
                "AB73 ZF", "IP Thief");
            theLibrary.AddLibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
                "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
                LibraryMovie.MPAARatings.PG);
            theLibrary.AddLibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2011, 10,
                "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G);
            theLibrary.AddLibraryMusic("C# - The Album", "UofL Music", 2011, 14,
                "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
            theLibrary.AddLibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
                "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12);
            theLibrary.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2011, 14,
                "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
            theLibrary.AddLibraryJournal("Journal of VB Goodness", "UofL Journals", 2007, 14,
                "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams");
            theLibrary.AddLibraryMagazine("C# Monthly", "UofL Mags", 2010, 14,
                "MA53 9A", 16, 7);
            theLibrary.AddLibraryMagazine("C# Monthly", "UofL Mags", 2010, 14,
                "MA53 9B", 16, 8);
            theLibrary.AddLibraryMagazine("C# Monthly", "UofL Mags", 2010, 14,
                "MA53 9C", 16, 9);
            theLibrary.AddLibraryMagazine("VB Magazine", "UofL Mags", 2011, 14,
                "MA21 5V", 1, 1);

             //Add patrons
            theLibrary.AddPatron("Ima Reader", "12345");
            theLibrary.AddPatron("Jane Doe", "11223");
            theLibrary.AddPatron("John Smith", "54321");
            theLibrary.AddPatron("James T. Kirk", "98765");
            theLibrary.AddPatron("Jean-Luc Picard", "33456");

        }

        //Preconditions: click File>About
        //Postconditions: displays information about the project
        private void aboutSubMenuItem_Click(object sender, EventArgs e)    
        {
            MessageBox.Show("Nicholas Schuler\nProgram 2\nDue March 11, 2015\nCIS 200-01");
        }

        //Preconditions: click File>CLose
        //Postconditions: closes the form
        private void exitSubMenuItem_Click(object sender, EventArgs e)    
        {
            this.Close();
        }

        //Preconditions: click Report>List Patrons
        //Postconditions: goes through a loop to display all the patrons in the library
        private void patronListSubMenuItem_Click(object sender, EventArgs e)    
        {
            PatronDialogBox patronDBox = new PatronDialogBox();    //create object for PatronDialogBox

            outputTextBox.Text = "";   //Clears the textbox

            outputTextBox.Text = "Count of Patrons: " + theLibrary.GetPatronCount() + System.Environment.NewLine +
                System.Environment.NewLine;

            for (int k = 0; k < theLibrary._patrons.Count; k++)     //loops through the library and displays patrons
            {
                outputTextBox.Text += theLibrary._patrons[k] +
                    System.Environment.NewLine + System.Environment.NewLine;
            }

        }

        //Preconditions: Click Insert>Patron
        //Postconditions: pops up dialog box for user to enter patron information then adds to the library
        private void patronSubMenuItem_Click(object sender, EventArgs e)   
        {
            PatronDialogBox patronDBox = new PatronDialogBox();    //create object for PatronDialogBox
            patronDBox.ShowDialog();                               //pulls up the PatronDialogBox - modal

            theLibrary.AddPatron(patronDBox.AddPatronName, patronDBox.AddPatronID);
        }

        //Preconditions: click Insert>Book
        //Postconditions: pops up a dialog box for user to enter book information. stores the information as a book in the library
        private void bookSubMenuItem_Click(object sender, EventArgs e)    
        {
            BookDialogBox bookDBox = new BookDialogBox();     //create object for BookDialogBox
            bookDBox.ShowDialog();                            //pulls up the BookDialogBox

            theLibrary.AddLibraryBook(bookDBox.AddTitle, bookDBox.AddPublisher, bookDBox.AddCopyrightYear,   
                bookDBox.AddLoanPeriod, bookDBox.AddCallNumber, bookDBox.AddAuthor);
        }

        //Preconditions: click Report>List Items
        //Postconditions: goes through a loop to display all items stored in the library
        private void itemListSubMenuItem_Click(object sender, EventArgs e)    
        {
            BookDialogBox bookDBox = new BookDialogBox();

            outputTextBox.Text = "";   //clears textbox

            outputTextBox.Text = "Count of items: " + theLibrary.GetItemCount() + System.Environment.NewLine +
                System.Environment.NewLine;

            for (int k = 0; k < theLibrary._items.Count; k++)   //loops through the library and displaying items
            {
                outputTextBox.Text += theLibrary._items[k] + System.Environment.NewLine +
                    System.Environment.NewLine;
            }
        }

        //Preconditions: click Item>Check Out
        //Postconditions: pops up dialog box to enter information. then changes book status to checked out
        private void checkOutSubMenuItem_Click(object sender, EventArgs e)
        {
            CheckOutDialogBox checkOutDBox = new CheckOutDialogBox(theLibrary._items, theLibrary._patrons);
            checkOutDBox.ShowDialog();

            theLibrary.CheckOut(checkOutDBox.ItemCheckedOut, checkOutDBox.PatronCheckedOut);
        }

        //Preconditions: click Item>Return
        //Postconditions: pops up dialog box to enter information. then changes books status to not checked out
        private void returnSubMenuItem1_Click(object sender, EventArgs e)
        {
            ReturnItemDialogBox returnDBox = new ReturnItemDialogBox(theLibrary._items);
            returnDBox.ShowDialog();

            theLibrary.ReturnToShelf(returnDBox.ReturnItem);
        }

        //Preconditions: click report>checked out items
        //Postconditions: goes through a loop and displays all items that are checked out
        private void checkedOutItemsSubMenuItem_Click(object sender, EventArgs e)     //REPORT - LIST CHECKED OUT
        {
            outputTextBox.Text = "";

            outputTextBox.Text = "Count of checked out items: " + theLibrary.GetCheckedOutCount() + System.Environment.NewLine +
                System.Environment.NewLine;

            foreach (LibraryItem item in theLibrary._items)
            {                                   
                if (item.IsCheckedOut())
                {
                    outputTextBox.Text += item + System.Environment.NewLine + System.Environment.NewLine;
                }
            }
        }
    }
}
