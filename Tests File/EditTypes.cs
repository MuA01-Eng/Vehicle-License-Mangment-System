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
    public partial class EditTypes : Form
    {
        TypesConnection _TypesConnection;
        public EditTypes(TypesConnection typesConnection)
        {
            InitializeComponent();
            _TypesConnection = typesConnection;
        }

        private void Close_But_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _TypesConnection.Name = textBox1.Text;
            _TypesConnection.fees = Convert.ToDecimal(textBox2.Text);

            if (_TypesConnection.Save())
            {
                MessageBox.Show("Type Is Update Succefully !!", "Result ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Type Is UnUpdated Succefully !!", "Result ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EditTypes_Load(object sender, EventArgs e)
        {
            if (_TypesConnection!=null)
            {
                Id_Lapel.Text = _TypesConnection.ID.ToString();
                textBox1.Text = _TypesConnection.Name;
                textBox2.Text=_TypesConnection.fees.ToString();
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                e.Cancel=true;
                errorProvider1.SetError(textBox1, "You Cant Insert A Empty Value !!");
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "You Cant Insert A Empty Value !!");
            }
            else
            {
                errorProvider1.SetError(textBox2, null);
            }
        }
    }
}
