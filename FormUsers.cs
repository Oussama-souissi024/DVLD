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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        //Filter the People list without using the DataTable method
        //Filter with a direct link to the database

        private void _RefreshUsersListWithSelectedIndex(int SelectedIndex)
        {
            if (comboBoxFilterUserList.SelectedIndex == 0)
                return;
            else
                DGVMAnageUsers.DataSource = clsUsers.GetAllUsersOrderByIndex(SelectedIndex);
        }

        //Overloading of _RefreshPeopleListWithSelectedIndex Find person with text and selectedindex
        private void _RefreshUsersListWithSelectedIndex(int SelectedIndex, string FindWithText)
        {
            if (comboBoxFilterUserList.SelectedIndex == 0)
                return;
            else
                DGVMAnageUsers.DataSource = clsUsers.GetAllUsersOrderByIndex(SelectedIndex, FindWithText);
        }


        private void _RefreshUsersList()
        {
            DGVMAnageUsers.DataSource = clsUsers.GetAllUsers();
            DGVMAnageUsers.Columns[0].Width = 300;

        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
            LblRecord.Text = DGVMAnageUsers.RowCount.ToString();
        }

        private void comboBoxFilterUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFindUserByText.Text = "";
            textBoxFindUserByText.Visible = true;
            _RefreshUsersListWithSelectedIndex(comboBoxFilterUserList.SelectedIndex);
            DGVMAnageUsers.Columns[0].Width = 300;
        }

        private void textBoxFindUserByText_TextChanged(object sender, EventArgs e)
        {
            _RefreshUsersListWithSelectedIndex(comboBoxFilterUserList.SelectedIndex, textBoxFindUserByText.Text);
            DGVMAnageUsers.Columns[0].Width = 300;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormAddUser frm = new FormAddUser();
            frm.ShowDialog();
        }
    }
}
