using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_C__DVLD_Project
{
    public partial class FormChangePassword : Form
    {
        int _UserID;
        public FormChangePassword(int userID)
        {
            InitializeComponent();
            _UserID = userID;
            userControlShowUserDetails1.UserID = _UserID;
        }


        private bool CheckCurrentPassword(int UserID, string Paswword)
        {
            return clsUsers.CheckCurrentPassword(UserID, Paswword);
        }

        private bool ChangeUserPassword(int UserID, string NewPaswword)
        {
            return clsUsers.ChangeUserPassword(UserID, NewPaswword);
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void ResetPassword()
        {
            textBoxCurrentPass.Text = "";
            textBoxNewPass.Text = "";
            textBoxConfirmPass.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetPassword();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CheckCurrentPassword(_UserID,textBoxCurrentPass.Text))
            {
                if (textBoxNewPass.Text == textBoxConfirmPass.Text)
                {
                    if(ChangeUserPassword(_UserID,textBoxNewPass.Text))
                    {
                        MessageBox.Show("Password Successfully Changed ");

                        ResetPassword();
                    }
                }
                else
                {
                    MessageBox.Show("Eror the new password is not the same ");

                    ResetPassword();
                }       
            }
            else
            {
                MessageBox.Show("Eror the current password is not the same");

                ResetPassword();

            }
        }

      
    }
}
