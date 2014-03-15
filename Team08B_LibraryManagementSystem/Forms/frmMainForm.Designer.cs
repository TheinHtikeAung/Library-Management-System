namespace Team08B_LibraryManagementSystem
{
    partial class frmMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.mnuLibrary = new System.Windows.Forms.MenuStrip();
            this.maintaineseFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookByVariousCriteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overdueBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // mnuLibrary
            // 
            this.mnuLibrary.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuLibrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintaineseFormsToolStripMenuItem,
            this.issueFormsToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.printReportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuLibrary.Location = new System.Drawing.Point(0, 0);
            this.mnuLibrary.Name = "mnuLibrary";
            this.mnuLibrary.Size = new System.Drawing.Size(1056, 25);
            this.mnuLibrary.TabIndex = 1;
            this.mnuLibrary.Text = "menuStrip1";
            // 
            // maintaineseFormsToolStripMenuItem
            // 
            this.maintaineseFormsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberFormToolStripMenuItem,
            this.bookFormToolStripMenuItem});
            this.maintaineseFormsToolStripMenuItem.Name = "maintaineseFormsToolStripMenuItem";
            this.maintaineseFormsToolStripMenuItem.Size = new System.Drawing.Size(94, 21);
            this.maintaineseFormsToolStripMenuItem.Text = "Maintenance";
            // 
            // memberFormToolStripMenuItem
            // 
            this.memberFormToolStripMenuItem.Name = "memberFormToolStripMenuItem";
            this.memberFormToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.memberFormToolStripMenuItem.Text = "Member";
            this.memberFormToolStripMenuItem.Click += new System.EventHandler(this.memberFormToolStripMenuItem_Click);
            // 
            // bookFormToolStripMenuItem
            // 
            this.bookFormToolStripMenuItem.Name = "bookFormToolStripMenuItem";
            this.bookFormToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.bookFormToolStripMenuItem.Text = "Book";
            this.bookFormToolStripMenuItem.Click += new System.EventHandler(this.bookFormToolStripMenuItem_Click);
            // 
            // issueFormsToolStripMenuItem
            // 
            this.issueFormsToolStripMenuItem.Name = "issueFormsToolStripMenuItem";
            this.issueFormsToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.issueFormsToolStripMenuItem.Text = "Issue";
            this.issueFormsToolStripMenuItem.Click += new System.EventHandler(this.issueFormsToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookByVariousCriteriaToolStripMenuItem,
            this.loanBookToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // bookByVariousCriteriaToolStripMenuItem
            // 
            this.bookByVariousCriteriaToolStripMenuItem.Name = "bookByVariousCriteriaToolStripMenuItem";
            this.bookByVariousCriteriaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.bookByVariousCriteriaToolStripMenuItem.Text = "Book by various criteria";
            this.bookByVariousCriteriaToolStripMenuItem.Click += new System.EventHandler(this.bookByVariousCriteriaToolStripMenuItem_Click);
            // 
            // loanBookToolStripMenuItem
            // 
            this.loanBookToolStripMenuItem.Name = "loanBookToolStripMenuItem";
            this.loanBookToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.loanBookToolStripMenuItem.Text = "Loan Book";
            this.loanBookToolStripMenuItem.Click += new System.EventHandler(this.loanBookToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(928, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "@Team8 B";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Team08B_LibraryManagementSystem.Properties.Resources.library_management_system;
            this.pictureBox1.Location = new System.Drawing.Point(45, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 181);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // printReportToolStripMenuItem
            // 
            this.printReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyRentalToolStripMenuItem,
            this.overdueBooksToolStripMenuItem});
            this.printReportToolStripMenuItem.Name = "printReportToolStripMenuItem";
            this.printReportToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.printReportToolStripMenuItem.Text = "Print Report";
            // 
            // monthlyRentalToolStripMenuItem
            // 
            this.monthlyRentalToolStripMenuItem.Name = "monthlyRentalToolStripMenuItem";
            this.monthlyRentalToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.monthlyRentalToolStripMenuItem.Text = "Monthly Rental";
            this.monthlyRentalToolStripMenuItem.Click += new System.EventHandler(this.monthlyRentalToolStripMenuItem_Click);
            // 
            // overdueBooksToolStripMenuItem
            // 
            this.overdueBooksToolStripMenuItem.Name = "overdueBooksToolStripMenuItem";
            this.overdueBooksToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.overdueBooksToolStripMenuItem.Text = "Overdue Books";
            this.overdueBooksToolStripMenuItem.Click += new System.EventHandler(this.overdueBooksToolStripMenuItem_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 618);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuLibrary);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuLibrary;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainForm";
            this.Text = "Library Management System By @Team08B";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mnuLibrary.ResumeLayout(false);
            this.mnuLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuLibrary;
        private System.Windows.Forms.ToolStripMenuItem maintaineseFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem bookByVariousCriteriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overdueBooksToolStripMenuItem;
    }
}

