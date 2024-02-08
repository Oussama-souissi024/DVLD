namespace Full_C__DVLD_Project
{
    partial class FormAddUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePersonInfo = new System.Windows.Forms.TabPage();
            this.buttonNext = new System.Windows.Forms.Button();
            this.groupBoxPersonInformation = new System.Windows.Forms.GroupBox();
            this.userControlShowPersonDetails1 = new Full_C__DVLD_Project.UserControlShowPersonDetails();
            this.groupBoxfilter = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxFindBy = new System.Windows.Forms.TextBox();
            this.comboBoxFindBy = new System.Windows.Forms.ComboBox();
            this.labelFindBy = new System.Windows.Forms.Label();
            this.tabPageUserInfo = new System.Windows.Forms.TabPage();
            this.LblUserID = new System.Windows.Forms.Label();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.LblAddUser = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPagePersonInfo.SuspendLayout();
            this.groupBoxPersonInformation.SuspendLayout();
            this.groupBoxfilter.SuspendLayout();
            this.tabPageUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePersonInfo);
            this.tabControl1.Controls.Add(this.tabPageUserInfo);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(30, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 531);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePersonInfo
            // 
            this.tabPagePersonInfo.Controls.Add(this.buttonNext);
            this.tabPagePersonInfo.Controls.Add(this.groupBoxPersonInformation);
            this.tabPagePersonInfo.Controls.Add(this.groupBoxfilter);
            this.tabPagePersonInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePersonInfo.Location = new System.Drawing.Point(4, 26);
            this.tabPagePersonInfo.Name = "tabPagePersonInfo";
            this.tabPagePersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonInfo.Size = new System.Drawing.Size(966, 501);
            this.tabPagePersonInfo.TabIndex = 0;
            this.tabPagePersonInfo.Text = "Person Info";
            this.tabPagePersonInfo.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Image = global::Full_C__DVLD_Project.Properties.Resources.next;
            this.buttonNext.Location = new System.Drawing.Point(843, 462);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 31);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // groupBoxPersonInformation
            // 
            this.groupBoxPersonInformation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxPersonInformation.CausesValidation = false;
            this.groupBoxPersonInformation.Controls.Add(this.userControlShowPersonDetails1);
            this.groupBoxPersonInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxPersonInformation.Location = new System.Drawing.Point(15, 81);
            this.groupBoxPersonInformation.Name = "groupBoxPersonInformation";
            this.groupBoxPersonInformation.Size = new System.Drawing.Size(943, 375);
            this.groupBoxPersonInformation.TabIndex = 1;
            this.groupBoxPersonInformation.TabStop = false;
            this.groupBoxPersonInformation.Text = "Person Information";
            // 
            // userControlShowPersonDetails1
            // 
            this.userControlShowPersonDetails1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userControlShowPersonDetails1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userControlShowPersonDetails1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userControlShowPersonDetails1.Location = new System.Drawing.Point(14, 21);
            this.userControlShowPersonDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlShowPersonDetails1.Name = "userControlShowPersonDetails1";
            this.userControlShowPersonDetails1.PersonID = -1;
            this.userControlShowPersonDetails1.Size = new System.Drawing.Size(914, 347);
            this.userControlShowPersonDetails1.TabIndex = 0;
            // 
            // groupBoxfilter
            // 
            this.groupBoxfilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBoxfilter.Controls.Add(this.buttonSearch);
            this.groupBoxfilter.Controls.Add(this.textBoxFindBy);
            this.groupBoxfilter.Controls.Add(this.comboBoxFindBy);
            this.groupBoxfilter.Controls.Add(this.labelFindBy);
            this.groupBoxfilter.Location = new System.Drawing.Point(15, 6);
            this.groupBoxfilter.Name = "groupBoxfilter";
            this.groupBoxfilter.Size = new System.Drawing.Size(943, 69);
            this.groupBoxfilter.TabIndex = 0;
            this.groupBoxfilter.TabStop = false;
            this.groupBoxfilter.Text = "Filter";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Image = global::Full_C__DVLD_Project.Properties.Resources.zoom;
            this.buttonSearch.Location = new System.Drawing.Point(423, 21);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(33, 35);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // textBoxFindBy
            // 
            this.textBoxFindBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFindBy.Location = new System.Drawing.Point(245, 27);
            this.textBoxFindBy.Name = "textBoxFindBy";
            this.textBoxFindBy.Size = new System.Drawing.Size(147, 25);
            this.textBoxFindBy.TabIndex = 13;
            // 
            // comboBoxFindBy
            // 
            this.comboBoxFindBy.FormattingEnabled = true;
            this.comboBoxFindBy.Items.AddRange(new object[] {
            "National Number"});
            this.comboBoxFindBy.Location = new System.Drawing.Point(85, 27);
            this.comboBoxFindBy.Name = "comboBoxFindBy";
            this.comboBoxFindBy.Size = new System.Drawing.Size(146, 25);
            this.comboBoxFindBy.TabIndex = 12;
            this.comboBoxFindBy.Text = "   National Number";
            // 
            // labelFindBy
            // 
            this.labelFindBy.AutoSize = true;
            this.labelFindBy.Location = new System.Drawing.Point(17, 31);
            this.labelFindBy.Name = "labelFindBy";
            this.labelFindBy.Size = new System.Drawing.Size(53, 17);
            this.labelFindBy.TabIndex = 12;
            this.labelFindBy.Text = "Find By";
            // 
            // tabPageUserInfo
            // 
            this.tabPageUserInfo.Controls.Add(this.LblUserID);
            this.tabPageUserInfo.Controls.Add(this.checkBoxIsActive);
            this.tabPageUserInfo.Controls.Add(this.textBoxConfirmPassword);
            this.tabPageUserInfo.Controls.Add(this.textBoxPassword);
            this.tabPageUserInfo.Controls.Add(this.textBoxUsername);
            this.tabPageUserInfo.Controls.Add(this.labelConfirmPassword);
            this.tabPageUserInfo.Controls.Add(this.labelPassword);
            this.tabPageUserInfo.Controls.Add(this.labelUsername);
            this.tabPageUserInfo.Controls.Add(this.labelUserID);
            this.tabPageUserInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageUserInfo.Location = new System.Drawing.Point(4, 26);
            this.tabPageUserInfo.Name = "tabPageUserInfo";
            this.tabPageUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserInfo.Size = new System.Drawing.Size(966, 501);
            this.tabPageUserInfo.TabIndex = 1;
            this.tabPageUserInfo.Text = "Login Info";
            this.tabPageUserInfo.UseVisualStyleBackColor = true;
            // 
            // LblUserID
            // 
            this.LblUserID.AutoSize = true;
            this.LblUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserID.Location = new System.Drawing.Point(419, 88);
            this.LblUserID.Name = "LblUserID";
            this.LblUserID.Size = new System.Drawing.Size(31, 21);
            this.LblUserID.TabIndex = 9;
            this.LblUserID.Text = "???";
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Location = new System.Drawing.Point(414, 312);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(73, 21);
            this.checkBoxIsActive.TabIndex = 8;
            this.checkBoxIsActive.Text = "isActive";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(414, 250);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(175, 25);
            this.textBoxConfirmPassword.TabIndex = 7;
            this.textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(414, 196);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(175, 25);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(414, 142);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(175, 25);
            this.textBoxUsername.TabIndex = 5;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(180, 250);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(148, 21);
            this.labelConfirmPassword.TabIndex = 3;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(180, 196);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 21);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(180, 142);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 21);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(180, 88);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(61, 21);
            this.labelUserID.TabIndex = 0;
            this.labelUserID.Text = "UserID";
            // 
            // LblAddUser
            // 
            this.LblAddUser.AutoSize = true;
            this.LblAddUser.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddUser.ForeColor = System.Drawing.Color.Red;
            this.LblAddUser.Location = new System.Drawing.Point(426, 11);
            this.LblAddUser.Name = "LblAddUser";
            this.LblAddUser.Size = new System.Drawing.Size(213, 40);
            this.LblAddUser.TabIndex = 11;
            this.LblAddUser.Text = "Add New User";
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Image = global::Full_C__DVLD_Project.Properties.Resources.cancelledbutton2;
            this.buttonCancel.Location = new System.Drawing.Point(415, 593);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 52);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Image = global::Full_C__DVLD_Project.Properties.Resources.save;
            this.buttonSave.Location = new System.Drawing.Point(567, 594);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(56, 52);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 649);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.LblAddUser);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAddUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePersonInfo.ResumeLayout(false);
            this.groupBoxPersonInformation.ResumeLayout(false);
            this.groupBoxfilter.ResumeLayout(false);
            this.groupBoxfilter.PerformLayout();
            this.tabPageUserInfo.ResumeLayout(false);
            this.tabPageUserInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePersonInfo;
        private System.Windows.Forms.TabPage tabPageUserInfo;
        private System.Windows.Forms.Label LblAddUser;
        private System.Windows.Forms.GroupBox groupBoxPersonInformation;
        private System.Windows.Forms.GroupBox groupBoxfilter;
        private System.Windows.Forms.TextBox textBoxFindBy;
        private System.Windows.Forms.ComboBox comboBoxFindBy;
        private System.Windows.Forms.Label labelFindBy;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private UserControlShowPersonDetails userControlShowPersonDetails1;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.Label LblUserID;
        private System.Windows.Forms.Button buttonSearch;
    }
}