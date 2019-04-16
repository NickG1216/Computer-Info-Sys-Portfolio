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

namespace Program_4
{
    public class LibraryBook
    {
        private string _title;//Title of the book
        private string _author;//Author of the book
        private string _publisher;//Publisher of the book 
        private int _copyrightYear;//The copyright year for the book
        private string _callNumber;//The call number for the book
        private bool _isCheckedOut = false;//Is the book checked out?

        //Properties

        public string Title {get; set;}
        //Precondition: None
        //Postconditon: The title of the book is returned

        public string Author {get; set;}
        //Precondition: None
        //Postcondition: The author of the book is returned

        public string Publisher {get; set;}
        //Precondition: None
        //Postcondition: The publisher of the book is returned

        public int CopyrightYear
        {
            //Precondition: The copyright year value is a non-negative number
            //Postconditon: If the copyright year value is a negative number, the default year will be 2017
            get { return _copyrightYear; }
            set
            {
                if (value >= 0)
                    _copyrightYear = value;
                else _copyrightYear = 2017;
            }
        }
        public string CallNumber {get; set;}
        //Precondition: None
        //PostCondition: The call number of the book is returned
        
        //Five parameter constructor
        public LibraryBook(string title, string author, string publisher, int copyrightYear, string callNumber)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            CopyrightYear = copyrightYear;
            CallNumber = callNumber;
        }

        public void CheckOut()//Method that changes the book's check out status to see if it has been checked out
        {
            _isCheckedOut = true;
        }

        public void ReturnToShelf()//Method that changes the book's check out status to see if it has been returned
        {
            _isCheckedOut = false;
        }

        public bool IsCheckedOut()//Method that returns the book's check out status 
        {
            return _isCheckedOut;
        }
        //Returns a string represenation of LibraryBook objects, using properties
        public override string ToString()
        {
            return $"Title: {Title}{Environment.NewLine}" +
                $"Author: {Author}{Environment.NewLine}" +
                $"Publisher: {Publisher}{Environment.NewLine}" +
                $"Copyright Year: {CopyrightYear}{Environment.NewLine}" +
                $"Call Number: {CallNumber}{Environment.NewLine}" +
                $"Check out status: {IsCheckedOut()}";
        }
    }
}
