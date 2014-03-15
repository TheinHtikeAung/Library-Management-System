using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;


namespace Team08B_LibraryManagementSystem
{
    public partial class IssueReport : Form
    {
        int issueID;

        public IssueReport()
        {
            InitializeComponent();
        }

        public IssueReport(int issueID)
        {
            this.issueID = issueID;
            InitializeComponent();            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
       
        private void IssueReport_Load(object sender, EventArgs e)
        {

            Team08B_LibraryManagementSystemDataSet ds = new Team08B_LibraryManagementSystemDataSet();
            Team08B_LibraryManagementSystemDataSetTableAdapters.ReceiptTableAdapter ta = new Team08B_LibraryManagementSystemDataSetTableAdapters.ReceiptTableAdapter();
            PrintReceipt r = new PrintReceipt();
            //Issue s = new Issue();
            ta.Fill(ds.Receipt,issueID);
            r.SetDataSource(ds);
            crvReceipt.ReportSource = r;
                      
        }

   }
}
