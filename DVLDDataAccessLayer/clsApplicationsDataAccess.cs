using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public class clsApplicationsDataAccess
    {
        public static int AddNewApplication(int ApplicationPersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus,
                                      DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            //this function will return the new Application id if succeeded and -1 if not.
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Applications (ApplicationPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, 
                                                       LastStatusDate, PaidFees, CreatedByUserID)

                             VALUES (@ApplicationPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate,
                                     @PaidFees, @CreatedByUserID);

                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationID = insertedID;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            finally
            {
                connection.Close();
            }


            return ApplicationID;

        }

        public static DataTable GetAllApplication()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Applications";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
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

            return dt;


        }

        public static bool GetApplicationInfoByID(int ApplicationID, ref int ApplicationPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID,
                                                 ref int ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    ApplicationPersonID = (int)Convert.ToInt32(reader["ApplicationPersonID"]);
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)Convert.ToInt32(reader["ApplicationTypeID"]);
                    ApplicationStatus = (int)Convert.ToInt32(reader["ApplicationStatus"]);
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    CreatedByUserID = (int)Convert.ToInt32(reader["CreatedByUserID"]);
                    PaidFees = (int)Convert.ToDecimal(reader["PaidFees"]);
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

        //public enum enComboboxItems
        //{
        //    ApplicationID = 1, ApplicationPersonID = 2, ApplicationDate = 3, ApplicationTypeID = 4, ApplicationStatus = 5,
        //    LastStatusDate = 6, PaidFees = 7, CreatedByUserID = 8, ApplicationLicenseClass = 9
        //};

        //public static DataTable GetAllApplicationsOrderByIndex(enComboboxItems IndexSelected)
        //{
        //    DataTable dt = new DataTable();
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
        //    string columnName = "";

        //    switch (IndexSelected)
        //    {
        //        case enComboboxItems.ApplicationID:
        //            columnName = "ApplicationID";
        //            break;
        //        case enComboboxItems.ApplicationPersonID:
        //            columnName = "ApplicationPersonID";
        //            break;
        //        case enComboboxItems.ApplicationDate:
        //            columnName = "ApplicationDate";
        //            break;
        //        case enComboboxItems.ApplicationTypeID:
        //            columnName = "ApplicationTypeID";
        //            break;
        //        case enComboboxItems.ApplicationStatus:
        //            columnName = "ApplicationStatus";
        //            break;
        //        case enComboboxItems.LastStatusDate:
        //            columnName = "LastStatusDate";
        //            break;
        //        case enComboboxItems.PaidFees:
        //            columnName = "PaidFees";
        //            break;
        //        case enComboboxItems.CreatedByUserID:
        //            columnName = "CreatedByUserID";
        //            break;
        //        default:
        //            columnName = "ApplicationLicenseClass";
        //            break;
        //    }
        //    string query = $"SELECT * FROM Applications ORDER BY {columnName}";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    try
        //    {
        //        connection.Open();

        //        SqlDataReader reader = command.ExecuteReader();

        //        if (reader.HasRows)

        //        {
        //            dt.Load(reader);
        //        }

        //        reader.Close();


        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return dt;
        //}

        ////Overloading of GetAllApplicationsOrderByIndex Find person with text and selectedindex
        //public static DataTable GetAllApplicationsOrderByIndex(enComboboxItems IndexSelected, string FindWithText)
        //{
        //    DataTable dt = new DataTable();
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
        //    string columnName = "";

        //    switch (IndexSelected)
        //    {
        //        case enComboboxItems.ApplicationID:
        //            columnName = "ApplicationID";
        //            break;
        //        case enComboboxItems.ApplicationPersonID:
        //            columnName = "ApplicationPersonID";
        //            break;
        //        case enComboboxItems.ApplicationDate:
        //            columnName = "ApplicationDate";
        //            break;
        //        case enComboboxItems.ApplicationTypeID:
        //            columnName = "ApplicationTypeID";
        //            break;
        //        case enComboboxItems.ApplicationStatus:
        //            columnName = "ApplicationStatus";
        //            break;
        //        case enComboboxItems.LastStatusDate:
        //            columnName = "LastStatusDate";
        //            break;
        //        case enComboboxItems.PaidFees:
        //            columnName = "PaidFees";
        //            break;
        //        case enComboboxItems.CreatedByUserID:
        //            columnName = "CreatedByUserID";
        //            break;
        //        default:
        //            columnName = "ApplicationLicenseClass";
        //            break;
        //    }


        //    string query = $"SELECT * FROM Applications WHERE {columnName} LIKE @FindWithText + '%' ORDER BY {columnName}";

        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@FindWithText", FindWithText);

        //    try
        //    {
        //        connection.Open();

        //        SqlDataReader reader = command.ExecuteReader();

        //        if (reader.HasRows)

        //        {
        //            dt.Load(reader);
        //        }

        //        reader.Close();


        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return dt;

        //}


    }
}
