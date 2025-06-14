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
    public partial class DriverScreen : Form
    {
        public DriverScreen()
        {
            InitializeComponent();
        }

        private void DriverScreen_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex= 0;
            dataGridView1.DataSource=DriverConnect.GetAllDrivers();
            label2.Text=DriverConnect.GetCountAllDrivers().ToString();
            dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy / MM / dd";
            dataGridView1.Columns[3].HeaderText = "Full Name";
            dataGridView1.Columns[0].Width = 65;
            dataGridView1.Columns[1].Width = 65;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Width = 170;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 100;
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
            DataView DV = DriverConnect.GetAllDrivers().DefaultView;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                DV.RowFilter = string.Empty;
            }
            else if (comboBox1.Text == "Driver ID")
            {
                DV.RowFilter = "DriverID = " + textBox1.Text;
            }
            else if (comboBox1.Text == "Person ID")
            {
                DV.RowFilter = "PersonID = " + textBox1.Text;
            }
            else if (comboBox1.Text == "National NO")
            {
                DV.RowFilter = "NationalNo Like '" + textBox1.Text+"%'";
            }
            else if (comboBox1.Text == "Full Name")
            {
                DV.RowFilter = "FullName Like '" + textBox1.Text + "%'";
            }
            dataGridView1.DataSource = DV ;
        }
    }
}
