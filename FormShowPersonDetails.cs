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
    public partial class FormShowPersonDetails : Form
    {
        int _PersonID;
        public FormShowPersonDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            userControlShowPersonDetails1.PersonID = _PersonID;
        }

        private void FormShowPersonDetails_Load(object sender, EventArgs e)
        {

        }


    }
}
