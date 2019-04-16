// Program 4
// CIS 200-01
// Due: 4/17/2018
// By: Z8933

//Implements the IComparer interface that allows items to be put in descending order by CopyrightYear. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    class DescendingCopyrightYearOrder : Comparer<LibraryItem>
    {
        // Precondition:  None
        // Postcondition: Reverses natural time order, so descending
        //                When item1 < item2, method returns positive #
        //                When item1 == item2, method returns zero
        //                When item1 > item2, method returns negative #
        public override int Compare(LibraryItem item1, LibraryItem item2)
        {
            // Ensure correct handling of null values (in .NET, null less than anything)
            if (item1 == null && item2 == null) // Both null?
                return 0;                 // Equal

            if (item1 == null) // only item1 is null?
                return -1;  // null is less than any actual LibraryItem

            if (item2 == null) // only item2 is null?
                return 1;   // Any actual LibraryItem is greater than null

            return (-1) * item1.CopyrightYear.CompareTo(item2.CopyrightYear); // Reverses natural order, so descending

        }
    }
}
