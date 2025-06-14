using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Connect;

namespace DVLDMySolution
{
    public partial class Login_Screen : Form
    {
        string FilePAth = @"C:\DVLD Files\Register.txt";
       
        short tries = 3;
        
        public Login_Screen()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
        
        

        private void Login_Screen_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (ClsUtil.GetStoredCredential(ref UserName, ref Password))
            {
                textBox1.Text = UserName;
                textBox2.Text = Password;
                checkBox2.Checked = true;
            }
            else
                checkBox2.Checked = false;

        }

        private void Login_But_Click(object sender, EventArgs e)
        {
            string User = UserConnect.GetUser(textBox1.Text);
            string Password=UserConnect.GetAllPAss(textBox1.Text);
            if (tries>0)
            {
                if (checkBox2.Checked==true)
                {
                    ClsUtil.RememberUsernameAndPassword(textBox1.Text.Trim(), textBox2.Text.Trim());
                }
                else
                {
                    ClsUtil.RememberUsernameAndPassword("", "");
                }

                if (textBox1.Text == User && textBox2.Text == Password  )
                {
                    //if User Active
                    UserConnect _User = UserConnect.FindByUserName(User);
                    DVLDMainSecreen form1 = new DVLDMainSecreen(_User);
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Your Password Or UserName Is UnCorrect !! ", "Result ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    tries--;
                    Result_La.Text = "You Have " + tries + " Tries Before You Banned ";
                }
            }
            if (tries==0)
            {
                MessageBox.Show("Your Tries Is Finished Call The Author !! ", "Result ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                Result_La.Text = "Call Authors !!";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
