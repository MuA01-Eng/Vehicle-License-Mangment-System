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
    public partial class RenewLicense : Form
    {
        UserConnect _User;
        decimal _Fees;
        FinalLicenseConnect _FinalLicense;
        public RenewLicense(UserConnect User )
        {
            InitializeComponent();
            _User = User;
        }
        private void RenewLicense_Load(object sender, EventArgs e)
        {
            _Fees = (TypesConnection.Find(2).fees);
            DateTime Date = DateTime.Now;
            App_Date_lap.Text = Date.ToString("d");
            Iss_lap.Text = Date.ToString("d");
            Ex_Lap.Text = Date.AddYears(1).ToString("d");
            Fees_lap.Text = ((int)TypesConnection.GetFeeOfClassName(3)).ToString();
            Created_lap.Text = _User.UserName.ToString();
            Total_fee.Text = ((int)_Fees + (int)TypesConnection.GetFeeOfClassName(3)).ToString();
            AppFee_lap.Text = ((int)_Fees).ToString();
        }

        private void Save_Butt_Click(object sender, EventArgs e)
        {
            _FinalLicense = FinalLicenseConnect.FindByLicenseID(FinalLicenseConnect._ID_Find);
            if (_FinalLicense.ExpiarDate>DateTime.Now)
            {
                MessageBox.Show("Select License Is Not Yet Expaireed , It Will Be Expire In " + _FinalLicense.ExpiarDate.ToString("d"), "Result ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FinalLicenseConnect ReNewLicense = new FinalLicenseConnect();
                ReNewLicense.PersonId = _FinalLicense.PersonId;
                ReNewLicense.ApplicationDate = DateTime.Now;
                ReNewLicense.ApplicationTypeID = 2;
                ReNewLicense.ApplicationStatus = 3;
                ReNewLicense.LastDate = DateTime.Now;
                ReNewLicense.PayFeesApplication = _Fees;
                ReNewLicense.DriverID = _FinalLicense.DriverID;
                ReNewLicense.LicensceClassId = _FinalLicense.LicensceClassId;
                ReNewLicense.IssueDate = DateTime.Now;
                ReNewLicense.ExpiarDate = DateTime.Now.AddYears(10);
                if (textBox1.Text==string.Empty)
                {
                    ReNewLicense.Notes = string.Empty;
                }
                else
                    ReNewLicense.Notes=textBox1.Text;
                ReNewLicense.FessOfLicense = TypesConnection.GetFeeOfClassName(_FinalLicense.LicensceClassId);
                ReNewLicense.IsActive = true;
                ReNewLicense.IssueReason = 2;
                ReNewLicense.CreatedUser = _User.Id;
                if (ReNewLicense.SaveReNewLicense())
                {                   
                    MessageBox.Show("Congrats License Add Sucefully , And The New ID = " + ReNewLicense.ID, "Result", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    FinalLicenseConnect.MakeLicenseUnActive(_FinalLicense.ID);
                    License_LAp.Text = ReNewLicense.ID.ToString();
                    AppId_Lap.Text = ReNewLicense.ApplicationId.ToString();
                }
                else
                {
                    MessageBox.Show("Error License Is NotAdd Sucefully ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
