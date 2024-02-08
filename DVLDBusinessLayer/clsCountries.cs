using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsCountries
    {
        public static DataTable GetAllCountries()
        {

            return clsCountriesDataAccess.GetAllCountries();

        }

        public static string GetCountryNameByID(int CountryID)
        {
            return clsCountriesDataAccess.GetCountryNameByID(CountryID);
        }
    }
}
