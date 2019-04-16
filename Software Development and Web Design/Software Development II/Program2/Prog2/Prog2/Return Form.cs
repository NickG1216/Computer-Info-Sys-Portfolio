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
    public partial class Return : Form
    {
        Library GetLibrary;
        public Return(Library _library)
        {
            GetLibrary = _library;
            InitializeComponent();
        }

        private void Return_Load(DataObjectMethodType sender, EventArgs e)
        {
            foreach(LibraryBook book in GetLibrary.GetItemsList())
            {
                if(book.IsCheckedOut())
                {
                    itemBox.Items.Add(book.Title + "," + book.CallNumber);
                }
            }
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
