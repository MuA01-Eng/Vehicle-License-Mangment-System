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
    public partial class ReleseDetainLicense : Form
    {
        UserConnect _User;
        decimal _Fees;
        DetainedLicenseConnect DetainLicenseFind;
        public ReleseDetainLicense(UserConnect user)
        {
            InitializeComponent();
            _User = user;
        }

        private void ReleseDetainLicense_Load(object sender, EventArgs e)
        {
            _Fees = TypesConnection.Find(5).fees;
            App_Date_lap.Text = DateTime.Now.ToString("d");
            Created_lap.Text = _User.UserName;
            App_Fee.Text = ((int)_Fees).ToString();
        }
        private void Save_Butt_Click(object sender, EventArgs e)
        {
            if (DetainLicenseFind==null)
            {
                MessageBox.Show("Select LicenseID Is Not Detained", "Result ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ApplicationConnect Application = new ApplicationConnect();
                Application.PersonId = DetainedLicenseConnect.GetPersonIDByLicenseID (DetainLicenseFind.LicensceId) ;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationTypeID = 5;
                Application.ApplicationStatus = 3;
                Application.LastDate = DateTime.Now;
                Application.PayFeesApplication = _Fees;
                Application.CreatedUser = _User.Id;
                if (Application.Save())
                {
                    MessageBox.Show("Congrats License Is Released Succefully !!","Result",MessageBoxButtons.OK,MessageBoxIcon.Question);
                    App_ID.Text = Application.ApplicationId.ToString();
                    DetainedLicenseConnect.MakeDetainLicenseRelesed(DetainLicenseFind.LicensceId,DateTime.Now,_User.Id,Application.ApplicationId);
                }
                else
                {
                    MessageBox.Show("There Is Something Error !!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchOnLicense1_MouseMove(object sender, MouseEventArgs e)
        {
            DetainLicenseFind = DetainedLicenseConnect.FindDetainedLicenseByLicenseID(FinalLicenseConnect._ID_Find);
            if (DetainLicenseFind != null)
            {
                Fine_Fee.Text = ((int)DetainLicenseFind.FessOfLicense).ToString();
                License_ID.Text = DetainLicenseFind.LicensceId.ToString();
                Total_Fees.Text = ((int)_Fees + (int)DetainLicenseFind.FessOfLicense).ToString();
                AppId_Lap.Text = DetainLicenseFind.ID.ToString();
            }
        }
    }
}
