namespace WindowsFormsApp3
{
    partial class AddMemberForm
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
            this.memberNameText = new System.Windows.Forms.TextBox();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.memberPhoneLabel = new System.Windows.Forms.Label();
            this.memberPhoneText = new System.Windows.Forms.TextBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.booksDatabaseDataSet = new WindowsFormsApp3.BooksDatabaseDataSet();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new WindowsFormsApp3.BooksDatabaseDataSetTableAdapters.MembersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.BooksDatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // memberNameText
            // 
            this.memberNameText.Location = new System.Drawing.Point(265, 153);
            this.memberNameText.Name = "memberNameText";
            this.memberNameText.Size = new System.Drawing.Size(220, 22);
            this.memberNameText.TabIndex = 0;
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.AutoSize = true;
            this.memberNameLabel.Location = new System.Drawing.Point(265, 131);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(100, 16);
            this.memberNameLabel.TabIndex = 1;
            this.memberNameLabel.Text = "Member Name:";
            // 
            // memberPhoneLabel
            // 
            this.memberPhoneLabel.AutoSize = true;
            this.memberPhoneLabel.Location = new System.Drawing.Point(265, 205);
            this.memberPhoneLabel.Name = "memberPhoneLabel";
            this.memberPhoneLabel.Size = new System.Drawing.Size(102, 16);
            this.memberPhoneLabel.TabIndex = 3;
            this.memberPhoneLabel.Text = "Member Phone:";
            // 
            // memberPhoneText
            // 
            this.memberPhoneText.Location = new System.Drawing.Point(265, 227);
            this.memberPhoneText.Name = "memberPhoneText";
            this.memberPhoneText.Size = new System.Drawing.Size(220, 22);
            this.memberPhoneText.TabIndex = 2;
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(268, 292);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(217, 70);
            this.addMemberButton.TabIndex = 4;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // booksDatabaseDataSet
            // 
            this.booksDatabaseDataSet.DataSetName = "BooksDatabaseDataSet";
            this.booksDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.booksDatabaseDataSet;
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
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.memberPhoneLabel);
            this.Controls.Add(this.memberPhoneText);
            this.Controls.Add(this.memberNameLabel);
            this.Controls.Add(this.memberNameText);
            this.Name = "AddMemberForm";
            this.Text = "AddMemberForm";
            this.Load += new System.EventHandler(this.AddMemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox memberNameText;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.Label memberPhoneLabel;
        private System.Windows.Forms.TextBox memberPhoneText;
        private System.Windows.Forms.Button addMemberButton;
        private BooksDatabaseDataSet booksDatabaseDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private BooksDatabaseDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private BooksDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}