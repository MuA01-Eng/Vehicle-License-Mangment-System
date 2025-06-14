using Connect;
using DVLDMySolution.Properties;
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
    public partial class VisionTestAppointment : Form
    {
        public int _ID ,_TestType;
        UserConnect _User;
        public VisionTestAppointment(int ID,int testType,UserConnect connect)
        {
            InitializeComponent();
            _ID = ID;
            _User = connect;
            _TestType = testType;
        }
        private void DataLoad()
        {
            dataGridView1.DataSource = TestAppointemntConnect.GetAppointment(_ID,_TestType);
            label4.Text = TestAppointemntConnect.GetCount(_ID,_TestType).ToString();
            if (TestAppointemntConnect.GetResultOFExam(_ID,_TestType))
            {
                Add_butt.Enabled = false;
            }
        }
       
        private void VisionTestAppointment_Load(object sender, EventArgs e)
        {
            DataLoad();
            if (_TestType== 1)
            {
                pictureBox1.Image = Resources.View_Schedule;
                label1.Text = "Vision Test Appointments";
            }
            if (_TestType==2)
            {
                pictureBox1.Image = Resources.Left_Handed;
                label1.Text = "Written Test Appointments";
            }
            if (_TestType ==3)
            {
                pictureBox1.Image = Resources.Car_Badge;
                label1.Text = "Street Test Appointments";
            }
        }

        private void Close_Butt_Click(object sender, EventArgs e)
        {
           this.Close   ();
        }
        private void Add_butt_Click(object sender, EventArgs e)
        {
            if (!TestAppointemntConnect.CheckAppointment(_ID,_TestType)) 
            {
                TestAppointemntConnect Test = new TestAppointemntConnect();
                TestVision T1 = new TestVision(_ID, Test,_TestType,_User);
                T1.ShowDialog();
                
            }
            else
            {       
                MessageBox.Show("Person Is Alredy Has A Appointment for this test,Cannot Add New Appointment", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           DataLoad();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TestAppointemntConnect.CheckIsLocked(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value), _TestType) != "Locked")
            {
                TakeTestForm T1 = new TakeTestForm(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value),_TestType);
                T1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Person Is Alredy Take this test,Can not Take A new Tist ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            DataLoad();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TestAppointemntConnect.CheckIsLocked(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value),_TestType) != "Locked")
            {
                if (TestAppointemntConnect.CheckIfIsIn(_ID,_TestType))
                {
                    TestAppointemntConnect Test = TestAppointemntConnect.Find(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    TestVision T1 = new TestVision(_ID,Test, _TestType,_User);
                    T1.ShowDialog();      
                }   
            }
            else
            {
                MessageBox.Show("Person Is Alredy Take this test,Cannot Edit This Appointment", "Result", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            DataLoad();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
