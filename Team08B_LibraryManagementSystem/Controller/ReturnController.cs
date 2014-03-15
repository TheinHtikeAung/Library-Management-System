using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Team08B_LibraryManagementSystem
{
    class ReturnController
    {
        LibraryEntities context;

        public ReturnController()
        {
             context= new LibraryEntities();
        }

        public IssueDetail getIssueDetail(int returnBookCopyID)
        {
            return context.IssueDetails.First(x => x.BookCopyID == returnBookCopyID
                                                && x.ReturnDate == null);
        }

        public BookCopy getBookCopy(int returnBookCopyID)
        {
            return context.BookCopies.First(x => x.BookCopyID == returnBookCopyID);
        }

        public bool checkNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                return true;
            }
            return false;
        }
    }
}
