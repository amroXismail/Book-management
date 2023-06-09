﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class RemoveMemberForm : Form
    {
        public RemoveMemberForm()
        {
            InitializeComponent();
        }

        private void membersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.membersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDatabaseDataSet);

        }

        private void RemoveMemberForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDatabaseDataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.booksDatabaseDataSet.Members);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            InputValidationMessages.RemoveSaveReminder();
        }
    }
}
