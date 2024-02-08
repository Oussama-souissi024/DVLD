using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsLicenses
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public clsLicenses()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = false;
            this.IssueReason = 0;
            this.CreatedByUserID = -1;

        }

        private clsLicenses(int licenseID, int applicationID, int driverID, int licenseClass, DateTime issueDate, DateTime expirationDate,
                           string notes, decimal paidFees, bool isActive, int issueReason, int createdByUserID)
        {
            this.LicenseID = licenseID;
            this.ApplicationID = applicationID;
            this.DriverID = driverID;
            this.LicenseClass = licenseClass;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.Notes = notes;
            this.PaidFees = paidFees;
            this.IsActive = isActive;
            this.IssueReason = issueReason;
            this.CreatedByUserID = createdByUserID;
        }

        public static bool IsLicenseExist(int LicenseID)
        {
            return clsLicensesDataAccess.IsLicenseExist(LicenseID);
        }

        public static clsLicenses Find(int LicenceID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClass=-1, issueReason=-1, createdByUserID=-1;
            DateTime issueDate = DateTime.Now, expirationDate = DateTime.Now;
            string notes = "";
            decimal paidFees = 0;
            bool isActive = false;

            if (clsLicensesDataAccess.GetLicenseInfoByID(LicenceID, ref ApplicationID, ref DriverID, ref LicenseClass, ref issueDate, ref expirationDate,
                                                        ref notes, ref paidFees, ref isActive, ref issueReason, ref createdByUserID))

                return new clsLicenses(LicenceID, ApplicationID, DriverID, LicenseClass, issueDate, expirationDate,
                                                        notes, paidFees, isActive, issueReason, createdByUserID);
            else
                return null;
        }

        public static string GetLicenceDriverNameByLicenseID(int licenseID)
        {
            return clsLicensesDataAccess.GetLicenceDriverNameByLicenseID(licenseID);
        }

        public static string GetLicenseDriverNationalNoByLicenseID(int LicenseID)
        {
            return clsLicensesDataAccess.GetLicenseDriverNationalNoByLicenseID(LicenseID);
        }

        public static string GetLicenseDriverGendorByLicenceID(int LicenseID)
        {
            return clsLicensesDataAccess.GetLicenseDriverGendorByLicenceID(LicenseID);
        }

        public static DateTime GetLicenseDriverDateOfBirthByLicenseID(int LicenseID)
        {
            return clsLicensesDataAccess.GetLicenseDriverDateOfBirthByLicenseID(LicenseID);
        }

        public static string GetLicenseDriverImagePathByLicenseID(int LicenseID)
        {
            return clsLicensesDataAccess.GetLicenseDriverImagePathByLicenseID(LicenseID);
        }

        public static bool IsDriverIDHaveThisLicense(int DriverID, int LicenseClass)
        {
            return clsLicensesDataAccess.IsDriverIDHaveThisLicense(DriverID, LicenseClass);
        }

    }
}
