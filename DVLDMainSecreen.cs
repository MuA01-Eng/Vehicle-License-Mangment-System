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
    public partial class DVLDMainSecreen : Form
    {
        UserConnect _User;
        ClsConnect Connect;
        public DVLDMainSecreen(UserConnect User)
        {
            InitializeComponent();
            _User = User;
           
        }

       
        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect= ClsConnect.Find(_User.personId);
            USerDetails user =new USerDetails (Connect,_User,'S');
            user.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            UsersScreen User = new UsersScreen();
            User.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect = ClsConnect.Find(_User.personId);
            USerDetails user = new USerDetails(Connect, _User, ' ');
            user.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationTypes edit = new ApplicationTypes ();
            edit.ShowDialog();
        }

        private void manageTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestTypes testTypes = new TestTypes ();
            testTypes.ShowDialog();
        }

        private void pepoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PepoleForm pepoleForm = new PepoleForm ();
            pepoleForm.ShowDialog();
        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loacal_License_Application loacal_License_Application = new Loacal_License_Application(_User);
            loacal_License_Application.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrderOfLicense addLicense = new AddOrderOfLicense(_User);
            addLicense.ShowDialog();
            ClsConnect._Current_Id = -1;

        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverScreen driverScreen = new DriverScreen();
            driverScreen.ShowDialog();
        }

        private void internationlLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternationalLicense internationalLicense = new InternationalLicense(_User); 
            internationalLicense.ShowDialog();
        }

        private void localDrivingLicenseApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageInterNationalLicense manageInterNational =new ManageInterNationalLicense();
            manageInterNational.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewLicense ReNewLicense = new RenewLicense(_User);
            ReNewLicense.ShowDialog();
        }

        private void DVLDMainSecreen_Load(object sender, EventArgs e)
        {

        }

        private void replacmentForLostOrDamagedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplacForDamaged R1=new ReplacForDamaged (_User);
            R1.ShowDialog();
            FinalLicenseConnect._ID_Find = -1;

        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetainLicense detainLicense = new DetainLicense(_User);
            detainLicense.ShowDialog();
            FinalLicenseConnect._ID_Find = -1;

        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleseDetainLicense Relese = new ReleseDetainLicense(_User);
            Relese.ShowDialog();
            FinalLicenseConnect._ID_Find = -1;
        }

        private void manageDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDetainLicense MangeDetain = new ManageDetainLicense(_User);
            MangeDetain.ShowDialog();
        }
    }
}
