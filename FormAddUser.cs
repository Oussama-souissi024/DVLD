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
    public partial class FormAddUser : Form
    {
        int _PersonID = 0;
        int _UserID = -1;
        clsUsers _User;
        public FormAddUser()
        {
            InitializeComponent();
        }



        private void FormAddUser_Load(object sender, EventArgs e)
        {
            comboBoxFindBy.SelectedIndex = 0;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageUserInfo;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _User = new clsUsers();
            _User.PersonID = userControlShowPersonDetails1.PersonID;
            _User.UserName = textBoxUsername.Text;

            if(textBoxPassword.Text == textBoxConfirmPassword.Text)
                _User.Password = textBoxPassword.Text;
            else
            {
                MessageBox.Show("Error Password Not Similar");
                return;
            }

            _User.IsActive = checkBoxIsActive.Checked;

            if (_User.AddNewUser() != -1)
            {
                MessageBox.Show("User Added Successfully");
                LblUserID.Text = _User.UserID.ToString();
            }
            else
                MessageBox.Show("Eror Cannot Add User");
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            if (clsPeople.IsPersonNationalNumberExist(textBoxFindBy.Text, ref _PersonID))
            {
                userControlShowPersonDetails1.PersonID = _PersonID;
                userControlShowPersonDetails1.refreshUserControlShowPersonDetails(_PersonID);
            }
            else
                MessageBox.Show("This National Number Does Not Exist");

        }
    }
}
