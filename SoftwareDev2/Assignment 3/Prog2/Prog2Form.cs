// Program 2 - Extra Credit
// CIS 200-01
// Spring 2015
// Due: 3/31/2015
// By: Nicholas Schuler

// File: Prog2Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Patron and
// Book items, an Item menu with Check Out and Return items, and a
// Report menu with Patron List, Item List, and Checked Out Items items.
// Extra Credit - Check Out and Return only show relevant items

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;   //added
using System.Runtime.Serialization;                     //added
using System.IO;                                        //added

namespace LibraryItems
{
    public partial class Prog2Form : Form
    {
        private Library lib; // The library

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test items and patrons
        //                are added to the library
        public Prog2Form()
        {
            InitializeComponent();

            lib = new Library(); // Create the library

            // //Insert test data - Magic numbers allowed here
            //lib.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14, "ZZ225 3G", "Andrew Wright");
            //lib.AddLibraryBook("Harriet Pooter", "Stealer Books", 2000, 21, "AG773 ZF", "IP Thief");
            //lib.AddLibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            //    "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            //    LibraryMovie.MPAARatings.PG);
            //lib.AddLibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2011, 10,
            //    "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G);
            //lib.AddLibraryMusic("C# - The Album", "UofL Music", 2011, 14,
            //    "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
            //lib.AddLibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
            //    "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12);
            //lib.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2011, 14,
            //    "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
            //lib.AddLibraryJournal("Journal of VB Goodness", "UofL Journals", 2007, 14,
            //    "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams");
            //lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2010, 14,
            //    "MA53 9A", 16, 7);
            //lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2010, 14,
            //    "MA53 9B", 16, 8);
            //lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2010, 14,
            //    "MA53 9C", 16, 9);
            //lib.AddLibraryMagazine("VB Magazine", "UofL Mags", 2011, 14,
            //    "MA21 5V", 1, 1);

            //// Add 5 Patrons
            //lib.AddPatron("Ima Reader", "12345");
            //lib.AddPatron("Jane Doe", "11223");
            //lib.AddPatron("John Smith", "54321");
            //lib.AddPatron("James T. Kirk", "98765");
            //lib.AddPatron("Jean-Luc Picard", "33456");
        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Program 2 - Extra Credit{0}By: Andrew L. Wright{0}" +
                "CIS 200-01{0}Spring 2015", System.Environment.NewLine), "About Program 2");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Report, Patron List menu item activated
        // Postcondition: The list of patrons is displayed in the reportTxt
        //                text box
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryPatron> patrons; // List of patrons

            patrons = lib.GetPatronsList();
            result.Append(String.Format("Patron List - {0} patrons", lib.GetPatronCount()));
            result.Append(System.Environment.NewLine); // Remember, \n doesn't always work in GUIs
            result.Append(System.Environment.NewLine);

            foreach (LibraryPatron p in patrons)
            {
                result.Append(p.ToString());
                result.Append(System.Environment.NewLine);
                result.Append(System.Environment.NewLine);
            }

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Item List menu item activated
        // Postcondition: The list of items is displayed in the reportTxt
        //                text box
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryItem> items;     // List of library items

            items = lib.GetItemsList();

            result.Append(String.Format("Item List - {0} items", lib.GetItemCount()));
            result.Append(System.Environment.NewLine); // Remember, \n doesn't always work in GUIs
            result.Append(System.Environment.NewLine);

            foreach (LibraryItem item in items)
            {
                result.Append(item.ToString());
                result.Append(System.Environment.NewLine);
                result.Append(System.Environment.NewLine);
            }

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Checked Out Items menu item activated
        // Postcondition: The list of checked out items is displayed in the
        //                reportTxt text box
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryItem> items;     // List of library items

            items = lib.GetItemsList();

            // LINQ: selects checked out items
            var checkedOutItems =
                from item in items
                where item.IsCheckedOut()
                select item;

            result.Append(String.Format("Checked Out Items - {0} items", checkedOutItems.Count()));
            result.Append(System.Environment.NewLine); // Remember, \n doesn't always work in GUIs
            result.Append(System.Environment.NewLine);

            foreach (LibraryItem item in checkedOutItems)
            {
                result.Append(item.ToString());
                result.Append(System.Environment.NewLine);
                result.Append(System.Environment.NewLine);
            }

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Insert, Patron menu item activated
        // Postcondition: The Patron dialog box is displayed. If data entered
        //                are OK, a LibraryPatron is created and added to the library
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm patronForm = new PatronForm(); // The patron dialog box form

            DialogResult result = patronForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                // Use form's properties to get patron info to send to library
                lib.AddPatron(patronForm.PatronName, patronForm.PatronID);
            }

            patronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Insert, Book menu item activated
        // Postcondition: The Book dialog box is displayed. If data entered
        //                are OK, a LibraryBook is created and added to the library
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(); // The book dialog box form

            DialogResult result = bookForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    // Use form's properties to get book info to send to library
                    lib.AddLibraryBook(bookForm.ItemTitle, bookForm.ItemPublisher, int.Parse(bookForm.ItemCopyrightYear),
                        int.Parse(bookForm.ItemLoanPeriod), bookForm.ItemCallNumber, bookForm.BookAuthor);
                }

                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Book Validation!", "Validation Error");
                }
            }

            bookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Item, Check Out menu item activated
        // Postcondition: The Checkout dialog box is displayed. If data entered
        //                are OK, an item is checked out from the library by a patron
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Extra Credit - Only display items that aren't already checked out

            List<LibraryItem> notCheckedOutList; // List of items not checked out
            List<int> notCheckedOutIndices;      // List of index values of items not checked out
            List<LibraryItem> items;             // List of library items
            List<LibraryPatron> patrons;         // List of patrons

            items = lib.GetItemsList();
            patrons = lib.GetPatronsList();
            notCheckedOutList = new List<LibraryItem>();
            notCheckedOutIndices = new List<int>();

            for (int i = 0; i < items.Count(); ++i)
                if (!items[i].IsCheckedOut()) // Not checked out
                {
                    notCheckedOutList.Add(items[i]);
                    notCheckedOutIndices.Add(i);
                }

            if ((notCheckedOutList.Count() == 0) || (patrons.Count() == 0)) // Must have items and patrons
                MessageBox.Show("Must have items and patrons to check out!", "Check Out Error");
            else
            {
                CheckoutForm checkoutForm = new CheckoutForm(notCheckedOutList, patrons); // The check out dialog box form

                DialogResult result = checkoutForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        int itemIndex; // Index of item from full list of items

                        itemIndex = notCheckedOutIndices[checkoutForm.ItemIndex]; // Look up index from full list
                        lib.CheckOut(itemIndex, checkoutForm.PatronIndex);
                    }
                    catch (ArgumentOutOfRangeException) // This should never happen
                    {
                        MessageBox.Show("Problem with Check Out Index!", "Check Out Error");
                    }
                }
                checkoutForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  Item, Return menu item activated
        // Postcondition: The Return dialog box is displayed. If data entered
        //                are OK, an item is returned to the library
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Extra Credit - Only display items that are already checked out

            List<LibraryItem> checkedOutList; // List of items checked out
            List<int> checkedOutIndices;      // List of index values of items checked out
            List<LibraryItem> items;          // List of library items
            List<LibraryPatron> patrons;      // List of patrons

            items = lib.GetItemsList();
            patrons = lib.GetPatronsList();
            checkedOutList = new List<LibraryItem>();
            checkedOutIndices = new List<int>();

            for (int i = 0; i < items.Count(); ++i)
                if (items[i].IsCheckedOut()) // Checked out
                {
                    checkedOutList.Add(items[i]);
                    checkedOutIndices.Add(i);
                }

            if ((checkedOutList.Count() == 0)) // Must have checked out items
                MessageBox.Show("Must have checked out items to return!", "Return Error");
            else
            {
                ReturnForm returnForm = new ReturnForm(checkedOutList); // The return dialog box form

                DialogResult result = returnForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        int itemIndex; // Index of item from full list of items

                        itemIndex = checkedOutIndices[returnForm.ItemIndex]; // Look up index from full list
                        lib.ReturnToShelf(itemIndex);
                    }
                    catch (ArgumentOutOfRangeException) // This should never happen
                    {
                        MessageBox.Show("Problem with Return Index!", "Return Error");
                    }
                }
                returnForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }
//-----------------------------------------------------------------------------------------------------------------------
                        //TO SAVE

        private BinaryFormatter formatter = new BinaryFormatter();  //creare binary formatter to write
        private FileStream output;   //create a filestream variable

        //Preconditions: user clicks file then clicks save
        //Postconditions: saves the current patrons and items by using serialization
        private void saveLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;   //to store result
            string fileName;       //to store the file name

            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;  //lets user create a file

                //retrieve result of the dialog box
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;  //get specified file name
            }

            if (result == DialogResult.OK)
            {
                //show error if user specified invalid file
                if (fileName == string.Empty)
                {
                    MessageBox.Show("Please enter a file name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //save file via file stream if user specified valid file
                    try
                    {
                        //open file with write access
                        output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                        formatter.Serialize(output, lib);   //put some sort of exception handling
                        output.Close();
                    }
                    //handle exception if there is one
                    catch (IOException)
                    {
                        //notify user if file could not be opened
                        MessageBox.Show("Cannot open file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
//---------------------------------------------------------------------------------------------------------------------------
                        //TO OPEN

        private BinaryFormatter reader = new BinaryFormatter();    //creates binary formatter to read
        private FileStream input;    //create filestream variable

        //Preconditions: user clicks file then clicks open, then selects the file to open
        //Postconditions: the user selected file gets loaded into the program
        private void openLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create and show dialog box enabling user to open file
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            //ensure user clicked ok
            if (result == DialogResult.OK)
            {
                //show if user specified invalid file
                if (fileName == string.Empty)
                {
                    MessageBox.Show("Invalid file name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //create filestream to obtain read access to file
                    input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                    lib = (Library) reader.Deserialize(input);

                    input.Close();
                }
            }
        }
//--------------------------------------------------------------------------------------------------------------------------------

                        //to edit the patron

        //Preconditions: user clicks edit then clicks patron. user must select item from combo box
        //Postconditions: dialog box comes up with current information loaded into it. user can then change information
        private void patronToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<LibraryPatron> patrons;         // List of patrons
            patrons = lib.GetPatronsList();

            EditPatronForm editPatronForm = new EditPatronForm(patrons);
            DialogResult result1 = editPatronForm.ShowDialog(); 
            if (result1 == DialogResult.OK)
            {
                PatronForm patronForm = new PatronForm();

                patronForm.PatronName = patrons[editPatronForm.PatronIndex].PatronName;
                patronForm.PatronID = patrons[editPatronForm.PatronIndex].PatronID;

                DialogResult result2 = patronForm.ShowDialog();

                if (result2 == DialogResult.OK)
                {
                    patrons[editPatronForm.PatronIndex].PatronName = patronForm.PatronName;
                    patrons[editPatronForm.PatronIndex].PatronID = patronForm.PatronID;
                }
            }
        }

        //Preconditions: user clicks edit then clicks book. user must select an item from the combo box
        //Postconditions: dialog box shows up with the books current information loaded into it. user can then change the info
        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items = lib.GetItemsList();   //reference library items
            List<LibraryItem> bookList = new List<LibraryItem>();   //create new list of only library books
            List <int> bookIndecies = new List<int>();  //creates index of which book is stored in the index in the items list

            for (int i = 0; i < items.Count; ++i)
            {
                if (items[i] is LibraryBook)
                {
                    bookList.Add(items[i]);
                    bookIndecies.Add(i);
                }
            }

            if ((bookList.Count() == 0))
            {
                MessageBox.Show("Must have books in the book list");
            }
            else
            {
                EditBookForm editBookForm = new EditBookForm(bookList);
                DialogResult result1 = editBookForm.ShowDialog();

                if (result1 == DialogResult.OK)
                {
                    int itemIndex;                                //to hold index

                    itemIndex = bookIndecies[editBookForm.ItemIndex];
                    BookForm bookForm = new BookForm();

                    LibraryBook books = (LibraryBook)items[itemIndex];   //downcast

                    bookForm.ItemTitle = items[itemIndex].Title;
                    bookForm.ItemPublisher = items[itemIndex].Publisher;
                    bookForm.ItemCopyrightYear = items[itemIndex].CopyrightYear.ToString();
                    bookForm.ItemLoanPeriod = items[itemIndex].LoanPeriod.ToString();
                    bookForm.ItemCallNumber = items[itemIndex].CallNumber;
                    bookForm.BookAuthor = books.Author;  //from downcast

                    DialogResult result2 = bookForm.ShowDialog();

                    if (result2 == DialogResult.OK)
                    {
                        items[itemIndex].Title = bookForm.ItemTitle;
                        items[itemIndex].Publisher = bookForm.ItemPublisher;
                        items[itemIndex].CopyrightYear = int.Parse(bookForm.ItemCopyrightYear);
                        items[itemIndex].LoanPeriod = int.Parse(bookForm.ItemLoanPeriod);
                        items[itemIndex].CallNumber = bookForm.ItemCallNumber;
                        books.Author = bookForm.BookAuthor;  //from downcast
                    }
                }
            }
        }
    }
}
