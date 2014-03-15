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
    public partial class frmSearchBookByCriteria : Form
    {
        LibraryEntities context;
        IList<GetBookByCriteria_Result> books;

        public frmSearchBookByCriteria()
        {
            InitializeComponent();
            context = new LibraryEntities();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int i=cboSearchBy.SelectedIndex;

            if (!txtKeyword.Text.Equals(""))
            {
                if (i == 1 || i == 7)
                {
                    books = context.GetBookByCriteria(cboSearchBy.Text, Convert.ToInt32(txtKeyword.Text), null, null).ToList<GetBookByCriteria_Result>();
                }
                else if (i == 8)
                {
                    books = context.GetBookByCriteria(cboSearchBy.Text, null, null, Convert.ToDateTime(txtKeyword.Text)).ToList<GetBookByCriteria_Result>();
                }
                else
                {
                    books = context.GetBookByCriteria(cboSearchBy.Text, null, txtKeyword.Text, null).ToList<GetBookByCriteria_Result>();
                }

                
            }
            else if (i == 0) { books = context.GetBookByCriteria(cboSearchBy.Text, null, null, null).ToList<GetBookByCriteria_Result>(); }
            else { dgvBookInfo.DataSource = null;}

            if (books.Count != 0)
                dgvBookInfo.DataSource = books;
            else
                dgvBookInfo.DataSource = null;
        }

        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch_Click(sender,e);
            }
        }

        private void SearchBookByCriteria_Load(object sender, EventArgs e)
        {
            cboSearchBy.SelectedIndex = 0;
        }

        private void cboSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKeyword.Text = "";
            txtKeyword.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
