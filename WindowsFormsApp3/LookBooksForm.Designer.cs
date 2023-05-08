namespace WindowsFormsApp3
{
    partial class LookBooksForm
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
            this.availableBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.searchBookText = new System.Windows.Forms.TextBox();
            this.searchBookButton = new System.Windows.Forms.Button();
            this.searchBookLabel = new System.Windows.Forms.Label();
            this.searchAuthorLabel = new System.Windows.Forms.Label();
            this.searchAuthorButton = new System.Windows.Forms.Button();
            this.searchAuthorText = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.searchIDLabel = new System.Windows.Forms.Label();
            this.searchIDButton = new System.Windows.Forms.Button();
            this.searchIDText = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDatabaseDataSet = new WindowsFormsApp3.BooksDatabaseDataSet();
            this.availableBooksTableAdapter = new WindowsFormsApp3.BooksDatabaseDataSetTableAdapters.AvailableBooksTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.BooksDatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.availableBooksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // availableBooksDataGridView
            // 
            this.availableBooksDataGridView.AllowUserToAddRows = false;
            this.availableBooksDataGridView.AllowUserToDeleteRows = false;
            this.availableBooksDataGridView.AutoGenerateColumns = false;
            this.availableBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableBooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.availableBooksDataGridView.DataSource = this.availableBooksBindingSource;
            this.availableBooksDataGridView.Location = new System.Drawing.Point(-1, 134);
            this.availableBooksDataGridView.Name = "availableBooksDataGridView";
            this.availableBooksDataGridView.ReadOnly = true;
            this.availableBooksDataGridView.RowHeadersWidth = 51;
            this.availableBooksDataGridView.RowTemplate.Height = 24;
            this.availableBooksDataGridView.Size = new System.Drawing.Size(800, 315);
            this.availableBooksDataGridView.TabIndex = 1;
            // 
            // searchBookText
            // 
            this.searchBookText.Location = new System.Drawing.Point(293, 29);
            this.searchBookText.Name = "searchBookText";
            this.searchBookText.Size = new System.Drawing.Size(155, 22);
            this.searchBookText.TabIndex = 2;
            // 
            // searchBookButton
            // 
            this.searchBookButton.Location = new System.Drawing.Point(454, 7);
            this.searchBookButton.Name = "searchBookButton";
            this.searchBookButton.Size = new System.Drawing.Size(75, 49);
            this.searchBookButton.TabIndex = 3;
            this.searchBookButton.Text = "Search Book";
            this.searchBookButton.UseVisualStyleBackColor = true;
            this.searchBookButton.Click += new System.EventHandler(this.searchBookButton_Click);
            // 
            // searchBookLabel
            // 
            this.searchBookLabel.AutoSize = true;
            this.searchBookLabel.Location = new System.Drawing.Point(294, 7);
            this.searchBookLabel.Name = "searchBookLabel";
            this.searchBookLabel.Size = new System.Drawing.Size(147, 16);
            this.searchBookLabel.TabIndex = 4;
            this.searchBookLabel.Text = "Search By Book Name:";
            // 
            // searchAuthorLabel
            // 
            this.searchAuthorLabel.AutoSize = true;
            this.searchAuthorLabel.Location = new System.Drawing.Point(553, 7);
            this.searchAuthorLabel.Name = "searchAuthorLabel";
            this.searchAuthorLabel.Size = new System.Drawing.Size(113, 16);
            this.searchAuthorLabel.TabIndex = 7;
            this.searchAuthorLabel.Text = "Search By Author:";
            // 
            // searchAuthorButton
            // 
            this.searchAuthorButton.Location = new System.Drawing.Point(713, 7);
            this.searchAuthorButton.Name = "searchAuthorButton";
            this.searchAuthorButton.Size = new System.Drawing.Size(75, 49);
            this.searchAuthorButton.TabIndex = 6;
            this.searchAuthorButton.Text = "Search Author";
            this.searchAuthorButton.UseVisualStyleBackColor = true;
            this.searchAuthorButton.Click += new System.EventHandler(this.searchAuthorButton_Click);
            // 
            // searchAuthorText
            // 
            this.searchAuthorText.Location = new System.Drawing.Point(552, 29);
            this.searchAuthorText.Name = "searchAuthorText";
            this.searchAuthorText.Size = new System.Drawing.Size(155, 22);
            this.searchAuthorText.TabIndex = 5;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(306, 66);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(135, 49);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchIDLabel
            // 
            this.searchIDLabel.AutoSize = true;
            this.searchIDLabel.Location = new System.Drawing.Point(12, 7);
            this.searchIDLabel.Name = "searchIDLabel";
            this.searchIDLabel.Size = new System.Drawing.Size(88, 16);
            this.searchIDLabel.TabIndex = 11;
            this.searchIDLabel.Text = "Search By ID:";
            // 
            // searchIDButton
            // 
            this.searchIDButton.Location = new System.Drawing.Point(187, 7);
            this.searchIDButton.Name = "searchIDButton";
            this.searchIDButton.Size = new System.Drawing.Size(75, 49);
            this.searchIDButton.TabIndex = 10;
            this.searchIDButton.Text = "Search ID";
            this.searchIDButton.UseVisualStyleBackColor = true;
            this.searchIDButton.Click += new System.EventHandler(this.searchIDButton_Click);
            // 
            // searchIDText
            // 
            this.searchIDText.Location = new System.Drawing.Point(11, 29);
            this.searchIDText.Name = "searchIDText";
            this.searchIDText.Size = new System.Drawing.Size(155, 22);
            this.searchIDText.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BookID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BookID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BookName";
            this.dataGridViewTextBoxColumn2.HeaderText = "BookName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // availableBooksBindingSource
            // 
            this.availableBooksBindingSource.DataMember = "AvailableBooks";
            this.availableBooksBindingSource.DataSource = this.booksDatabaseDataSet;
            // 
            // booksDatabaseDataSet
            // 
            this.booksDatabaseDataSet.DataSetName = "BooksDatabaseDataSet";
            this.booksDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // availableBooksTableAdapter
            // 
            this.availableBooksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvailableBooksTableAdapter = this.availableBooksTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.BooksDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LookBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchIDLabel);
            this.Controls.Add(this.searchIDButton);
            this.Controls.Add(this.searchIDText);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchAuthorLabel);
            this.Controls.Add(this.searchAuthorButton);
            this.Controls.Add(this.searchAuthorText);
            this.Controls.Add(this.searchBookLabel);
            this.Controls.Add(this.searchBookButton);
            this.Controls.Add(this.searchBookText);
            this.Controls.Add(this.availableBooksDataGridView);
            this.Name = "LookBooksForm";
            this.Text = "LookBooksForm";
            this.Load += new System.EventHandler(this.LookBooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availableBooksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooksDatabaseDataSet booksDatabaseDataSet;
        private System.Windows.Forms.BindingSource availableBooksBindingSource;
        private BooksDatabaseDataSetTableAdapters.AvailableBooksTableAdapter availableBooksTableAdapter;
        private BooksDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView availableBooksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox searchBookText;
        private System.Windows.Forms.Button searchBookButton;
        private System.Windows.Forms.Label searchBookLabel;
        private System.Windows.Forms.Label searchAuthorLabel;
        private System.Windows.Forms.Button searchAuthorButton;
        private System.Windows.Forms.TextBox searchAuthorText;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label searchIDLabel;
        private System.Windows.Forms.Button searchIDButton;
        private System.Windows.Forms.TextBox searchIDText;
    }
}