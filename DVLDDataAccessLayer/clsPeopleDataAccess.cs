using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public class clsPeopleDataAccess
    {
        public static bool GetPersonInfoByID(int PresonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName,
                                             ref string LastName, ref DateTime DateOfBirth, ref int Gendor, ref string Address, ref string Phone,
                                             ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE PersonID = @PresonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PresonID", PresonID);
            //command.Parameters.Add(new SqlParameter("@PersonId", SqlDbType.Int)).Value = PresonID;


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (int)Convert.ToInt32(reader["Gendor"]);
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

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

        public static DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People";

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
            PersonID = 1, NationalNo = 2, FirstName = 3, SecondName = 4, ThirdName = 5, LastName = 6, DateOfBirth = 7,
            Gendor = 8, Address = 9, Phone = 10, Email = 11, NationalityCountryID = 12, ImagePath = 13
        };
        public static DataTable GetAllPeopleOrderByIndex(enComboboxItems IndexSelected)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string columnName = "";

            switch (IndexSelected)
            {
                case enComboboxItems.PersonID:
                    columnName = "PersonID";
                    break;
                case enComboboxItems.NationalNo:
                    columnName = "NationalNo";
                    break;
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

                case enComboboxItems.DateOfBirth:
                    columnName = "DateOfBirth";
                    break;

                case enComboboxItems.Gendor:
                    columnName = "Gendor";
                    break;

                case enComboboxItems.Address:
                    columnName = "Address";
                    break;

                case enComboboxItems.Phone:
                    columnName = "Phone";
                    break;

                case enComboboxItems.Email:
                    columnName = "Email";
                    break;

                case enComboboxItems.NationalityCountryID:
                    columnName = "NationalityCountryID";
                    break;
                default:
                    columnName = "ImagePath";
                    break;
            }
            string query = $"SELECT * FROM People ORDER BY {columnName}";
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

        //Overloading of GetAllPeopleOrderByIndex Find person with text and selectedindex
        public static DataTable GetAllPeopleOrderByIndex(enComboboxItems IndexSelected, string FindWithText)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string columnName = "";

            switch (IndexSelected)
            {
                case enComboboxItems.PersonID:
                    columnName = "PersonID";
                    break;
                case enComboboxItems.NationalNo:
                    columnName = "NationalNo";
                    break;
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

                case enComboboxItems.DateOfBirth:
                    columnName = "DateOfBirth";
                    break;

                case enComboboxItems.Gendor:
                    columnName = "Gendor";
                    break;

                case enComboboxItems.Address:
                    columnName = "Address";
                    break;

                case enComboboxItems.Phone:
                    columnName = "Phone";
                    break;

                case enComboboxItems.Email:
                    columnName = "Email";
                    break;

                case enComboboxItems.NationalityCountryID:
                    columnName = "NationalityCountryID";
                    break;
                default:
                    columnName = "ImagePath";
                    break;
            }

            string query = $"SELECT * FROM People WHERE {columnName} LIKE @FindWithText + '%' ORDER BY {columnName}";

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

        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
            int Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            //this function will return the new Person id if succeeded and -1 if not.
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, 
                                                   Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)

                             VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth,
                                     @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);

                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
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


            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
            int Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  People  
                            set NationalNo=@NationalNo,
                                FirstName=@FirstName,
                                SecondName=@SecondName,
                                ThirdName=@ThirdName,
                                LastName=@LastName,
                                DateOfBirth=@DateOfBirth,
                                Gendor=@Gendor,
                                Address=@Address,
                                Phone=@Phone,
                                Email=@Email,
                                NationalityCountryID=@NationalityCountryID,
                                ImagePath=@ImagePath

                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);



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

        public static bool DeletePerson(int PersonID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete People 
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }

        public static bool IsPersonNationalNumberExist( string  NationalNumber )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNumber);

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

        //Overloading of IsPersonNationalNumberExist PersonID by referance 
        public static bool IsPersonNationalNumberExist(string NationalNumber, ref int PersonID)
        {
            bool isFound = false;
            PersonID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) // Check if there is a row in the result set
                {
                    isFound = true;
                    // Access PersonID from the result set
                    if (!reader.IsDBNull(reader.GetOrdinal("PersonID")))
                    {
                        PersonID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                    }
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

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

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

        public static string GetFullNameByPersonID(int PersonID)
        {
            string FullName = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = $"SELECT FirstName, SecondName, ThirdName, LastName FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        FullName = (string)reader["FirstName"];
                        FullName += " " + (string)reader["SecondName"];
                        FullName += " " + (string)reader["ThirdName"];
                        FullName += (string)reader["LastName"];
                    }                    
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

            return FullName ;

        }

        public static int GetPersonAgeByID(int PersonID)
        {
            int Age = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = $"SELECT DateOfBirth FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DateTime DateOfBirth;
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Age = DateTime.Now.Year - DateOfBirth.Year;
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

            return Age;

        }

    }

}

