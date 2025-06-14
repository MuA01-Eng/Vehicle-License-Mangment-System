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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLDMySolution
{
    public partial class ReplacForDamaged : Form
    {
        decimal _Fees;
        byte TypeApp,_IssueReason;
        UserConnect _User;
        FinalLicenseConnect _FinalLicense;
        public ReplacForDamaged(UserConnect user)
        {
            InitializeComponent();
            _User = user;
        }

        private void ReplacForDamaged_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
           
            App_Date_lap.Text = DateTime.Now.ToString("d");
            Created_lap.Text = _User.UserName.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _Fees = TypesConnection.Find(4).fees;
            Fees_lap.Text = ((int)_Fees).ToString();
            label7.Text = "Replacment For Damaged License";
            TypeApp = 4;
            _IssueReason = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _Fees += TypesConnection.Find(3).fees;
            Fees_lap.Text = ((int)_Fees).ToString();
            label7.Text = "Replacment For Lost License";
            TypeApp = 3;
            _IssueReason = 4;
        }
        private void Save_Butt_Click(object sender, EventArgs e)
        {
            _FinalLicense = FinalLicenseConnect.FindByLicenseID(FinalLicenseConnect._ID_Find);
            if (_FinalLicense.IsActive==false)
            {
                MessageBox.Show("Select License Is Not Active, Choose An Active One " , "Result ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FinalLicenseConnect DamagedLicense = new FinalLicenseConnect();
                DamagedLicense.PersonId = _FinalLicense.PersonId;
                DamagedLicense.ApplicationDate = DateTime.Now;
                DamagedLicense.ApplicationTypeID = TypeApp;
                DamagedLicense.ApplicationStatus = 3;
                DamagedLicense.LastDate = DateTime.Now;
                DamagedLicense.PayFeesApplication = _Fees;
                DamagedLicense.DriverID = _FinalLicense.DriverID;
                DamagedLicense.LicensceClassId = _FinalLicense.LicensceClassId;
                DamagedLicense.IssueDate = DateTime.Now;
                DamagedLicense.ExpiarDate = DateTime.Now.AddYears(10);
                DamagedLicense.Notes= _FinalLicense.Notes;
                DamagedLicense.FessOfLicense = TypesConnection.GetFeeOfClassName(_FinalLicense.LicensceClassId);
                DamagedLicense.IsActive = true;
                DamagedLicense.IssueReason = _IssueReason;
                DamagedLicense.CreatedUser = _User.Id;
                if (DamagedLicense.SaveReNewLicense())
                {
                    MessageBox.Show("Congrats License Add Sucefully , And The New ID = " + DamagedLicense.ID, "Result", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    FinalLicenseConnect.MakeLicenseUnActive(_FinalLicense.ID);
                    R_License_LAp.Text = DamagedLicense.ID.ToString();
                    AppId_Lap.Text = DamagedLicense.ApplicationId.ToString();
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
