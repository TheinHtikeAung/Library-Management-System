namespace Team08B_LibraryManagementSystem
{
    partial class frmBookMaintenance
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
            this.components = new System.ComponentModel.Container();
            this.gboBookcopy = new System.Windows.Forms.GroupBox();
            this.dgvcopies = new System.Windows.Forms.DataGridView();
            this.gbocategory = new System.Windows.Forms.GroupBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.dgvbook = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.bookCopyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookShelfNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCopyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getBookSPResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gboBookcopy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcopies)).BeginInit();
            this.gbocategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCopyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getBookSPResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gboBookcopy
            // 
            this.gboBookcopy.Controls.Add(this.dgvcopies);
            this.gboBookcopy.Location = new System.Drawing.Point(13, 427);
            this.gboBookcopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboBookcopy.Name = "gboBookcopy";
            this.gboBookcopy.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboBookcopy.Size = new System.Drawing.Size(648, 239);
            this.gboBookcopy.TabIndex = 5;
            this.gboBookcopy.TabStop = false;
            this.gboBookcopy.Text = "Copies Detail";
            // 
            // dgvcopies
            // 
            this.dgvcopies.AutoGenerateColumns = false;
            this.dgvcopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcopies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookCopyIDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn1,
            this.bookShelfNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.bookDataGridViewTextBoxColumn,
            this.issueDetailsDataGridViewTextBoxColumn});
            this.dgvcopies.DataSource = this.bookCopyBindingSource;
            this.dgvcopies.Location = new System.Drawing.Point(19, 42);
            this.dgvcopies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvcopies.MultiSelect = false;
            this.dgvcopies.Name = "dgvcopies";
            this.dgvcopies.ReadOnly = true;
            this.dgvcopies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcopies.Size = new System.Drawing.Size(609, 179);
            this.dgvcopies.TabIndex = 0;
            // 
            // gbocategory
            // 
            this.gbocategory.Controls.Add(this.txtCategoryName);
            this.gbocategory.Controls.Add(this.txtCategoryID);
            this.gbocategory.Controls.Add(this.label1);
            this.gbocategory.Controls.Add(this.lblCategoryName);
            this.gbocategory.Location = new System.Drawing.Point(680, 427);
            this.gbocategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbocategory.Name = "gbocategory";
            this.gbocategory.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbocategory.Size = new System.Drawing.Size(361, 149);
            this.gbocategory.TabIndex = 4;
            this.gbocategory.TabStop = false;
            this.gbocategory.Text = "Category";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(143, 82);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.ReadOnly = true;
            this.txtCategoryName.Size = new System.Drawing.Size(208, 27);
            this.txtCategoryName.TabIndex = 4;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(143, 37);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(208, 27);
            this.txtCategoryID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "CategoryName";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(23, 42);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(84, 20);
            this.lblCategoryName.TabIndex = 3;
            this.lblCategoryName.Text = "CategoryID";
            // 
            // dgvbook
            // 
            this.dgvbook.AllowUserToAddRows = false;
            this.dgvbook.AutoGenerateColumns = false;
            this.dgvbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvbook.DataSource = this.getBookSPResultBindingSource;
            this.dgvbook.Location = new System.Drawing.Point(13, 14);
            this.dgvbook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvbook.MultiSelect = false;
            this.dgvbook.Name = "dgvbook";
            this.dgvbook.ReadOnly = true;
            this.dgvbook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbook.Size = new System.Drawing.Size(1258, 403);
            this.dgvbook.TabIndex = 3;
            this.dgvbook.SelectionChanged += new System.EventHandler(this.dgvbook_SelectionChanged);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(420, 676);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(100, 35);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "&Detail...";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(800, 676);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(669, 676);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Location = new System.Drawing.Point(545, 676);
            this.btnAddNewBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(100, 35);
            this.btnAddNewBook.TabIndex = 11;
            this.btnAddNewBook.Text = "Add &New";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(303, 676);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // bookCopyIDDataGridViewTextBoxColumn
            // 
            this.bookCopyIDDataGridViewTextBoxColumn.DataPropertyName = "BookCopyID";
            this.bookCopyIDDataGridViewTextBoxColumn.HeaderText = "Book Copy ID";
            this.bookCopyIDDataGridViewTextBoxColumn.Name = "bookCopyIDDataGridViewTextBoxColumn";
            this.bookCopyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookCopyIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // bookIDDataGridViewTextBoxColumn1
            // 
            this.bookIDDataGridViewTextBoxColumn1.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn1.HeaderText = "Book ID";
            this.bookIDDataGridViewTextBoxColumn1.Name = "bookIDDataGridViewTextBoxColumn1";
            this.bookIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bookShelfNoDataGridViewTextBoxColumn
            // 
            this.bookShelfNoDataGridViewTextBoxColumn.DataPropertyName = "BookShelfNo";
            this.bookShelfNoDataGridViewTextBoxColumn.HeaderText = "Book Shelf No";
            this.bookShelfNoDataGridViewTextBoxColumn.Name = "bookShelfNoDataGridViewTextBoxColumn";
            this.bookShelfNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookShelfNoDataGridViewTextBoxColumn.Width = 130;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookDataGridViewTextBoxColumn
            // 
            this.bookDataGridViewTextBoxColumn.DataPropertyName = "Book";
            this.bookDataGridViewTextBoxColumn.HeaderText = "Book";
            this.bookDataGridViewTextBoxColumn.Name = "bookDataGridViewTextBoxColumn";
            this.bookDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookDataGridViewTextBoxColumn.Visible = false;
            // 
            // issueDetailsDataGridViewTextBoxColumn
            // 
            this.issueDetailsDataGridViewTextBoxColumn.DataPropertyName = "IssueDetails";
            this.issueDetailsDataGridViewTextBoxColumn.HeaderText = "IssueDetails";
            this.issueDetailsDataGridViewTextBoxColumn.Name = "issueDetailsDataGridViewTextBoxColumn";
            this.issueDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            this.issueDetailsDataGridViewTextBoxColumn.Visible = false;
            // 
            // bookCopyBindingSource
            // 
            this.bookCopyBindingSource.DataSource = typeof(Team08B_LibraryManagementSystem.BookCopy);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BookID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Book ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn2.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn3.HeaderText = "Title";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CategoryDescription";
            this.dataGridViewTextBoxColumn4.HeaderText = "Category";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn5.HeaderText = "Author";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Publisher";
            this.dataGridViewTextBoxColumn6.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Edition";
            this.dataGridViewTextBoxColumn7.HeaderText = "Edition";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "YearOfPublishion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Published Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CategoryID";
            this.dataGridViewTextBoxColumn9.HeaderText = "CategoryID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // getBookSPResultBindingSource
            // 
            this.getBookSPResultBindingSource.DataSource = typeof(Team08B_LibraryManagementSystem.GetBookSP_Result);
            // 
            // frmBookMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 737);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.gboBookcopy);
            this.Controls.Add(this.gbocategory);
            this.Controls.Add(this.dgvbook);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBookMaintenance";
            this.Text = "Book Maintenance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookMaintenance_Load);
            this.gboBookcopy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcopies)).EndInit();
            this.gbocategory.ResumeLayout(false);
            this.gbocategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCopyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getBookSPResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboBookcopy;
        private System.Windows.Forms.GroupBox gbocategory;
        private System.Windows.Forms.DataGridView dgvbook;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.DataGridView dgvcopies;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.BindingSource bookCopyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfPublishionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCopyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookShelfNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getBookSPResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnRefresh;
    }
}