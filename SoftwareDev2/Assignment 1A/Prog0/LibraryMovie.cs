using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class LibraryMovie : LibraryMediaItem
{
    //constructor
    public LibraryMovie(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber, double theDuration, string director, MediaType medium, MPAARatings rating)
        : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theDuration)
    {
        director = _director;
        medium = _medium;
        rating = _rating;
    }
    //end constructor

    private string _director;       //create backing field for director
    private MediaType _medium;      //create backing field for medium
    private MPAARatings _rating;    //create backing field for rating

    public enum MPAARatings { G, PG, PG13, R, NC17, U };    //create enum

    private const decimal VHS_DVD_LATE_FEE = 1.00m;   //create constant for vhs/dvd late fee
    private const decimal BLURAY_LATE_FEE = 1.5m;     //create blu ray constant late fee
    private const decimal LATE_FEE_MAX = 25.00m;      //create constant max late fee

    public string Director
    {
        //Preconditions: none
        //Postconditions: will return director
        get
        {
            return _director;
        }
        //Preconditions: none
        //Postconditions: will set director to specified value
        set
        {
            _director = value;
        }
    }

    public new MediaType Medium 
    {
        //Preconditions: none
        //Postconditions: will return medium
        get
        {
            return _medium;
        }
        //Preconditions: MediaType must be DVD, VHS, or BLURAY
        //Postconditions: medium will set the specified value
        set
        {
            if (value == MediaType.DVD || value == MediaType.VHS || value == MediaType.BLURAY)
            {
                _medium = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Must be of MediaType DVD, VHS, or BLURAY");
            }
        }
    }

    public MPAARatings Rating 
    {
        //Preconditions: none
        //Postconditions: will return rating
        get
        {
            return _rating;
        }
        //Preconditions: none
        //Postconditions: will set the specified rating value
        set
        {
            _rating = value;
        }
    }

    //Preconditions: none
    //Postconditions: will retrun the late fee owed
    public override decimal CalcLateFee(int daysLate)
    {
        if (Medium == MediaType.DVD || Medium == MediaType.VHS)
        {
            amountOwed = daysLate * VHS_DVD_LATE_FEE;
            if (amountOwed <= LATE_FEE_MAX)
            {
                return amountOwed;
            }
            else
            {
                return LATE_FEE_MAX;
            }
        }
        else
        {
            amountOwed = daysLate * BLURAY_LATE_FEE;
            if (amountOwed <= LATE_FEE_MAX)
            {
                return amountOwed;
            }
            else
            {
                return LATE_FEE_MAX;
            }
        }
    }

    //Preconditions: none
    //Postconditions: a string will display the library movie information
    public override string ToString()
    {
        return string.Format("{0}\nDirector: {1}\nMedium: {2}\nRating: {3}", base.ToString(), Director, Medium, Rating);
    }
}
