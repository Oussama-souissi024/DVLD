using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsDrivers
    {
        public static bool IsPersonIDDriverOrNot(int PersonID, ref int DriverID )
        {
            return clsDriversDataAccess.IsPersonIDDriverOrNot(PersonID, ref DriverID);
        }

    }
}
