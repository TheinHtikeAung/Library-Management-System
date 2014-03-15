namespace Team08B_LibraryManagementSystem
{
    partial class frmBookdetail
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
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label bookIDLabel;
            System.Windows.Forms.Label editionLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label publisherLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label yearOfPublishionLabel;
            System.Windows.Forms.Label bookCopyIDLabel;
            System.Windows.Forms.Label bookIDLabel1;
            System.Windows.Forms.Label bookShelfNoLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label label1;
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dtPickerYearofPublish = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCatagoyName = new System.Windows.Forms.ComboBox();
            this.bookCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNewCopy = new System.Windows.Forms.Button();
            this.btnEditcopy = new System.Windows.Forms.Button();
            this.btnDeletecopy = new System.Windows.Forms.Button();
            this.txtBookCopyID = new System.Windows.Forms.TextBox();
            this.bookCopyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBookIDD = new System.Windows.Forms.TextBox();
            this.txtShelfNo = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.dgvcopy = new System.Windows.Forms.DataGridView();
            this.bookCopyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookShelfNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.team08BLibraryEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            authorLabel = new System.Windows.Forms.Label();
            bookIDLabel = new System.Windows.Forms.Label();
            editionLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            publisherLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            yearOfPublishionLabel = new System.Windows.Forms.Label();
            bookCopyIDLabel = new System.Windows.Forms.Label();
            bookIDLabel1 = new System.Windows.Forms.Label();
            bookShelfNoLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookCopyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team08BLibraryEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(29, 341);
            authorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(57, 20);
            authorLabel.TabIndex = 1;
            authorLabel.Text = "Author:";
            // 
            // bookIDLabel
            // 
            bookIDLabel.AutoSize = true;
            bookIDLabel.Location = new System.Drawing.Point(29, 46);
            bookIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bookIDLabel.Name = "bookIDLabel";
            bookIDLabel.Size = new System.Drawing.Size(65, 20);
            bookIDLabel.TabIndex = 3;
            bookIDLabel.Text = "Book ID:";
            // 
            // editionLabel
            // 
            editionLabel.AutoSize = true;
            editionLabel.Location = new System.Drawing.Point(29, 242);
            editionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            editionLabel.Name = "editionLabel";
            editionLabel.Size = new System.Drawing.Size(59, 20);
            editionLabel.TabIndex = 7;
            editionLabel.Text = "Edition:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(29, 95);
            iSBNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(44, 20);
            iSBNLabel.TabIndex = 9;
            iSBNLabel.Text = "ISBN:";
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new System.Drawing.Point(29, 295);
            publisherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new System.Drawing.Size(72, 20);
            publisherLabel.TabIndex = 11;
            publisherLabel.Text = "Publisher:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(29, 190);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(41, 20);
            titleLabel.TabIndex = 13;
            titleLabel.Text = "Title:";
            // 
            // yearOfPublishionLabel
            // 
            yearOfPublishionLabel.AutoSize = true;
            yearOfPublishionLabel.Location = new System.Drawing.Point(26, 391);
            yearOfPublishionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            yearOfPublishionLabel.Name = "yearOfPublishionLabel";
            yearOfPublishionLabel.Size = new System.Drawing.Size(133, 20);
            yearOfPublishionLabel.TabIndex = 15;
            yearOfPublishionLabel.Text = "Year Of Publishion:";
            // 
            // bookCopyIDLabel
            // 
            bookCopyIDLabel.AutoSize = true;
            bookCopyIDLabel.Location = new System.Drawing.Point(27, 280);
            bookCopyIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bookCopyIDLabel.Name = "bookCopyIDLabel";
            bookCopyIDLabel.Size = new System.Drawing.Size(103, 20);
            bookCopyIDLabel.TabIndex = 1;
            bookCopyIDLabel.Text = "Book Copy ID:";
            // 
            // bookIDLabel1
            // 
            bookIDLabel1.AutoSize = true;
            bookIDLabel1.Location = new System.Drawing.Point(27, 320);
            bookIDLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bookIDLabel1.Name = "bookIDLabel1";
            bookIDLabel1.Size = new System.Drawing.Size(65, 20);
            bookIDLabel1.TabIndex = 3;
            bookIDLabel1.Text = "Book ID:";
            // 
            // bookShelfNoLabel
            // 
            bookShelfNoLabel.AutoSize = true;
            bookShelfNoLabel.Location = new System.Drawing.Point(27, 360);
            bookShelfNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bookShelfNoLabel.Name = "bookShelfNoLabel";
            bookShelfNoLabel.Size = new System.Drawing.Size(107, 20);
            bookShelfNoLabel.TabIndex = 5;
            bookShelfNoLabel.Text = "Book Shelf No:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(27, 400);
            statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(52, 20);
            statusLabel.TabIndex = 7;
            statusLabel.Text = "Status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(29, 141);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 20);
            label1.TabIndex = 5;
            label1.Text = "Category Name:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(167, 337);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(265, 27);
            this.txtAuthor.TabIndex = 2;
            // 
            // txtBookID
            // 
            this.txtBookID.Enabled = false;
            this.txtBookID.Location = new System.Drawing.Point(167, 42);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(265, 27);
            this.txtBookID.TabIndex = 4;
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(167, 238);
            this.txtEdition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(265, 27);
            this.txtEdition.TabIndex = 8;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(167, 91);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(265, 27);
            this.txtISBN.TabIndex = 10;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(167, 291);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(265, 27);
            this.txtPublisher.TabIndex = 12;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(167, 186);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(265, 27);
            this.txtTitle.TabIndex = 14;
            // 
            // dtPickerYearofPublish
            // 
            this.dtPickerYearofPublish.Location = new System.Drawing.Point(167, 386);
            this.dtPickerYearofPublish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtPickerYearofPublish.Name = "dtPickerYearofPublish";
            this.dtPickerYearofPublish.Size = new System.Drawing.Size(265, 27);
            this.dtPickerYearofPublish.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCatagoyName);
            this.groupBox1.Controls.Add(authorLabel);
            this.groupBox1.Controls.Add(this.dtPickerYearofPublish);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(iSBNLabel);
            this.groupBox1.Controls.Add(yearOfPublishionLabel);
            this.groupBox1.Controls.Add(bookIDLabel);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.txtBookID);
            this.groupBox1.Controls.Add(titleLabel);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtPublisher);
            this.groupBox1.Controls.Add(publisherLabel);
            this.groupBox1.Controls.Add(editionLabel);
            this.groupBox1.Controls.Add(this.txtEdition);
            this.groupBox1.Location = new System.Drawing.Point(19, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(471, 447);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book";
            // 
            // cboCatagoyName
            // 
            this.cboCatagoyName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bookCategoryBindingSource, "CategoryDescription", true));
            this.cboCatagoyName.DataSource = this.bookCategoryBindingSource1;
            this.cboCatagoyName.DisplayMember = "CategoryDescription";
            this.cboCatagoyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCatagoyName.FormattingEnabled = true;
            this.cboCatagoyName.Location = new System.Drawing.Point(167, 137);
            this.cboCatagoyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCatagoyName.Name = "cboCatagoyName";
            this.cboCatagoyName.Size = new System.Drawing.Size(265, 28);
            this.cboCatagoyName.TabIndex = 17;
            this.cboCatagoyName.ValueMember = "CategoryID";
            // 
            // bookCategoryBindingSource
            // 
            this.bookCategoryBindingSource.DataSource = typeof(Team08B_LibraryManagementSystem.BookCategory);
            // 
            // bookCategoryBindingSource1
            // 
            this.bookCategoryBindingSource1.DataSource = typeof(Team08B_LibraryManagementSystem.BookCategory);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(391, 482);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNewCopy);
            this.groupBox2.Controls.Add(this.btnEditcopy);
            this.groupBox2.Controls.Add(bookCopyIDLabel);
            this.groupBox2.Controls.Add(this.btnDeletecopy);
            this.groupBox2.Controls.Add(this.txtBookCopyID);
            this.groupBox2.Controls.Add(bookIDLabel1);
            this.groupBox2.Controls.Add(this.txtBookIDD);
            this.groupBox2.Controls.Add(bookShelfNoLabel);
            this.groupBox2.Controls.Add(this.txtShelfNo);
            this.groupBox2.Controls.Add(statusLabel);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.dgvcopy);
            this.groupBox2.Location = new System.Drawing.Point(516, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(628, 447);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BookDetail";
            // 
            // btnNewCopy
            // 
            this.btnNewCopy.Location = new System.Drawing.Point(495, 272);
            this.btnNewCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewCopy.Name = "btnNewCopy";
            this.btnNewCopy.Size = new System.Drawing.Size(100, 35);
            this.btnNewCopy.TabIndex = 21;
            this.btnNewCopy.Text = "Add &New";
            this.btnNewCopy.UseVisualStyleBackColor = true;
            this.btnNewCopy.Click += new System.EventHandler(this.btnNewCopy_Click);
            // 
            // btnEditcopy
            // 
            this.btnEditcopy.Location = new System.Drawing.Point(495, 329);
            this.btnEditcopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditcopy.Name = "btnEditcopy";
            this.btnEditcopy.Size = new System.Drawing.Size(100, 35);
            this.btnEditcopy.TabIndex = 20;
            this.btnEditcopy.Text = "&Update";
            this.btnEditcopy.UseVisualStyleBackColor = true;
            this.btnEditcopy.Click += new System.EventHandler(this.btnEditcopy_Click);
            // 
            // btnDeletecopy
            // 
            this.btnDeletecopy.Location = new System.Drawing.Point(495, 391);
            this.btnDeletecopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeletecopy.Name = "btnDeletecopy";
            this.btnDeletecopy.Size = new System.Drawing.Size(100, 35);
            this.btnDeletecopy.TabIndex = 19;
            this.btnDeletecopy.Text = "&Delete";
            this.btnDeletecopy.UseVisualStyleBackColor = true;
            this.btnDeletecopy.Click += new System.EventHandler(this.btnDeletecopy_Click);
            // 
            // txtBookCopyID
            // 
            this.txtBookCopyID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookCopyBindingSource, "BookCopyID", true));
            this.txtBookCopyID.Location = new System.Drawing.Point(140, 275);
            this.txtBookCopyID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookCopyID.Name = "txtBookCopyID";
            this.txtBookCopyID.ReadOnly = true;
            this.txtBookCopyID.Size = new System.Drawing.Size(300, 27);
            this.txtBookCopyID.TabIndex = 2;
            // 
            // bookCopyBindingSource
            // 
            this.bookCopyBindingSource.DataSource = typeof(Team08B_LibraryManagementSystem.BookCopy);
            // 
            // txtBookIDD
            // 
            this.txtBookIDD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookCopyBindingSource, "BookID", true));
            this.txtBookIDD.Location = new System.Drawing.Point(140, 315);
            this.txtBookIDD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookIDD.Name = "txtBookIDD";
            this.txtBookIDD.ReadOnly = true;
            this.txtBookIDD.Size = new System.Drawing.Size(300, 27);
            this.txtBookIDD.TabIndex = 4;
            // 
            // txtShelfNo
            // 
            this.txtShelfNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookCopyBindingSource, "BookShelfNo", true));
            this.txtShelfNo.Location = new System.Drawing.Point(140, 355);
            this.txtShelfNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShelfNo.Name = "txtShelfNo";
            this.txtShelfNo.Size = new System.Drawing.Size(300, 27);
            this.txtShelfNo.TabIndex = 6;
            // 
            // txtStatus
            // 
            this.txtStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookCopyBindingSource, "Status", true));
            this.txtStatus.Location = new System.Drawing.Point(140, 395);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(300, 27);
            this.txtStatus.TabIndex = 8;
            // 
            // dgvcopy
            // 
            this.dgvcopy.AutoGenerateColumns = false;
            this.dgvcopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcopy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookCopyIDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.bookShelfNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvcopy.DataSource = this.bookCopyBindingSource;
            this.dgvcopy.Location = new System.Drawing.Point(9, 42);
            this.dgvcopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvcopy.MultiSelect = false;
            this.dgvcopy.Name = "dgvcopy";
            this.dgvcopy.ReadOnly = true;
            this.dgvcopy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcopy.Size = new System.Drawing.Size(601, 206);
            this.dgvcopy.TabIndex = 0;
            this.dgvcopy.SelectionChanged += new System.EventHandler(this.dgvcopy_SelectionChanged);
            // 
            // bookCopyIDDataGridViewTextBoxColumn
            // 
            this.bookCopyIDDataGridViewTextBoxColumn.DataPropertyName = "BookCopyID";
            this.bookCopyIDDataGridViewTextBoxColumn.HeaderText = "BookCopyID";
            this.bookCopyIDDataGridViewTextBoxColumn.Name = "bookCopyIDDataGridViewTextBoxColumn";
            this.bookCopyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookShelfNoDataGridViewTextBoxColumn
            // 
            this.bookShelfNoDataGridViewTextBoxColumn.DataPropertyName = "BookShelfNo";
            this.bookShelfNoDataGridViewTextBoxColumn.HeaderText = "BookShelfNo";
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(583, 482);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // team08BLibraryEntitiesBindingSource
            // 
            this.team08BLibraryEntitiesBindingSource.DataSource = typeof(Team08B_LibraryManagementSystem.LibraryEntities);
            // 
            // Bookdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 547);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bookdetail";
            this.Text = "Book Detail";
            this.Load += new System.EventHandler(this.Bookcopies_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookCopyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team08BLibraryEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DateTimePicker dtPickerYearofPublish;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource bookCopyBindingSource;
        private System.Windows.Forms.DataGridView dgvcopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCopyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookShelfNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeletecopy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBookCopyID;
        private System.Windows.Forms.TextBox txtBookIDD;
        private System.Windows.Forms.TextBox txtShelfNo;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ComboBox cboCatagoyName;
        private System.Windows.Forms.BindingSource team08BLibraryEntitiesBindingSource;
        private System.Windows.Forms.BindingSource bookCategoryBindingSource;
        private System.Windows.Forms.Button btnNewCopy;
        private System.Windows.Forms.Button btnEditcopy;
        private System.Windows.Forms.BindingSource bookCategoryBindingSource1;

    }
}