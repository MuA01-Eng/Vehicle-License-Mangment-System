using Connect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDMySolution
{
    public partial class AddOrderOfLicense : Form
    {
        UserConnect _User;
        LocalLicense_Connection _Connection;
        
        public AddOrderOfLicense(UserConnect user)
        {
            InitializeComponent();
            _User = user;

        }

        private void Save_But_Click(object sender, EventArgs e)
        {
            if (LocalLicense_Connection.Check(ClsConnect._National_NO ,comboBox1.Text))
            {
                MessageBox.Show("Pepole has The Same License , Choose Another One ","Results ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                _Connection = new LocalLicense_Connection();
                _Connection.PersonId = ClsConnect._Current_Id;
                _Connection.ApplicationDate = DateTime.Now;
                _Connection.ApplicationTypeID = 1;
                _Connection.ApplicationStatus = 1;
                _Connection.LastDate = DateTime.Now;
                _Connection.PayFeesApplication = TypesConnection.GetFeeOfClassName(3);
                _Connection.CreatedUser = _User.Id;
                _Connection.LicenseClassID = comboBox1.SelectedIndex+1;
                if (_Connection.save())
                {
                    MessageBox.Show("License Add Succefully !!","Result" ) ;
                }
                else
                {
                    MessageBox.Show("License Is Not Add Succefully !!", "Result" ) ;
                }
            }
        }
        private void Close_But_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddLicense_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            Fees_lap.Text = ((int)TypesConnection.GetFeeOfClassName(3)).ToString();
            Crea_Lap.Text = _User.UserName;
            DAte_LA.Text = DateTime.Now.Year.ToString()+" / " + DateTime.Now.Month.ToString() + " / " + DateTime.Now.Day.ToString();
        }    
    }
}
