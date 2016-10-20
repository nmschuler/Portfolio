/*Nicholas Schuler
 *Program 0
 *Due: February 3, 2015
 *CIS 200-01
 *Description: This program has a library of books, we create some patrons who will check some books out, then display on the console 3 different parts. part 1 shows all the books not checked out, part 2 shows some checked out and the name and ID of who checked them out, and part 3 shows them all when they have been returned.
 *
 *Shout out to Dr. Wright for the skeleton of this code! */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryBook 
{
    public const int DEFAULT_YEAR = 2015; // Default copyright year

    private String _title;      // The book's title
    private String _author;     // The book's author
    private String _publisher;  // The book's publisher
    private int _copyrightYear; // The book's year of copyright
    private String _callNumber; // The book's call number in the library
    private bool _checkedOut;   // The book's checked out status

    private LibraryPatron _patron; //creates the HAS-A relatiionship


    // Precondition:  None
    // Postcondition: The library book has been initialized with the specified
    //                values for title, author, publisher, copyright year, and
    //                call number. The book is not checked out.
    public LibraryBook(String theTitle, String theAuthor, String thePublisher,
        int theCopyrightYear, String theCallNumber)
    {
        // Establish default first in case invalid
        CopyrightYear = DEFAULT_YEAR;

        Title = theTitle;
        Author = theAuthor;
        Publisher = thePublisher;
        CopyrightYear = theCopyrightYear;
        CallNumber = theCallNumber;

        ReturnToShelf(); // Make sure book is not checked out
    }

    public String Title
    {
        // Precondition:  None
        // Postcondition: The title has been returned
        get
        {
            return _title;
        }

        // Precondition:  None
        // Postcondition: The title has been set to the specified value
        set
        {
            _title = value;
        }
    }

    public String Author
    {
        // Precondition:  None
        // Postcondition: The author has been returned
        get
        {
            return _author;
        }

        // Precondition:  None
        // Postcondition: The author has been set to the specified value
        set
        {
            _author = value;
        }
    }

    public String Publisher
    {
        // Precondition:  None
        // Postcondition: The publisher has been returned
        get
        {
            return _publisher;
        }

        // Precondition:  None
        // Postcondition: The publisher has been set to the specified value
        set
        {
            _publisher = value;
        }
    }

    public int CopyrightYear
    {
        // Precondition:  None
        // Postcondition: The copyright year has been returned
        get
        {
            return _copyrightYear;
        }

        // Precondition:  value >= 0
        // Postcondition: The copyright year has been set to the specified value
        set
        {
            if (value >= 0)
                _copyrightYear = value;
        }
    }

    public String CallNumber
    {
        // Precondition:  None
        // Postcondition: The call number has been returned
        get
        {
            return _callNumber;
        }

        // Precondition:  None
        // Postcondition: The call number has been set to the specified value
        set
        {
            _callNumber = value;
        }
    }

    // Precondition:  None
    // Postcondition: The book is checked out
    public void CheckOut(LibraryPatron patronCheckedOut) 
    {
        _checkedOut = true;
        _patron = patronCheckedOut;    
    }

    // Precondition:  None
    // Postcondition: The book is not checked out
    public void ReturnToShelf() 
    {
        _patron = null;    
        _checkedOut = false;
    }

    // Precondition:  None
    // Postcondition: true is returned if the book is checked out,
    //                otherwise false is returned
    public bool IsCheckedOut()
    {
        return _checkedOut;
        
    }

    //Preconditions: Book must be currently checked out
    //Postconditions: Will return patron who checked it out, or null
    public LibraryPatron Patron        
    {
        get
        {
            if (IsCheckedOut())
            {
                return _patron;
            }
            else
            {
                return null;
            }
        }
    }


    // Precondition:  None
    // Postcondition: A string is returned presenting the libary book's data on
    //                separate lines
    public override string ToString()
    {
        if (IsCheckedOut())
        {
            return String.Format("Title: {0}{6}Author: {1}{6}Publisher: {2}{6}" +
                "Copyright: {3:D4}{6}Call Number: {4}{6}Checked Out By: {5}",
                Title, Author, Publisher, CopyrightYear, CallNumber, Patron.ToString(),
                System.Environment.NewLine);
        }
        else
        {
            return String.Format("Title: {0}{5}Author: {1}{5}Publisher: {2}{5}" +
                "Copyright: {3:D4}{5}Call Number: {4}{5}Not Checked Out",  
                Title, Author, Publisher, CopyrightYear, CallNumber, 
                System.Environment.NewLine);
        }
    }
}
