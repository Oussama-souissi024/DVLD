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
using static System.Windows.Forms.LinkLabel;

namespace Full_C__DVLD_Project
{
    public partial class FormListPeople : Form
    {
        public FormListPeople()
        {
            InitializeComponent();
        }

        
        private void _RefreshPeopleList()
        {
            DGVMAnagePeople.DataSource = clsPeople.GetAllPeople();
            
        }

        //Filter the People list without using the DataTable method
        //Filter with a direct link to the database
        private void _RefreshPeopleListWithSelectedIndex(int SelectedIndex)
        {
            if (comboBoxFilterPeopleList.SelectedIndex == 0)
            {
                _RefreshPeopleList();
                return;
            }
            else
               DGVMAnagePeople.DataSource = clsPeople.GetAllPeopleOrderByIndex(SelectedIndex);
        }

        //Overloading of _RefreshPeopleListWithSelectedIndex Find person with text and selectedindex From DataBase
        private void _RefreshPeopleListWithSelectedIndex(int SelectedIndex, string FindWithText)
        {
            if (comboBoxFilterPeopleList.SelectedIndex == 0)
            {
                _RefreshPeopleList();
                return;
            }
            else
                DGVMAnagePeople.DataSource = clsPeople.GetAllPeopleOrderByIndex(SelectedIndex, FindWithText);
        } 


        private void FormListPeople_Load(object sender, EventArgs e)
        {
            _RefreshPeopleList();
            LblRecord.Text = DGVMAnagePeople.RowCount.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FromAddEditPerson frm = new FromAddEditPerson(-1);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void comboBoxFilterPeopleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFindPErsonByText.Text = "";
            textBoxFindPErsonByText.Visible = true;
            _RefreshPeopleListWithSelectedIndex(comboBoxFilterPeopleList.SelectedIndex );
        }

        private void textBoxFindPErsonByText_TextChanged(object sender, EventArgs e)
        {
            _RefreshPeopleListWithSelectedIndex(comboBoxFilterPeopleList.SelectedIndex, textBoxFindPErsonByText.Text);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowPersonDetails frm = new FormShowPersonDetails( (int) DGVMAnagePeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

      

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + DGVMAnagePeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

                if (clsPeople.DeletePerson((int)DGVMAnagePeople.CurrentRow.Cells[0].Value))
                   {
                    MessageBox.Show("Person Deleted Successfully.");
                    _RefreshPeopleList();
                    }
                else
                    MessageBox.Show("Person is not deleted.");

        }

      

        private void editToolStripMenuItemAddNew_Click(object sender, EventArgs e)
        {
            FromAddEditPerson frm = new FromAddEditPerson(-1);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void editToolStripMenuEditPerson_Click(object sender, EventArgs e)
        {
            FromAddEditPerson frm = new FromAddEditPerson((int)DGVMAnagePeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet");
        }

       
    }
}
