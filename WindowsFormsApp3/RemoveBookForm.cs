using System;
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
    public partial class RemoveBookForm : Form
    {
        public RemoveBookForm()
        {
            InitializeComponent();
        }

        private void availableBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.availableBooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDatabaseDataSet);

        }

        private void RemoveBookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDatabaseDataSet.AvailableBooks' table. You can move, or remove it, as needed.
            this.availableBooksTableAdapter.Fill(this.booksDatabaseDataSet.AvailableBooks);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            InputValidationMessages.RemoveSaveReminder();
        }
    }
}
