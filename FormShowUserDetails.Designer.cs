namespace Full_C__DVLD_Project
{
    partial class FormShowUserDetails
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
            this.userControlShowUserDetails1 = new Full_C__DVLD_Project.UserControlShowUserDetails();
            this.SuspendLayout();
            // 
            // userControlShowUserDetails1
            // 
            this.userControlShowUserDetails1.Location = new System.Drawing.Point(0, 0);
            this.userControlShowUserDetails1.Name = "userControlShowUserDetails1";
            this.userControlShowUserDetails1.Size = new System.Drawing.Size(903, 369);
            this.userControlShowUserDetails1.TabIndex = 0;
            this.userControlShowUserDetails1.UserID = -1;
            // 
            // FormShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 371);
            this.Controls.Add(this.userControlShowUserDetails1);
            this.Name = "FormShowUserDetails";
            this.Text = "FormShowUserDetails";
            this.Load += new System.EventHandler(this.FormShowUserDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlShowUserDetails userControlShowUserDetails1;
    }
}