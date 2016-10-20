// Program 1A
// CIS 200-01
// Due: 2/17/2015
// By: Nick Schuler

//This progam sets up the inheritance for our soon to be completed library.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class LibraryItem
{

    public const int DEFAULT_YEAR = 2015; // Default copyright year


    //public int daysLate;
    public decimal amountOwed;
    
    
    private String _title;          // The book's title
    private String _publisher;      // The book's publisher
    private int _copyrightYear;     // The book's year of copyright
    private String _callNumber;     // The book's call number in the library
    private int _loanPeriod;        // The book's loan period
    private bool _checkedOut;       // The book's checked out status
    private LibraryPatron _patron;  // The person that has the book checked out (null otherwise)

    // Precondition:  None
    // Postcondition: The library book has been initialized with the specified
    //                values for title, author, publisher, copyright year, and
    //                call number. The book is not checked out.
    public LibraryItem(String theTitle, String thePublisher,
        int theCopyrightYear, int theLoanPeriod, String theCallNumber)
    {

        // Establish default first in case invalid
        CopyrightYear = DEFAULT_YEAR;

        Title = theTitle;
        Publisher = thePublisher;
        CopyrightYear = theCopyrightYear;
        LoanPeriod = theLoanPeriod;
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

        // HELPER - not public
        // Precondition:  None
        // Postcondition: The title has been set to the specified value
        private set
        {
            _title = value;
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

        // HELPER - not public
        // Precondition:  value >= 0
        // Postcondition: The copyright year has been set to the specified value
        set
        {
            if (value >= 0)
                _copyrightYear = value;
        }
    }

    public int LoanPeriod
    {
        //Precondition: none
        //Postcondition: the loan period has been returned
        get
        {
            return _loanPeriod;
        }
        //Precondition: loan period must not be negative
        //Postcondition: the loan period will be set to its value
        set
        {
            if (value >= 0)
            {
                _loanPeriod = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Loan period must not be negative!");
            }
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

    public LibraryPatron Patron
    {
        // Precondition:  IsCheckedOut() == true
        // Postcondition: The patron that has the book checked out is returned
        //                (otherwise null)
        get
        {
            return _patron;
        }

        // Precondition:  None
        // Postcondition: The associated patron value is stored
        private set
        {
            _patron = value;
        }
    }

    // Precondition:  None
    // Postcondition: The book is checked out by thePatron
    public void CheckOut(LibraryPatron thePatron)
    {
        _checkedOut = true;
        Patron = thePatron;
    }

    // Precondition:  None
    // Postcondition: The book is not checked out (by any patron)
    public void ReturnToShelf()
    {
        _checkedOut = false;
        Patron = null; // No longer associated with anyone
    }

    // Precondition:  None
    // Postcondition: true is returned if the book is checked out,
    //                otherwise false is returned
    public bool IsCheckedOut()
    {
        return _checkedOut;
    }

    //Precondnitions: none
    //Postconditions: abstrct calc late fee, concrete in derived classes
    public abstract decimal CalcLateFee(int daysLate);

    //Preconditions: none
    //Postconditions: a string will be displayed with library item information
    public override string ToString()
    {
        String result; // Holds for formatted results as being built

        result = String.Format("Title: {0}{5}Publisher: {1}{5}" +
            "Copyright: {2}{5}Loan Period: {3}{5}Call Number: {4}{5}",
            Title, Publisher, CopyrightYear, LoanPeriod, CallNumber, System.Environment.NewLine);

        if (IsCheckedOut())
            result += String.Format("Checked Out By: {1}{0}", Patron, System.Environment.NewLine);
        else
            result += "Not Checked Out";

        return result;
    }
}


