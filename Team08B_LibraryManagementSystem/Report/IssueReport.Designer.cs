namespace Team08B_LibraryManagementSystem
{
    partial class IssueReport
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
            this.crvReceipt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReceipt
            // 
            this.crvReceipt.ActiveViewIndex = -1;
            this.crvReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReceipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReceipt.Location = new System.Drawing.Point(0, 0);
            this.crvReceipt.Name = "crvReceipt";
            this.crvReceipt.Size = new System.Drawing.Size(740, 618);
            this.crvReceipt.TabIndex = 0;
            // 
            // IssueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 618);
            this.Controls.Add(this.crvReceipt);
            this.Name = "IssueReport";
            this.Text = "IssueReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IssueReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReceipt;
        //private Receipt Receipt1;
        //private PrintReceipt PrintReceipt1;

    }
}