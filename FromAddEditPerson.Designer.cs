namespace Full_C__DVLD_Project
{
    partial class FromAddEditPerson
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
            this.LblManagePerson = new System.Windows.Forms.Label();
            this.labelPersonID = new System.Windows.Forms.Label();
            this.LblPersonID = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.userControlEditAddPerson1 = new Full_C__DVLD_Project.UserControlEditAddPerson();
            this.SuspendLayout();
            // 
            // LblManagePerson
            // 
            this.LblManagePerson.AutoSize = true;
            this.LblManagePerson.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblManagePerson.ForeColor = System.Drawing.Color.Red;
            this.LblManagePerson.Location = new System.Drawing.Point(334, 10);
            this.LblManagePerson.Name = "LblManagePerson";
            this.LblManagePerson.Size = new System.Drawing.Size(188, 40);
            this.LblManagePerson.TabIndex = 10;
            this.LblManagePerson.Text = "Add / Edit ??";
            // 
            // labelPersonID
            // 
            this.labelPersonID.AutoSize = true;
            this.labelPersonID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonID.Location = new System.Drawing.Point(39, 55);
            this.labelPersonID.Name = "labelPersonID";
            this.labelPersonID.Size = new System.Drawing.Size(83, 21);
            this.labelPersonID.TabIndex = 11;
            this.labelPersonID.Text = "Person ID";
            // 
            // LblPersonID
            // 
            this.LblPersonID.AutoSize = true;
            this.LblPersonID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPersonID.Location = new System.Drawing.Point(128, 55);
            this.LblPersonID.Name = "LblPersonID";
            this.LblPersonID.Size = new System.Drawing.Size(24, 21);
            this.LblPersonID.TabIndex = 113;
            this.LblPersonID.Text = "??";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.Image = global::Full_C__DVLD_Project.Properties.Resources.save;
            this.buttonSave.Location = new System.Drawing.Point(411, 474);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(56, 59);
            this.buttonSave.TabIndex = 122;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // userControlEditAddPerson1
            // 
            this.userControlEditAddPerson1.Location = new System.Drawing.Point(12, 89);
            this.userControlEditAddPerson1.Name = "userControlEditAddPerson1";
            this.userControlEditAddPerson1.PersonID = -1;
            this.userControlEditAddPerson1.Size = new System.Drawing.Size(815, 445);
            this.userControlEditAddPerson1.TabIndex = 121;
            // 
            // FromAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 542);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.userControlEditAddPerson1);
            this.Controls.Add(this.LblPersonID);
            this.Controls.Add(this.labelPersonID);
            this.Controls.Add(this.LblManagePerson);
            this.Name = "FromAddEditPerson";
            this.Text = "Add / Edit Person";
            this.Load += new System.EventHandler(this.FromAddEditPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblManagePerson;
        private System.Windows.Forms.Label labelPersonID;
        private System.Windows.Forms.Label LblPersonID;
        private UserControlEditAddPerson userControlEditAddPerson1;
        private System.Windows.Forms.Button buttonSave;
    }
}