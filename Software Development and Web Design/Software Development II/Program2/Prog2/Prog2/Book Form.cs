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
    public partial class Book_Form : Form
    {
        public Book_Form()
        {
            InitializeComponent();
        }

        internal string TitleInputValue // My friends can use this blah blah blah...
        {
            // Precondition:  None
            // Postcondition: Text in titleTxt is returned
            get { return titleTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in titleTxt is set to specified value
            set { titleTxt.Text = value; }
        }

        internal string PublisherInputValue // My friends can use this blah blah blah...
        {
            // Precondition:  None
            // Postcondition: Text in publisherTxt is returned
            get { return publisherTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in publisherTxt is set to specified value
            set { publisherTxt.Text = value; }
        }

        internal string AuthorInputValue // My friends can use this blah blah blah...
        {
            // Precondition:  None
            // Postcondition: Text in authorTxt is returned
            get { return authorTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in authorTxt is set to specified value
            set { authorTxt.Text = value; }
        }

        internal string CopyrightInputValue // My friends can use this blah blah blah...
        {
            // Precondition:  None
            // Postcondition: Text in copyrightTxt is returned
            get { return copyrightTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in copyrightTxt is set to specified value
            set { copyrightTxt.Text = value; }
        }

        internal string LoanPeriodInputValue // My friends can use this blah blah blah...
        {
            // Precondition:  None
            // Postcondition: Text in loanPeriodTxt is returned
            get { return loanPeriodTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in loanPeriodTxt is set to specified value
            set { loanPeriodTxt.Text = value; }
        }

        internal string CallNumInputValue // My friends can use this blah blah blah...
        {
            // Precondition:  None
            // Postcondition: Text in callNumTxt is returned
            get { return callNumTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in callNumTxt is set to specified value
            set { callNumTxt.Text = value; }
        }

        // Precondition:  Attempting to change focus from book form
        // Postcondition: If entered string is neither null nor whitespace for title and call number, and 
        // entered ints for copyright year and loan period are greater than or euqal to zero focus will change,
        //                else focus will remain and error provider message set
        private void BookInputText_Validating(object sender, CancelEventArgs e)
        {
            int number; // Value entered as input text

            if (string.IsNullOrWhiteSpace(titleTxt.Text)) // Validate the title
            {

                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(titleTxt, "Enter a title!"); // Set error message
            }

            else
            
                if (string.IsNullOrWhiteSpace(callNumTxt.Text)) // Validate the call number
                {
                    e.Cancel = true; // Stops focus changing process
                                     // Will NOT proceed to Validated event

                    errorProvider1.SetError(callNumTxt, "Enter a valid call number!"); // Set error message
                }
            
        
            else // Try to validate the copyright yr and loan period
            {
                // Will try to parse text as int
                // If fails, TryParse returns false
                // If succeeds, TryParse returns true and number stores parsed value
                if (!int.TryParse(copyrightTxt.Text, out number))
                {
                    e.Cancel = true; // Stops focus changing process
                                     // Will NOT proceed to Validated event

                    errorProvider1.SetError(copyrightTxt, "Enter an integer!"); // Set error message

                    copyrightTxt.SelectAll(); // Select all text in inputTxt to ease correction
                }
                else
                
                    if (number < 0)
                    {
                        e.Cancel = true; // Stops focus changing process
                                         // Will NOT proceed to Validated event

                        errorProvider1.SetError(copyrightTxt, "Enter a non-negative integer!"); // Set error message

                        copyrightTxt.SelectAll(); // Select all text in inputTxt to ease correction
                    }
                 
                else // Try to validate the loan period
                
                    // Will try to parse text as int
                    // If fails, TryParse returns false
                    // If succeeds, TryParse returns true and number stores parsed value
                    if (!int.TryParse(loanPeriodTxt.Text, out number))
                    {
                        e.Cancel = true; // Stops focus changing process
                                         // Will NOT proceed to Validated event

                        errorProvider1.SetError(loanPeriodTxt, "Enter an integer!"); // Set error message

                        loanPeriodTxt.SelectAll(); // Select all text in inputTxt to ease correction
                    }
                    else
                    
                        if (number < 0)
                        {
                            e.Cancel = true; // Stops focus changing process
                                             // Will NOT proceed to Validated event

                            errorProvider1.SetError(loanPeriodTxt, "Enter a non-negative integer!"); // Set error message

                            loanPeriodTxt.SelectAll(); // Select all text in inputTxt to ease correction
                        }
                    
                
            }
        }

        // Precondition:  BookInputText_Validating succeeded
        // Postcondition: Any error message set for library book data is cleared
        //                Focus is allowed to change
        private void BookInputText_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(titleTxt, ""); // Clears error message
            errorProvider1.SetError(callNumTxt, ""); // Clears error message
            errorProvider1.SetError(copyrightTxt, ""); // Clears error message
            errorProvider1.SetError(loanPeriodTxt, ""); // Clears error message
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
    }

}
