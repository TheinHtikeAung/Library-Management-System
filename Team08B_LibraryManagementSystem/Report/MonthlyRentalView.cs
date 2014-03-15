using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Team08B_LibraryManagementSystem
{
    public partial class MonthlyRentalView : Form
    {
        SqlDataAdapter da;
        public MonthlyRentalView()
        {
            InitializeComponent();
        }

        private void MonthlyRentalView_Load(object sender, EventArgs e)
        {
            Team08B_LibraryManagementSystemDataSet ds = new Team08B_LibraryManagementSystemDataSet();
            Team08B_LibraryManagementSystemDataSetTableAdapters.MonthlyrentalTableAdapter ta = new Team08B_LibraryManagementSystemDataSetTableAdapters.MonthlyrentalTableAdapter();
            ta.Fill(ds.Monthlyrental);
            month mrental = new month();
            mrental.SetDataSource(ds);
            crvMontlyrental.ReportSource = mrental;
            
         }
    }
}
