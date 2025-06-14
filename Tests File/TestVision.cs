using Connect;
using DVLDMySolution.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DVLDMySolution
{
    public partial class TestVision : Form
    {

        int _ID ;
        int Fees = 0,_TestType;
        LocalLicense_Connection _Connection;
        TestAppointemntConnect T1;
        ApplicationConnect Application;
        UserConnect _User;
        public TestVision(int ID, TestAppointemntConnect _T1,int test,UserConnect User)
        {
            T1 = _T1;
            InitializeComponent();
            _ID = ID;
            _TestType = test;
            _User = User;
        }
        private void ChangePicture()
        {
            if (_TestType == 1)
            {
                pictureBox1.Image = Resources.View_Schedule;
                groupBox1.Text = "Vision Test";
            }
            if (_TestType == 2)
            {
                pictureBox1.Image = Resources.Left_Handed;
                groupBox1.Text = "Written Test";
            }
            if (_TestType == 3)
            {
                pictureBox1.Image = Resources.Car_Badge;
                groupBox1.Text = "Street Test";
            }
        }
        private void TestVision_Load(object sender, EventArgs e)
        {
            
            dateTimePicker1.MinDate = DateTime.Now;
            Fees = (int)TestTypesConnection.Find(_TestType).Fees;
            Fees_lap.Text = Fees.ToString();
            ChangePicture();
            groupBox2.Enabled = false;
            _Connection= LocalLicense_Connection.Find(_ID);
            if (_Connection!=null)
            {
                APpL_ID.Text=_Connection.localDrivingLicenseId.ToString();
                Driver_class_LAp.Text = LocalLicense_Connection.GetClassName(_Connection.LicenseClassID);
                Name_Lap.Text = _Connection.FullName;    
            }

            if (T1.GetTrials(_ID,_TestType) > 0)
            {
                Application = new ApplicationConnect();
                Application.PersonId = _Connection.PersonId;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationTypeID = 8;
                Application.ApplicationStatus = 3;
                Application.LastDate = DateTime.Now;
                Application.PayFeesApplication = TypesConnection.Find(2).fees;
                Application.CreatedUser =_User.Id;
                R_App_lap.Text = TypesConnection.Find(2).fees.ToString();
                Fees +=(int) Application.PayFeesApplication;
                groupBox2.Enabled = true;
                Trial_lap.Text=T1.Trials.ToString();
            }
            
            Total_Fee_lap.Text = Fees.ToString();
            Trial_lap.Text = T1.GetTrials(_ID,_TestType).ToString();
        }

        private void Save_Butt_Click(object sender, EventArgs e)
        {
           
            T1.TestTypeID = _TestType;
            T1.LicenseId = _Connection.localDrivingLicenseId;
            T1.Appointmentdate = dateTimePicker1.Value;
            T1.fess = Fees;          
            T1.UserCreated = _Connection.CreatedUser;
            T1.IsLocked = false;
            if (T1.GetTrials(_ID, _TestType) > 0)
            {
                T1.RetakeTestIDApp = Application.ApplicationId;
            }
            else
                T1.RetakeTestIDApp = -1;
            if (T1.Save())
            {
                if (Application != null && Application.Save())
                {
                    R_TestAPp_ID_Lap.Text = Application.ApplicationId.ToString(); 
                    TestAppointemntConnect.MakeCompostionBetWAPPAndTest(T1.Id,Application.ApplicationId);
                }
                MessageBox.Show("Appointment Add Succefully !!" , "Result", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("Appointment Not Added Succefully !!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
