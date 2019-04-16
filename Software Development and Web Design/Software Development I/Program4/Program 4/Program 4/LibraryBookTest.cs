//B7623
//Program 4
//CIS 199-75
//12/05/2017
//This is a console application that displays data for different library books by using different classes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_4
{
    class LibraryBookTest
    {
        static void Main(string[] args)
        {
            LibraryBook book1 = new LibraryBook("How To Be OK at Euphonium", "Not-Nicholas Gay", "Wannabe Brass Player's Publishing", 2017, "12345");//Book 1
            LibraryBook book2 = new LibraryBook("What to do when you have too many finals on one day...", "A Whiney Student", "Overpriced College Bookstores Inc.", 2002, "67891");//Book 2
            LibraryBook book3 = new LibraryBook("An actual book title", "A Real Author", "A Legitimate Publishing Company", 1995, "11121");//Book 3
            LibraryBook book4 = new LibraryBook("What?! An actual book this time?", "jk :p", "Ran Out of Ideas Publishing Co.", 2005, "00022");//Book 4
            LibraryBook book5 = new LibraryBook("I spent a lot of time coming up with these titles so laugh!", "An Internet troll", "Random Publisherz", 1984, "99999");//Book 5

            LibraryBook[] books = new LibraryBook[5];
            books[0] = book1;
            books[1] = book2;
            books[2] = book3;
            books[3] = book4;
            books[4] = book5;

            WriteLine("This is the original data: ");
            WriteLine("---------------------------");
            WriteLine();
            PrintOut(books);

            book1.CallNumber = "11111";
            book2.CallNumber = "22222";
            book3.CheckOut();
            book4.CheckOut();
            book5.Publisher = "Overpriced College Bookstores Inc.";
            WriteLine("Changes to the book's data: ");
            WriteLine("----------------------------");
            WriteLine();
            PrintOut(books);

            book3.ReturnToShelf();
            book4.ReturnToShelf();
            WriteLine("After books have been returned: ");
            WriteLine("--------------------------------");
            WriteLine();
            PrintOut(books);
        }
        public static void PrintOut(LibraryBook[] books)
        {
            // generically process each element in array employees
            foreach (LibraryBook currentBook in books)
            {
                WriteLine(currentBook);// invokes ToString implicitly
                WriteLine();
            }
        }
    }
}
