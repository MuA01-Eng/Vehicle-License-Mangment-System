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
    public partial class InternationalLicense : Form
    {
        int _ID;
        decimal _Fees;
        UserConnect _User;
        FinalLicenseConnect finalLicenseConnect;
        LocalLicense_Connection License;
        public InternationalLicense(UserConnect user)
        {
            InitializeComponent();       
            _User = user;
        }
        private void InternationalLicense_Load(object sender, EventArgs e)
        {
            _Fees= (TypesConnection.Find(6).fees);
            DateTime Date = DateTime.Now;
            App_Date_lap.Text = Date.ToString("d");
            Iss_lap.Text= Date.ToString("d");
            Ex_Lap.Text= Date.AddYears(1).ToString("d");
            Fees_lap.Text = ((int)_Fees).ToString();
            Created_lap.Text = _User.UserName.ToString();
           
        }
        
        private void Save_Butt_Click(object sender, EventArgs e)
        {
            finalLicenseConnect = FinalLicenseConnect.FindByLicenseID(FinalLicenseConnect._ID_Find);
            if (finalLicenseConnect.IsActive != true || finalLicenseConnect.ExpiarDate < DateTime.Now || InterNationalLicenseConnect.CheckIfglobalLicenseIn(finalLicenseConnect.ApplicationId) || InterNationalLicenseConnect.ISLicenseHere( _ID))
            {
                MessageBox.Show("Cant Add New License  !!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InterNationalLicenseConnect GlobalLicense = new InterNationalLicenseConnect();
                GlobalLicense.DriverID = finalLicenseConnect.DriverID;
                GlobalLicense.LicenseID = finalLicenseConnect.ID;
                GlobalLicense.IssueDate = DateTime.Now;
                GlobalLicense.ExpiarDate = DateTime.Now.AddYears(1);
                GlobalLicense.IsActive = true;
                GlobalLicense.CreatedUser = _User.Id;
                GlobalLicense.PersonId = finalLicenseConnect.PersonId;
                GlobalLicense.ApplicationTypeID = 6;
                GlobalLicense.PayFeesApplication = _Fees;
                GlobalLicense.ApplicationStatus = 3;

                if (GlobalLicense.SaveInterNationalLicense())
                {
                    MessageBox.Show("Congrats , The New ID Of License is =" + GlobalLicense.ID, "Result ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    AppId_Lap.Text = GlobalLicense.ApplicationId.ToString();
                    License_LAp.Text = GlobalLicense.ID.ToString();
                }
                else
                {
                    MessageBox.Show("There Is Something Wrong", "Result ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        
    }
}
