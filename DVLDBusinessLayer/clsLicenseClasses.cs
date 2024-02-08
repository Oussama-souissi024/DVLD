using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsLicenseClasses
    {
        public static string GetLicenseClassNameByLicenseClassID(int licenseClassID)
        {
            return clsLicenseClassesDataAccess.GetLicenseClassNameByLicenseClassID(licenseClassID);
        }

        public static  bool IsPersonHaveMinimumLicenseAge(int PersonAge, int LicenseClassID)
        {
            return clsLicenseClassesDataAccess.IsPersonHaveMinimumLicenseAge(PersonAge, LicenseClassID);

        }


    }
}
