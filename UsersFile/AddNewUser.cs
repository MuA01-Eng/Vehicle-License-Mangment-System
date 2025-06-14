using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connect;
namespace DVLDMySolution
{ 
    public partial class AddNewUser : Form
    {
        static bool num=false ;
        UserConnect User ;
        public AddNewUser(UserConnect connect)
        {
            InitializeComponent()  ;
            User = connect         ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (UserConnect.IsUserExist(ClsConnect._Current_Id))
            {
                MessageBox.Show("This Pepole Is Already Is A User ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserID_la.Enabled = false;
                PAss_text.Enabled = false;
                Con_Text.Enabled = false;
                User_text.Enabled = false;
                ISA_Check.Enabled = false;
                tabControl1.SelectedIndex = 1;

            }
            else
            {
                tabControl1.SelectedIndex = 1;
                Save_But.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ISA_Check.Checked==true)
            {
                num = true ;
            }
            else
            {
                num = false ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            User.personId = ClsConnect._Current_Id;
            User.UserName = User_text.Text;
            User.PassWord = PAss_text.Text;
            User.ISActive = num;
            
           
            if (User.Save())
            {
                MessageBox.Show("User Is Add Succefully !! , With New ID = "+User.Id, "Result");
                UserID_la.Text = User.Id.ToString();
                
            }
            else
            {
                MessageBox.Show("User Is Not Add Succefully!!", "Result");
            }
           
        }

        private void Con_Text_Validating(object sender, CancelEventArgs e)
        {
            if (PAss_text.Text!= Con_Text.Text)
            {
                e.Cancel = true;
                Con_Text.Focus();
                errorProvider1.SetError(Con_Text, "Confirm Pass is not like Password !!");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(Con_Text, "");
            }
        }

        private void Close_But_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            Save_But.Enabled = false;
            if (User!=null)
            {
                label1.Text = "  Update  User ";
                UserID_la.Text = User.Id.ToString();
                User_text.Text = User.UserName;
                PAss_text.Text = User.PassWord;
                Con_Text.Text  = User.PassWord;
                if (User.ISActive)
                {
                    ISA_Check.Checked = true;
                }
                else
                {
                    ISA_Check.Checked= false;
                }
            }
            if (User== null)
            {
                label1.Text = "Add New USer ";
            }
            

        }
    }
}
