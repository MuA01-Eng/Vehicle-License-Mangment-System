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
    public partial class PepoleForm : Form
    {
        ClsConnect Contact;
        AddNewPepole form1;
        public PepoleForm()
        {
            
            InitializeComponent();
            
        }
        private void DataLoad() 
        {
            dataGridView1.DataSource = ClsConnect.GetAllContact();  
        }
        private void RefreshData() 
        {
            form1.FormClosed += delegate
            {
                DataLoad();
            };
           
            ResultLa.Text = ClsConnect.GetNumPeople().ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataLoad();
            ResultLa.Text= ClsConnect.GetNumPeople().ToString();
            Filter_Box.SelectedIndex= 0;
                      
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact = new ClsConnect();
            form1 = new AddNewPepole(Contact);
            form1.Show();
            RefreshData();


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact = ClsConnect.Find(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
            form1 = new AddNewPepole(Contact);
            RefreshData();
            form1.Show();
           
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            RefreshData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact = ClsConnect.Find(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
            
            if (Contact != null)
            {
                if (ClsConnect.DeletePeople(Contact.ID))
                {
                    ClsUtil.DeleteOldPicture(Contact.ImagePath);
                    MessageBox.Show("Record Is Deleted Succefully !!", "Rseults ");

                }
                else
                {
                    MessageBox.Show("Record Is UnDeleted Succefully !!", "Rseults ");
                }

            }
           
            DataLoad();
        }

        private void showDetilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact = ClsConnect.Find(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
            form1 = new AddNewPepole(Contact, 'D');
            
            form1.Show();

        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon  !!", "Result");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon  !!", "Result");
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
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = ClsConnect.GetAllContact().DefaultView;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                DV.RowFilter = string.Empty;
            }
            else if (Filter_Box.Text== "Person ID")
            {
                DV.RowFilter = "PersonID = " + textBox1.Text;
            }
            else if (Filter_Box.Text== "National No")
            {
                DV.RowFilter = "NationalNo Like '" + textBox1.Text + "%'";
            }
            else if (Filter_Box.Text == "First Name")
            {
                DV.RowFilter = "FirstName Like '" + textBox1.Text + "%'";
            }
            else if (Filter_Box.Text == "Second Name")
            {
                DV.RowFilter = "SecondName Like '" + textBox1.Text + "%'";
            }
            else if (Filter_Box.Text == "Third Name")
            {
                DV.RowFilter = "ThirdName Like '" + textBox1.Text + "%'";
            }
            else if (Filter_Box.Text == "Last Name")
            {
                DV.RowFilter = "lastName Like '" + textBox1.Text + "%'";
            }
            else if (Filter_Box.Text == "Gender")
            {
                DV.RowFilter = "Gendor Like '" + textBox1.Text + "%'";
            }
            else if (Filter_Box.Text == "Nationallity")
            {
                DV.RowFilter = "Natonallity Like '" + textBox1.Text + "%'";
            }
            else if (Filter_Box.Text == "Phone")
            {
                DV.RowFilter = "Phone Like '" + textBox1.Text + "%'";
            }
            dataGridView1.DataSource = DV;
        }

       
    }
}
