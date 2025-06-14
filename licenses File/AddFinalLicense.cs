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
    public partial class AddFinalLicense : Form
    {
        int _ID;
        UserConnect _USer;
        public AddFinalLicense(int ID,UserConnect User)
        {
            InitializeComponent();
            _ID = ID;
            _USer = User;
        }

        private void Save_Butt_Click(object sender, EventArgs e)
        {
            LocalLicense_Connection _LocalLicense_Connection = LocalLicense_Connection.Find(_ID);
            FinalLicenseConnect License =new FinalLicenseConnect ();
            License.ApplicationId = _LocalLicense_Connection.ApplicationId;
            License.LicensceClassId = _LocalLicense_Connection.LicenseClassID;
            License.IssueDate=DateTime.Now;
            License.ExpiarDate = DateTime.Now.AddYears(TypesConnection.GetValidate(_LocalLicense_Connection.LicenseClassID));
            if (textBox1.Text == string.Empty)
            {
                License.Notes = string.Empty;
            }
            else
                License.Notes = textBox1.Text;
            License.FessOfLicense = TypesConnection.GetFeeOfClassName(_LocalLicense_Connection.LicenseClassID);
            License.IsActive = true;
            License.IssueReason = 1 ;
            License.CreatedUser = _USer.Id;
            License.CreatedDate = DateTime.Now;
            License.PersonId = _LocalLicense_Connection.PersonId;
            if (License.SaveNewLicnse())
            {
                MessageBox.Show("License Add Succefully !! , The New Id = "+License.ID, "Result", MessageBoxButtons.OK, MessageBoxIcon.Question);
                ApplicationConnect.CompletedApp(_LocalLicense_Connection.ApplicationId);
            }
            else
            {
                MessageBox.Show("License Not Added Succefully !!" , "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddFinalLicense_Load(object sender, EventArgs e)
        {

        }
    }
}
