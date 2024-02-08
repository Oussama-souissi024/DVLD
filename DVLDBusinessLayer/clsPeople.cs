using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PresonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public int Gendor { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }
        public string ImagePath { set; get; }

        public clsPeople()

        {
            this.PresonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = -1;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;
        }

        private clsPeople(int PresonID, string NationalNo, string FirstName, string SecondName, string ThirdName,
        string LastName, DateTime DateOfBirth, int Gendor, string Address, string Phone, string Email, int NationalityCountryID
            , string ImagePath)
        {
            this.PresonID = PresonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }
        public static DataTable GetAllPeople()
        {

            return clsPeopleDataAccess.GetAllPeople();

        }

        public static clsPeople FindPersonByID(int PresonID)
        {

            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int Gendor = 0, NationalityCountryID = -1;


            if (clsPeopleDataAccess.GetPersonInfoByID(PresonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID
                , ref ImagePath))

                return new clsPeople(PresonID, NationalNo, FirstName, SecondName, ThirdName,
                 LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID
                , ImagePath);
            else
                return null;
        }


        public static DataTable GetAllPeopleOrderByIndex(int Index)
        {
            //enComboxItems is a public enum type,
            //which was declared in the clsPeopleDataAcsess class,
            //we used this type in this class which is already inherited from clsPeopleDateAcsess
            clsPeopleDataAccess.enComboboxItems selectedEnumItem = (clsPeopleDataAccess.enComboboxItems)Index;
            return clsPeopleDataAccess.GetAllPeopleOrderByIndex(selectedEnumItem);
        }

        //Overloading of GetAllPeopleOrderByIndex Find person with text and selectedindex
        public static DataTable GetAllPeopleOrderByIndex(int Index, string FindWithText)
        {
            
            clsPeopleDataAccess.enComboboxItems selectedEnumItem = (clsPeopleDataAccess.enComboboxItems)Index;
            return clsPeopleDataAccess.GetAllPeopleOrderByIndex(selectedEnumItem, FindWithText);
        }

        private bool _AddNewPerson()
        {
            //call DataAccess Layer 

            this.PresonID = clsPeopleDataAccess.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

            return (this.PresonID != -1);
        }

        private bool _UpdatePerson()
        {
            //call DataAccess Layer 

            return clsPeopleDataAccess.UpdatePerson(this.PresonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth,
                                                    this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();


            }
            return false;
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPeopleDataAccess.DeletePerson(PersonID);
        }

        public static  bool IsPersonExist(int PersonID)
        {
            return clsPeopleDataAccess.IsPersonExist(PersonID);
        }

        public static bool IsPersonNationalNumberExist(string NationalNumber)
        {
            return clsPeopleDataAccess.IsPersonNationalNumberExist(NationalNumber);
        }

        public static bool IsPersonNationalNumberExist(string NationalNumber, ref int PersonID)
        {
            return clsPeopleDataAccess.IsPersonNationalNumberExist(NationalNumber,ref  PersonID);
        }

        public static string GetFullNameByPersonID(int PersonID)
        {
            return clsPeopleDataAccess.GetFullNameByPersonID( PersonID);
        }

        public static int GetPersonAgeByID(int PersonID)
        {
            return clsPeopleDataAccess.GetPersonAgeByID(PersonID);
        }

    }
}
