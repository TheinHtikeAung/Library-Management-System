namespace Team08B_LibraryManagementSystem
{
    partial class overdue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvOverDue = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.team08B_LibraryDataSet1 = new Team08B_LibraryManagementSystem.Team08B_LibraryManagementSystemDataSet();
            this.DueView1 = new Team08B_LibraryManagementSystem.DueView();
            ((System.ComponentModel.ISupportInitialize)(this.team08B_LibraryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // crvOverDue
            // 
            this.crvOverDue.ActiveViewIndex = -1;
            this.crvOverDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvOverDue.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvOverDue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvOverDue.Location = new System.Drawing.Point(0, 0);
            this.crvOverDue.Name = "crvOverDue";
            this.crvOverDue.Size = new System.Drawing.Size(679, 288);
            this.crvOverDue.TabIndex = 0;
            // 
            // team08B_LibraryDataSet1
            // 
            this.team08B_LibraryDataSet1.DataSetName = "Team08B_LibraryDataSet";
            this.team08B_LibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // overdue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 288);
            this.Controls.Add(this.crvOverDue);
            this.Name = "overdue";
            this.Text = "OverDue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.overdue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.team08B_LibraryDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvOverDue;
        private Team08B_LibraryManagementSystemDataSet team08B_LibraryDataSet1;
        private DueView DueView1;
    }
}