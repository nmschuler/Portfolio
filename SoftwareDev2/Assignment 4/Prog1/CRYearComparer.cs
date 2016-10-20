using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    class CRYearComparer : IComparer<LibraryItem>
    {
        //Preconditions: none
        //Postconditions: compares copyright years. returns 0 if both null, returns -1 if second is null, else returns compares 
        public int Compare(LibraryItem i1, LibraryItem i2)
        {
            if (i1 == null && i2 == null)
                return 0;
            if (i2 == null)
                return -1;
            return i2.CopyrightYear.CompareTo(i1.CopyrightYear);
        }
    }
}
