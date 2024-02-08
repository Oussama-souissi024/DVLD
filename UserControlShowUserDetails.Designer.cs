namespace Full_C__DVLD_Project
{
    partial class UserControlShowUserDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUserID = new System.Windows.Forms.Label();
            this.LblUserID = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LabelIsActve = new System.Windows.Forms.Label();
            this.LblIsActive = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userControlShowPersonDetails1 = new Full_C__DVLD_Project.UserControlShowPersonDetails();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(162, 16);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(63, 21);
            this.labelUserID.TabIndex = 1;
            this.labelUserID.Text = "User ID";
            // 
            // LblUserID
            // 
            this.LblUserID.AutoSize = true;
            this.LblUserID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserID.Location = new System.Drawing.Point(224, 16);
            this.LblUserID.Name = "LblUserID";
            this.LblUserID.Size = new System.Drawing.Size(31, 21);
            this.LblUserID.TabIndex = 2;
            this.LblUserID.Text = "???";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(366, 16);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(86, 21);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "UserName";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.Location = new System.Drawing.Point(459, 16);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(31, 21);
            this.LblUserName.TabIndex = 4;
            this.LblUserName.Text = "???";
            // 
            // LabelIsActve
            // 
            this.LabelIsActve.AutoSize = true;
            this.LabelIsActve.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIsActve.Location = new System.Drawing.Point(609, 16);
            this.LabelIsActve.Name = "LabelIsActve";
            this.LabelIsActve.Size = new System.Drawing.Size(72, 21);
            this.LabelIsActve.TabIndex = 5;
            this.LabelIsActve.Text = "Is Active";
            // 
            // LblIsActive
            // 
            this.LblIsActive.AutoSize = true;
            this.LblIsActive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIsActive.Location = new System.Drawing.Point(693, 16);
            this.LblIsActive.Name = "LblIsActive";
            this.LblIsActive.Size = new System.Drawing.Size(31, 21);
            this.LblIsActive.TabIndex = 6;
            this.LblIsActive.Text = "???";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userControlShowPersonDetails1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 301);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Info";
            // 
            // userControlShowPersonDetails1
            // 
            this.userControlShowPersonDetails1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userControlShowPersonDetails1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userControlShowPersonDetails1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userControlShowPersonDetails1.Location = new System.Drawing.Point(35, 25);
            this.userControlShowPersonDetails1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userControlShowPersonDetails1.Name = "userControlShowPersonDetails1";
            this.userControlShowPersonDetails1.PersonID = -1;
            this.userControlShowPersonDetails1.Size = new System.Drawing.Size(810, 270);
            this.userControlShowPersonDetails1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelUserName);
            this.groupBox2.Controls.Add(this.labelUserID);
            this.groupBox2.Controls.Add(this.LblIsActive);
            this.groupBox2.Controls.Add(this.LblUserID);
            this.groupBox2.Controls.Add(this.LabelIsActve);
            this.groupBox2.Controls.Add(this.LblUserName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 51);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Info";
            // 
            // UserControlShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlShowUserDetails";
            this.Size = new System.Drawing.Size(895, 369);
            this.Load += new System.EventHandler(this.UserControlShowUserDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label LblUserID;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LabelIsActve;
        private System.Windows.Forms.Label LblIsActive;
        private UserControlShowPersonDetails userControlShowPersonDetails1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
