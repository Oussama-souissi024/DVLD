namespace Full_C__DVLD_Project
{
    partial class FormNewLocalDrivingLicenseApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePersonInfo = new System.Windows.Forms.TabPage();
            this.buttonNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userControlShowPersonDetails1 = new Full_C__DVLD_Project.UserControlShowPersonDetails();
            this.groupBoxfilter = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxFindBy = new System.Windows.Forms.TextBox();
            this.comboBoxFindBy = new System.Windows.Forms.ComboBox();
            this.labelFindBy = new System.Windows.Forms.Label();
            this.tabPageApplicationInfo = new System.Windows.Forms.TabPage();
            this.comboBoxLicenseClass = new System.Windows.Forms.ComboBox();
            this.dateTimePickerApplicationDate = new System.Windows.Forms.DateTimePicker();
            this.LblCreatedBy = new System.Windows.Forms.Label();
            this.LblApplicationFees = new System.Windows.Forms.Label();
            this.LblApplicationID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPagePersonInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxfilter.SuspendLayout();
            this.tabPageApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(249, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Local Driving License Application";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePersonInfo);
            this.tabControl1.Controls.Add(this.tabPageApplicationInfo);
            this.tabControl1.Location = new System.Drawing.Point(27, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(985, 466);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPagePersonInfo
            // 
            this.tabPagePersonInfo.Controls.Add(this.buttonNext);
            this.tabPagePersonInfo.Controls.Add(this.groupBox1);
            this.tabPagePersonInfo.Controls.Add(this.groupBoxfilter);
            this.tabPagePersonInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPagePersonInfo.Name = "tabPagePersonInfo";
            this.tabPagePersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonInfo.Size = new System.Drawing.Size(977, 440);
            this.tabPagePersonInfo.TabIndex = 0;
            this.tabPagePersonInfo.Text = "Person Info";
            this.tabPagePersonInfo.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Image = global::Full_C__DVLD_Project.Properties.Resources.next;
            this.buttonNext.Location = new System.Drawing.Point(833, 400);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 31);
            this.buttonNext.TabIndex = 17;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userControlShowPersonDetails1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 311);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Information";
            // 
            // userControlShowPersonDetails1
            // 
            this.userControlShowPersonDetails1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userControlShowPersonDetails1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userControlShowPersonDetails1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userControlShowPersonDetails1.Location = new System.Drawing.Point(16, 18);
            this.userControlShowPersonDetails1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userControlShowPersonDetails1.Name = "userControlShowPersonDetails1";
            this.userControlShowPersonDetails1.PersonID = -1;
            this.userControlShowPersonDetails1.Size = new System.Drawing.Size(891, 287);
            this.userControlShowPersonDetails1.TabIndex = 0;
            // 
            // groupBoxfilter
            // 
            this.groupBoxfilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBoxfilter.Controls.Add(this.buttonSearch);
            this.groupBoxfilter.Controls.Add(this.textBoxFindBy);
            this.groupBoxfilter.Controls.Add(this.comboBoxFindBy);
            this.groupBoxfilter.Controls.Add(this.labelFindBy);
            this.groupBoxfilter.Location = new System.Drawing.Point(27, 9);
            this.groupBoxfilter.Name = "groupBoxfilter";
            this.groupBoxfilter.Size = new System.Drawing.Size(926, 68);
            this.groupBoxfilter.TabIndex = 1;
            this.groupBoxfilter.TabStop = false;
            this.groupBoxfilter.Text = "Filter";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Image = global::Full_C__DVLD_Project.Properties.Resources.zoom;
            this.buttonSearch.Location = new System.Drawing.Point(428, 21);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(33, 35);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxFindBy
            // 
            this.textBoxFindBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFindBy.Location = new System.Drawing.Point(250, 27);
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
            this.comboBoxFindBy.Size = new System.Drawing.Size(146, 23);
            this.comboBoxFindBy.TabIndex = 12;
            this.comboBoxFindBy.Text = "     National Number";
            // 
            // labelFindBy
            // 
            this.labelFindBy.AutoSize = true;
            this.labelFindBy.Location = new System.Drawing.Point(22, 31);
            this.labelFindBy.Name = "labelFindBy";
            this.labelFindBy.Size = new System.Drawing.Size(47, 15);
            this.labelFindBy.TabIndex = 12;
            this.labelFindBy.Text = "Find By";
            // 
            // tabPageApplicationInfo
            // 
            this.tabPageApplicationInfo.Controls.Add(this.comboBoxLicenseClass);
            this.tabPageApplicationInfo.Controls.Add(this.dateTimePickerApplicationDate);
            this.tabPageApplicationInfo.Controls.Add(this.LblCreatedBy);
            this.tabPageApplicationInfo.Controls.Add(this.LblApplicationFees);
            this.tabPageApplicationInfo.Controls.Add(this.LblApplicationID);
            this.tabPageApplicationInfo.Controls.Add(this.label6);
            this.tabPageApplicationInfo.Controls.Add(this.label5);
            this.tabPageApplicationInfo.Controls.Add(this.label4);
            this.tabPageApplicationInfo.Controls.Add(this.label3);
            this.tabPageApplicationInfo.Controls.Add(this.label2);
            this.tabPageApplicationInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageApplicationInfo.Name = "tabPageApplicationInfo";
            this.tabPageApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApplicationInfo.Size = new System.Drawing.Size(977, 440);
            this.tabPageApplicationInfo.TabIndex = 1;
            this.tabPageApplicationInfo.Text = "Application Info";
            this.tabPageApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // comboBoxLicenseClass
            // 
            this.comboBoxLicenseClass.FormattingEnabled = true;
            this.comboBoxLicenseClass.Items.AddRange(new object[] {
            "It allows the driver to drive small motorcycles, It is suitable for motorcycles w" +
                "ith small capacity and limited power.",
            "Heavy Motorcycle License (Large Motorcycle License)",
            "Ordinary driving license (car licence)",
            "Commercial driving license (taxi/limousine)",
            "",
            "Small and medium bus license",
            "Truck and heavy vehicle license"});
            this.comboBoxLicenseClass.Location = new System.Drawing.Point(388, 171);
            this.comboBoxLicenseClass.Name = "comboBoxLicenseClass";
            this.comboBoxLicenseClass.Size = new System.Drawing.Size(441, 23);
            this.comboBoxLicenseClass.TabIndex = 9;
            // 
            // dateTimePickerApplicationDate
            // 
            this.dateTimePickerApplicationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerApplicationDate.Location = new System.Drawing.Point(388, 120);
            this.dateTimePickerApplicationDate.MinDate = new System.DateTime(2024, 1, 30, 0, 0, 0, 0);
            this.dateTimePickerApplicationDate.Name = "dateTimePickerApplicationDate";
            this.dateTimePickerApplicationDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerApplicationDate.TabIndex = 8;
            // 
            // LblCreatedBy
            // 
            this.LblCreatedBy.AutoSize = true;
            this.LblCreatedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreatedBy.Location = new System.Drawing.Point(385, 279);
            this.LblCreatedBy.Name = "LblCreatedBy";
            this.LblCreatedBy.Size = new System.Drawing.Size(26, 17);
            this.LblCreatedBy.TabIndex = 7;
            this.LblCreatedBy.Text = "???";
            // 
            // LblApplicationFees
            // 
            this.LblApplicationFees.AutoSize = true;
            this.LblApplicationFees.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApplicationFees.Location = new System.Drawing.Point(385, 228);
            this.LblApplicationFees.Name = "LblApplicationFees";
            this.LblApplicationFees.Size = new System.Drawing.Size(20, 17);
            this.LblApplicationFees.TabIndex = 6;
            this.LblApplicationFees.Text = "15";
            // 
            // LblApplicationID
            // 
            this.LblApplicationID.AutoSize = true;
            this.LblApplicationID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApplicationID.Location = new System.Drawing.Point(385, 75);
            this.LblApplicationID.Name = "LblApplicationID";
            this.LblApplicationID.Size = new System.Drawing.Size(26, 17);
            this.LblApplicationID.TabIndex = 5;
            this.LblApplicationID.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Created By :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Application Fees :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "License Class :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Application Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Application ID :";
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Image = global::Full_C__DVLD_Project.Properties.Resources.cancelledbutton2;
            this.buttonCancel.Location = new System.Drawing.Point(408, 514);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 52);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Image = global::Full_C__DVLD_Project.Properties.Resources.save;
            this.buttonSave.Location = new System.Drawing.Point(560, 515);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(56, 52);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormNewLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 572);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FormNewLocalDrivingLicenseApplication";
            this.Text = "FormNewLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.FormNewLocalDrivingLicenseApplication_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePersonInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxfilter.ResumeLayout(false);
            this.groupBoxfilter.PerformLayout();
            this.tabPageApplicationInfo.ResumeLayout(false);
            this.tabPageApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePersonInfo;
        private System.Windows.Forms.TabPage tabPageApplicationInfo;
        private System.Windows.Forms.GroupBox groupBoxfilter;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxFindBy;
        private System.Windows.Forms.ComboBox comboBoxFindBy;
        private System.Windows.Forms.Label labelFindBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private UserControlShowPersonDetails userControlShowPersonDetails1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLicenseClass;
        private System.Windows.Forms.DateTimePicker dateTimePickerApplicationDate;
        private System.Windows.Forms.Label LblCreatedBy;
        private System.Windows.Forms.Label LblApplicationFees;
        private System.Windows.Forms.Label LblApplicationID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}