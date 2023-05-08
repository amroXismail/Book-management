namespace WindowsFormsApp3
{
    partial class LookMembersForm
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
            this.membersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDatabaseDataSet = new WindowsFormsApp3.BooksDatabaseDataSet();
            this.resetButton = new System.Windows.Forms.Button();
            this.searchPhoneLabel = new System.Windows.Forms.Label();
            this.searchPhoneButton = new System.Windows.Forms.Button();
            this.searchPhoneText = new System.Windows.Forms.TextBox();
            this.searchMemberLabel = new System.Windows.Forms.Label();
            this.searchMemberButton = new System.Windows.Forms.Button();
            this.searchMemberText = new System.Windows.Forms.TextBox();
            this.membersTableAdapter = new WindowsFormsApp3.BooksDatabaseDataSetTableAdapters.MembersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.BooksDatabaseDataSetTableAdapters.TableAdapterManager();
            this.searchIDLabel = new System.Windows.Forms.Label();
            this.searchIDButton = new System.Windows.Forms.Button();
            this.searchIDText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // membersDataGridView
            // 
            this.membersDataGridView.AllowUserToAddRows = false;
            this.membersDataGridView.AllowUserToDeleteRows = false;
            this.membersDataGridView.AutoGenerateColumns = false;
            this.membersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.membersDataGridView.DataSource = this.membersBindingSource;
            this.membersDataGridView.Location = new System.Drawing.Point(0, 144);
            this.membersDataGridView.Name = "membersDataGridView";
            this.membersDataGridView.ReadOnly = true;
            this.membersDataGridView.RowHeadersWidth = 51;
            this.membersDataGridView.RowTemplate.Height = 24;
            this.membersDataGridView.Size = new System.Drawing.Size(800, 307);
            this.membersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "memberName";
            this.dataGridViewTextBoxColumn2.HeaderText = "memberName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "memberPhone";
            this.dataGridViewTextBoxColumn3.HeaderText = "memberPhone";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.booksDatabaseDataSet;
            // 
            // booksDatabaseDataSet
            // 
            this.booksDatabaseDataSet.DataSetName = "BooksDatabaseDataSet";
            this.booksDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(304, 71);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(135, 49);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchPhoneLabel
            // 
            this.searchPhoneLabel.AutoSize = true;
            this.searchPhoneLabel.Location = new System.Drawing.Point(553, 9);
            this.searchPhoneLabel.Name = "searchPhoneLabel";
            this.searchPhoneLabel.Size = new System.Drawing.Size(114, 16);
            this.searchPhoneLabel.TabIndex = 14;
            this.searchPhoneLabel.Text = "Search By Phone:";
            // 
            // searchPhoneButton
            // 
            this.searchPhoneButton.Location = new System.Drawing.Point(713, 4);
            this.searchPhoneButton.Name = "searchPhoneButton";
            this.searchPhoneButton.Size = new System.Drawing.Size(75, 49);
            this.searchPhoneButton.TabIndex = 13;
            this.searchPhoneButton.Text = "Search Phone";
            this.searchPhoneButton.UseVisualStyleBackColor = true;
            this.searchPhoneButton.Click += new System.EventHandler(this.searchPhoneButton_Click);
            // 
            // searchPhoneText
            // 
            this.searchPhoneText.Location = new System.Drawing.Point(552, 31);
            this.searchPhoneText.Name = "searchPhoneText";
            this.searchPhoneText.Size = new System.Drawing.Size(155, 22);
            this.searchPhoneText.TabIndex = 12;
            // 
            // searchMemberLabel
            // 
            this.searchMemberLabel.AutoSize = true;
            this.searchMemberLabel.Location = new System.Drawing.Point(274, 9);
            this.searchMemberLabel.Name = "searchMemberLabel";
            this.searchMemberLabel.Size = new System.Drawing.Size(165, 16);
            this.searchMemberLabel.TabIndex = 11;
            this.searchMemberLabel.Text = "Search By Member Name:";
            // 
            // searchMemberButton
            // 
            this.searchMemberButton.Location = new System.Drawing.Point(456, 4);
            this.searchMemberButton.Name = "searchMemberButton";
            this.searchMemberButton.Size = new System.Drawing.Size(75, 49);
            this.searchMemberButton.TabIndex = 10;
            this.searchMemberButton.Text = "Search Member";
            this.searchMemberButton.UseVisualStyleBackColor = true;
            this.searchMemberButton.Click += new System.EventHandler(this.searchMemberButton_Click);
            // 
            // searchMemberText
            // 
            this.searchMemberText.Location = new System.Drawing.Point(284, 31);
            this.searchMemberText.Name = "searchMemberText";
            this.searchMemberText.Size = new System.Drawing.Size(155, 22);
            this.searchMemberText.TabIndex = 9;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvailableBooksTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MembersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.BooksDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // searchIDLabel
            // 
            this.searchIDLabel.AutoSize = true;
            this.searchIDLabel.Location = new System.Drawing.Point(6, 9);
            this.searchIDLabel.Name = "searchIDLabel";
            this.searchIDLabel.Size = new System.Drawing.Size(88, 16);
            this.searchIDLabel.TabIndex = 18;
            this.searchIDLabel.Text = "Search By ID:";
            // 
            // searchIDButton
            // 
            this.searchIDButton.Location = new System.Drawing.Point(166, 9);
            this.searchIDButton.Name = "searchIDButton";
            this.searchIDButton.Size = new System.Drawing.Size(75, 49);
            this.searchIDButton.TabIndex = 17;
            this.searchIDButton.Text = "Search ID";
            this.searchIDButton.UseVisualStyleBackColor = true;
            this.searchIDButton.Click += new System.EventHandler(this.searchIDButton_Click);
            // 
            // searchIDText
            // 
            this.searchIDText.Location = new System.Drawing.Point(5, 31);
            this.searchIDText.Name = "searchIDText";
            this.searchIDText.Size = new System.Drawing.Size(155, 22);
            this.searchIDText.TabIndex = 16;
            // 
            // LookMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchIDLabel);
            this.Controls.Add(this.searchIDButton);
            this.Controls.Add(this.searchIDText);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchPhoneLabel);
            this.Controls.Add(this.searchPhoneButton);
            this.Controls.Add(this.searchPhoneText);
            this.Controls.Add(this.searchMemberLabel);
            this.Controls.Add(this.searchMemberButton);
            this.Controls.Add(this.searchMemberText);
            this.Controls.Add(this.membersDataGridView);
            this.Name = "LookMembersForm";
            this.Text = "LookMembersForm";
            this.Load += new System.EventHandler(this.LookMembersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooksDatabaseDataSet booksDatabaseDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private BooksDatabaseDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private BooksDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView membersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label searchPhoneLabel;
        private System.Windows.Forms.Button searchPhoneButton;
        private System.Windows.Forms.TextBox searchPhoneText;
        private System.Windows.Forms.Label searchMemberLabel;
        private System.Windows.Forms.Button searchMemberButton;
        private System.Windows.Forms.TextBox searchMemberText;
        private System.Windows.Forms.Label searchIDLabel;
        private System.Windows.Forms.Button searchIDButton;
        private System.Windows.Forms.TextBox searchIDText;
    }
}