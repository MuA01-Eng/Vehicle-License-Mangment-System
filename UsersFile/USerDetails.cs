using Connect;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDMySolution
{
    public partial class USerDetails : Form
    {
        UserConnect User;
        ClsConnect _Connect;
        char Mode = ' ';
        public USerDetails(ClsConnect connect,UserConnect user, char mode)
        {
            InitializeComponent();
            _Connect = connect;
            User = user;
            Mode = mode;
        }

        private void USerDetails_Load(object sender, EventArgs e)
        {
            if (_Connect !=null && User != null)
            {
                Name_L.Text = _Connect.First + " " + _Connect.Second + " " + _Connect.Third + " " + _Connect.Last;
                No_L.Text = _Connect.NationalNO;
                Gender_l.Text = _Connect.Gender;
                Email_L.Text = _Connect.Email;
                ADdress_L.Text = _Connect.Address;
                Date_.Text = _Connect.DateOfBirth.ToString();
                Phone_L.Text = _Connect.Phone;
                Country_L.Text = ClsConnect.GetCountryById(_Connect.NationalCountry);
                pictureBox1.ImageLocation = _Connect.ImagePath;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                textBox1.Text = User.PassWord;
                label12.Text = User.Id.ToString();
                label13.Text=User.UserName;
                if (User.ISActive==true)
                {
                    label14.Text = "YES";
                }
                else
                {
                    label14.Text = "NO";
                }
                if (Mode=='S')
                {
                    groupBox3.Hide();
                    Save_But.Hide();
                }
               
            }
        }

       

        private void textBox1_Validating_1(object sender, CancelEventArgs e)
        {
            if (textBox1.Text != UserConnect.GetAllPAss(User.UserName))
            {
               
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Current Password Is Not Like Offical Password!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text != textBox3.Text)
            {
                e.Cancel = false;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Confirm Password Is Not Like Password!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox3, "");
            }
        }

        private void Close_But_Click(object sender, EventArgs e)
        {
            this.Close  ();
        }

        private void Save_But_Click(object sender, EventArgs e)
        {
            User.PassWord = textBox3.Text;
            if (User.Save())
            {
                MessageBox.Show("Password Is Update Succefully !!" ,"Result");
               
            }
            else
            {
                MessageBox.Show("Password Is Not Update Succefully!!", "Result");
            }
        }
    }
}
