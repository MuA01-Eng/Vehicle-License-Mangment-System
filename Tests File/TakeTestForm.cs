using Connect;
using DVLDMySolution.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDMySolution
{
    public partial class TakeTestForm : Form
    {
        int _ID,_TestType;
        bool Result;
        LocalLicense_Connection _LocalLicense_Connection;
        TestAppointemntConnect _TestAppointemntConnect;
        public TakeTestForm(int iD,int TestType)
        {
            InitializeComponent();
            _ID = iD;
            _TestType = TestType;
        }
        private void ChangePicture()
        {
            if (_TestType == 1)
            {
                pictureBox1.Image = Resources.View_Schedule;
                label9.Text = "Schedule Vision Test";
            }
            if (_TestType == 2)
            {
                pictureBox1.Image = Resources.Left_Handed;
                label9.Text = "Schedule Written Test";
            }
            if (_TestType == 3)
            {
                pictureBox1.Image = Resources.Car_Badge;
                label9.Text = "Schedule Street Test";
            }
        }
        private void TakeTestForm_Load(object sender, EventArgs e)
        {
            ChangePicture();
            _TestAppointemntConnect = TestAppointemntConnect.Find(_ID);
            _LocalLicense_Connection = LocalLicense_Connection.Find(_TestAppointemntConnect.LicenseId);
            if (_LocalLicense_Connection != null) 
            {
                APpL_ID.Text = _LocalLicense_Connection.localDrivingLicenseId.ToString();
                Driver_class_LAp.Text = LocalLicense_Connection.GetClassName(_LocalLicense_Connection.LicenseClassID);
                Name_Lap.Text = _LocalLicense_Connection.FullName;
                Date_lap.Text=_TestAppointemntConnect.Appointmentdate.ToString();
                Fees_lap.Text = _TestAppointemntConnect.fess.ToString();
                Trial_lap.Text= _TestAppointemntConnect.Trials.ToString();
                TestID_Lap.Text = " ???";
            }

        }
        private void Save_Butt_Click(object sender, EventArgs e)
        {
           
            TakeTestConnect Test = new TakeTestConnect();
            Test.Notes=textBox1.Text;            
            Test.TestAppointmentId = _TestAppointemntConnect.Id;
            Test.ResultOfExam =Result;
            Test.UserId = _TestAppointemntConnect.UserCreated;
            
            if (Test.save())
            {
                MessageBox.Show("Test Add Succefully !!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Question);
             
            }
            else
            {
                MessageBox.Show("Test Not Added Succefully !!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TestID_Lap.Text = Test.ID.ToString();
            Trial_lap.Text = _TestAppointemntConnect.Trials.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Result = true;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
             Result= false;
        }
    }
}
