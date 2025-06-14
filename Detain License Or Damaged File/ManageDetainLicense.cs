using Connect;
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

namespace DVLDMySolution
{
    public partial class ManageDetainLicense : Form
    {
        UserConnect _User;
        public ManageDetainLicense(UserConnect user)
        {
            InitializeComponent();
            _User = user;
        }

        private void ManageDetainLicense_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= DetainedLicenseConnect.GetAllLicense();
            label2.Text = DetainedLicenseConnect.GetCountAllLicense().ToString();
            dataGridView1.Columns[0].HeaderText = "Detain.ID";
            dataGridView1.Columns[1].HeaderText = "L.ID";
            dataGridView1.Columns[2].HeaderText = "D.Date";
            dataGridView1.Columns[3].HeaderText = "IsRealsed";
            dataGridView1.Columns[4].HeaderText = "Fine Fees";
            dataGridView1.Columns[5].HeaderText = "Relese Date";
            dataGridView1.Columns[6].HeaderText = "National.NO";
            dataGridView1.Columns[7].HeaderText = "Full Name";
            dataGridView1.Columns[8].HeaderText = "Relese.App.ID";

            dataGridView1.Columns[2].DefaultCellStyle.Format = "yyyy / MM / dd";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "yyyy / MM / dd";

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 60;
            dataGridView1.Columns[6].Width = 60;
            dataGridView1.Columns[7].Width = 120;
            dataGridView1.Columns[8].Width = 100;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsConnect Connect = ClsConnect.Find(DetainedLicenseConnect.GetPersonIDByLicenseID(Convert.ToInt16(dataGridView1.CurrentRow.Cells[1].Value)));
            AddNewPepole PepoleInfo = new AddNewPepole(Connect, 'D');
            PepoleInfo.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalLicense_Connection.ID_Find = Convert.ToInt16(dataGridView1.CurrentRow.Cells[1].Value);
            LicenseForm licenseForm = new LicenseForm(LocalLicense_Connection.ID_Find, 2);
            licenseForm.ShowDialog();
            LocalLicense_Connection.ID_Find = -1;
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalLicense_Connection.ID_Find = Convert.ToInt16(dataGridView1.CurrentRow.Cells[1].Value);
            LicenseHistory licenseHistory = new LicenseHistory(LocalLicense_Connection.ID_Find, 2);
            licenseHistory.ShowDialog();
            LocalLicense_Connection.ID_Find = -1;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            DataView DV = DetainedLicenseConnect.GetAllLicense().DefaultView;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                DV.RowFilter = string.Empty;
            }
            else if (comboBox1.Text == "Detain ID")
            {
                DV.RowFilter = "DetainID = " + textBox1.Text;
            }
            else if (comboBox1.Text == "Full Name")
            {
                DV.RowFilter = "FullName Like '" + textBox1.Text + "%'";
            }
            else if (comboBox1.Text == "National NO")
            {
                DV.RowFilter = "NationalNO Like '" + textBox1.Text + "%'";
            }
            else if (comboBox1.Text == "Relase AppID")
            {
                DV.RowFilter = "ApplicationID =" + textBox1.Text;
            }
            dataGridView1.DataSource = DV;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Visible = false;
            }
            else
            {

                textBox1.Visible = true;
                textBox1.Focus();
            }
        }

        private void Re_Detain_Click(object sender, EventArgs e)
        {
            ReleseDetainLicense releseDetainLicense = new ReleseDetainLicense (_User);
            releseDetainLicense.ShowDialog ();
            FinalLicenseConnect._ID_Find = -1;
        }

        private void Detain_Butt_Click(object sender, EventArgs e)
        {
            DetainLicense Detain = new DetainLicense(_User);
            Detain.ShowDialog ();
            FinalLicenseConnect._ID_Find = -1;
        }
    }
}
