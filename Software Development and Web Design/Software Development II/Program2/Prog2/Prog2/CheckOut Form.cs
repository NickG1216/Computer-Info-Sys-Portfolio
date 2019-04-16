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
    public partial class CheckOut_Form : Form
    {
        public CheckOut_Form(List<LibraryItem> itemsList, List<LibraryPatron> patronsList)
        {
            InitializeComponent();
           
            foreach(LibraryItem book in itemsList)
            {
                if(book is LibraryBook)
                itemBox.Items.Add(book.Title + "," + book.CallNumber);
            }

            foreach(LibraryPatron user in patronsList)
            {
                patronBox.Items.Add(user.PatronName + "," + user.PatronID);
            }
            
        }

        

        private void itemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
