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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }


        private void AddBookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDatabaseDataSet.AvailableBooks' table. You can move, or remove it, as needed.
            this.availableBooksTableAdapter.Fill(this.booksDatabaseDataSet.AvailableBooks);

        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            //Adds Book to the database
            bool valid = true; // determines whether input is valid or not
            if (bookNameText.Text == "" || authorText.Text == "") //If any of the fields is empty input is not valid
            {
                InputValidationMessages.FillFields();
                valid = false;
            }
            if (authorText.Text.Any(char.IsDigit)) //If the author name contains a digit it's not valid
            {
                InputValidationMessages.AuthorHasNum();
                valid = false;
            }
            if (valid) //If input is valid it's entered
            {
                availableBooksTableAdapter.Insert(bookNameText.Text, authorText.Text);
                InputValidationMessages.DataEntered();
            }
        }
    }
}
