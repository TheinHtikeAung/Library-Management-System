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
    public partial class frmSearchLoanBook : Form
    {
        LibraryEntities context;
        GetLoanBookInfo_Result b;

        public frmSearchLoanBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtSearch.Text.Equals(""))
                {
                    b = context.GetLoanBookInfo(Convert.ToInt32(txtSearch.Text)).FirstOrDefault();
                    if (b != null)
                    {
                        lblISBN.Text = b.ISBN;
                        lblTitle.Text = b.Title;
                        lblCategory.Text = b.CategoryDescription;
                        lblDueDate.Text = b.DueDate.ToShortDateString();
                        lblStatus.Text = b.Status;
                        lblMemberID.Text = b.MemberID.ToString();
                        lblName.Text = b.FirstName + " " + b.LastName;
                    }
                    else { resetForm(); }
                }
                else { resetForm(); }
            }
            catch (Exception ex)
            {
                txtSearch.Text = "";
            }
        }

        public void resetForm()
        {
            lblISBN.Text = "";
            lblTitle.Text = "";
            lblCategory.Text = "";
            lblDueDate.Text = "";
            lblStatus.Text = "";
            lblMemberID.Text = "";
            lblName.Text = "";
        }

        private void SearchLoanBook_Load(object sender, EventArgs e)
        {
            context = new LibraryEntities();
            resetForm();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
