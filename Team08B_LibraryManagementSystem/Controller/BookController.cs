using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Team08B_LibraryManagementSystem
{
    class BookController
    {
        LibraryEntities context;

        public BookController()
        {
             context= new LibraryEntities();
        }

        public LibraryEntities getContext()
        {
            return context;
        }

        public IList getBookCopies(int currentCell)
        {
            var query = from bc in context.BookCopies
                        where bc.BookID == currentCell
                        select new { bc.BookCopyID, bc.BookShelfNo, bc.Status, bc.BookID };

            return query.ToList();
        }

        public void deleteBook(int bookID)
        {
                var book = new Book();
                book = context.Books.First(c => c.BookID == bookID);
                context.Books.DeleteObject(book);
                context.SaveChanges();
        }
    }
}
