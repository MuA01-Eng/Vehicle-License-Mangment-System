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
    public partial class DrivingInfo : UserControl
    {
        LocalLicense_Connection _Connect = LocalLicense_Connection.Find(LocalLicense_Connection.ID_Find); 
        public DrivingInfo()
        {
            InitializeComponent();
        }

        private void DrivingInfo_Load(object sender, EventArgs e)
        {
            if (_Connect!=null)
            {
                ID_Li_la.Text = _Connect.localDrivingLicenseId.ToString();
                Class_Lap.Text=LocalLicense_Connection.GetClassName(_Connect.LicenseClassID);
                PAssedTest_lap.Text = TestAppointemntConnect.GetPAssCoutResults(LocalLicense_Connection.ID_Find) + "/3";
                ID_APp.Text = _Connect.ApplicationId.ToString();
                Status_L.Text = "New";
                Fee_LA.Text = _Connect.PayFeesApplication.ToString();
                Type_L.Text= LocalLicense_Connection.GetTypeName(_Connect.ApplicationTypeID);
                Date_la.Text= _Connect.ApplicationDate.ToString();
                DAte2_lap.Text=_Connect.LastDate.ToString();
                User_ID.Text=_Connect.CreatedUser.ToString();
                Applicant_LA.Text=_Connect.FullName.ToString(); 
            }
        }
    }
}
