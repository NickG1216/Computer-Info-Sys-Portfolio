using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class Form1 : Form
    {
        private Library _lib;
        public Form1()
        {
            InitializeComponent();
            _lib = new Library();

            // Test data - Magic numbers allowed here
            _lib.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
                "ZZ25 3G", "Andrew Wright");
            _lib.AddLibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
                "AB73 ZF", "IP Thief");
            _lib.AddLibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
                "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
                LibraryMovie.MPAARatings.PG);
           _lib.AddLibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
                "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G);
           _lib.AddLibraryMusic("C# - The Album", "UofL Music", 2014, 14,
                "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
           _lib.AddLibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
                "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12);
           _lib.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
                "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
           _lib.AddLibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
                "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams");
           _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
                "MA53 9A", 16, 7);
           _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
                "MA53 9B", 16, 8);
           _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
                "MA53 9C", 16, 9);
           _lib.AddLibraryMagazine("     VB Magazine    ", "    UofL Mags   ", 2018, 14,
                "MA21 5V", 1, 1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Display MessageBox when the About menu item is selected
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caption = " About";
            string message = "Grading ID: Z8933\n Program 2\n 3/10/2018\n CIS 200-01\n" +
                "This is a simple GUI that allows the user to add patrons and books to the library and check them out. ";
            MessageBox.Show(message, caption);
        }

        // Exits the program when the Exit menu item is selected
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Precondition:  The patron menu item has been clicked
        // Postcondition: A dialog box has been displayed prompting for
        //                a name and patron id. If user submits, Main form is updated
        //                to display new patrons.
        private void patronToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Patron_Form patronInput = new Patron_Form();
            DialogResult result;
            result = patronInput.ShowDialog();
            string patronName; // Patron name
            string patronID; // Patron Id
           

            if (result == DialogResult.OK)
            {
                patronName = patronInput.PatronNameInputValue;
                patronID = patronInput.PatronIDInputValue;
                _lib.AddPatron(patronName, patronID);
            }
        }

        // Precondition:  The book menu item has been clicked
        // Postcondition: A dialog box has been displayed prompting for
        //                data about a library book. If user submits, Main form is updated
        //                to display new library books.
        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Book_Form bookInput = new Book_Form();
            DialogResult result;
            result = bookInput.ShowDialog();
            string author; //The author
            string publisher; // The publisher
            string title; // The title
            string callNum; // The call number 
            int copyrightYear; // The copyright year
            int loanPeriod; // The loan period

            if (result == DialogResult.OK)
            {
                author = bookInput.AuthorInputValue;
                publisher = bookInput.PublisherInputValue;
                title = bookInput.TitleInputValue;
                callNum = bookInput.CallNumInputValue;
                copyrightYear = int.Parse(bookInput.CopyrightInputValue);
                loanPeriod = int.Parse(bookInput.LoanPeriodInputValue);
                _lib.AddLibraryBook(title, publisher, copyrightYear, loanPeriod, callNum, author);
            }
        }

        
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOut_Form checkedOut = new CheckOut_Form(_lib.GetItemsList(), _lib.GetPatronsList());
            DialogResult result = checkedOut.ShowDialog();
            int itemName;
            int patronName;
            if (result == DialogResult.OK)
            {
                
            }

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return returnItem = new Return(_lib);
            DialogResult result = returnItem.ShowDialog();

            if (result == DialogResult.OK)
            {
                
            }

        }


        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var countPatrons =
            from p in _lib._patrons
            select p;
            foreach (var user in countPatrons)
            {
                reportTxt.Text = $"{user}";
            }   
        }

        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            var countItems =
                from i in _lib._items
                select i;
            foreach (var item in countItems)
            {
                reportTxt.Text = $"{item}";
                
            }
        }

        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showCheckedOutItems =
                from i in _lib._items
                where i.IsCheckedOut() == true
                select i;

            foreach (var item in showCheckedOutItems)
            {
                reportTxt.Text = $"{item}";
            }
        }
    }

}
