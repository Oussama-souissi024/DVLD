namespace Full_C__DVLD_Project
{
    partial class FormUsers
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
            this.comboBoxFilterUserList = new System.Windows.Forms.ComboBox();
            this.labelManagePeople = new System.Windows.Forms.Label();
            this.textBoxFindUserByText = new System.Windows.Forms.TextBox();
            this.LblRecord = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGVMAnageUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMAnageUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFilterUserList
            // 
            this.comboBoxFilterUserList.FormattingEnabled = true;
            this.comboBoxFilterUserList.Items.AddRange(new object[] {
            "None",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "UserID",
            "PersonID",
            "IsActive"});
            this.comboBoxFilterUserList.Location = new System.Drawing.Point(86, 142);
            this.comboBoxFilterUserList.Name = "comboBoxFilterUserList";
            this.comboBoxFilterUserList.Size = new System.Drawing.Size(138, 21);
            this.comboBoxFilterUserList.TabIndex = 26;
            this.comboBoxFilterUserList.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterUserList_SelectedIndexChanged);
            // 
            // labelManagePeople
            // 
            this.labelManagePeople.AutoSize = true;
            this.labelManagePeople.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagePeople.ForeColor = System.Drawing.Color.Red;
            this.labelManagePeople.Location = new System.Drawing.Point(394, 112);
            this.labelManagePeople.Name = "labelManagePeople";
            this.labelManagePeople.Size = new System.Drawing.Size(169, 25);
            this.labelManagePeople.TabIndex = 19;
            this.labelManagePeople.Text = "Manage Users";
            // 
            // textBoxFindUserByText
            // 
            this.textBoxFindUserByText.Location = new System.Drawing.Point(248, 143);
            this.textBoxFindUserByText.Name = "textBoxFindUserByText";
            this.textBoxFindUserByText.Size = new System.Drawing.Size(143, 20);
            this.textBoxFindUserByText.TabIndex = 25;
            this.textBoxFindUserByText.Visible = false;
            this.textBoxFindUserByText.TextChanged += new System.EventHandler(this.textBoxFindUserByText_TextChanged);
            // 
            // LblRecord
            // 
            this.LblRecord.AutoSize = true;
            this.LblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecord.Location = new System.Drawing.Point(87, 11);
            this.LblRecord.Name = "LblRecord";
            this.LblRecord.Size = new System.Drawing.Size(23, 15);
            this.LblRecord.TabIndex = 23;
            this.LblRecord.Text = "??";
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecord.Location = new System.Drawing.Point(16, 11);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(65, 15);
            this.labelRecord.TabIndex = 22;
            this.labelRecord.Text = "# Record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Filter By";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Full_C__DVLD_Project.Properties.Resources.user_add;
            this.pictureBox2.Location = new System.Drawing.Point(870, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Full_C__DVLD_Project.Properties.Resources.Users2;
            this.pictureBox1.Location = new System.Drawing.Point(411, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // DGVMAnageUsers
            // 
            this.DGVMAnageUsers.AllowUserToAddRows = false;
            this.DGVMAnageUsers.AllowUserToDeleteRows = false;
            this.DGVMAnageUsers.AllowUserToOrderColumns = true;
            this.DGVMAnageUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVMAnageUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMAnageUsers.Location = new System.Drawing.Point(86, 169);
            this.DGVMAnageUsers.Name = "DGVMAnageUsers";
            this.DGVMAnageUsers.ReadOnly = true;
            this.DGVMAnageUsers.Size = new System.Drawing.Size(744, 291);
            this.DGVMAnageUsers.TabIndex = 20;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 467);
            this.Controls.Add(this.comboBoxFilterUserList);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelManagePeople);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxFindUserByText);
            this.Controls.Add(this.LblRecord);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVMAnageUsers);
            this.Name = "FormUsers";
            this.Text = "List Users";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMAnageUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFilterUserList;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelManagePeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxFindUserByText;
        private System.Windows.Forms.Label LblRecord;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVMAnageUsers;
    }
}