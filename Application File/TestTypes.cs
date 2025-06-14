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
    public partial class TestTypes : Form
    {
        EditTestType editTestType;
        public TestTypes()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            editTestType.FormClosed += delegate
            {
                Get_Data();
            };
            
        }
        private void Get_Data()
        {
            dataGridView1.DataSource = TestTypesConnection.GetContatct();
            NumUsers_lap.Text = TestTypesConnection.Getnum().ToString();
        }
        private void TestTypes_Load(object sender, EventArgs e)
        {
            Get_Data();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestTypesConnection Connection = TestTypesConnection.Find(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
            editTestType = new EditTestType(Connection);
            editTestType.Show();
            RefreshData();
        }
    }
}
