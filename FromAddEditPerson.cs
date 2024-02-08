using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDBusinessLayer.clsPeople;

namespace Full_C__DVLD_Project
{
    public partial class FromAddEditPerson : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _PersonID;
        clsPeople _Person;
        public FromAddEditPerson(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;

            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
            //This will Fill the UserControl in this Form.
            userControlEditAddPerson1.PersonID = _PersonID;
        }

        private void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                LblManagePerson.Text = "Add New Person";
                _Person = new clsPeople();
                
                return;
            }
            _Person = clsPeople.FindPersonByID(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because No Person with ID = " + _PersonID);
                this.Close();
                return;
            }
            LblManagePerson.Text = "Update Person";
            LblPersonID.Text = _PersonID.ToString();
            


        }

        private void FromAddEditPerson_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            _Person.NationalNo = userControlEditAddPerson1.GetNationalNo;
            _Person.FirstName = userControlEditAddPerson1.GetFirtsName;
            _Person.SecondName = userControlEditAddPerson1.GetSecondName;
            _Person .ThirdName = userControlEditAddPerson1.GetThirdName;
            _Person.LastName = userControlEditAddPerson1.GetLastName;
            _Person.DateOfBirth = userControlEditAddPerson1.GetDateOfBirth;
            _Person.Gendor = userControlEditAddPerson1.GetGendor;
            _Person.Address = userControlEditAddPerson1.GetAddress;
            _Person.Phone = userControlEditAddPerson1.GetPhone;
            _Person.Email = userControlEditAddPerson1.GetEmail;
            _Person.NationalityCountryID = userControlEditAddPerson1.GetNationalCountryID;

            if (userControlEditAddPerson1.GetImagePath != null)
                _Person.ImagePath = userControlEditAddPerson1.GetImagePath;
            else
                _Person.ImagePath = "";

            if (clsPeople.IsPersonNationalNumberExist(userControlEditAddPerson1.GetNationalNo) && _Mode == enMode.AddNew)
            {
                MessageBox.Show("National Number is alredy exist! please choose another one :-)");
            }
            else
            {
                if (_Person.Save())
                    MessageBox.Show("Data Saved Successfully.");
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.");
            }

                

            
           
        }
    }
}
