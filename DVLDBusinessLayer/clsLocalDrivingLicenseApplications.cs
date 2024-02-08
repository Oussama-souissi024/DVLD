using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsLocalDrivingLicenseApplications
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsLocalDrivingLicenseApplications()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;
        }

        private clsLocalDrivingLicenseApplications(int localDrivingLicenseApplicationID, int applicationID, int licenseClassID)
        {
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            ApplicationID = applicationID;
            LicenseClassID = licenseClassID;
        }

        public static DataTable GetAllLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetAllLocalDrivingLicenseApplication();
        }

        private int _AddNewLocalDrivingLicenseApplications()
        {
            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationsDataAccess.AddNewLocalDrivingLicenseApplications( this.ApplicationID, this.LicenseClassID);
            return this.LocalDrivingLicenseApplicationID;
        }

        public int Save()
        {
            return _AddNewLocalDrivingLicenseApplications();
        }


        public static bool DeleteLocalDrivingLicenseAppliation(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.DeleteLocalDrivingLicenseAppliation(LocalDrivingLicenseApplicationID);
        }

        public static string GetLicenseClasNameByID (int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetLicenseClasNameByID( LocalDrivingLicenseApplicationID );
        }

        public static int GetApplicationIDByLDApplicationID (int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetApplicationIDByLDApplicationID(LocalDrivingLicenseApplicationID);
        }

        public static bool CanceledLocalDrivingApplicationByID(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.CanceledLocalDrivingApplicationByID(LocalDrivingLicenseApplicationID);
        }
    }   
}
