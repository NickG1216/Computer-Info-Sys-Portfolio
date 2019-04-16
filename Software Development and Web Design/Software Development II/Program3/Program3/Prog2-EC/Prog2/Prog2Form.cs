// Program 3
// CIS 200-01
// Due: 4/5/2018
// By: Z8933

// File: Prog2Form.cs
// This class creates the main GUI for Programs 2 and 3. It provides a
// File menu with About and Exit items, an Insert menu with Patron and
// Book items, an Item menu with Check Out and Return items, and a
// Report menu with Patron List, Item List, and Checked Out Items items.

// Extra Credit - Check Out and Return only show relevant items

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    [Serializable]
    public partial class Prog2Form : Form
    {
        private Library _lib; // The library
        private BinaryFormatter reader = new BinaryFormatter();// Object for deserializing library object in binary format
        private BinaryFormatter formatter = new BinaryFormatter();// Object for serializing library object in binary format
        private FileStream input;// stream for reading file
        private FileStream output;// stream for saving file

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test items and patrons
        //                are added to the library

        public Prog2Form()
        {
            InitializeComponent();

            _lib = new Library(); // Create the library


        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // NewLine shortcut

            MessageBox.Show($"Program 3{NL}By: Z8933{NL}CIS 200-01{NL}Spring 2018",
                "About Program 3");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Report, Patron List menu item activated
        // Postcondition: The list of patrons is displayed in the reportTxt
        //                text box
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryPatron> patrons;                // List of patrons
            string NL = Environment.NewLine;            // NewLine shortcut

            patrons = _lib.GetPatronsList();

            result.Append($"Patron List - {patrons.Count} patrons{NL}{NL}");

            foreach (LibraryPatron p in patrons)
                result.Append($"{p}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Item List menu item activated
        // Postcondition: The list of items is displayed in the reportTxt
        //                text box
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryItem> items;                    // List of library items
            string NL = Environment.NewLine;            // NewLine shortcut

            items = _lib.GetItemsList();

            result.Append($"Item List - {items.Count} items{NL}{NL}");

            foreach (LibraryItem item in items)
                result.Append($"{item}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Checked Out Items menu item activated
        // Postcondition: The list of checked out items is displayed in the
        //                reportTxt text box
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryItem> items;                    // List of library items
            string NL = Environment.NewLine;            // NewLine shortcut

            items = _lib.GetItemsList();

            // LINQ: selects checked out items
            var checkedOutItems =
                from item in items
                where item.IsCheckedOut()
                select item;

            result.Append($"Checked Out Items - {checkedOutItems.Count()} items{NL}{NL}");

            foreach (LibraryItem item in checkedOutItems)
                result.Append($"{item}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Insert, Patron menu item activated
        // Postcondition: The Patron dialog box is displayed. If data entered
        //                are OK, a LibraryPatron is created and added to the library
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm patronForm = new PatronForm(); // The patron dialog box form

            DialogResult result = patronForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                // Use form's properties to get patron info to send to library
                _lib.AddPatron(patronForm.PatronName, patronForm.PatronID);
            }

            patronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Insert, Book menu item activated
        // Postcondition: The Book dialog box is displayed. If data entered
        //                are OK, a LibraryBook is created and added to the library
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(); // The book dialog box form

            DialogResult result = bookForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    // Use form's properties to get book info to send to library
                    _lib.AddLibraryBook(bookForm.ItemTitle, bookForm.ItemPublisher, int.Parse(bookForm.ItemCopyrightYear),
                        int.Parse(bookForm.ItemLoanPeriod), bookForm.ItemCallNumber, bookForm.BookAuthor);
                }

                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Book Validation!", "Validation Error");
                }
            }

            bookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Item, Check Out menu item activated
        // Postcondition: The Checkout dialog box is displayed. If data entered
        //                are OK, an item is checked out from the library by a patron
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;     // List of library items
            List<LibraryPatron> patrons; // List of patrons

            items = _lib.GetItemsList();
            patrons = _lib.GetPatronsList();

            if (((items.Count - _lib.GetCheckedOutCount()) == 0) || (patrons.Count() == 0)) // Must have items and patrons
                MessageBox.Show("Must have items and patrons to check out!", "Check Out Error");
            else
            {
                CheckoutForm checkoutForm = new CheckoutForm(items, patrons); // The check out dialog box form

                DialogResult result = checkoutForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    _lib.CheckOut(checkoutForm.ItemIndex, checkoutForm.PatronIndex);
                }

                checkoutForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  Item, Return menu item activated
        // Postcondition: The Return dialog box is displayed. If data entered
        //                are OK, an item is returned to the library
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;     // List of library items

            items = _lib.GetItemsList();

            if ((_lib.GetCheckedOutCount() == 0)) // Must have items to return
                MessageBox.Show("Must have items to return!", "Return Error");
            else
            {
                ReturnForm returnForm = new ReturnForm(items); // The return dialog box form

                DialogResult result = returnForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    _lib.ReturnToShelf(returnForm.ItemIndex);
                }

                returnForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }
        // Event handler for when the user clicks the open library menu button
        private void openLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result; //result of OpenFileDialog
            string fileName; // name of the file
            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;//get specified name
            }
            if (result == DialogResult.OK)//Only if the dialog result is ok
            {
                if (string.IsNullOrWhiteSpace(fileName))
                {
                    MessageBox.Show("Invalid File Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//Show Error Message
                }
                else
                {
                    try//open file 
                    {
                        input = new FileStream(fileName, FileMode.Open, FileAccess.Read);//This is the file that you open
                        _lib = (Library)reader.Deserialize(input);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error Opening File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//Show error message
                    }
                    catch (SerializationException)
                    {
                        input.Close();//Close File Stream
                        MessageBox.Show("Error Opening File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//Show error message
                    }
                }

            }


        }
        //Event handler for the save library menu button
        private void saveLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;//result of SaveFileDialog
            string fileName;//name of the file that you save
            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;//let user create file
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;//get specified name
            }

            if (result == DialogResult.OK)//Only if the dialog result is ok
            {
                if (string.IsNullOrWhiteSpace(fileName))
                {
                    MessageBox.Show("Invalid File Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//show error message
                }
                else
                {
                    try//Save file via file stream
                    {
                        output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);// This is the file that you save, 
                                                                                                   //if the file exists it will be overwritten
                        formatter.Serialize(output, _lib); //Serializes the library data
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error Saving File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//Show error message
                    }
                    catch (SerializationException)
                    {
                        output.Close();//Close File Stream
                        MessageBox.Show("Error Saving File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//Show error message
                    }
                }
            }
        }
        //Event handler for Edit Patron Menu Button
        private void patronToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<LibraryPatron> patrons; // List of patrons
            patrons = _lib.GetPatronsList();
            int patronIndex;

            if (patrons.Count() == 0)//Must have patrons to edit(open Library DAT File)
            {
                MessageBox.Show("Must have patrons available to edit!", "Error");
            }
            else
            {
                ChoosePatronForm cpForm = new ChoosePatronForm(patrons); // Show choose patron form 
                DialogResult result = cpForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    patronIndex = cpForm.PatronIndex;
                    LibraryPatron p = patrons[patronIndex];

                    PatronForm pf = new PatronForm();
                    pf.PatronName = p.PatronName;
                    pf.PatronID = p.PatronID;

                    DialogResult result2 = pf.ShowDialog(); // Show form as dialog and store result

                    if (result2 == DialogResult.OK)
                    {
                        p.PatronName = pf.PatronName;
                        p.PatronID = pf.PatronID;
                    }
                }
            }
        }
        
        //Event Handler for edit book menu
        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items; //List of Library items
            items = _lib.GetItemsList();
            int itemIndex;

            if (items.Count() == 0)//Must have items to edit(open Library DAT File)
            {
                MessageBox.Show("Must have books available to edit!", "Error");
            }
            else
            {
                ChooseBookForm cbForm = new ChooseBookForm(items);// Show choose book form
                DialogResult result = cbForm.ShowDialog();// Show form as dialog and store result


                if (result == DialogResult.OK)// If the result is ok 
                {
                    itemIndex = cbForm.ItemIndex;
                    LibraryBook book = (LibraryBook)items[itemIndex];

                    BookForm bf = new BookForm();
                    
                    bf.ItemTitle = book.Title;
                    bf.ItemPublisher = book.Publisher;
                    bf.ItemCopyrightYear = book.CopyrightYear.ToString();//Converts the copyright year from int to string 
                    bf.ItemLoanPeriod = book.LoanPeriod.ToString();//Converts the copyright year from int to string 
                    bf.ItemCallNumber = book.CallNumber;
                    bf.BookAuthor = book.Author;

                    DialogResult result2 = bf.ShowDialog();// Show form as dialog and store result

                    if(result2 == DialogResult.OK)//If the result is ok
                    {
                        book.Title = bf.ItemTitle;
                        book.Publisher = bf.ItemPublisher;
                        book.CopyrightYear = int.Parse(bf.ItemCopyrightYear);
                        book.LoanPeriod = int.Parse(bf.ItemLoanPeriod);
                        book.CallNumber = bf.ItemCallNumber;
                        book.Author = bf.BookAuthor;
                    }


                }
            }
        }
    }
}