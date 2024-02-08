namespace Full_C__DVLD_Project
{
    partial class FormShowApplicationInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.userControlApplicationInfo1 = new Full_C__DVLD_Project.UserControlApplicationInfo();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::Full_C__DVLD_Project.Properties.Resources.cancelledbutton2;
            this.button1.Location = new System.Drawing.Point(403, 459);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(55, 54);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControlApplicationInfo1
            // 
            this.userControlApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlApplicationInfo1.LocalDrivingLicenseApplicationID = 0;
            this.userControlApplicationInfo1.Location = new System.Drawing.Point(0, 0);
            this.userControlApplicationInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlApplicationInfo1.Name = "userControlApplicationInfo1";
            this.userControlApplicationInfo1.PassedTest = 0;
            this.userControlApplicationInfo1.Size = new System.Drawing.Size(890, 455);
            this.userControlApplicationInfo1.TabIndex = 3;
            this.userControlApplicationInfo1.Load += new System.EventHandler(this.userControlApplicationInfo1_Load);
            // 
            // FormShowApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 520);
            this.Controls.Add(this.userControlApplicationInfo1);
            this.Controls.Add(this.button1);
            this.Name = "FormShowApplicationInfo";
            this.Text = "Show Application Info";
            this.Load += new System.EventHandler(this.FormShowApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private UserControlApplicationInfo userControlApplicationInfo1;
    }
}