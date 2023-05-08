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
    public partial class ModifyBookForm : Form
    {
        public ModifyBookForm()
        {
            InitializeComponent();
        }

        private void availableBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bool valid=true; //Determines if data is valid or not
            bool broke = false; //A variable to break from the first loop after breaking from the nested loop
            for (int rows = 0; rows < availableBooksDataGridView.Rows.Count; rows++)//Loops over each row
            {
                string value = availableBooksDataGridView.Rows[rows].Cells[2].Value.ToString(); //Data in the Author Column
                for (int i = 0; i < value.Length; i++) //Loops over each letter
                {
                    if (char.IsDigit(value[i])) //if a number is detected input is invalid
                    {
                        broke = true;
                        valid = false;
                        InputValidationMessages.AuthorHasNum();
                        break;
                    }
                    
                }
                if (broke) // if broke from the nested loop break from this loop
                {
                    break;
                }
            }
            if (valid) // if valid data is entered
            {
                this.Validate();
                this.availableBooksBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.booksDatabaseDataSet);
            }

        }

        private void ModifyBookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDatabaseDataSet.AvailableBooks' table. You can move, or remove it, as needed.
            this.availableBooksTableAdapter.Fill(this.booksDatabaseDataSet.AvailableBooks);
            InputValidationMessages.SaveReminder();

        }
    }
}
