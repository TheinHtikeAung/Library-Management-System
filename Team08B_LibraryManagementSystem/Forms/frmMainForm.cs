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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnForm returnForm = new frmReturnForm();
            returnForm.ShowDialog();
        }

        private void bookByVariousCriteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchBookByCriteria bookByCriteria = new frmSearchBookByCriteria();
            bookByCriteria.ShowDialog();
        }

        private void loanBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchLoanBook bookLoan = new frmSearchLoanBook();
            bookLoan.ShowDialog();
        }

        private void bookFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookMaintenance bm = new frmBookMaintenance();
            bm.ShowDialog();
        }

        private void memberFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMember member = new frmMember();
            member.ShowDialog();
        }

        private void issueFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueDetails issue = new frmIssueDetails();
            issue.ShowDialog();
        }

        private void monthlyRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlyRentalView mrv = new MonthlyRentalView();
            mrv.Show();
        }

        private void overdueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            overdue rv = new overdue();
            rv.Show();
        }
    }
}
