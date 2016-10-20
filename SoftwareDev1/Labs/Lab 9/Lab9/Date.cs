/* Nick Schuler
 * Lab 9
 * Due December 7, 2014
 * CIS 199-01
 * This program starts off with a preset date (01/01/2000) and the user enters new numbers. when the user 
 *      clicks the update button, the month will update just that number, rather than the entire date */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Date
    {
        private int _month; //1-12
        private int _day;   //1-31
        private int _year;  //>=0

        public Date(int month, int day, int year) //constructor
        {
            _month = month;
            _day = day;
            _year = year;
        }
        //Preconditions: month must be no less than 1 and no greater than 12
        //Postconditions: will return a value for month between 1-12
        public int Month 
        {
            get { return _month; }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    _month = value;
                }
            }
        }

        //Preconditions: day must be no less than 1 and no greater than 31
        //Postconditions: will return a day between 1-31
        public int Day
        {
            get {return _day; }
            set 
            {
                if (value >=1 && value <= 31)
                {
                    _day = value;
                }
            }
        }

        //Preconditions: year must not be negative
        //Postconditions: returns a year that is greater than zero (and as long as it can fit in an int)
        public int Year
        {
            get { return _year; }
            set
            {
                if (value >= 0)
                {
                    _year = value;
                }
            }
        }

        //Preconditions: must create a return and set it to mm/dd/yyyy
        //Postconditions: will send to DateForm for display
        public override string ToString()
        {
            string result;

            result = Month.ToString("D2") + "/" + Day.ToString("D2") + "/" + Year.ToString("D4");

            return result;
        }
    }
}
