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
    public partial class EditTestType : Form
    {
        TestTypesConnection testTypesConnection;
        public EditTestType(TestTypesConnection test)
        {
            InitializeComponent();
            testTypesConnection = test;
        }

        private void EditTestType_Load(object sender, EventArgs e)
        {
            if (testTypesConnection!=null)
            {
                Id_Lapel.Text = testTypesConnection.ID.ToString();
                textBox1.Text = testTypesConnection.Name;
                textBox3.Text = testTypesConnection.Description;
                textBox2.Text = testTypesConnection.Fees.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            testTypesConnection.Name = textBox1.Text;
            testTypesConnection.Fees = Convert.ToDecimal(textBox2.Text);
            testTypesConnection.Description = textBox3.Text;

            if (testTypesConnection.Save())
            {
                MessageBox.Show("Type Is Update Succefully !!", "Result ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Type Is UnUpdated Succefully !!", "Result ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Close_But_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
