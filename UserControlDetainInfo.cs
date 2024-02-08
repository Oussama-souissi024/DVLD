using DVLDBusinessLayer;
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
    public partial class UserControlDetainInfo : UserControl
    {
        public int UserID { get; set; }
        public int LicenseID { get; set; }
        public UserControlDetainInfo()
        {
            InitializeComponent();
        }

        public decimal GetFineFees { get { return decimal.Parse(textBoxFineFees.Text); } }
        public int GetLicenseID { get { return int.Parse(LblLicenseID.Text); } }
        public int SetDetainID { set { LblDetainID.Text = value.ToString(); } }

        public void FillInformationBeforeDetain(int LicenseID)
        {
            if (clsLicenses.IsLicenseExist(LicenseID))
                LblLicenseID.Text = LicenseID.ToString();
            else
            {
                MessageBox.Show("Invalid License ID");
                return;
            }
            LblDetainDate.Text = DateTime.Now.ToString();
            LblCreatedBy.Text = clsUsers.GetUserNameByUserID(UserID);
        }
         
        private void UserControlDetainInfo_Load(object sender, EventArgs e)
        {
            FillInformationBeforeDetain(LicenseID);
        }

   
    }
}
