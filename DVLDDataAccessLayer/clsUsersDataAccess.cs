using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace DVLDDataAccessLayer
{
    public class clsUsersDataAccess
    {
        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = " SELECT CONCAT( People.FirstName,' ', People.SecondName,' ', People.ThirdName,' ', People.LastName ) AS FullName, " +
                           " Users.UserID, Users.PersonID, Users.UserName, Users.IsActive" +
                           " FROM  People  INNER JOIN   Users   ON    People.PersonID = Users.PersonID ";



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

        public enum enComboboxItems
        {
            FirstName = 1, SecondName = 2, ThirdName = 3, LastName = 4, UserID = 5, PersonID = 6, IsActive = 7  
        };

        public static DataTable GetAllUsersByIndex(enComboboxItems IndexSelected)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string columnName = "";

            switch (IndexSelected)
            {
                case enComboboxItems.FirstName:
                    columnName = "FirstName";
                    break;
                case enComboboxItems.SecondName:
                    columnName = "SecondName";
                    break;

                case enComboboxItems.ThirdName:
                    columnName = "ThirdName";
                    break;

                case enComboboxItems.LastName:
                    columnName = "LastName";
                    break;

                case enComboboxItems.UserID:
                    columnName = "UserID";
                    break;

                case enComboboxItems.PersonID:
                    columnName = "PersonID";
                    break;

                default:
                    columnName = "IsActive";
                    break;
            }
            string query = $" SELECT CONCAT( People.FirstName,' ', People.SecondName,' ', People.ThirdName,' ', People.LastName ) AS FullName, " +
                           " Users.UserID, Users.PersonID, Users.UserName, Users.IsActive" +
                           " FROM  People  INNER JOIN   Users   ON    People.PersonID = Users.PersonID " +
                           $" ORDER BY {columnName} "; 

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

        //Overloading of GetAllUsersOrderByIndex Find user with text and selectedindex
        public static DataTable GetAllUsersByIndex(enComboboxItems IndexSelected, string FindWithText)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string columnName = "";

            switch (IndexSelected)
            {
                case enComboboxItems.FirstName:
                    columnName = "FirstName";
                    break;
                case enComboboxItems.SecondName:
                    columnName = "SecondName";
                    break;

                case enComboboxItems.ThirdName:
                    columnName = "ThirdName";
                    break;

                case enComboboxItems.LastName:
                    columnName = "LastName";
                    break;

                case enComboboxItems.UserID:
                    columnName = "UserID";
                    break;

                case enComboboxItems.PersonID:
                    columnName = "PersonID";
                    break;

                default:
                    columnName = "IsActive";
                    break;
            }
            string query = $" SELECT CONCAT( People.FirstName,' ', People.SecondName,' ', People.ThirdName,' ', People.LastName ) AS FullName, " +
                           " Users.UserID, Users.PersonID, Users.UserName, Users.IsActive" +
                           " FROM  People  INNER JOIN   Users   ON    People.PersonID = Users.PersonID " +
                           $" WHERE {columnName} LIKE @FindWithText + '%' " +
                           $"ORDER BY {columnName} ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FindWithText", FindWithText);
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

        public static int AddNewUser(int PsersonID, string UserName, string Password, bool IsActive)
        {
            //this function will return the new Person id if succeeded and -1 if not.
            int UserId = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (PersonID, UserName, Password, IsActive)

                             VALUES (@PsersonID, @UserName, @Password, @IsActive);

                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PsersonID", PsersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserId = insertedID;
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


            return UserId;
        }

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users  WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool Authentication(string Username, string Password, ref int UserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT UserID FROM Users  WHERE Username = @Username And Password = @Password;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = reader.HasRows;

                    UserID = (int)reader["UserID"];

                    reader.Close();
                }
                else
                {
                    // The record was not found
                    IsFound = false;
                }
                   
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool GetUserInfoByUserID(int UserID,ref int PersonID ,ref string Username, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users  WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                   
                    PersonID = (int)reader["PersonID"];
                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];

                    IsFound = true;
                    reader.Close();
                }
                else
                {
                    // The record was not found
                    reader.Close();
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
            return IsFound;
        }

        public static bool CheckCurrentPassword(int UserID, string Password)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Password FROM Users  WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string PasswordRequest = "";
                    PasswordRequest = (string)reader["Password"];

                    if(Password == PasswordRequest)
                    {
                        IsFound = true;
                    }

                    reader.Close();
                }
                else
                {
                    // The record was not found
                    reader.Close();
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
            return IsFound;

        }

        public static bool ChangeUserPassword(int UserID, string NewPassword)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Users   set Password=@NewPassword where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@NewPassword", NewPassword);

            int rowsAffected = 0;


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static string GetUserNameByUserID(int UserID)
        {
            string Username = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT UserName FROM Users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Username = (string)reader["UserName"];
                    reader.Close();
                }
                else
                {
                    // The record was not found
                    reader.Close();
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
            return Username;

        }

    }

}

