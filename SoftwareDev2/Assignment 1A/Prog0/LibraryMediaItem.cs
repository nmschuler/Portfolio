using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class LibraryMediaItem : LibraryItem
{
    //constructor
    public LibraryMediaItem(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber, double theDuration)
        : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber)
    {
        theDuration = _duration;
    } //end constructor

    private double _duration; //the duration of the media

    public enum MediaType { DVD, BLURAY, VHS, CD, SACD, VINYL };    //create enum

    private MediaType _medium;    //create backing field for Medium

    public MediaType Medium
    {
        //Preconditions: none
        //Postconditions:  will return medium
        get
        {
            return _medium;
        }
        //Preconditions: none
        //Postconditions: will set medium to specified value
        set
        {
            _medium = value;
        }
    }

    public double Duration
    {
        //Precondition: none
        //Postcondition: duration has been returned
        get
        {
            return _duration;
        }
        //Precondition: Cannot have media being negative or 0 time. Must be >0.
        //Postcondition: The duration has been set to its specified value.
        set
        {
            if (value >= 0)
            {
                _duration = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The duration must not be a negative number or zero!"); 
            }
        }
    }

    //Preconditions: none
    //Postconditions: a string will return the library media item information
    public override string ToString()
    {
        return string.Format("{0}\nDuration: {1}", base.ToString(), Duration);
    }
}
