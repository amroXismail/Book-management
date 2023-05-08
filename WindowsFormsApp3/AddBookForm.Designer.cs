namespace WindowsFormsApp3
{
    partial class AddBookForm
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
            this.bookNameText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.booksDatabaseDataSet = new WindowsFormsApp3.BooksDatabaseDataSet();
            this.availableBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.availableBooksTableAdapter = new WindowsFormsApp3.BooksDatabaseDataSetTableAdapters.AvailableBooksTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.BooksDatabaseDataSetTableAdapters.TableAdapterManager();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableBooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookNameText
            // 
            this.bookNameText.Location = new System.Drawing.Point(280, 141);
            this.bookNameText.Name = "bookNameText";
            this.bookNameText.Size = new System.Drawing.Size(188, 22);
            this.bookNameText.TabIndex = 0;
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(280, 240);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(188, 22);
            this.authorText.TabIndex = 1;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(280, 324);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(188, 50);
            this.addBookButton.TabIndex = 2;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // booksDatabaseDataSet
            // 
            this.booksDatabaseDataSet.DataSetName = "BooksDatabaseDataSet";
            this.booksDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // availableBooksBindingSource
            // 
            this.availableBooksBindingSource.DataMember = "AvailableBooks";
            this.availableBooksBindingSource.DataSource = this.booksDatabaseDataSet;
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
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Location = new System.Drawing.Point(280, 119);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(82, 16);
            this.bookNameLabel.TabIndex = 3;
            this.bookNameLabel.Text = "Book Name:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(280, 218);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(88, 16);
            this.authorLabel.TabIndex = 4;
            this.authorLabel.Text = "Author Name:";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.bookNameText);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableBooksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookNameText;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.Button addBookButton;
        private BooksDatabaseDataSet booksDatabaseDataSet;
        private System.Windows.Forms.BindingSource availableBooksBindingSource;
        private BooksDatabaseDataSetTableAdapters.AvailableBooksTableAdapter availableBooksTableAdapter;
        private BooksDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.Label authorLabel;
    }
}