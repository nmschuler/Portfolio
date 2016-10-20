using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class LibraryPeriodical : LibraryItem
{
    //constructor
    public LibraryPeriodical(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber, int theVolume, int theNumber)
        : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber)
    {
        theVolume = _volume;
        theNumber = _number;
    } //end constructor

    private int _volume;   //create backing field for volume
    private int _number;   //create backing field for number

    public int Volume
    {
        //Preconditions: none
        //Postconditions: the volume has been returned
        get
        {
            return _volume;
        }
        //Preconditions: Must be postive number
        //Postconditions: has been set to its specified value
        set
        {
            if (value >= 0)
            {
                _volume = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Volume can not be a negative number!");
            }
        }
    }

    public int Number
    {
        //Preconditions: none
        //Postconditions: the volume has been returned
        get
        {
            return _number;
        }
        //Preconditions: value must not be negative
        //Postconditions: number will be set to specified value
        set
        {
            if (value >= 0)
            {
                _number = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Number can not be a negative number!");
            }
        }
    }

    //Preconditions: None
    //Postconditions: A string is returned displaying LibraryPeriodical information on seperate lines
    public override string ToString()
    {
        return string.Format("{0}\nVolume: {1}\nNumber: {2}", base.ToString(), Volume, Number);
    }
}

