using Connect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDMySolution
{
    public partial class SearchOnLicense : UserControl
    {
        int _ID;
        FinalLicenseConnect finalLicenseConnect;
        LocalLicense_Connection License;
        public SearchOnLicense()
        {
            InitializeComponent();
        }
        private void Load_LIcesnse()
        {
            Class_lap.Text = LocalLicense_Connection.GetClassName(License.LicenseClassID);
            Nmae_Lap.Text = License.FullName;
            LicenseId_Lap.Text = License.localDrivingLicenseId.ToString();
            No_lap.Text = License.PersonInfo.NationalNO;
            Gendor_Lap.Text = License.PersonInfo.Gender;
            Issue_date.Text = finalLicenseConnect.IssueDate.Year.ToString() + '/' + finalLicenseConnect.IssueDate.Month.ToString() + '/' + finalLicenseConnect.IssueDate.Day.ToString();
            if (finalLicenseConnect.Notes == string.Empty)
            {
                Notes_LAp.Text = "NO Notes";
            }
            else { Notes_LAp.Text = finalLicenseConnect.Notes; }
            if (finalLicenseConnect.IsActive == true)
            {
                Is_Lap.Text = "YES";
            }
            else { Is_Lap.Text = "NO"; }
            Date_Lap.Text = License.PersonInfo.DateOfBirth.Year.ToString() + '/' + License.PersonInfo.DateOfBirth.Month.ToString() + '/' + License.PersonInfo.DateOfBirth.Day.ToString();
            Driver_Lap.Text = finalLicenseConnect.DriverID.ToString();
            ExparitonDAte_lap.Text = finalLicenseConnect.ExpiarDate.Year.ToString() + '/' + finalLicenseConnect.ExpiarDate.Month.ToString() + '/' + finalLicenseConnect.ExpiarDate.Day.ToString();
            if (DetainedLicenseConnect.CheckIfLicenseDetain(finalLicenseConnect.ID))
            {
                ISDetained_lap.Text = "YES";
            }
            else
            {
                ISDetained_lap.Text = "NO";
            }
            Issue_Reason_lap.Text = "First Time";
            pictureBox1.ImageLocation = License.PersonInfo.ImagePath;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void Try_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ID = Convert.ToInt16(textBox1.Text);
            if (FinalLicenseConnect.IsLicenseHere(_ID))
            {
                finalLicenseConnect = FinalLicenseConnect.FindByLicenseID(_ID);
                License = LocalLicense_Connection.FindByApplicationId(finalLicenseConnect.ApplicationId);
                if (License != null)
                {
                    MessageBox.Show("Licesns Is Found !!", "Result ",MessageBoxButtons.OK,MessageBoxIcon.Question);
                    FinalLicenseConnect._ID_Find = _ID;
                    Load_LIcesnse();
                    Local_Lap.Text = finalLicenseConnect.ID.ToString();
                }
                else
                {
                    MessageBox.Show("There Is no Local License For this    !! ", "Result ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("License IS Not Find !! ", "Result ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        }
    }
