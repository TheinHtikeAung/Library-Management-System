using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Transactions;


namespace Team08B_LibraryManagementSystem
{
    public partial class frmIssueDetails : Form
    {

        IssueController issueController;
        List<BookInfo_Result> bookList=new List<BookInfo_Result>();
        int memberId;
        int bookCount=0;
        int maxLimit = 4;

        public frmIssueDetails()
        {
            InitializeComponent();
            issueController = new IssueController();
        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {
            
            if (!txtMemberID.Text.Equals(""))
            {
               
                try
                {
                    memberId = int.Parse(txtMemberID.Text);
                    ErrorStatusLabel1.Text = "";
                    txtName.Text = issueController.GetMember(memberId);

                    bookCount = issueController.GetBookCountLoanByMember(memberId);
                }
                catch(FormatException ex)
                {
                    txtName.Text = "";
                    ErrorStatusLabel1.Text = "";
                    ErrorStatusLabel1.Text = "Enter valid data!: " + ex.Message;
                }

                catch (Exception ex)
                {
                    txtName.Text = "";
                    ErrorStatusLabel1.Text = "";
                    ErrorStatusLabel1.Text = "Not Found: "+ex.Message;
                }
              
            }
            else if (txtMemberID.Text.Equals(""))
            {
                txtName.Text = "";
            }
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            //List<ReceiptView> receiptList = new List<ReceiptView>();
            //using (System.
            issueController.CreateIssueObject(memberId);
            if (dataGridViewIssueDetails.DataSource != null&&bookList.Count!=0)
            {
                using (System.Transactions.TransactionScope ts
                    = new System.Transactions.TransactionScope())
                {
                    foreach (BookInfo_Result book in bookList)
                    {
                        issueController.ChangeBookStatus(book.BookCopyID);
                    }

                    foreach (BookInfo_Result book in bookList)
                    {
                        issueController.UpdateIssueDetails(book.BookCopyID);
                    }
                    ts.Complete();
                }
                    ResetForm();
                    ErrorStatusLabel1.Text = "";
                    ErrorStatusLabel1.Text = "Save Successfull!!";
                    DialogResult dialogResult = MessageBox.Show("Do You Want to Print Issue Receipt?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        issueController.GenerateReport();
                    }
                
                
            }
            else
            {
                ErrorStatusLabel1.Text = "";
                ErrorStatusLabel1.Text = "Grid View is Empty! Add atleast one book!!";
            }

        }

        public void ResetForm()
        {
            txtBookID.Text = "";
            txtMemberID.Text = "";
            bookList.Clear();
            dataGridViewIssueDetails.DataSource = null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = -1;
            if (dataGridViewIssueDetails.DataSource != null && bookList.Count != 0)
            {
                foreach (BookInfo_Result book in bookList)
                {
                    //MessageBox.Show(dataGridViewBookInfo.SelectedRows[0].Cells[0].Value.ToString() + " " + book.BookID.ToString().ToLower());
                    //dr.ToString
                    try
                    {
                        ErrorStatusLabel1.Text = "";
                        if (dataGridViewIssueDetails.SelectedRows[0].Cells[0].Value.ToString().ToLower().
                                                                                Equals(book.BookCopyID.ToString().ToLower()))
                        {
                            index = bookList.IndexOf(book);
                        }
                    }
                    catch (ArgumentOutOfRangeException ior)
                    {
                        ErrorStatusLabel1.Text = "";
                        ErrorStatusLabel1.Text = "Please select a Row!!";
                    }
                }
                if (index != -1)
                {
                    bookList.RemoveAt(index);
                    dataGridViewIssueDetails.DataSource = null;
                    dataGridViewIssueDetails.DataSource = bookList;
                }
            }
            else
            {
                ErrorStatusLabel1.Text = "";
                ErrorStatusLabel1.Text = "Grid View is Empty! Add atleast one book!!";
            }

        }

      

        private void txtBookID_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("key data"+e.KeyData+" Key value:"+e.KeyValue+" key code:"+e.KeyCode);
            try
            {
                if (e.KeyValue == 13)
                {
                    int bookId;

                    if (!txtBookID.Text.Equals("") && bookCount<maxLimit)
                    {
                        ErrorStatusLabel1.Text = "";
                        bookId = int.Parse(txtBookID.Text);
                        //BookInfo_Result book = context.BookInfo(bookId).FirstOrDefault<BookInfo_Result>();
                        BookInfo_Result book = issueController.GetBookByBookId(bookId);
                        if ((book != null) && book.Status.Equals("Available"))
                        {
                            bookList.Add(book);
                            bookCount++; 

                            dataGridViewIssueDetails.DataSource = null;
                            dataGridViewIssueDetails.DataSource = bookList;
                            //dataGridViewIssueDetails.DataSource = bookRes;
                        }
                        else
                        {
                            dataGridViewIssueDetails.DataSource = null;
                            ErrorStatusLabel1.Text = "";
                            ErrorStatusLabel1.Text = "Book Not Available!";
                        }

                    }
                    else if (txtBookID.Text.Equals(""))
                    {
                        dataGridViewIssueDetails.DataSource = null;
                        ErrorStatusLabel1.Text = "";
                        ErrorStatusLabel1.Text = "Enter Book Id!";
                        //dataGridViewBookInfo.DataBind();
                    }
                    else if(bookCount==maxLimit)
                    {
                        ErrorStatusLabel1.Text = "";
                        ErrorStatusLabel1.Text = "Exceed maximum limit of Book !";
                    }

                }
            }
            catch (Exception ee)
            {
                txtBookID.Text = "";
            }

        }

        private void frmIssueDetails_Load(object sender, EventArgs e)
        {

        }

    }
}
