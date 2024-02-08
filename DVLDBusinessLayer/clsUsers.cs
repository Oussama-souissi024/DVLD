using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsUsers
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUsers()
        {
            this.UserID = -1;
            this.PersonID = - 1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
        }

        private clsUsers(int userID, int personID, string userName, string password, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersDataAccess.GetAllUsers();
        }

        public static DataTable GetAllUsersOrderByIndex(int Index)
        {
            //enComboxItems is a public enum type,
            //which was declared in the clsUsersDataAcsess class,
            //we used this type in this class which is already inherited from clsUsersDataAcsess
            clsUsersDataAccess.enComboboxItems selectedEnumItem = (clsUsersDataAccess.enComboboxItems)Index;
            return clsUsersDataAccess.GetAllUsersByIndex(selectedEnumItem);
        }

        public static DataTable GetAllUsersOrderByIndex(int Index, string FindWithText)
        {
            clsUsersDataAccess.enComboboxItems selectedEnumItem = (clsUsersDataAccess.enComboboxItems)Index;
            return clsUsersDataAccess.GetAllUsersByIndex(selectedEnumItem, FindWithText);
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsUsersDataAccess.IsPersonExist(PersonID);
        }

        public  int AddNewUser()
        {
            //Check if the User exist with PersonID
            if(!IsPersonExist(this.PersonID))
            {
                this.UserID = clsUsersDataAccess.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
                return this.UserID;
            }
            else
                return -1;
        }

        public static bool Authentication(string Username, string Password, ref int UserID)
        {
            return clsUsersDataAccess.Authentication(Username, Password, ref UserID);
        }

        public static clsUsers GetUserInfoByUserID (int UserID)
        {
            clsUsers User = new clsUsers();
            int PersonID = 0;
            string Username = "";
            string Password = "";
            bool IsActive = false;

            if (clsUsersDataAccess.GetUserInfoByUserID(UserID, ref PersonID, ref Username, ref Password, ref IsActive))
            {
                User.UserID = UserID;
                User.PersonID = PersonID;
                User.UserName = Username;
                User.Password = Password;
                User.IsActive = IsActive;
            }
            else
                User = null;

            return User;
        }

        public static bool CheckCurrentPassword(int UserID, string Password)
        {
            return clsUsersDataAccess.CheckCurrentPassword(UserID, Password);
        }

        public static bool ChangeUserPassword(int UserID, string NewPassword)
        {
            return clsUsersDataAccess.ChangeUserPassword(UserID, NewPassword);
        }

        public static string GetUserNameByUserID(int UserID)
        {
            return clsUsersDataAccess.GetUserNameByUserID(UserID);
        }

    }
}
