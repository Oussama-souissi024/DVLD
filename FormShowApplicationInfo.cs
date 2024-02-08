using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_C__DVLD_Project
{
    public partial class FormShowApplicationInfo : Form
    {
        public FormShowApplicationInfo(int localDrivingLicenseApplicationID, int PassedTest)
        {
            InitializeComponent();
            userControlApplicationInfo1.FillApplicationBasinInfoByApplicationID(localDrivingLicenseApplicationID);
            userControlApplicationInfo1.FillLocalDrivingApplicationInfoByID(localDrivingLicenseApplicationID);
            userControlApplicationInfo1.PassedTest = PassedTest;
        }

        private void FormShowApplicationInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userControlApplicationInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
