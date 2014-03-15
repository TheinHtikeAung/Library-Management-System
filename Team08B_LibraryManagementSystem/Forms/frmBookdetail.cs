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
    public partial class frmBookdetail : Form
    {
        LibraryEntities context;
        public int bookid;
        IList<BookCopy> originalcopies;
        IList<BookCopy> copies;
        int newCount = 1;
        public bool newform=false;

        bool update = true;
      
       public frmBookdetail() 
        {
            InitializeComponent();
        }

        private void Bookcopies_Load(object sender, EventArgs e)
        {
            context = new LibraryEntities();
            if (newform == false)
            {
                var b = context.Books.First(x => x.BookID == bookid);
                txtBookID.Text = b.BookID.ToString();
                txtAuthor.Text = b.Author;
                txtISBN.Text = b.ISBN.ToString();
                txtEdition.Text = b.Edition.ToString();
                txtPublisher.Text = b.Publisher.ToString();

                cboCatagoyName.DataSource = context.BookCategories;
                cboCatagoyName.SelectedValue = b.CategoryID;

                txtTitle.Text = b.Title.ToString();

                //var bc = context.BookCopies.First(x => x.BookID == bookid);

                //txtBookIDcopy.Text = bc.BookID.ToString();
                //txtBookCopy.Text = bc.BookCopyID.ToString();

                var q = from x in context.BookCopies
                        where x.BookID == bookid
                        select x;
                //copies = context.BookCopies.ToList<BookCopy>(x => x.BookID == bookid);

                copies = q.ToList<BookCopy>();
                originalcopies = q.ToList<BookCopy>();
                dgvcopy.DataSource = q.ToList();
                dgvcopy.Refresh();

                // BindingContext[context.BookCopies].AddNew();
            }
            else
            {
                var lastBook = (from x in context.Books
                                    select x).OrderByDescending(x => x.BookID).Take(1);
                foreach (Book book in lastBook)
                {
                    txtBookID.Text = (book.BookID + 1).ToString();   
                }
                var q = from x in context.BookCopies
                        where x.BookID == bookid
                        select x;
                //copies = context.BookCopies.ToList<BookCopy>(x => x.BookID == bookid);
                originalcopies = q.ToList<BookCopy>();
                copies = q.ToList<BookCopy>();

                cboCatagoyName.DataSource = context.BookCategories;
                cboCatagoyName.SelectedIndex = 0;
            }
       }


        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bookid!=0)
            {
                SaveBookMasterInfo();
            }
            else 
            {
                AddNewBook();
            }
            MessageBox.Show("Successfully Update !");
            Bookcopies_Load(sender, e);
        }

        private void SaveBookMasterInfo()
        {          
                var book = context.Books.First(x => x.BookID == bookid);

                book.Author = txtAuthor.Text;
                book.CategoryID = Convert.ToInt32(cboCatagoyName.SelectedValue);
                book.Edition = int.Parse(txtEdition.Text);
                book.ISBN = txtISBN.Text;
                book.Publisher = txtPublisher.Text;
                book.Title = txtTitle.Text;
                book.YearOfPublishion = dtPickerYearofPublish.Value;
                SaveBookDetail();
                AddNewBookDetail();

                context.SaveChanges();
        }

        public void SaveBookDetail()
        {
            
            foreach(BookCopy ob in originalcopies)
            {
                bool update = false;
                foreach (BookCopy b in copies)
                {
                    BookCopy bookcopy = context.BookCopies.FirstOrDefault(c => c.BookCopyID == ob.BookCopyID);
                    if (ob.BookCopyID == b.BookCopyID && bookcopy!=null) // Update existing record
                    {
                        bookcopy.BookShelfNo = ob.BookShelfNo;
                        context.SaveChanges();

                        update = true;
                    }
                }
                if (update==false)   // Must be deleted row
                {
                    BookCopy bookcopy = context.BookCopies.FirstOrDefault(c => c.BookCopyID == ob.BookCopyID);
                    context.BookCopies.DeleteObject(bookcopy);
                    context.SaveChanges();
                }
            }
        }

        public void AddNewBookDetail()
        {
            foreach (BookCopy b in copies)
            {
                int count=0;
                foreach (BookCopy ob in originalcopies)
                {
                    if (ob.BookCopyID != b.BookCopyID) 
                    {
                        count++;
                    }
                }
                if (count == originalcopies.Count)   // No exist in database (New)
                {
                    BookCopy bookCopy = new BookCopy();
                    bookCopy.BookID = b.BookID;
                    bookCopy.BookShelfNo = b.BookShelfNo;
                    bookCopy.Status = b.Status;
                    context.BookCopies.AddObject(bookCopy);
                }
            }
        }

        private void btnDeletecopy_Click(object sender, EventArgs e)
        {
            int index=0;
            int count = 0;
            int deletedCopyID = (int)dgvcopy.SelectedRows[0].Cells[0].Value;

            foreach(BookCopy copy  in copies)
            {
                if (copy.BookCopyID ==deletedCopyID)
                {
                    index = count;
                }
                count++;
            }
            copies.RemoveAt(index);
            dgvcopy.DataSource = copies.ToList();
            
            dgvcopy.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewBook()
        {
            var book = new Book();

            book.Author = txtAuthor.Text;
            book.CategoryID = Convert.ToInt32(cboCatagoyName.SelectedValue.ToString());
            book.Edition = Convert.ToInt32(txtEdition.Text);
            book.ISBN = txtISBN.Text;
            book.Publisher = txtPublisher.Text;
            book.Title = txtTitle.Text;
            book.YearOfPublishion = dtPickerYearofPublish.Value;

            foreach(BookCopy c in copies)
            {
                BookCopy newCopy = new BookCopy();
                newCopy.BookID = c.BookID;
                newCopy.BookCopyID = c.BookCopyID;
                newCopy.Status = c.Status;
                newCopy.BookShelfNo = c.BookShelfNo;

                book.BookCopies.Add(newCopy);
            }

            context.Books.AddObject(book);
            context.SaveChanges();

            // update latest no in Number
            var lastBookCopy = (from x in context.Books
                                select x).OrderByDescending(x => x.BookID).Take(1);
            foreach(Book b in lastBookCopy)
            {
                bookid = b.BookID;                
            }
            newform = false;
        }

        
        private void dgvcopy_SelectionChanged(object sender, EventArgs e)
        {
          try
            {
              txtBookCopyID.Text = dgvcopy.SelectedRows[0].Cells[0].Value.ToString();
              txtBookIDD.Text = dgvcopy.SelectedRows[0].Cells[1].Value.ToString();
              txtShelfNo.Text = dgvcopy.SelectedRows[0].Cells[2].Value.ToString();
              txtStatus.Text = dgvcopy.SelectedRows[0].Cells[3].Value.ToString();

              update = true;
             }
            catch (Exception ec)
            {

            }
        }

        private void btnNewCopy_Click(object sender, EventArgs e)
        {
                var lastBookCopy = (from x in context.BookCopies
                                select x).OrderByDescending(x=>x.BookCopyID).Take(1);
                foreach(BookCopy bookCopy in lastBookCopy)
                {
                    txtBookCopyID.Text = (bookCopy.BookCopyID + newCount).ToString();
                    txtBookIDD.Text = txtBookID.Text;
                    txtStatus.Text = "Available";
                    txtShelfNo.Text = "";
                    update = false;
                }
 
                //BookCopy bookcp = from x in context.BookCopies
                //             orderby x.BookCopyID descending
                //             select x;
                   

                //bookcp.Status = "Available";
                //bookcp.BookShelfNo = txtShelfNo.Text;

                ////bookcp.BookCopyID = Convert.ToInt32(txtBookCopy.Text);
                //book.BookCopies.Add(bookcp);
                ////AddNew();
                //// context.Books.AddObject(book);
                //context.SaveChanges();
            
            //catch (Exception ec)
            //{
            //    throw new Exception("Cannot Add new!");
            //}
           
        }

        private BookCopy SearchID(int id)
        {
            foreach (BookCopy copy in copies)
            {
                if (copy.BookCopyID == id)
                {
                    return copy;
                }
            }
            return null;
        }

        private void btnEditcopy_Click(object sender, EventArgs e)
        {

            BookCopy bc;
            int bookCopyId = Convert.ToInt32(txtBookCopyID.Text);

            if (update == false)
            {
                bc = new BookCopy();
                bc.BookCopyID = Convert.ToInt32(txtBookCopyID.Text);
                bc.BookID = Convert.ToInt32(txtBookID.Text);
            }
            else
                bc = SearchID(bookCopyId);

            bc.BookShelfNo = txtShelfNo.Text;
            bc.Status = txtStatus.Text;

            if(update==false)
                copies.Add(bc);
            //if (update == false)
            //{
            //    context.BookCopies.AddObject(bc);
            //}

            dgvcopy.DataSource = copies.ToList();
            dgvcopy.Refresh();
            update = true;
            //context.SaveChanges();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
