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
    public partial class overdue : Form
    {
        public overdue()
        {
            InitializeComponent();
        }

        private void overdue_Load(object sender, EventArgs e)
        {
            Team08B_LibraryManagementSystemDataSet ds = new Team08B_LibraryManagementSystemDataSet();
            Team08B_LibraryManagementSystemDataSetTableAdapters.overdueloansTableAdapter ta = new Team08B_LibraryManagementSystemDataSetTableAdapters.overdueloansTableAdapter();
                      DueView ov=new DueView();
            ta.Fill(ds.overdueloans);
                        ov.SetDataSource(ds);
                        crvOverDue.ReportSource = ov;
        }
    }
}
