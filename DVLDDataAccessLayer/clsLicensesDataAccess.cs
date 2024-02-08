using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDDataAccessLayer
{
    public class clsLicensesDataAccess
    {
        public static bool GetLicenseInfoByID(int LicenseID, ref int applicationID, ref int driverID, ref int licenseClass, ref DateTime issueDate, ref DateTime expirationDate,
                                               ref string notes, ref decimal paidFees, ref bool isActive, ref int issueReason, ref int createdByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            //command.Parameters.Add(new SqlParameter("@PersonId", SqlDbType.Int)).Value = PresonID;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found

                    applicationID = (int)Convert.ToInt32(reader["applicationID"]);
                    driverID = (int)Convert.ToInt32(reader["driverID"]);
                    licenseClass = (int)Convert.ToInt32(reader["licenseClass"]);
                    issueDate = (DateTime)reader["issueDate"];
                    expirationDate = (DateTime)reader["expirationDate"];

                    if (reader["notes"] != DBNull.Value)
                    {
                        notes = (string)reader["notes"];
                    }
                    else
                        notes = ""; 
                    paidFees = (decimal)reader["paidFees"];
                    isActive = (bool)Convert.ToBoolean(reader["isActive"]);
                    issueReason = (int)Convert.ToInt32(reader["issueReason"]);
                    createdByUserID = (int)Convert.ToInt32(reader["createdByUserID"]);

                    isFound = true;
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static bool IsLicenseExist(int LicenseID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Licenses WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static string GetLicenceDriverNameByLicenseID(int LicenseID)
        {
            string FullName = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT FirstName,SecondName,ThirdName,LastName  FROM " +
                " People INNER JOIN Drivers ON People.PersonID = Drivers.PersonID " +
                " INNER JOIN Licenses ON Drivers.DriverID = Licenses.DriverID" +
                " Where Licenses.LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    FullName += (string)reader["FirstName"];
                    FullName += " " + (string)reader["SecondName"];
                    FullName += " " + (string)reader["ThirdName"];
                    FullName += (string)reader["LastName"];
                }
                reader.Close();
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return FullName;
        }

        public static string GetLicenseDriverNationalNoByLicenseID(int LicenseID)
        {
            string DriverNationalNo = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT NationalNo  FROM " +
                " People INNER JOIN Drivers ON People.PersonID = Drivers.PersonID " +
                " INNER JOIN Licenses ON Drivers.DriverID = Licenses.DriverID" +
                " Where Licenses.LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DriverNationalNo += (string)reader["NationalNo"];
                }

                reader.Close();
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return DriverNationalNo;
        }

        public static string GetLicenseDriverGendorByLicenceID(int LicenseID)
        {
            string DriverGendor = "";
            int Result = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Gendor  FROM  " +
                " People INNER JOIN Drivers ON People.PersonID = Drivers.PersonID " +
                " INNER JOIN Licenses ON Drivers.DriverID = Licenses.DriverID" +
                " Where Licenses.LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Result = (int)Convert.ToInt32(reader["Gendor"]);
                }

                reader.Close();
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            if (Result == 1)
                DriverGendor = "Male";
            else if (Result == 0)
                DriverGendor = "Female";
            else
                DriverGendor = "";

            return DriverGendor;
        }

        public static DateTime GetLicenseDriverDateOfBirthByLicenseID(int LicenseID)
        {
            DateTime DriverDateOfBirth = DateTime.Now;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT DateOfBirth FROM " +
                " People INNER JOIN Drivers ON People.PersonID = Drivers.PersonID " +
                " INNER JOIN Licenses ON Drivers.DriverID = Licenses.DriverID" +
                " Where Licenses.LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DriverDateOfBirth = (DateTime)reader["DateOfBirth"]; 
                }

                reader.Close();
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return DriverDateOfBirth;
        }

        public static string  GetLicenseDriverImagePathByLicenseID(int LicenseID)
        {
            string DriverImagePath = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT People.ImagePath  FROM  " +
                " People INNER JOIN Drivers ON People.PersonID = Drivers.PersonID " +
                " INNER JOIN Licenses ON Drivers.DriverID = Licenses.DriverID" +
                " Where Licenses.LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DriverImagePath = (string)(reader["ImagePath"]);
                }

                reader.Close();
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return DriverImagePath;
        }

        public static bool IsDriverIDHaveThisLicense(int DriverID, int LicenseClass)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Licenses WHERE DriverID = @DriverID and LicenseClass = @LicenseClass";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
    }
}

