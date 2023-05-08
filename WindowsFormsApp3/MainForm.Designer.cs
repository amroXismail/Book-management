namespace WindowsFormsApp3
{
    partial class MainForm
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
            this.addBookButton = new System.Windows.Forms.Button();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.removeMemberButton = new System.Windows.Forms.Button();
            this.lookBooksButton = new System.Windows.Forms.Button();
            this.lookMembersButton = new System.Windows.Forms.Button();
            this.modifyBookButton = new System.Windows.Forms.Button();
            this.modifyMemberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.addBookButton.Location = new System.Drawing.Point(231, 134);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(232, 71);
            this.addBookButton.TabIndex = 0;
            this.addBookButton.Text = "Add New Book";
            this.addBookButton.UseVisualStyleBackColor = false;
            this.addBookButton.Click += new System.EventHandler(this.addBook_Click);
            // 
            // removeBookButton
            // 
            this.removeBookButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.removeBookButton.Location = new System.Drawing.Point(231, 211);
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(232, 71);
            this.removeBookButton.TabIndex = 1;
            this.removeBookButton.Text = "Remove Book";
            this.removeBookButton.UseVisualStyleBackColor = false;
            this.removeBookButton.Click += new System.EventHandler(this.removeBookButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Firebrick;
            this.closeButton.Location = new System.Drawing.Point(12, 286);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 163);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.addMemberButton.Location = new System.Drawing.Point(512, 134);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(232, 71);
            this.addMemberButton.TabIndex = 6;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // removeMemberButton
            // 
            this.removeMemberButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.removeMemberButton.Location = new System.Drawing.Point(512, 211);
            this.removeMemberButton.Name = "removeMemberButton";
            this.removeMemberButton.Size = new System.Drawing.Size(232, 71);
            this.removeMemberButton.TabIndex = 7;
            this.removeMemberButton.Text = "Remove Member";
            this.removeMemberButton.UseVisualStyleBackColor = false;
            this.removeMemberButton.Click += new System.EventHandler(this.removeMemberButton_Click);
            // 
            // lookBooksButton
            // 
            this.lookBooksButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lookBooksButton.Location = new System.Drawing.Point(231, 288);
            this.lookBooksButton.Name = "lookBooksButton";
            this.lookBooksButton.Size = new System.Drawing.Size(232, 71);
            this.lookBooksButton.TabIndex = 8;
            this.lookBooksButton.Text = "Look Up Books";
            this.lookBooksButton.UseVisualStyleBackColor = false;
            this.lookBooksButton.Click += new System.EventHandler(this.lookBooksButton_Click);
            // 
            // lookMembersButton
            // 
            this.lookMembersButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lookMembersButton.Location = new System.Drawing.Point(512, 288);
            this.lookMembersButton.Name = "lookMembersButton";
            this.lookMembersButton.Size = new System.Drawing.Size(232, 71);
            this.lookMembersButton.TabIndex = 9;
            this.lookMembersButton.Text = "Look Up Members";
            this.lookMembersButton.UseVisualStyleBackColor = false;
            this.lookMembersButton.Click += new System.EventHandler(this.lookMembersButton_Click);
            // 
            // modifyBookButton
            // 
            this.modifyBookButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.modifyBookButton.Location = new System.Drawing.Point(231, 365);
            this.modifyBookButton.Name = "modifyBookButton";
            this.modifyBookButton.Size = new System.Drawing.Size(232, 73);
            this.modifyBookButton.TabIndex = 10;
            this.modifyBookButton.Text = "Modify Book Data";
            this.modifyBookButton.UseVisualStyleBackColor = false;
            this.modifyBookButton.Click += new System.EventHandler(this.modifyBookButton_Click);
            // 
            // modifyMemberButton
            // 
            this.modifyMemberButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.modifyMemberButton.Location = new System.Drawing.Point(512, 365);
            this.modifyMemberButton.Name = "modifyMemberButton";
            this.modifyMemberButton.Size = new System.Drawing.Size(232, 73);
            this.modifyMemberButton.TabIndex = 11;
            this.modifyMemberButton.Text = "Modify Member Data";
            this.modifyMemberButton.UseVisualStyleBackColor = false;
            this.modifyMemberButton.Click += new System.EventHandler(this.modifyMemberButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(980, 576);
            this.Controls.Add(this.modifyMemberButton);
            this.Controls.Add(this.modifyBookButton);
            this.Controls.Add(this.lookMembersButton);
            this.Controls.Add(this.lookBooksButton);
            this.Controls.Add(this.removeMemberButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.removeBookButton);
            this.Controls.Add(this.addBookButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button removeBookButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button removeMemberButton;
        private System.Windows.Forms.Button lookBooksButton;
        private System.Windows.Forms.Button lookMembersButton;
        private System.Windows.Forms.Button modifyBookButton;
        private System.Windows.Forms.Button modifyMemberButton;
    }
}

