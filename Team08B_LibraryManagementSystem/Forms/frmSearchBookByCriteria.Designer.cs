namespace Team08B_LibraryManagementSystem
{
    partial class frmSearchBookByCriteria
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
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.dgvBookInfo = new System.Windows.Forms.DataGridView();
            this.bookCopyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfPublishionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookShelfNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getBookByCriteriaResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchGroupBox.SuspendLayout();
            this.BookInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getBookByCriteriaResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.btnClose);
            this.searchGroupBox.Controls.Add(this.txtKeyword);
            this.searchGroupBox.Controls.Add(this.label2);
            this.searchGroupBox.Controls.Add(this.btnSearch);
            this.searchGroupBox.Controls.Add(this.cboSearchBy);
            this.searchGroupBox.Controls.Add(this.label1);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 14);
            this.searchGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchGroupBox.Size = new System.Drawing.Size(714, 159);
            this.searchGroupBox.TabIndex = 1;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Choose Criteria";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(563, 46);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 31);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(197, 103);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(303, 27);
            this.txtKeyword.TabIndex = 2;
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyword_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Keyword :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(563, 101);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "All",
            "Copy Book ID",
            "ISBN",
            "Title",
            "Category Description",
            "Author",
            "Publisher",
            "Edition",
            "Year Of Publishion"});
            this.cboSearchBy.Location = new System.Drawing.Point(197, 46);
            this.cboSearchBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(303, 28);
            this.cboSearchBy.TabIndex = 1;
            this.cboSearchBy.SelectedIndexChanged += new System.EventHandler(this.cboSearchBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By :";
            // 
            // BookInfoGroupBox
            // 
            this.BookInfoGroupBox.Controls.Add(this.dgvBookInfo);
            this.BookInfoGroupBox.Location = new System.Drawing.Point(12, 193);
            this.BookInfoGroupBox.Name = "BookInfoGroupBox";
            this.BookInfoGroupBox.Size = new System.Drawing.Size(1260, 523);
            this.BookInfoGroupBox.TabIndex = 3;
            this.BookInfoGroupBox.TabStop = false;
            this.BookInfoGroupBox.Text = "Book Information";
            // 
            // dgvBookInfo
            // 
            this.dgvBookInfo.AutoGenerateColumns = false;
            this.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookCopyIDDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.categoryDescriptionDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.editionDataGridViewTextBoxColumn,
            this.yearOfPublishionDataGridViewTextBoxColumn,
            this.bookShelfNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvBookInfo.DataSource = this.getBookByCriteriaResultBindingSource;
            this.dgvBookInfo.Location = new System.Drawing.Point(19, 26);
            this.dgvBookInfo.MultiSelect = false;
            this.dgvBookInfo.Name = "dgvBookInfo";
            this.dgvBookInfo.ReadOnly = true;
            this.dgvBookInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookInfo.Size = new System.Drawing.Size(1224, 484);
            this.dgvBookInfo.TabIndex = 1;
            // 
            // bookCopyIDDataGridViewTextBoxColumn
            // 
            this.bookCopyIDDataGridViewTextBoxColumn.DataPropertyName = "BookCopyID";
            this.bookCopyIDDataGridViewTextBoxColumn.HeaderText = "Book Copy ID";
            this.bookCopyIDDataGridViewTextBoxColumn.Name = "bookCopyIDDataGridViewTextBoxColumn";
            this.bookCopyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookCopyIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            this.iSBNDataGridViewTextBoxColumn.Width = 120;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 350;
            // 
            // categoryDescriptionDataGridViewTextBoxColumn
            // 
            this.categoryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CategoryDescription";
            this.categoryDescriptionDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDescriptionDataGridViewTextBoxColumn.Name = "categoryDescriptionDataGridViewTextBoxColumn";
            this.categoryDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDescriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn.Width = 150;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            this.publisherDataGridViewTextBoxColumn.Width = 150;
            // 
            // editionDataGridViewTextBoxColumn
            // 
            this.editionDataGridViewTextBoxColumn.DataPropertyName = "Edition";
            this.editionDataGridViewTextBoxColumn.HeaderText = "Edition";
            this.editionDataGridViewTextBoxColumn.Name = "editionDataGridViewTextBoxColumn";
            this.editionDataGridViewTextBoxColumn.ReadOnly = true;
            this.editionDataGridViewTextBoxColumn.Width = 60;
            // 
            // yearOfPublishionDataGridViewTextBoxColumn
            // 
            this.yearOfPublishionDataGridViewTextBoxColumn.DataPropertyName = "YearOfPublishion";
            this.yearOfPublishionDataGridViewTextBoxColumn.HeaderText = "Published Date";
            this.yearOfPublishionDataGridViewTextBoxColumn.Name = "yearOfPublishionDataGridViewTextBoxColumn";
            this.yearOfPublishionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookShelfNoDataGridViewTextBoxColumn
            // 
            this.bookShelfNoDataGridViewTextBoxColumn.DataPropertyName = "BookShelfNo";
            this.bookShelfNoDataGridViewTextBoxColumn.HeaderText = "Shelf No";
            this.bookShelfNoDataGridViewTextBoxColumn.Name = "bookShelfNoDataGridViewTextBoxColumn";
            this.bookShelfNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getBookByCriteriaResultBindingSource
            // 
            this.getBookByCriteriaResultBindingSource.DataSource = typeof(Team08B_LibraryManagementSystem.GetBookByCriteria_Result);
            // 
            // frmSearchBookByCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 732);
            this.Controls.Add(this.BookInfoGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSearchBookByCriteria";
            this.Text = "Search Book By Various Criteria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SearchBookByCriteria_Load);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.BookInfoGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getBookByCriteriaResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearchBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox BookInfoGroupBox;
        private System.Windows.Forms.DataGridView dgvBookInfo;
        private System.Windows.Forms.BindingSource getBookByCriteriaResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCopyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfPublishionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookShelfNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
    }
}