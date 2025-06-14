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

namespace DVLDMySolution
{
    public partial class ManageInterNationalLicense : Form
    {
        public ManageInterNationalLicense()
        {
            InitializeComponent();
        }

        private void ManageInterNationalLicense_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
         
            label2.Text = InterNationalLicenseConnect.GetCountrecord().ToString();
            dataGridView1.DataSource=InterNationalLicenseConnect.GetRecords();
            dataGridView1.Columns[0].HeaderText = "Int.LIcense.ID";
            dataGridView1.Columns[1].HeaderText = "App.ID";
            dataGridView1.Columns[2].HeaderText = "Driver.ID";
            dataGridView1.Columns[3].HeaderText = "L.LicenseId";
            dataGridView1.Columns[4].HeaderText = "Issue Date"; 
            dataGridView1.Columns[5].HeaderText = "Expair Date";
            dataGridView1.Columns[6].HeaderText = "Is Active";

            dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy / MM / dd";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "yyyy / MM / dd";

            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 95;
            dataGridView1.Columns[3].Width = 95;
            dataGridView1.Columns[4].Width = 125;
            dataGridView1.Columns[5].Width = 125;
            dataGridView1.Columns[6].Width = 75;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = InterNationalLicenseConnect.GetRecords().DefaultView;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                DV.RowFilter = string.Empty;
            }
            else if (comboBox1.Text == "Driver ID")
            {
                DV.RowFilter = "DriverID = " + textBox1.Text;
            }
            else if (comboBox1.Text == "Int.LicenseID")
            {
                DV.RowFilter = "InternationalLicenseID = " + textBox1.Text;
            }
            else if (comboBox1.Text == "L.License ID")
            {
                DV.RowFilter = "IssuedUsingLocalLicenseID =" + textBox1.Text ;
            }
           
            dataGridView1.DataSource = DV;
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalLicense_Connection.ID_Find = Convert.ToInt16(dataGridView1.CurrentRow.Cells[3].Value);
            LicenseHistory licenseHistory = new LicenseHistory(LocalLicense_Connection.ID_Find,2);
            licenseHistory.ShowDialog();
            LocalLicense_Connection.ID_Find = -1;

        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalLicense_Connection.ID_Find = Convert.ToInt16(dataGridView1.CurrentRow.Cells[3].Value);
            LicenseForm licenseForm = new LicenseForm (LocalLicense_Connection.ID_Find,2);
            licenseForm.ShowDialog();
            LocalLicense_Connection.ID_Find = -1;
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinalLicenseConnect FinalLicense = FinalLicenseConnect.FindByLicenseID(Convert.ToInt16(dataGridView1.CurrentRow.Cells[3].Value));

            ClsConnect Connect =ClsConnect.Find(FinalLicense.PersonId);
            AddNewPepole PepoleInfo =new AddNewPepole(Connect,'D');
            PepoleInfo.ShowDialog();
        }
    }
}
