using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsApplicationTypes
    {
        public static string GetApplicationTypeTitleByApplicationTypeID(int ApplicationTypeID)
        {
            return clsApplicationTypesDataAccess.GetApplicationTypeTitleByApplicationTypeID(ApplicationTypeID);
        }
    }
}
