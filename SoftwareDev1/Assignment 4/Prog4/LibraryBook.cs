/*Nick Schuler
 * Program 4
 * Due: December 8, 2014
 * CIS 199-01 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    public class LibraryBook
    {
        //field to create backing fields
        private string _title;
        private string _author;
        private string _publisher;
        private int _copyrightYear;
        private string _callNumber;
        private bool _checkedOut;

        //constructor
        //Preconditions: _checkedOut must be set to false because when a new book comes in, it is
                        //not considered checked out
        //Postconditions: creates backing fields and the book is shown as still in the library
        public LibraryBook(string title, string author, string publisher, int copyrightYear, string callNumber)
        {
            _title = title; //to hold books title  
            _author = author; //to hold books author
            _publisher = publisher;  //to hold the publisher
            _copyrightYear = copyrightYear;  //to hold the CR year
            _callNumber = callNumber;  //to hold the call number
            _checkedOut = false; //to hold checked out status
        }

        //title property 
        public string Title
        {
            get { return _title; }
            private set { _title = value; }
        }

        //author property 
        public string Author
        {
            get { return _author; }
            private set { _author = value; }
        }

        //publisher property
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        //copyright year property
        public int CopyrightYear
        {
            get { return _copyrightYear; }
            private set { _copyrightYear = value; }
        }

        //call number property
        public string CallNumber
        {
            get { return _callNumber; }
            set { _callNumber = value; }
        }

        public void CheckOut()
        {
            _checkedOut = true;
        }

        public void ReturnToShelf()
        {
            _checkedOut = false;
        }

        public bool IsCheckedOut() 
        {
            return _checkedOut;
        }

        //Preconditions: each bit of info must be on a seperate line for easier for user to read in the messagebox
        //Postconditions: all will be on a seperate line and returns to the Form1 class to be displayed
        public override string ToString()
        {
            string result;

            result = "Title: "+Title +
                System.Environment.NewLine+"Author: " +Author +
                System.Environment.NewLine+"Publisher: " +Publisher +
                System.Environment.NewLine+"Copyright Year: "+CopyrightYear.ToString() +
                System.Environment.NewLine+"Call Number: " +CallNumber+
                System.Environment.NewLine+"Checked Out Status: " +IsCheckedOut().ToString();

            return result;



        }
    }
}
