using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using SodaPop.DAL;
using System.Data;





namespace SodaPop.BL
{
    public class UserAccountBL
    {
        public void registerAccount(string email, string userPassword, string firstName, string lastName, int phoneNumber, string userAddress)
        {
            UsersDAL DAL = new UsersDAL();
            DAL.registerAccount(email, userPassword, firstName, lastName, phoneNumber, userAddress);
        }
        public int confirmLogin(string email, string password)
        {
            UsersDAL DAL = new UsersDAL();
            return DAL.confirmLogin(email, password);
        }
        public DataTable displayUserDetails(int userID)
        {
            UsersDAL DAL = new UsersDAL();
            return DAL.displayUserDetails(userID);
        }
        public int getUserID(string email)
        {
            UsersDAL DAL = new UsersDAL();
            return DAL.getUserID(email);
        }
        public void updatePassword(string email, string password)
        {
            UsersDAL DAL = new UsersDAL();
            DAL.updatePassword(email, password);
        }

        public void makeAdmin(string email)
        {// Give the ability to make user an admin
            UsersDAL DAL = new UsersDAL();
            DAL.makeAdmin(email);
        }
        //public string getAdminEmail()
        //{
        //    UsersDAL DAL = new UsersDAL();
        //    return DAL.getAdminEmail();
        //}
        public int getAdminStatus(string email)
        {
            UsersDAL DAL = new UsersDAL();
            return DAL.getAdminStatus(email);
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<DL.UserAccount> getUserDetails()
        {
            UsersDAL DAL = new UsersDAL();
            return DAL.getAllUsersDetails();
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void updateUserAccount(int userId, string Email, string userPassword, string FirstName, string LastName, int PhoneNumber, string userAddress)
        {
            UsersDAL Dal = new UsersDAL();
            Dal.userAccountUpdate(userId, Email, userPassword, FirstName, LastName, PhoneNumber, userAddress);
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void deleteUserAccount(int userId)
        {
            UsersDAL Dal = new UsersDAL();
            Dal.userAccountDelete(userId);
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void insertUserAccount(int id, string Email, string userPassword, string FirstName, string LastName, int PhoneNumber, string userAddress)
        {
            UsersDAL Dal = new UsersDAL();
            Dal.userAccountInsert(id, Email, userPassword, FirstName, LastName, PhoneNumber, userAddress);
        }
    }
}