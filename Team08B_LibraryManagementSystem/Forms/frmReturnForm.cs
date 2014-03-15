using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Team08B_LibraryManagementSystem
{
    public partial class frmReturnForm : Form
    {
        LibraryEntities context;
        Member member;
        int memberId;
        int bookId;
        IList<BookLendByMemberSP_Result> list;
        ReturnController returnController;

        public readonly double fine = 0.15; // essentially a constant same with final keyword
        double overDue;
        
        public frmReturnForm()
        {
            InitializeComponent();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            context = new LibraryEntities();
            returnController = new ReturnController();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            tslStatus.Text = ""; // reset status if save function work in previous
            tsProgress.Value = 0;

            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (!txtId.Text.Equals(""))
                    {
                        memberId = Convert.ToInt32(txtId.Text);

                        //Use FirstOrDefault instead of First. This will return null in the face of an empty collection.
                        member = context.Members.FirstOrDefault(x => x.MemberID == memberId);
                        if (member != null)
                        {
                            txtName.Text = member.FirstName.ToString() + " " + member.LastName.ToString();

                            list = context.BookLendByMemberSP(memberId).ToList<BookLendByMemberSP_Result>();

                            if (list.Count != 0)
                                dgvBook.DataSource = list;
                            else
                                dgvBook.DataSource = null;
                        }
                        else
                        {
                            txtName.Text = "";
                            dgvBook.DataSource = null;
                        }
                    }
                    else
                    {
                        txtName.Text = "";
                        dgvBook.DataSource = null;
                    }
                }
            }
            catch (Exception a)
            { txtId.Text = ""; }
        }

        private void txtBookId_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (!txtBookId.Text.Equals(""))
                    {
                        bookId = Convert.ToInt32(txtBookId.Text);

                        foreach (BookLendByMemberSP_Result book in list)
                        {
                            if (book.BookCopyID == bookId)
                            {
                                double daysLeft = book.DueDate.Subtract(DateTime.Now.Date).TotalDays;

                                if (book.Status == "Available")
                                {
                                    book.Status = "Lend";
                                    book.ReturnDate = null;
                                }
                                else
                                {
                                    book.Status = "Available";
                                    book.ReturnDate = DateTime.Now.Date;
                                }
                                bool forLend = (book.Status == "Lend") ? true : false;
                                CheckOverDue(daysLeft, forLend);

                                dgvBook.DataSource = null;
                                dgvBook.DataSource = list;
                            }
                        }
                        txtBookId.Text = "";
                    }
                }
            }
            catch (Exception a)
            { txtBookId.Text = ""; }
        }
        public void CheckOverDue(double daysLeft,bool forLend)
        {
            if (daysLeft < 0)
            {
                overDue += (((forLend==true)?daysLeft:Math.Abs(daysLeft)) * fine);
                lblOverdue.Text = String.Format("$ {0:0.00}", overDue);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tsProgress.Value += 5;
            foreach (BookLendByMemberSP_Result returnBook in list)
            {
                if(returnBook.Status=="Available")
                {
                    tsProgress.Value += 5;
                    
                    IssueDetail issueDetail = context.IssueDetails.First(x => x.BookCopyID == returnBook.BookCopyID
                                                && x.ReturnDate == null);
                    issueDetail.ReturnDate = DateTime.Now.Date;

                    BookCopy bookCopy = new BookCopy();
                    bookCopy = context.BookCopies.First(x => x.BookCopyID == returnBook.BookCopyID);
                    
                    bookCopy.Status = "Available";

                    context.SaveChanges();
                    tsProgress.Value += 5;
                }
            }
            tslStatus.Text = "Successfully Save !";
            tsProgress.Value = 100;
            resetForm();
        }

        public void resetForm()
        {
            lblOverdue.Text = "$ 0.00";

            txtName.Text = "";
            txtId.Text = "";
            txtId.Focus();
            dgvBook.DataSource = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
