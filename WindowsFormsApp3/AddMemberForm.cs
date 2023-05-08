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
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
        }


        private void AddMemberForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDatabaseDataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.booksDatabaseDataSet.Members);

        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            //Adds Member to the database
            bool valid = true; // determines whether input is valid or not
            if (memberNameText.Text == "" || memberPhoneText.Text == "") //If any of the fields is empty input is not valid
            {
                InputValidationMessages.FillFields();
                valid = false;
            }
            if (memberNameText.Text.Any(char.IsDigit)) //If the Member name contains a digit it's not valid
            {
                InputValidationMessages.MemberHasNum();
                valid = false;
            }
            for (int i = 0; i < memberPhoneText.Text.Length; i++)//Loop to check each character
            {
                if (memberPhoneText.Text[i] != ' ' && memberPhoneText.Text[i] != '-') // If the string contains anything other than numbers, dashes and spaces it's not valid
                {
                    if (!char.IsDigit(memberPhoneText.Text[i]))
                    {
                        valid = false;
                        InputValidationMessages.MemberPhoneHasLetter();
                        break;
                    }
                }
            }
            if (valid) // If input is valid it's entered
            {
                membersTableAdapter.Insert(memberNameText.Text, memberPhoneText.Text);
                InputValidationMessages.DataEntered();
            }
        }
    }
}
