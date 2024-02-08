using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_C__DVLD_Project
{
    public partial class FormNewLocalDrivingLicenseApplication : Form
    {
        int _PersonID = 0;
        int _UserID = 0;
        clsApplications NewApplication;
        clsLocalDrivingLicenseApplications NewLocalDrivingLicenseApplication;
        public FormNewLocalDrivingLicenseApplication(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void FormNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            comboBoxLicenseClass.SelectedIndex = 2;
            LblCreatedBy.Text = clsUsers.GetUserNameByUserID(_UserID);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageApplicationInfo;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (clsPeople.IsPersonNationalNumberExist(textBoxFindBy.Text, ref _PersonID))
            {
                userControlShowPersonDetails1.PersonID = _PersonID;
                userControlShowPersonDetails1.refreshUserControlShowPersonDetails(_PersonID);
            }
            else
                MessageBox.Show("This National Number Does Not Exist");
        }

        

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Examine if this PersonID is a driver or not and obtain the DriverID if it exists.
        private bool IsPersonIDDriverOrNot(int PersonID , ref int DriverID )
        {
            return clsDrivers.IsPersonIDDriverOrNot(PersonID, ref DriverID);
        }

        private bool IsDriverIDHaveThisLicense(int DriverID, int LicenseClass)
        {
            return clsLicenses.IsDriverIDHaveThisLicense(DriverID, LicenseClass);
        }

        private bool IsPersonHaveMinimumLicenseAge(int PersonAge, int LicenseClassID)
        {
            return clsLicenseClasses.IsPersonHaveMinimumLicenseAge(PersonAge, LicenseClassID);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int PersonAge = clsPeople.GetPersonAgeByID(_PersonID);
            if (IsPersonHaveMinimumLicenseAge(PersonAge, comboBoxLicenseClass.SelectedIndex +1))
            {
                int DriverID = -1;
                if (!IsPersonIDDriverOrNot(_PersonID, ref DriverID) || (! IsDriverIDHaveThisLicense(DriverID, comboBoxLicenseClass.SelectedIndex + 1)))
                {
                    NewApplication = new clsApplications();
                    NewApplication.ApplicationPersonID = _PersonID;
                    NewApplication.ApplicationDate = dateTimePickerApplicationDate.Value;
                    NewApplication.ApplicationTypeID = 1;
                    NewApplication.ApplicationStatus = 1;
                    NewApplication.LastStatusDate = DateTime.Now;
                    NewApplication.PaidFees = 15;
                    NewApplication.CreatedByUserID = _UserID;
                    int ApplicationID = -1;
                    ApplicationID = NewApplication.Save();
                    if (ApplicationID != -1)
                    {
                        LblApplicationID.Text = ApplicationID.ToString();
                        MessageBox.Show("Application Added Successfully ");
                        NewLocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplications();
                        NewLocalDrivingLicenseApplication.ApplicationID = ApplicationID;
                        NewLocalDrivingLicenseApplication.LicenseClassID = comboBoxLicenseClass.SelectedIndex + 1;
                        if (NewLocalDrivingLicenseApplication.Save() != -1)
                        {
                            MessageBox.Show("Local Driving Application Added Successfully ");
                        }
                        else
                        {
                            MessageBox.Show("Eror To Add Local Driving License Application ");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Eror To Add This Application ");
                        return;
                    }
                }
                }
            else
            {
                MessageBox.Show("This Person don't have the minimum age of this license class");
                return;
            }
            }

    }
}
