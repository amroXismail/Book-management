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
    
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void addBook_Click(object sender, EventArgs e)
        {
            //Opens the Add Book Form
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Closes the App
            this.Close();
        }

        private void removeBookButton_Click(object sender, EventArgs e)
        {
            //Opens the Remove Book Form
            RemoveBookForm removeBookForm = new RemoveBookForm();
            removeBookForm.ShowDialog();    
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            //Opens the Add Member Form
            AddMemberForm addMemberForm = new AddMemberForm();
            addMemberForm.ShowDialog();
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            //Opens the Add Member Form
            RemoveMemberForm removeMemberForm = new RemoveMemberForm();
            removeMemberForm.ShowDialog();
        }

        private void lookBooksButton_Click(object sender, EventArgs e)
        {
            //Opens the Look Books Form
            LookBooksForm lookBooksForm = new LookBooksForm();
            lookBooksForm.ShowDialog();
        }

        private void lookMembersButton_Click(object sender, EventArgs e)
        {
            //Opens the Look Members Form
            LookMembersForm lookMembersForm = new LookMembersForm();
            lookMembersForm.ShowDialog();
        }

        private void modifyBookButton_Click(object sender, EventArgs e)
        {
            //Opens the Modify Book Form
            ModifyBookForm modifyBookForm = new ModifyBookForm();
            modifyBookForm.ShowDialog();
        }

        private void modifyMemberButton_Click(object sender, EventArgs e)
        {
            //Opens the Modify Members Form
            ModifyMemberForm modifyMemberForm = new ModifyMemberForm();
            modifyMemberForm.ShowDialog();
        }
    }
    //Class of functions that display messages related to input validation
    class InputValidationMessages
    {
        //For empty textboxes
        public static void FillFields()
        {
            MessageBox.Show("Please fill field/s");
        }

        //For Author names that contain numbers
        public static void AuthorHasNum()
        {
            MessageBox.Show("Author name can't contain a number");
        }

        //For valid input
        public static void DataEntered()
        {
            MessageBox.Show("Data entered Successfully");
        }

        //For Member names that contain numbers
        public static void MemberHasNum()
        {
            MessageBox.Show("Member name can't contain a number");
        }

        //For Member phones that contain letters other than dash and space
        public static void MemberPhoneHasLetter()
        {
            MessageBox.Show("Member phone must contain numbers, spaces and dashes only");
        }

        //To remind the user to save after modification
        public static void SaveReminder()
        {
            MessageBox.Show("Remeber to press enter after modifying data and then clicking the save button, otherwise, changes won't be saved");
        }

        //To remind the user to save after deleting
        public static void RemoveSaveReminder()
        {
            MessageBox.Show("Data removed, click save button to save changes");
        }

        //For ID that contains letters
        public static void IDHasLetter()
        {
            MessageBox.Show("ID Must be a number");
        }

        //For ID that is negative
        public static void IDIsNegative()
        {
            MessageBox.Show("ID must be bigger than zero");
        }
    }
}
