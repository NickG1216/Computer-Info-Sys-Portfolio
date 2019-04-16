// Program 4
// CIS 200-01
// Due: 4/17/2018
// By: Z8933

// File: Program.cs
// This file creates a small application that tests the LibraryItem hierarchy using
// LINQ and demonstrates polymorphism.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryItems;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryItem hierarchy has been tested using LINQ, demonstrating polymorphism
    public static void Main(string[] args)
    {
        const int DAYSLATE = 14;     // Number of days late to test each object's CalcLateFee method
        const int LOANEXTENSION = 7; // Number of days to extend loan period

        List<LibraryItem> items = new List<LibraryItem>();       // List of library items
        List<LibraryPatron> patrons = new List<LibraryPatron>(); // List of patrons

        int p; // Patron index

        // Test data - Magic numbers allowed here
        items.Add(new LibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright"));
        items.Add(new LibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
            "AB73 ZF", "IP Thief"));
        items.Add(new LibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG));
        items.Add(new LibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
            "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G));
        items.Add(new LibraryMusic("C# - The Album", "UofL Music", 2014, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10));
        items.Add(new LibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
            "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12));
        items.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));
        items.Add(new LibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
            "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams"));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9A", 16, 7));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9B", 16, 8));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9C", 16, 9));
        items.Add(new LibraryMagazine("     VB Magazine    ", "    UofL Mags   ", 2018, 14,
            "MA21 5V", 1, 1));

        // Add patrons
        patrons.Add(new LibraryPatron("Ima Reader", "12345"));
        patrons.Add(new LibraryPatron("Jane Doe", "11223"));
        patrons.Add(new LibraryPatron("   John Smith   ", "   654321   "));
        patrons.Add(new LibraryPatron("James T. Kirk", "98765"));
        patrons.Add(new LibraryPatron("Jean-Luc Picard", "33456"));

        Console.WriteLine("List of items at start:\n");
        foreach (LibraryItem item in items)
            Console.WriteLine("{0}\n", item);
        Pause();
        
        
        // ---------------------- Program 4 ------------------
        items.Sort(); // Sort - uses natural order
        Console.WriteLine("Program 4");
        Console.WriteLine("----------");
        Console.Out.WriteLine("Sorted list (natural order by Title):");
        foreach (LibraryItem i in items)
            Console.WriteLine(i);
        Pause();

        items.Sort(new DescendingCopyrightYearOrder()); // Sort - uses specified Comparer class
        Console.WriteLine("Program 4");
        Console.WriteLine("----------");
        Console.Out.WriteLine("Sorted list (descending natural order by CopyrightYear) using Comparer:");
        foreach (LibraryItem i in items)
            Console.WriteLine(i);
        Pause();

        items.Sort(new ItemTypeOrder()); // Sort - uses specified Comparer class
        Console.WriteLine("Program 4: Attempted Extra Credit");
        Console.WriteLine("------------------------");
        Console.Out.WriteLine("Sorted list (natural order by type and ascending order by title) using Comparer:");
        foreach (LibraryItem i in items)
            Console.WriteLine(i);
        // Tried a lot of stuff but ultimately couldn't figure out. TLDR: The EC doesn't work like it's supposed to.
        Pause();
        // ----------------------- Ends Here -------------------


        // Check out some items
        // Here, every other item will be checked out by patrons (in order)
        // This is tricky... pay attention!

        p = 0; // Start with 1st patron
        for (int i = 0; i < items.Count; i += 2) // +=2 does every other
            items[i].CheckOut(patrons[p++ % patrons.Count]); // % count keeps within 0 - (count-1)

        Console.WriteLine("List of items after checking some out:\n");
        foreach (LibraryItem item in items)
            Console.WriteLine($"{item}\n");
        Pause();

        // LINQ: selects checked out items
        var checkedOutItems =
            from item in items
            where item.IsCheckedOut()
            select item;

        Console.WriteLine("List of checked out items:\n");
        foreach (LibraryItem item in checkedOutItems)
            Console.WriteLine($"{item}\n");
        Console.WriteLine($"There are {checkedOutItems.Count()} items checked out\n");
        Pause();

        // LINQ: selects checked out media items
        var checkedOutMediaItems =
            from item in checkedOutItems
            where item is LibraryMediaItem
            select item;

        Console.WriteLine("List of checked out media items:\n");
        foreach (LibraryItem item in checkedOutMediaItems)
            Console.WriteLine($"{item}\n");
        Pause();

        //// LINQ: selects all magazine titles
        //var magazineTitles =
        //    from item in items
        //    where item is LibraryMagazine
        //    select item.Title;

        //Console.WriteLine("List of unique magazine titles:\n");
        //foreach (string title in magazineTitles.Distinct()) // Distinct restricts to unique titles
        //    Console.WriteLine(title);
        //Console.WriteLine();
        //Pause();

        // OR

        var distinctMagazineTitles =
            (from item in items
             where item is LibraryMagazine
             select item.Title).Distinct(); // Distinct restricts to unique titles

        Console.WriteLine("List of unique magazine titles:\n");
        foreach (string title in distinctMagazineTitles)
            Console.WriteLine(title);
        Console.WriteLine();
        Pause();

        Console.WriteLine($"Calculated late fees after {DAYSLATE} days late:\n");
        Console.WriteLine($"{"Title",42} {"Call Number",11} {"Late Fee",8}");
        Console.WriteLine("------------------------------------------ ----------- --------");

        // Caluclate and display late fees for each item
        foreach (LibraryItem item in items)
            Console.WriteLine($"{item.Title,42} {item.CallNumber,11} {item.CalcLateFee(DAYSLATE),8:C}");
        Pause();

        // Return each item that is checked out
        foreach (LibraryItem item in items)
        {
            if (item.IsCheckedOut())
                item.ReturnToShelf();
        }
        Console.WriteLine("After returning all items:\n");

        // Show results using same LINQ var as before - Deferred query execution
        Console.WriteLine($"There are {checkedOutItems.Count()} items checked out\n");
        Pause();

        Console.WriteLine("Changing book loan periods:\n");
        Console.WriteLine($"{"Title",42} {"Call Number",11} {"Before",6} {"After",5}");
        Console.WriteLine("------------------------------------------ ----------- ------ -----");

        // With No LINQ
        foreach (LibraryItem item in items)
        {
            if (item is LibraryBook)
            {
                Console.Write($"{item.Title,42} {item.CallNumber,11} {item.LoanPeriod,6} ");
                item.LoanPeriod += LOANEXTENSION;
                Console.WriteLine($"{item.LoanPeriod,5}");
            }
        }
        Pause();

        // OR

        // With a little LINQ
        //// LINQ: selects all LibraryBooks
        //var books =
        //    from item in items
        //    where item is LibraryBook
        //    select item;

        //// Change loan period for each book and display
        //foreach (LibraryBook book in books)
        //{
        //        Console.Write($"{book.Title,42} {book.CallNumber,11} {book.LoanPeriod,6} ");
        //        book.LoanPeriod += LOANEXTENSION;
        //        Console.WriteLine($"{book.LoanPeriod,5}");
        //}
        //Pause();

        Console.WriteLine("List of items at end:\n");
        foreach (LibraryItem item in items)
            Console.WriteLine($"{item}\n");
        Pause();
    }

    // Precondition:  None
    // Postcondition: Pauses program execution until user presses Enter and
    //                then clears the screen
    public static void Pause()
    {
        Console.WriteLine("Press Enter to Continue...");
        Console.ReadLine();

        Console.Clear(); // Clear screen
    }
}