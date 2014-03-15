using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team08B_LibraryManagementSystem
{
    public class IssueController
    {
        LibraryEntities context;
        List<BookInfo_Result> bookList = new List<BookInfo_Result>();
        Issue issue;

        public IssueController()
        {
            context = new LibraryEntities();           
          
        }

        public string GetMember(int memberId)
        {
            Member member = context.Members.First(x => x.MemberID.Equals(memberId));
            string memberName = member.FirstName.ToString() + " " + member.LastName.ToString();
            return memberName;
        }

        public int GetBookCountLoanByMember(int memberId)
        { 
            IList<BookLendByMemberSP_Result> list = context.BookLendByMemberSP(memberId).ToList<BookLendByMemberSP_Result>();

            return list.Count();
        }

              
        public BookInfo_Result GetBookByBookId(int bookId)
        {
            BookInfo_Result book = context.BookInfo(bookId).FirstOrDefault<BookInfo_Result>();
            return book;
        }

        public void CreateIssueObject(int memberId)
        {
            issue = new Issue();
            issue.MemberID = memberId;
            issue.IssueDate = DateTime.Now.Date;
            issue.DueDate = DateTime.Now.Date.AddDays(14);
            context.Issues.AddObject(issue);
            context.SaveChanges();
        }

        public void ChangeBookStatus(int bookCopyId)
        {
            BookCopy bookCopy = context.BookCopies.First(x => x.BookCopyID.Equals(bookCopyId));
            bookCopy.Status = "Lend";
            context.SaveChanges();
        }

        public void UpdateIssueDetails(int bookCopyId)
        {
            IssueDetail issueDetail = new IssueDetail();
            BookCopy bookCopy = context.BookCopies.First(x => x.BookCopyID.Equals(bookCopyId));
            issueDetail.BookCopy = bookCopy;
            issueDetail.Issue = issue;
            issue.IssueDetails.Add(issueDetail);
            context.SaveChanges();
        }

        public int GetIssueID()
        {
            Issue issue= (from x in context.Issues select x).OrderByDescending(x => x.IssueID).Take(1).First<Issue>();
            return issue.IssueID;
        }

        public void GenerateReport()
        {
            IssueReport issueReport = new IssueReport(GetIssueID());
            issueReport.ShowDialog();
        }
    }
    
}
