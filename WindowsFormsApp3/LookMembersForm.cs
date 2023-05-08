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
    public partial class LookMembersForm : Form
    {
        public LookMembersForm()
        {
            InitializeComponent();
        }

        private void LookMembersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDatabaseDataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.booksDatabaseDataSet.Members);

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Resets the table to the original form
            this.membersTableAdapter.Fill(this.booksDatabaseDataSet.Members);
        }

        private void searchMemberButton_Click(object sender, EventArgs e)
        {
            string searchString = searchMemberText.Text; // the string used for search
            bool valid = true; // To determine validity of input
            if (searchString == "") // if the string is empty data is invalid
            {
                InputValidationMessages.FillFields();
                valid = false;
            }
            if (searchString.Any(char.IsDigit))
            {
                InputValidationMessages.MemberHasNum();
                valid = false;
            }
            if (valid)
            {
                //Custom Query To fill the dataGridView by the records matching memberName with the search criteria specified by searchString
                this.membersTableAdapter.FillByMember(this.booksDatabaseDataSet.Members, searchString);
            }
        }

        private void searchPhoneButton_Click(object sender, EventArgs e)
        {
            string searchString = searchPhoneText.Text; // the string used for search
            bool valid = true; // To determine validity of input
            if (searchString == "") // if the string is empty data is invalid
            {
                InputValidationMessages.FillFields();
                valid = false;
            }
            for (int i = 0; i < searchPhoneText.Text.Length; i++)//Loop to check each character
            {
                if (searchPhoneText.Text[i] != ' ' && searchPhoneText.Text[i] != '-') // If the string contains anything other than numbers, dashes and spaces it's not valid
                {
                    if (!char.IsDigit(searchPhoneText.Text[i]))
                    {
                        valid = false;
                        InputValidationMessages.MemberPhoneHasLetter();
                        break;
                    }
                }
            }
            if (valid)
            {
                //Custom Query To fill the dataGridView by the records matching memberName with the search criteria specified by searchString
                this.membersTableAdapter.FillByPhone(this.booksDatabaseDataSet.Members, searchString);
            }
        }

        private void searchIDButton_Click(object sender, EventArgs e)
        {
            bool valid = true; // To determine validity of input
            int searchID = 0; //Integer to use for search
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
                this.membersTableAdapter.FillByID(this.booksDatabaseDataSet.Members, searchID);
            }
        }
    }
}
