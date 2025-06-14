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
    public partial class ApplicationTypes : Form
    {
        TypesConnection Type;
        EditTypes editTypes;
        public ApplicationTypes()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dataGridView1.DataSource = TypesConnection.GetAllContact();
            NumUsers_lap.Text = dataGridView1.Rows.Count.ToString();
        }
        private void ApplicationTypes_Load(object sender, EventArgs e)
        {
             LoadData();
        }
        private void RefreshData()
        {
            editTypes.FormClosed += delegate
            {
                LoadData();
            };
            
        }
        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type = TypesConnection.Find(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
           
            editTypes=new EditTypes(Type);
            editTypes.Show();
            RefreshData();
        }
    }
}
