namespace Full_C__DVLD_Project
{
    partial class FormListPeople
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblRecord = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVMAnagePeople = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItemAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuEditPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelManagePeople = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxFindPErsonByText = new System.Windows.Forms.TextBox();
            this.comboBoxFilterPeopleList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMAnagePeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRecord
            // 
            this.LblRecord.AutoSize = true;
            this.LblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecord.Location = new System.Drawing.Point(77, 9);
            this.LblRecord.Name = "LblRecord";
            this.LblRecord.Size = new System.Drawing.Size(23, 15);
            this.LblRecord.TabIndex = 14;
            this.LblRecord.Text = "??";
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecord.Location = new System.Drawing.Point(15, 9);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(65, 15);
            this.labelRecord.TabIndex = 13;
            this.labelRecord.Text = "# Record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filter By";
            // 
            // DGVMAnagePeople
            // 
            this.DGVMAnagePeople.AllowUserToAddRows = false;
            this.DGVMAnagePeople.AllowUserToDeleteRows = false;
            this.DGVMAnagePeople.AllowUserToOrderColumns = true;
            this.DGVMAnagePeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVMAnagePeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMAnagePeople.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVMAnagePeople.Location = new System.Drawing.Point(12, 167);
            this.DGVMAnagePeople.Name = "DGVMAnagePeople";
            this.DGVMAnagePeople.ReadOnly = true;
            this.DGVMAnagePeople.Size = new System.Drawing.Size(916, 289);
            this.DGVMAnagePeople.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.editToolStripMenuItemAddNew,
            this.editToolStripMenuEditPerson,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 148);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::Full_C__DVLD_Project.Properties.Resources.Show_Details;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(159, 6);
            // 
            // editToolStripMenuItemAddNew
            // 
            this.editToolStripMenuItemAddNew.Image = global::Full_C__DVLD_Project.Properties.Resources.Person_add;
            this.editToolStripMenuItemAddNew.Name = "editToolStripMenuItemAddNew";
            this.editToolStripMenuItemAddNew.Size = new System.Drawing.Size(162, 22);
            this.editToolStripMenuItemAddNew.Text = "Add New Person";
            this.editToolStripMenuItemAddNew.Click += new System.EventHandler(this.editToolStripMenuItemAddNew_Click);
            // 
            // editToolStripMenuEditPerson
            // 
            this.editToolStripMenuEditPerson.Image = global::Full_C__DVLD_Project.Properties.Resources.Person_Edit2;
            this.editToolStripMenuEditPerson.Name = "editToolStripMenuEditPerson";
            this.editToolStripMenuEditPerson.Size = new System.Drawing.Size(162, 22);
            this.editToolStripMenuEditPerson.Text = "Edit";
            this.editToolStripMenuEditPerson.Click += new System.EventHandler(this.editToolStripMenuEditPerson_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Full_C__DVLD_Project.Properties.Resources.Person_Delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::Full_C__DVLD_Project.Properties.Resources.Send_email;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::Full_C__DVLD_Project.Properties.Resources.phone_Call;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // labelManagePeople
            // 
            this.labelManagePeople.AutoSize = true;
            this.labelManagePeople.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagePeople.ForeColor = System.Drawing.Color.Red;
            this.labelManagePeople.Location = new System.Drawing.Point(429, 110);
            this.labelManagePeople.Name = "labelManagePeople";
            this.labelManagePeople.Size = new System.Drawing.Size(164, 30);
            this.labelManagePeople.TabIndex = 9;
            this.labelManagePeople.Text = "Manage People";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Full_C__DVLD_Project.Properties.Resources.invite_friends;
            this.pictureBox2.Location = new System.Drawing.Point(863, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Full_C__DVLD_Project.Properties.Resources.people2;
            this.pictureBox1.Location = new System.Drawing.Point(433, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxFindPErsonByText
            // 
            this.textBoxFindPErsonByText.Location = new System.Drawing.Point(247, 141);
            this.textBoxFindPErsonByText.Name = "textBoxFindPErsonByText";
            this.textBoxFindPErsonByText.Size = new System.Drawing.Size(143, 20);
            this.textBoxFindPErsonByText.TabIndex = 16;
            this.textBoxFindPErsonByText.Visible = false;
            this.textBoxFindPErsonByText.TextChanged += new System.EventHandler(this.textBoxFindPErsonByText_TextChanged);
            // 
            // comboBoxFilterPeopleList
            // 
            this.comboBoxFilterPeopleList.FormattingEnabled = true;
            this.comboBoxFilterPeopleList.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "DateOfBirth",
            "Gendor",
            "Address",
            "Phone",
            "Email",
            "NationalityCountryID",
            "ImagePath"});
            this.comboBoxFilterPeopleList.Location = new System.Drawing.Point(85, 140);
            this.comboBoxFilterPeopleList.Name = "comboBoxFilterPeopleList";
            this.comboBoxFilterPeopleList.Size = new System.Drawing.Size(138, 21);
            this.comboBoxFilterPeopleList.TabIndex = 17;
            this.comboBoxFilterPeopleList.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterPeopleList_SelectedIndexChanged);
            // 
            // FormListPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 465);
            this.Controls.Add(this.comboBoxFilterPeopleList);
            this.Controls.Add(this.textBoxFindPErsonByText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LblRecord);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVMAnagePeople);
            this.Controls.Add(this.labelManagePeople);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormListPeople";
            this.Text = "FormListPeople";
            this.Load += new System.EventHandler(this.FormListPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMAnagePeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblRecord;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVMAnagePeople;
        private System.Windows.Forms.Label labelManagePeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItemAddNew;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuEditPerson;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxFindPErsonByText;
        private System.Windows.Forms.ComboBox comboBoxFilterPeopleList;
    }
}