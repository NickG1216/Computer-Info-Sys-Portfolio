// Program 1B
// CIS 200-01
// Due: 2/21/2018
// By: Z8933

// File: Program.cs
// This file creates a small application that tests the LibraryItem hierarchy

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
        const int DAYSLATE = 14; // Number of days late to test each object's CalcLateFee method
        const int EXTRA_DAYS = 7;
        List<LibraryItem> items = new List<LibraryItem>();       // List of library items
        List<LibraryPatron> patrons = new List<LibraryPatron>(); // List of patrons

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

        // Check out some items
        items[0].CheckOut(patrons[0]);
        items[2].CheckOut(patrons[2]);
        items[5].CheckOut(patrons[1]);
        items[3].CheckOut(patrons[4]);
        items[9].CheckOut(patrons[3]);

        Console.WriteLine("List of items after checking some out:\n");
        foreach (LibraryItem item in items)
            Console.WriteLine("{0}\n", item);
        Pause();

        // Filter and count the checked out items
        var countCheckOut =
            from i in items
             where i.IsCheckedOut() == true
             select  i;

        Console.WriteLine("These are the items that have been checked out: \n");
        foreach (var check in countCheckOut)
        {
            Console.WriteLine($"{check}\n");      
        }
        Console.WriteLine($"Number of checked out items is: {countCheckOut.Count()}\n");
        Pause();

        // Filter the media items from the checkedout items
        var checkOutMediaItems =
            from media in items
            where media.IsCheckedOut() == true && media is LibraryMediaItem
            select media;
        Console.WriteLine("These are the library media items that have been checked out: \n");
        foreach ( var mediaItem in checkOutMediaItems)
        {
            Console.WriteLine($"{mediaItem}\n");
        }
        Pause();

        var uniqueMagazineTitles =
            from mags in items
            where mags is LibraryMagazine
            select new { mags.Title };
        Console.WriteLine("Unique magazine titles: \n");
        foreach (var title in uniqueMagazineTitles.Distinct())
        {
            Console.WriteLine($"{title.Title}\n");
        }
        Pause();

        Console.WriteLine("Calculated late fees after {0} days late:\n", DAYSLATE);
        Console.WriteLine("{0,42} {1,11} {2,8}", "Title", "Call Number", "Late Fee");
        Console.WriteLine("------------------------------------------ ----------- --------");

        // Caluclate and display late fees for each item
        foreach (LibraryItem item in items)
            Console.WriteLine("{0,42} {1,11} {2,8:C}", item.Title, item.CallNumber,
                item.CalcLateFee(DAYSLATE));
        Pause();

        // Return each item that is checked out
        foreach (LibraryItem item in items)
        {
            if (item.IsCheckedOut())
                item.ReturnToShelf();
        }

        Console.WriteLine("After returning all items:\n");
        foreach (LibraryItem item in items)
        {
            Console.WriteLine("{0}\n", item);
        }
        Console.WriteLine($"Number of checked out items is: {countCheckOut.Count()}\n ");
        Pause();

        Console.WriteLine("Original loan period for each book: \n");
        // Display the original loan period of each book
        foreach (LibraryItem book in items)
        {
            if (book is LibraryBook)
                Console.WriteLine($"{book.LoanPeriod} days");
        }
        Console.WriteLine("\nAfter adding seven days to the current loan period: \n");
        // Add an extra 7 days to the original loan period of each book
        foreach (LibraryItem book in items)
        {
            if(book is LibraryBook)
            {
                book.LoanPeriod += EXTRA_DAYS;
                Console.WriteLine($"{book.LoanPeriod} days");
            }
        }
        Console.WriteLine();
        Pause();

        Console.WriteLine("Original list of items at start:\n");
        foreach (LibraryItem item in items)
            Console.WriteLine("{0}\n", item);
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