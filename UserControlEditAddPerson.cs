using DVLDBusinessLayer;
using Full_C__DVLD_Project.Properties;
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

namespace Full_C__DVLD_Project
{

    public partial class UserControlEditAddPerson : UserControl
    {

        public int PersonID { get; set; } = -1;
        clsPeople _PersonDetails;
        public UserControlEditAddPerson()
        {
            InitializeComponent();
        }

        public string GetNationalNo { get { return (textBoxNationalNumber.Text); } }
        public string GetFirtsName { get { return (textBoxFirstName.Text); } }
        public string GetSecondName { get { return (textBoxSecondName.Text); } }
        public string GetThirdName { get { return (textBoxThirdName.Text); } }
        public string GetLastName { get { return (textBoxLastName.Text); } }
        public DateTime GetDateOfBirth { get { return (DateTime)Convert.ToDateTime(dateTimeDateOfBirth.Text); } }
        public int GetGendor { get { return (int)Convert.ToInt32(radioButtonMale.Checked); } }
        public string GetAddress { get { return (richTextBoxAddress.Text); } }
        public string GetPhone { get { return textBoxPhone.Text; } }
        public string GetEmail { get { return (textBoxEmail.Text); } }
        public int GetNationalCountryID { get { return (comboBoxCountry.SelectedIndex + 1); } }
        public string GetImagePath { get { return (pictureBox1.ImageLocation); } }


        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountries.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {

                comboBoxCountry.Items.Add(row["CountryName"]);

            }
        }


        private void _FillPersonInformation(int PersonID)
        {
            _PersonDetails =  clsPeople.FindPersonByID(PersonID);

            if (_PersonDetails == null)
            {
                MessageBox.Show("Eror Loading = " + PersonID);
                return;
            }

            textBoxFirstName.Text = _PersonDetails.FirstName;
            textBoxSecondName.Text = _PersonDetails.SecondName;
            textBoxThirdName.Text = _PersonDetails.ThirdName;
            textBoxLastName.Text = _PersonDetails.LastName;
            textBoxNationalNumber.Text = _PersonDetails.NationalNo.ToString();

            if (_PersonDetails.Gendor == 1)
                radioButtonMale.Checked = true;
            else
                radioButtonFemale.Checked = true;

            textBoxEmail.Text = _PersonDetails.Email;
            richTextBoxAddress.Text = _PersonDetails.Address;
            dateTimeDateOfBirth.Value = _PersonDetails.DateOfBirth;
            textBoxPhone.Text = _PersonDetails.Phone;

            _FillCountriesInComoboBox();
            comboBoxCountry.SelectedIndex = _PersonDetails.NationalityCountryID -1;

            pictureBox1.ImageLocation = _PersonDetails.ImagePath;
        }

        private void UserControlُEditAddPerson_Load(object sender, EventArgs e)
        {
            if (PersonID == -1)
            {
                _FillCountriesInComoboBox();
                comboBoxCountry.SelectedIndex = 177;
            }
            else
                _FillPersonInformation(PersonID);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string ImagePath = "";
            openFileDialog1.InitialDirectory = @"C:\";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImagePath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = ImagePath;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxSecondName.Text = "";
            textBoxThirdName.Text = "";
            textBoxLastName.Text = "";
            textBoxNationalNumber.Text = "";
            radioButtonMale.Checked = true;
            textBoxEmail.Text = "";
            richTextBoxAddress.Text = "";
            dateTimeDateOfBirth.Value = DateTime.Now;
            textBoxPhone.Text = "";
            comboBoxCountry.SelectedIndex = 177;
            pictureBox1.Image = Resources.image_picture_box;
        }

        
    }
}
