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
    public partial class FormShowUserDetails : Form
    {
        int _UserID;
        public FormShowUserDetails(int userID)
        {
            InitializeComponent();
            _UserID = userID;
            userControlShowUserDetails1.UserID = _UserID;
        }


        private void FormShowUserDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
