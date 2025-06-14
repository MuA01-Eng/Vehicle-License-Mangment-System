using Connect;
using DVLDMySolution.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDMySolution
{
    public partial class Filter : UserControl
    {
        ClsConnect _Connect;
        private int _PersonID = -1;
        public Filter()
        {
            InitializeComponent();
        }
        private void Fill_Control(ClsConnect _Connect)
        {
            if (_Connect != null)
            {
                Name_L.Text = _Connect.First + " " + _Connect.Second + " " + _Connect.Third + " " + _Connect.Last;
                No_L.Text = _Connect.NationalNO;
                Gender_l.Text = _Connect.Gender.ToString();
                Email_L.Text = _Connect.Email;
                ADdress_L.Text = _Connect.Address;
                Date_.Text = _Connect.DateOfBirth.ToString();
                Phone_L.Text = _Connect.Phone;
                Country_L.Text = ClsConnect.GetCountryById(_Connect.NationalCountry);
                pictureBox1.ImageLocation = _Connect.ImagePath;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }
        private void Filter_Load(object sender, EventArgs e)
        {  
            comboBox1.SelectedIndex = 0;
            pictureBox1.SizeMode=PictureBoxSizeMode.CenterImage;
            _Connect = ClsConnect.Find(ClsConnect._Current_Id);
            if (_Connect != null)
            {
                Name_L.Text = _Connect.First + " " + _Connect.Second + " " + _Connect.Third + " " + _Connect.Last;
                No_L.Text = _Connect.NationalNO;
                Gender_l.Text = _Connect.Gender.ToString();
                Email_L.Text = _Connect.Email;
                ADdress_L.Text = _Connect.Address;
                Date_.Text = _Connect.DateOfBirth.ToString();
                Phone_L.Text = _Connect.Phone;
                Country_L.Text = ClsConnect.GetCountryById(_Connect.NationalCountry);
                pictureBox1.ImageLocation = _Connect.ImagePath;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                groupBox1.Enabled = false;
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Person ID")
            {
                if (ClsConnect.IsExist(Convert.ToInt16(textBox1.Text)))
                {
                    _Connect = ClsConnect.Find(Convert.ToInt16(textBox1.Text));
                    MessageBox.Show("Pepole Is found", "Result !!");
                    ClsConnect._Current_Id = _Connect.ID;
                    ClsConnect._National_NO = _Connect.NationalNO;
                 
                }
                else
                {
                    MessageBox.Show("ID Is not found", "Result !!");
                }

            }
            else if (comboBox1.Text == "National NO")
            {
                if (ClsConnect.GetAllNO(textBox1.Text))
                {
                    _Connect = ClsConnect.FindByNo(textBox1.Text);
                    MessageBox.Show("Pepole Is found", "Result !!");
                    ClsConnect._Current_Id = _Connect.ID;
                    ClsConnect._National_NO = _Connect.NationalNO;
                }
                else
                {
                    MessageBox.Show("No Is not found", "Result !!");
                }
            }
           
           Fill_Control(_Connect);

        }

        private void AddPepole_But_Click(object sender, EventArgs e)
        {
            ClsConnect Connect = new ClsConnect();
            AddNewPepole a =new AddNewPepole(Connect);
            a.ShowDialog();
                 
           

        }

        
    }
}