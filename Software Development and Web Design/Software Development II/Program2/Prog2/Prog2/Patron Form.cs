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
    public partial class Patron_Form : Form
    {
        public Patron_Form()
        {
            InitializeComponent();
        }


        internal string PatronNameInputValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in patronName is returned
            get { return patronNameTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in patronName is set to specified value
            set { patronNameTextBox.Text = value; }
        }

        internal string PatronIDInputValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in patronID is returned
            get { return patronIDTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in patronID is set to specified value
            set { patronIDTextBox.Text = value; }
        }
        
        // Precondition:  Attempting to change focus from patronName or patronID
        // Postcondition: If entered string is neither null nor whitespace focus will change,
        //                else focus will remain and error provider message set
        private void PatronText_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(patronNameTextBox.Text))
            {
                e.Cancel = true; // Stops focus changing process
                errorProvider1.SetError(patronNameTextBox, "Enter a name!"); // Set error message
            }
            else
            {
                if (string.IsNullOrWhiteSpace(patronIDTextBox.Text))
                {
                    e.Cancel = true; // Stops focus changing process
                                     // Will NOT proceed to Validated event

                    errorProvider2.SetError(patronIDTextBox, "Enter a valid ID!"); // Set error message
                }
            }
        }
        // Precondition:  PatronText_Validating succeeded
        // Postcondition: Any error message set for patronName and patronID is cleared
        //                Focus is allowed to change
        private void PatronText_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(patronNameTextBox, ""); // Clears error message
            errorProvider2.SetError(patronIDTextBox, ""); // Clears error message
        }

        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

    }

}
