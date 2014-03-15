using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Team08B_LibraryManagementSystem.Properties;


namespace Team08B_LibraryManagementSystem
{
    public partial class frmBookMaintenance : Form
    {
        LibraryEntities context;
        BookController bookController;

        public int bookid
        {
        get;
        set;
        }
        
        public frmBookMaintenance()
        {
            InitializeComponent();
        }
        
        private void BookMaintenance_Load(object sender, EventArgs e)
        {
            bookController = new BookController();
            context = bookController.getContext();

            dgvbook.DataSource = context.GetBookSP();
            
            dgvcopies.DataSource = context.BookCopies;
            txtCategoryID.Text = dgvbook.SelectedRows[0].Cells[8].Value.ToString();
            txtCategoryName.Text =dgvbook.SelectedRows[0].Cells[3].Value.ToString();
            
            this.dgvbook.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.dgvbook.MultiSelect = false;

            dgvbook_SelectionChanged(sender, e);
        }
            
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void dgvbook_SelectionChanged(object sender, EventArgs e)
        {
           if(dgvbook.ColumnCount!=0)
           {
               try
               {
                   int i = Convert.ToInt32(dgvbook.SelectedRows[0].Cells[0].Value);
                   dgvcopies.DataSource = bookController.getBookCopies((int)dgvbook.SelectedRows[0].Cells[0].Value);

                   txtCategoryID.Text = dgvbook.SelectedRows[0].Cells[8].Value.ToString();
                   txtCategoryName.Text = dgvbook.SelectedRows[0].Cells[3].Value.ToString();
               }
               catch (Exception ee)
               { }
           }
        }
        
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmBookdetail bookdetail = new frmBookdetail();
            bookdetail.bookid=(int)dgvbook.SelectedRows[0].Cells[0].Value;
            bookdetail.ShowDialog();

            btnRefresh_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete book record ?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bookController.deleteBook((int)dgvbook.SelectedRows[0].Cells[0].Value);
                    MessageBox.Show("Successfully Deleted !", "Progress");

                    btnRefresh_Click(sender, e);
                }
                catch (Exception ee)
                {
                    MessageBox.Show("You can't delete this record because of security issue.");
                }
            }
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            frmBookdetail bookdetail = new frmBookdetail();
            bookdetail.newform = true;
            bookdetail.ShowDialog();

            btnRefresh_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvbook.DataSource = context.GetBookSP();
            dgvbook.Refresh();
        }

        
    }
}
