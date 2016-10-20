using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class LibraryJournal : LibraryPeriodical
{
    //constructor
    public LibraryJournal(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber, int theVolume, int theNumber, string theDiscipline, string theEditor)
        : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theVolume, theNumber)
    {
        theDiscipline = _discipline;
        theEditor = _editor;
    }
    //end constructor

    private string _discipline;   //create backing field for discipline
    private string _editor;       //create backing field for editor

    private const decimal LATE_FEE = 0.75m;  //create constant for late fee

    public string Discipline
    {
        //preconditions: none
        //postconditions: the discipline has been returned
        get
        {
            return _discipline;
        }
        //Preconditions: none
        //Postconditions: the value has been set
        set
        {
            _discipline = value;
        }
    }

    public string Editor
    {
        //Preconditions: none
        //Postconditions: the editor has been returned
        get
        {
            return _editor;
        }
        //Preconditions: none
        //Postconditions: the editor has set
        set
        {
            _editor = value;
        }
    }

    //Preconditions: none
    //Postconditions: will calculate late fee owed
    public override decimal CalcLateFee(int daysLate)
    {
        return daysLate * LATE_FEE;
    }

    //Preconditions: none
    //Postconditions: a string will display the library journal information
    public override string ToString()
    {
        return string.Format("{0}\nDiscipline: {1}\nEditor {2}", base.ToString(), Discipline, Editor);
    }
}
