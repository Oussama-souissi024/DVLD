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
    public partial class UserControlShowUserDetails : UserControl
    {
        public int UserID { get; set; } = -1;
        clsUsers _LoggedInUser;
        public UserControlShowUserDetails()
        {
            InitializeComponent();
        }

        private clsUsers GetUserInfoByUserID(int UserID)
        {
            return clsUsers.GetUserInfoByUserID(UserID);
        }

        private void FilluserControlShowPersonDetails()
        {
            _LoggedInUser = clsUsers.GetUserInfoByUserID(UserID);

            if (_LoggedInUser != null)
            {
                userControlShowPersonDetails1.PersonID = _LoggedInUser.PersonID;
                userControlShowPersonDetails1.FillCardInformation(_LoggedInUser.PersonID);
            }
            else
                MessageBox.Show("Eror Loading User Information");
        }

        private void FillUserInformation()
        {
            _LoggedInUser = clsUsers.GetUserInfoByUserID(UserID);

            if (_LoggedInUser != null)
            {
                LblUserID.Text = UserID.ToString();
                LblUserName.Text = _LoggedInUser.UserName.ToString();

                if (_LoggedInUser.IsActive == true)
                    LblIsActive.Text = "Yes";
                else
                    LblIsActive.Text = "No" ;
            }
            else
                MessageBox.Show("Eror Loading User Information");

        }

        private void UserControlShowUserDetails_Load(object sender, EventArgs e)
        {
            FilluserControlShowPersonDetails();
            FillUserInformation();
        }

      
    }
}
