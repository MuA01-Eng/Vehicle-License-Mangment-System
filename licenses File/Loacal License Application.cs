using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Connect;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace DVLDMySolution
{
    public partial class Loacal_License_Application : Form
    {
        DataView DV;
        UserConnect _User;
        public Loacal_License_Application(UserConnect user)
        {
            InitializeComponent();
            _User = user;
        }
        private void RefreshData()
        {
            Load_Data();
        }
        private void Load_Data()
        {
            dataGridView1.DataSource= LocalLicense_Connection.GetContact();
            ResultLa.Text=LocalLicense_Connection.GetNums().ToString(); 
        }
        private void Loacal_License_Application_Load(object sender, EventArgs e)
        {
            RefreshData();
            Filter_Box.SelectedIndex = 0; 
        }

        private void Filter_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Filter_Box.SelectedIndex == 0)
            {
                textBox1.Visible = false;       
            }      
            else
            {
                textBox1.Visible = true;
                textBox1.Focus();
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DV = LocalLicense_Connection.GetContact().DefaultView;
            
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                DV.RowFilter = string.Empty;
            }
            else if (Filter_Box.Text == "L.D.LAppID")
            {
                DV.RowFilter = "L.D.LAppID = " + textBox1.Text;
            }
            else if (Filter_Box.Text == "National NO")
            {
                DV.RowFilter = "NationalNo Like '" + textBox1.Text + "%'";
            }
            else if (Filter_Box.Text == "Full Name")
            {
                DV.RowFilter = "FullName Like '%" + textBox1.Text + "%'";
            }
            else if (Filter_Box.Text == "Status")
            {
                DV.RowFilter = "Status Like '" + textBox1.Text + "%'";
            }
            dataGridView1.DataSource = DV;
        }
        private void cancelledToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LocalLicense_Connection _Connect = LocalLicense_Connection.Find(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
            MessageBox.Show("Are You Sure To Cancelld This Application ?? ","Result",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (DialogResult==DialogResult.OK)
            {
                if (ApplicationConnect.CancelledApp(_Connect.ApplicationId))
                {
                    MessageBox.Show("Application IS Cancelled", "Result ");
                }
                else
                {
                    MessageBox.Show("Application Is Already Cancelled Or Completed", "Result ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            RefreshData();
        }
        private void sToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            if (TestAppointemntConnect.GetPAssCoutResults(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)) == 0)
            {
                scheduleVisionTestToolStripMenuItem.Enabled = true;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
            }
            else if (TestAppointemntConnect.GetPAssCoutResults(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)) == 1)
            {
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = true;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
            }
            else if (TestAppointemntConnect.GetPAssCoutResults(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)) == 2)
            {
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = true;
            }
           
        }
        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalLicense_Connection.ID_Find = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            VisionTestAppointment T1= new VisionTestAppointment(LocalLicense_Connection.ID_Find, 1,_User);
            T1.ShowDialog();
            LocalLicense_Connection.ID_Find = -1;
            RefreshData();
        }
        
        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalLicense_Connection.ID_Find = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            VisionTestAppointment T1 = new VisionTestAppointment(LocalLicense_Connection.ID_Find,2, _User);
            T1.ShowDialog();
            LocalLicense_Connection.ID_Find = -1;
            RefreshData();
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalLicense_Connection.ID_Find = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            VisionTestAppointment T1 = new VisionTestAppointment(LocalLicense_Connection.ID_Find,3, _User);
            T1.ShowDialog();
            LocalLicense_Connection.ID_Find = -1;
            RefreshData();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalLicense_Connection.ID_Find = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            LicenseForm license = new LicenseForm(LocalLicense_Connection.ID_Find,1);
            license.ShowDialog();
            LocalLicense_Connection.ID_Find = -1;
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalLicense_Connection.ID_Find = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            AddFinalLicense AddLicense = new AddFinalLicense(LocalLicense_Connection.ID_Find,_User);
            AddLicense.ShowDialog();
            LocalLicense_Connection.ID_Find = -1;
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalLicense_Connection.ID_Find = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            LicenseHistory licenseHistory = new LicenseHistory(LocalLicense_Connection.ID_Find,1);   
            licenseHistory.ShowDialog();
            LocalLicense_Connection.ID_Find = -1 ;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (TestAppointemntConnect.GetPAssCoutResults(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)) == 3)
            {
                sToolStripMenuItem.Enabled = false;
                cancelledToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = true;
                showPersonLicenseHistoryToolStripMenuItem.Enabled = true;
                if (FinalLicenseConnect.SearchOnLicensebyLocalDrivingID(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)))
                {
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                }
                else
                {
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                }
            }
            else
            {
                sToolStripMenuItem.Enabled = true;
                cancelledToolStripMenuItem.Enabled = true;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
                showPersonLicenseHistoryToolStripMenuItem.Enabled   =false;
            }
           
        }
    }
}
