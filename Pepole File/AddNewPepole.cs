using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Connect;
using System.Security.Cryptography;
using DVLDMySolution.Properties;
namespace DVLDMySolution
{
    public partial class AddNewPepole : Form
    {
        static string genderC="";
        ClsConnect _Connect;
        char _Mode=' ';
        public AddNewPepole(ClsConnect Connect,char Mode = ' ')
        {
             InitializeComponent();
            _Connect = Connect;
            _Mode = Mode;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Administrator_Male;
            genderC = radioButton1.Text;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Woman_Profile;
            genderC = radioButton2.Text;
        }
        private bool _HandlePersonImage()
        {
            if (_Connect.ImagePath != pictureBox1.ImageLocation)
            {
                if (_Connect.ImagePath!="")
                {
                    try
                    {
                        File.Delete(_Connect.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }
                if (pictureBox1.ImageLocation!=null)
                {
                    string SourceFile = pictureBox1.ImageLocation.ToString();
                    if (ClsUtil.CopyImageToProjectImagesFolder(ref SourceFile))
                    {
                        pictureBox1.ImageLocation = SourceFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        private void Fill_Form()
        {
            First_Box.Text = _Connect.First;
            Second_Box.Text=_Connect.Second;
            Third_Box.Text= _Connect.Third;
            Last_Box.Text =_Connect.Last;
            NO_Box.Text = _Connect.NationalNO;

            if (_Connect.Gender=="Male")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked= true;
                
            }
            
            Phone_Box.Text = _Connect.Phone;
            Email_Box.Text = _Connect.Email;
            Country_Box.SelectedIndex = _Connect.NationalCountry-1;
            Address_Box.Text = _Connect.Address;
            pictureBox1.ImageLocation = _Connect.ImagePath;
            dateTimePicker1.Value = _Connect.DateOfBirth;
           
            
        }
        private void FillCountries()
        {
            DataTable dataTable = ClsConnect.GetAllCountries() ;
            foreach (DataRow row in dataTable.Rows)
            {
                Country_Box.Items.Add(row["CountryNAme"]);
            }
            Country_Box.SelectedItem = "Syria";
        }
        private void AddNewUser_Load(object sender, EventArgs e)
        { 
           
            FillCountries();
           
            if (_Connect != null)
            {
                
                Fill_Form();  
            }
            

            if (_Connect.ID == -1)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                Result_La.Text = "??";
                Country_Box.SelectedItem = "Syria";
                dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
                dateTimePicker1.Value = dateTimePicker1.MaxDate;
                dateTimePicker1.MinDate = DateTime.Now.AddYears(-100);
                radioButton1.Checked = true;
            }
            else if(_Mode == 'D')
            {
                Fill_Form();
                Save_But.Hide();
                label1.Text = "   Person Details ";
                Delete_Pic.Hide();
                Save_Pic.Hide();
                Close_But.Hide();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                Result_La.Text = _Connect.ID.ToString();
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }
            else
            {
                label1.Text = "Update Person Screen";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                Result_La.Text = _Connect.ID.ToString();

            }
        }
        private void Save_Pic_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Find A Picture";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pictureBox1.Load(selectedFilePath);
                pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
            }
        }
        private void Delete_Pic_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new PictureBox().Image;            
        }
        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            bool table = ClsConnect.GetAllNO(NO_Box.Text);
            
            if (table)
            {
                e.Cancel = true;
                NO_Box.Focus();
                errorProvider1.SetError(NO_Box, "NO Number Is Allredy Exist !!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(NO_Box, "");
            }
        }       
        private void Email_Box_Validating(object sender, CancelEventArgs e)
        {
            if (!Email_Box.Text.EndsWith(".com"))
            {
                e.Cancel = true;
                Email_Box.Focus();
                errorProvider1.SetError(Email_Box, "Invalid Email !!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Email_Box, "");
            }
        }

        private void Save_But_Click(object sender, EventArgs e)
        {

            if (!_HandlePersonImage())
                return;

            _Connect.First = First_Box.Text;
            _Connect.Second = Second_Box.Text;
            _Connect.Third= Third_Box.Text;
            _Connect.Last= Last_Box.Text;
            _Connect.NationalNO=NO_Box.Text;
            _Connect.DateOfBirth = dateTimePicker1.Value;
            _Connect.Gender = genderC;
            _Connect.Phone= Phone_Box.Text;
            _Connect.Email = Email_Box.Text;
            _Connect.NationalCountry=Country_Box.SelectedIndex+1;
            _Connect.Address=Address_Box.Text;
            _Connect.ImagePath = pictureBox1.ImageLocation;
            if (_Connect.Save())
            {
                MessageBox.Show("Pepole Is Add Succefully !! With Id IS = " + _Connect.ID, "Results ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Result_La.Text=_Connect.ID.ToString();
            }
            else 
            {
                MessageBox.Show("Pepole Is not Save :)","Results");
            }

            
        }

        private void Close_But_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
