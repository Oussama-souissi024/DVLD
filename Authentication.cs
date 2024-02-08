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
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private bool AuthenticationStatus(string Username, string Password, ref int UserID)
        {
            return clsUsers.Authentication(Username, Password ,ref  UserID);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int UserID = 0;
            if (AuthenticationStatus(textBoxUsername.Text.ToString(), textBoxPassword.Text.ToString(), ref UserID))
            {
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                Form frm = new Form1(UserID);
                frm.ShowDialog();    
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");

                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }

        }

        private void Authentication_Load(object sender, EventArgs e)
        {

        }

        
    }
}
