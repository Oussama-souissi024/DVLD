using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;
using Microsoft.Win32;

namespace Full_C__DVLD_Project
{
    public partial class Form1 : Form
    {
        public int UserID;
        public Form1(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListPeople frm = new FormListPeople() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            panel1.Visible = true;
            frm.Show();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers frm = new FormUsers() { TopLevel = false, FormBorderStyle = FormBorderStyle.None};
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            panel1.Visible = true;
            frm.Show();

        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormShowUserDetails(UserID);
            frm.ShowDialog();
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormChangePassword(UserID);
            frm.ShowDialog();
        }

        private void manageDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormDetainLicense(UserID);
            frm.ShowDialog();
        }

        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormNewLocalDrivingLicenseApplication(16);
                frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form frm = new FormManageLocalDivingApplication(UserID) { TopLevel = false, FormBorderStyle = FormBorderStyle.None } ;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            panel1.Visible = true;
            frm.Show();
        }
    }
}
