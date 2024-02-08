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
    public partial class UserControlShowPersonDetails : UserControl
    {
        public int PersonID { get; set; } = -1;
        clsPeople _PersonDetails;
        public UserControlShowPersonDetails()
        {
            InitializeComponent();
        }

        private clsPeople FillOBjectPersonDetails(int PersonID)
        {
            return clsPeople.FindPersonByID(PersonID);
        }

        public  void FillCardInformation(int PersonID)
        {
            _PersonDetails = FillOBjectPersonDetails(PersonID);
            if (_PersonDetails != null)
            {
                LblPersonID.Text = _PersonDetails.PresonID.ToString();
                //LblName.Text = _PersonDetails.FirstName + " " + _PersonDetails.SecondName + " " + _PersonDetails.ThirdName + " " + _PersonDetails.LastName;
                LblName.Text = clsPeople.GetFullNameByPersonID(PersonID);
                LblNationalNumber.Text = _PersonDetails.NationalNo.ToString();

                if (_PersonDetails.Gendor == 1)
                    LbLGendor.Text = "Male";
                else
                    LbLGendor.Text = "Female";

                LblEmail.Text = _PersonDetails.Email;
                LblAddess.Text = _PersonDetails.Address;
                dateTimePickerDateOfBirth.Value = _PersonDetails.DateOfBirth;
                LblPhone.Text = _PersonDetails.Phone;
                pictureBoxPersonImage.ImageLocation = _PersonDetails.ImagePath;
                LblCountry.Text =  clsCountries.GetCountryNameByID(_PersonDetails.NationalityCountryID);
            }
        }
   
        private void UserControlShowPersonDetails_Load(object sender, EventArgs e)
        {
            FillCardInformation(PersonID);
        }

        public  void refreshUserControlShowPersonDetails(int PersonID)
        {
            FillCardInformation(PersonID);
        }

        private void linkLabelEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FromAddEditPerson frm = new FromAddEditPerson(PersonID);
            frm.ShowDialog();
        }
    }
}
