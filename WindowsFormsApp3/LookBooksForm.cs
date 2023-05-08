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
    public partial class LookBooksForm : Form
    {
        public LookBooksForm()
        {
            InitializeComponent();
        }

        private void LookBooksForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDatabaseDataSet.AvailableBooks' table. You can move, or remove it, as needed.
            this.availableBooksTableAdapter.Fill(this.booksDatabaseDataSet.AvailableBooks);

        }

        private void searchBookButton_Click(object sender, EventArgs e)
        {
            string searchString = searchBookText.Text; // the string used for search
            bool valid = true; // To determine validity of input
            if (searchString == "") // if the string is empty data is invalid
            {
                InputValidationMessages.FillFields();
                valid = false;
            }
            if (valid) // if data is valid the table is filled by the matching records
            {
                this.availableBooksTableAdapter.FillByBook(this.booksDatabaseDataSet.AvailableBooks, searchString); //Custom Query To fill the dataGridView by the records matching BookName the search criteria specified by searchString
            }
            
        }

        private void searchAuthorButton_Click(object sender, EventArgs e)
        {
            string searchString = searchAuthorText.Text; // the string used for search
            bool valid = true; // To determine validity of input
            if (searchString == "") // if the string is empty data is invalid
            {
                InputValidationMessages.FillFields();
                valid = false;
            }
            if (searchString.Any(char.IsDigit))
            {
                InputValidationMessages.AuthorHasNum();
                valid = false;
            }
            if (valid) // if data is valid the table is filled by the matching records
            {
                this.availableBooksTableAdapter.FillByAuthor(this.booksDatabaseDataSet.AvailableBooks, searchString); //Custom Query To fill the dataGridView by the records matching Author with the search criteria specified by searchString
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Resets the table to the original form
            this.availableBooksTableAdapter.Fill(this.booksDatabaseDataSet.AvailableBooks);
        }

        private void searchIDButton_Click(object sender, EventArgs e)
        {
            bool valid = true; // To determine validity of input
            int searchID=0; //Integer to use for search
            string searchString = searchIDText.Text;
            if (searchString == "") // if the string is empty data is invalid
            {
                InputValidationMessages.FillFields();
                valid = false;
            }
            try
            {
                searchID = int.Parse(searchString);
            }
            catch //if id isn't an integer it's invalid
            {
                InputValidationMessages.IDHasLetter();
                valid = false;
            }
            if (searchID <= 0)//if Id is 0 or negative it's invalid
            {
                InputValidationMessages.IDIsNegative();
                valid = false;
            }
            if (valid)
            {
                this.availableBooksTableAdapter.FillByID(this.booksDatabaseDataSet.AvailableBooks, searchID);
            }
        }
    }
}
