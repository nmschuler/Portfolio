// Program 1A
// CIS 200-01
// Due: 2/17/2015
// By: Nick Schuler

//This progam sets up the inheritance for our soon to be completed library.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryBook : LibraryItem
{
    //Constructor
    public LibraryBook(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber, string theAuthor)
        : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber)
    {
        Author = _author;
    } //end constructor
    
    private string _author;    // The book's author

    private const decimal LATE_FEE = 0.25m;  //the late fee

    public string Author
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

    //Preconditions: none
    //Postconditions: returns the late fee
    public override decimal CalcLateFee(int daysLate)
    {
        return daysLate * LATE_FEE;
    }

    // Precondition:  None
    // Postcondition: A string is returned presenting the libary book's data on
    //                separate lines
    public override string ToString()
    {
        return string.Format("Library book : {0}\nAuthor: {1}", base.ToString(), Author);
    }
}
