using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_C__DVLD_Project
{
    public partial class FormDetainLicense : Form
    {
        int _UserID;
        clsDetainedLicenses _DetainLicense;
        public FormDetainLicense(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void FormDetainLicense_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int LicenseIDToFind = (int)Convert.ToInt32(textBoxFindLicenseID.Text);

            if(clsLicenses.IsLicenseExist(LicenseIDToFind))
            {
                userControlLicenseInfo1.LicenseID = LicenseIDToFind;
                userControlLicenseInfo1.FillLicenseInformation(LicenseIDToFind);

                userControlDetainInfo1.LicenseID = LicenseIDToFind;
                userControlDetainInfo1.UserID = _UserID;
                userControlDetainInfo1.FillInformationBeforeDetain(LicenseIDToFind);
            }
            else
            {
                MessageBox.Show("Invalid License ID");
                return;
            }
        }

        private void FormDetainLicense_Load_1(object sender, EventArgs e)
        {

        }

        private bool CheckFineFees(decimal FineFees)
        {
            if ((FineFees >= 10) && (FineFees <= 100))
                return true;
            else
                return false;
        }
          
        public bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicenses.IsLicenseDetained(LicenseID);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if( IsLicenseDetained(userControlDetainInfo1.LicenseID))
            {
                MessageBox.Show("This License Is Alredy Detained");
                return;
            }
            else
            {
                _DetainLicense = new clsDetainedLicenses();
                _DetainLicense.LicenseID = userControlDetainInfo1.GetLicenseID;
                if (CheckFineFees(userControlDetainInfo1.GetFineFees))
                    _DetainLicense.FineFees = userControlDetainInfo1.GetFineFees;
                else
                {
                    MessageBox.Show("Eror Fine Fees Value");
                    return;
                }

                _DetainLicense.DetainDate = DateTime.Now;
                _DetainLicense.CreatedByUserID = _UserID;

                int NewDetainID = _DetainLicense.SaveDetain();

                if (NewDetainID != -1)
                {
                    MessageBox.Show("Detain License Saved Successfully");
                    userControlDetainInfo1.SetDetainID = NewDetainID;
                }
                else
                {
                    MessageBox.Show("Eror To Saved Detain License");
                    return;
                }
            }          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
