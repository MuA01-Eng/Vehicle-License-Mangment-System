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
    public partial class LicenseForm : Form
    {
        int _ID;
        LocalLicense_Connection License;
        int _Num;
        public LicenseForm(int id,int Num)
        {
            InitializeComponent();
            _ID = id;   
            _Num = Num;
        }


        private void LicenseForm_Load(object sender, EventArgs e)
        {
            if (_Num==1)
            {
                License = LocalLicense_Connection.Find(_ID);
            }
            if (_Num==2)
            {
                FinalLicenseConnect _FinalLicenseConnect = FinalLicenseConnect.FindByLicenseID (_ID);
                License  = LocalLicense_Connection.FindByApplicationId(_FinalLicenseConnect.ApplicationId);
            }
            if (License!=null)
            {
                FinalLicenseConnect finalLicenseConnect = FinalLicenseConnect.FindByApplicationID(License.ApplicationId) ;
                Class_lap.Text = LocalLicense_Connection.GetClassName(License.LicenseClassID)  ;
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
                    ISDetained_lap.Text = "No";
                }
                else
                {
                    ISDetained_lap.Text = "Yes";
                }
                Issue_Reason_lap.Text = "First Time";
                pictureBox2.ImageLocation = License.PersonInfo.ImagePath;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("Is Not found !!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Close();
            }
        }

        private void Close_Butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
