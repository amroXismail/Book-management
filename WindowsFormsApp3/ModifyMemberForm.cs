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
    public partial class ModifyMemberForm : Form
    {
        public ModifyMemberForm()
        {
            InitializeComponent();
        }

        private void membersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bool valid = true; //Determines if data is valid or not
            bool broke = false; //A variable to break from the first loop after breaking from the nested loop
            for (int rows = 0; rows < membersDataGridView.Rows.Count; rows++)//Loops over each row
            {
                string value = membersDataGridView.Rows[rows].Cells[1].Value.ToString();//Data in MemberName Column
                for (int i = 0; i < value.Length; i++)//Loops over each character
                {
                    if (char.IsDigit(value[i])) //if a number is detected input is invalid
                    {
                        broke = true;
                        valid = false;
                        InputValidationMessages.MemberHasNum();
                        break;
                    }
                    
                }
                if (broke) // if broke from the nested loop break from this loop
                {
                    break;
                }
            }
            broke= false;
            for (int rows = 0; rows < membersDataGridView.Rows.Count; rows++)//loops over each row again
            {
                string value = membersDataGridView.Rows[rows].Cells[2].Value.ToString(); // Data in the MemberPhone Column
                for (int i = 0; i < value.Length; i++)//Loops over each character
                {
                    if (!(char.IsDigit(value[i]))) //if a number isn't detected
                    {
                        if(value[i] != ' ' && value[i]!='-') //if the letter detected is neither dash nor space input is invalid
                        {
                            broke = true;
                            valid = false;
                            InputValidationMessages.MemberPhoneHasLetter();
                            break;
                        }
                        
                    }   
                }
                if (broke) // if broke from the nested loop break from this loop
                {
                    break;
                }
            }
            if (valid)
            {
                this.Validate();
                this.membersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.booksDatabaseDataSet);
            }
           

        }

        private void ModifyMemberForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDatabaseDataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.booksDatabaseDataSet.Members);
            InputValidationMessages.SaveReminder();

        }
    }
}
