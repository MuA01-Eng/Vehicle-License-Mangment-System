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
    public partial class LicenseHistory : Form
    {
        int _ID;
        int _Num;
        LocalLicense_Connection _License;
        FinalLicenseConnect _FInalLicense;
        public LicenseHistory(int iD,byte num)
        {
            InitializeComponent();
            _ID = iD;
            _Num = num;
            
        }

        private void LicenseHistory_Load(object sender, EventArgs e)
        {
            if (_Num==1)
            {
                 _License  = LocalLicense_Connection.Find(_ID);
                _Num = _License.PersonId;
;            }
            if (_Num==2)
            {
                _FInalLicense = FinalLicenseConnect.FindByLicenseID(_ID);
                _Num = _FInalLicense.PersonId;
                 
            }
            dataGridView1.DataSource = FinalLicenseConnect.GetAllLocalLicense(_Num);
            dataGridView2.DataSource = FinalLicenseConnect.GetAllGlobalLicense(_Num);
            R_Lap1.Text = FinalLicenseConnect.GetAllLocalLicenseCount(_Num).ToString();
            R_Lap2.Text = FinalLicenseConnect.GetAllGlobalLicenseCount(_Num).ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
