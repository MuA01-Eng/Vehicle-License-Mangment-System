using Connect;
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
    public partial class DetainLicense : Form
    {
        UserConnect _User;
        public DetainLicense(UserConnect user)
        {
            InitializeComponent();
            _User = user;
        }
        private void DetainLicense_Load(object sender, EventArgs e)
        {
            App_Date_lap.Text = DateTime.Now.ToString("d");
            Created_lap.Text = _User.UserName;
        }
        private void Save_Butt_Click(object sender, EventArgs e)
        {
            DetainedLicenseConnect DetainLicenseFind= DetainedLicenseConnect.FindDetainedLicenseByLicenseID(FinalLicenseConnect._ID_Find);
            if (DetainLicenseFind != null )
            {
                MessageBox.Show("License Is Already Detained !! ","Result",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                if (textBox1.Text==string.Empty)
                {
                    MessageBox.Show("Add The Fine !! ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Focus();
                }
                else
                {
                    DetainedLicenseConnect detainedLicense =new DetainedLicenseConnect();
                    detainedLicense.LicensceId = FinalLicenseConnect._ID_Find;
                    detainedLicense.DetainDate = DateTime.Now;
                    detainedLicense.FessOfLicense = Convert.ToDecimal(textBox1.Text);
                    detainedLicense.UserCreated = _User.Id;
                    detainedLicense.IsRelesd = false;
                    if (detainedLicense.AddNewLicnse())
                    {
                        MessageBox.Show("License Detained Succefully !! , And The New ID Is = " + detainedLicense.ID, "Reslut", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        AppId_Lap.Text  = detainedLicense.ID.ToString();
                        License_ID.Text = detainedLicense.LicensceId.ToString();
                        FinalLicenseConnect.MakeLicenseUnActive(detainedLicense.LicensceId);
                    }
                    else
                    {
                        MessageBox.Show("There Is Something Error !!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
