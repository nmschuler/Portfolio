using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class LibraryMusic : LibraryMediaItem
{
    //constructor
    public LibraryMusic(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber, double theDuration, string theArtist, MediaType theMedium, int theNumberOfTracks)
        : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theDuration)
    {
        theArtist = _artist;
        theNumberOfTracks = _numberOfTracks;
        theMedium = _medium;
    } //end constructor

    private string _artist;         //create backing field for artist
    private int _numberOfTracks;    //create backing field for number fo tracks
    private MediaType _medium;      //create backing field for medium

    private const decimal LATE_FEE = 0.50M;          //create constant for late fee
    private const decimal LATE_FEE_MAX = 20.00m;     //create constant for max late fee

    public string Artist
    {
        //Preconditions: none
        //Postconditions: will return artist
        get
        {
            return _artist;
        }
        //Preconditions: none
        //Postconditions: artist has been set to specified value
        set
        {
            _artist = value;
        }
    }

    public int NumberOfTracks
    {
        //Precondition: None
        //Postcondition: Track number has been returned.
        get
        {
            return _numberOfTracks;
        }

        //Precondition: Track number must not be zero or negative
        //Postcondition: The track list has been set to specified value.
        set
        {
            if (value > 0)
            {
                _numberOfTracks = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Cannot have a track number with zero or less tracks!");
            }
        }
    }
    public new MediaType Medium //new?
    {
        //Preconditions: none
        //Postconditions: medium has been returned
        get
        {
            return _medium;
        }
        //Preconditions: MediaType must be CD, SACD, or VINYL
        //Postconditions: will set media type as value
        set
        {
            if (value == MediaType.CD || value == MediaType.SACD || value == MediaType.VINYL)
            {
                _medium = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Must be of MediaType CD, SACD, or VINYL");
            }
        }
    }

    //Preconditions: none
    //Postconditions: will display late fee owed
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
    //Postconditions: a string is returned with library music information
    public override string ToString()
    {
        return string.Format("{0}\nArtist: {1}\nMedium: {2}\nNumber of Tracks {3}", base.ToString(), Artist, Medium, NumberOfTracks);
    }
}
