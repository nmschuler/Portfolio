using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LibraryMagazine : LibraryPeriodical
{
    //Constructor
    public LibraryMagazine(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber, int theVolume, int theNumber)
        : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theVolume, theNumber)
    {
    }
    //end constructor

    private const decimal LATE_FEE = 0.25M;            //create constant for late fee
    private const decimal LATE_FEE_MAX = 20.00m;       //create constant for maximum late fee

    //Preconditions: none
    //Postconditions: will return the amount owed (if any)
    public override decimal CalcLateFee(int daysLate)
    {
        amountOwed = daysLate * LATE_FEE;
        if (amountOwed <= LATE_FEE_MAX)
        {
            return amountOwed;
        }
        else
        {
            return LATE_FEE_MAX;
        }
    }

    //Preconditions: none
    //Postconditions: a string will display the library magazine information
    public override string ToString()
    {
        return base.ToString();
    }
}
