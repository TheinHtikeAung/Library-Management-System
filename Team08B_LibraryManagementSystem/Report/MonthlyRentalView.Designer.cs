namespace Team08B_LibraryManagementSystem
{
    partial class MonthlyRentalView
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
            this.crvMontlyrental = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.team08B_LibraryDataSet1 = new Team08B_LibraryManagementSystem.Team08B_LibraryManagementSystemDataSet();
            this.month1 = new Team08B_LibraryManagementSystem.month();
            ((System.ComponentModel.ISupportInitialize)(this.team08B_LibraryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // crvMontlyrental
            // 
            this.crvMontlyrental.ActiveViewIndex = -1;
            this.crvMontlyrental.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMontlyrental.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvMontlyrental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMontlyrental.Location = new System.Drawing.Point(0, 0);
            this.crvMontlyrental.Name = "crvMontlyrental";
            this.crvMontlyrental.Size = new System.Drawing.Size(579, 306);
            this.crvMontlyrental.TabIndex = 0;
            // 
            // team08B_LibraryDataSet1
            // 
            this.team08B_LibraryDataSet1.DataSetName = "Team08B_LibraryDataSet";
            this.team08B_LibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MonthlyRentalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 306);
            this.Controls.Add(this.crvMontlyrental);
            this.Name = "MonthlyRentalView";
            this.Text = "MonthlyRentalView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MonthlyRentalView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.team08B_LibraryDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMontlyrental;
        private Team08B_LibraryManagementSystemDataSet team08B_LibraryDataSet1;
        private month month1;
       
    }
}