using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDBusinessLayer
{
    public class clsApplications
    {
        public int ApplicationID { get; set; }
        public int ApplicationPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public int ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public clsApplications()
        {
            this.ApplicationID = -1;
            this.ApplicationPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = -1;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
        }

        private clsApplications(int applicationID, int applicationPersonID, DateTime applicationDate, int applicationTypeID, 
                               int applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {
            ApplicationID = applicationID;
            ApplicationPersonID = applicationPersonID;
            ApplicationDate = applicationDate;
            ApplicationTypeID = applicationTypeID;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
        }

        private int _AddNewApplication()
        {
            this.ApplicationID = clsApplicationsDataAccess.AddNewApplication(this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID,
                                                         this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
            return (this.ApplicationID);
        }

        public int Save()
        {
            return _AddNewApplication();
        }

        public static DataTable GetAllApplication()
        {
            return clsApplicationsDataAccess.GetAllApplication();
        }

        //public static DataTable GetAllApplicationsOrderByIndex(int Index)
        //{
        //    //enComboxItems is a public enum type,
        //    //which was declared in the clsApplicationsDataAcsess class,
        //    //we used this type in this class which is already inherited from clsPeopleDateAcsess
        //    clsApplicationsDataAccess.enComboboxItems selectedEnumItem = (clsApplicationsDataAccess.enComboboxItems)Index;
        //    return clsApplicationsDataAccess.GetAllApplicationsOrderByIndex(selectedEnumItem);
        //}

        //Overloading of GetAllApplicationsOrderByIndex Find person with text and selectedindex
        //public static DataTable GetAllApplicationsOrderByIndex(int Index, string FindWithText)
        //{

        //    clsApplicationsDataAccess.enComboboxItems selectedEnumItem = (clsApplicationsDataAccess.enComboboxItems)Index;
        //    return clsApplicationsDataAccess.GetAllApplicationsOrderByIndex(selectedEnumItem, FindWithText);
        //}

        public static clsApplications FindApplicationByID(int  ApplicationID)
        {

            int ApplicationPersonID = -1, ApplicationTypeID = -1, ApplicationStatus = -1, CreatedByUserID = -1;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
            decimal PaidFees = 0;

            if (clsApplicationsDataAccess.GetApplicationInfoByID(ApplicationID, ref ApplicationPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus,
                                                      ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
                return new clsApplications(ApplicationID, ApplicationPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus,
                                                       LastStatusDate, PaidFees, CreatedByUserID);
            else return null;
        }
    }
}
