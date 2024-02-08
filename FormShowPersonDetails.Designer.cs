namespace Full_C__DVLD_Project
{
    partial class FormShowPersonDetails
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
            this.userControlShowPersonDetails1 = new Full_C__DVLD_Project.UserControlShowPersonDetails();
            this.SuspendLayout();
            // 
            // userControlShowPersonDetails1
            // 
            this.userControlShowPersonDetails1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userControlShowPersonDetails1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userControlShowPersonDetails1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userControlShowPersonDetails1.Location = new System.Drawing.Point(0, 0);
            this.userControlShowPersonDetails1.Name = "userControlShowPersonDetails1";
            this.userControlShowPersonDetails1.PersonID = 0;
            this.userControlShowPersonDetails1.Size = new System.Drawing.Size(734, 265);
            this.userControlShowPersonDetails1.TabIndex = 0;
            // 
            // FormShowPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 265);
            this.Controls.Add(this.userControlShowPersonDetails1);
            this.Name = "FormShowPersonDetails";
            this.Text = "Show Details";
            this.Load += new System.EventHandler(this.FormShowPersonDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlShowPersonDetails userControlShowPersonDetails1;
    }
}