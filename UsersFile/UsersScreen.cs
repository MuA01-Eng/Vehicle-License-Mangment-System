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
    public partial class UsersScreen : Form
    {
        AddNewUser UserForm;
        UserConnect _Connect;
        DataView DV = UserConnect.GetAll().DefaultView;
        public UsersScreen()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dataGridView1.DataSource = UserConnect.GetAll();
            NumUsers_lap.Text = UserConnect.GetAllUsers().ToString();
        } 
        private void RefreshData()
        {
            UserForm.FormClosed += delegate
            {
                LoadData();
                ClsConnect._Current_Id = -1;
            };
            NumUsers_lap.Text = UserConnect.GetAllUsers().ToString();
        }

        private void UsersScreen_Load_1(object sender, EventArgs e)
        {
            LoadData();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Connect = new UserConnect ();
            UserForm = new AddNewUser(_Connect);
            UserForm.Show();
            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Visible = false;
                textBox1.Visible = false;
            }
            else if (comboBox1.Text == "Is Active")
            {
                textBox1.Visible = false;
                comboBox2.Visible = true;
            }
            else
            {
                comboBox2.Visible= false;
                textBox1.Visible = true;
                textBox1.Focus();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                DV.RowFilter = string.Empty;
            }
            else if (comboBox1.Text == "Person ID")
            {
                DV.RowFilter = "PersonID = " + textBox1.Text;
            }
            else if (comboBox1.Text == "User Name")
            {
                DV.RowFilter = "UserName Like '" + textBox1.Text + "%'";
            }
            else if (comboBox1.Text == "Full Name")
            {
                DV.RowFilter = "FullName Like '%" + textBox1.Text + "%'";
            }
            else if (comboBox1.Text == "User ID")
            {
                DV.RowFilter = "UserID = " + textBox1.Text;
            }
            else if (comboBox1.Text == "Is Active")
            {
                
            }
            dataGridView1.DataSource = DV;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Yes")
            {
                DV.RowFilter = "IsActive = 1";
            }
            else if (comboBox2.Text == "No")
            {
                DV.RowFilter = "IsActive = 0 ";
            }
            else if (comboBox2.Text == "All")
            {
                DV.RowFilter = "IsActive = 0  Or IsActive = 1";
            }
        }

        private void Close_But_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Connect= UserConnect.Find(Convert.ToInt16( dataGridView1.CurrentRow.Cells[0].Value )) ;
            ClsConnect._Current_Id = _Connect.personId;
            UserForm = new AddNewUser( _Connect ) ;
            UserForm.ShowDialog();
            RefreshData();
            ClsConnect._Current_Id = -1;

        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Connect = new UserConnect();
            UserForm = new AddNewUser(_Connect);
            UserForm.ShowDialog();
            RefreshData() ;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Connect = UserConnect.Find(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
            if (_Connect != null)
            {
                if (UserConnect.DeleteUser(_Connect.Id))
                {

                    MessageBox.Show("User Is Deleted Succefully !!", "Rseults ");

                }
                else
                {
                    MessageBox.Show("User Is UnDeleted Succefully !!", "Rseults ");
                }
                LoadData();
            }
        }

        private void showDetilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsConnect Connect = ClsConnect.Find(Convert.ToInt16(dataGridView1.CurrentRow.Cells[1].Value));
            _Connect = UserConnect.Find(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
            USerDetails uSerDetails = new USerDetails(Connect, _Connect,'S');
            uSerDetails.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon  !!", "Result");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon  !!", "Result");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClsConnect Connect = ClsConnect.Find(Convert.ToInt16(dataGridView1.CurrentRow.Cells[1].Value));
            _Connect = UserConnect.Find(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
            USerDetails uSerDetails = new USerDetails(Connect, _Connect,' ');
            uSerDetails.ShowDialog();
            
        }
    }
}