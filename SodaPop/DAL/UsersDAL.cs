using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SodaPop.BL;
using System.Configuration;
using System.Data.SqlClient;
using SodaPop.DL;



namespace SodaPop.DAL
{
    public class UsersDAL
    {   //connection string to access db through web config
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public void registerAccount(string email, string userPassword, string firstName, string lastName, int phoneNumber, string userAddress)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO UserAccount (UserID, Email, userPassword, firstName, lastName, PhoneNumber, UserAddress)" +
                " Values (" + increaseUserID() + ",@email, @userPassword, @firstName, @lastName, @phone, @userAddress)", conn);
            //parameters entered in userAccount
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@userPassword", userPassword);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@phone", phoneNumber);
            cmd.Parameters.AddWithValue("@userAddress", userAddress);
            //Executes the sql command
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int increaseUserID()
        {   //This is set the first ID as 1. after the first one is run then it should be +1 through the else statement
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            //If there is no ID's first is 1

            int maxID = 0;
            SqlCommand cmd = new SqlCommand("SELECT MAX(UserID) FROM UserAccount", conn);
            if (cmd.ExecuteScalar() is DBNull)
            {
                maxID = 1;
            }
            else //Find the highest user ID and +1 to the ID
            {
                
                maxID = Convert.ToInt32(cmd.ExecuteScalar());
                maxID = maxID + 1;
            }
            return maxID;
        }

        public DataTable displayUserDetails(int userID)
        {//This is used to fill the database  witht he current user that is logged in that have an Orders  to their account
            //
            conn.Open();
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT u.FirstName, u.LastName, u.Email, o.ShippingAddress" +
                " FROM UserAccount u, Orders o " +
                "WHERE o.OrderID = s.OrderID AND s.OrderID = u.UserID = o.UserID AND u.userID = " + userID + "", conn);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            da.Fill(dt);

            conn.Close();
            return dt;
        }
        public int getUserID(string email)
        { //gets the user ID and  returns a single value to be userd
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT UserID FROM UserAccount WHERE Email = @email", conn);
            cmd.Parameters.AddWithValue("@email", email);
            int ID = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            conn.Close();
            return ID;
        }
        public int confirmLogin(string email, string password)
        {
            //Password and username match 1 else 0

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserAccount WHERE Password = @password AND Email = @email", conn);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);

            int check = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return check;
        }

        public void updatePassword(string email, string password)
        {// Updated the user with a new password
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE UserAccount SET userPassword = @password WHERE Email = @email", conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void makeAdmin(string email)
        {// gets single value and returns ID
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE UserAccount SET IsAdmin = 'Y' WHERE Email = @email", conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //public string getAdminEmail()
        //{
        //    //Finds most recent user added
        //    //get email from id of recent user
        //    conn.Open();
        //    string email = "";
        //    SqlCommand cmd = new SqlCommand("SELECT MAX(UserID) FROM UserAccount", conn);
        //    int id = Convert.ToInt32(cmd.ExecuteScalar());
        //    SqlCommand cmdString = new SqlCommand("SELECT Email FROM UserAccount WHERE UserID=" + id + "", conn);
        //    SqlDataReader reader = cmdString.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        email = reader[0].ToString();
        //    }
        //    conn.Close();
        //    return email;
        //}
        public int getAdminStatus(string email)
        {
            //Finds if admin status value exists inside column via email
            //if exists return 1 else 0
            int count = 0;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(IsAdmin) FROM UserAccount WHERE Email = @Email", conn);
            cmd.Parameters.AddWithValue("@Email", email);
            if (cmd.ExecuteScalar() is DBNull)
            {
                count = 0;
            }
            else
            {
                count = 1;
            }
            conn.Close();
            return count;

        }
        List<DL.UserAccount> List = new List<DL.UserAccount>();
        public List<UserAccount> getAllUsersDetails()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserAccount", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            //return list of all users
            while (reader.Read())
            {
                UserAccount user = new UserAccount();
                user.userId = (int)reader["UserID"];
                user.email = (string)reader["Email"];
                user.userPassword = (string)reader["UserPassword"];
                user.firstName = (string)reader["FirstName"];
                user.lastName = (string)reader["LastName"];
                user.phoneNumber = (int)reader["PhoneNumber"];
                user.userAddress = (string)reader["UserAddress"];
                List.Add(user);
            }
            conn.Close();
            return List;

        }

        public void userAccountUpdate(int userId, string Email, string userPassword, string FirstName, string LastName, int PhoneNumber, string userAddress)
        {
            //uses parameters to update account table
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                string sql = "UPDATE UserAccount SET Email = @Email, "
                    + "userPassword = @userPassword, "
                    + "FirstName = @FirstName, "
                    + "LastName = @LastName, "
                    + "PhoneNumber = @PhoneNumber, "
                    + "userAddress = @userAddress "
                    + "WHERE UserID = @UserID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlParameter paramID = new SqlParameter("@UserID", userId);
                cmd.Parameters.Add(paramID);
                SqlParameter paramEmail = new SqlParameter("@Email", Email);
                cmd.Parameters.Add(paramEmail);
                SqlParameter paramPassword = new SqlParameter("@userPassword", userPassword);
                cmd.Parameters.Add(paramPassword);
                SqlParameter paramFirst = new SqlParameter("@FirstName", FirstName);
                cmd.Parameters.Add(paramFirst);
                SqlParameter paramLast = new SqlParameter("@LastName", LastName);
                cmd.Parameters.Add(paramLast);
                SqlParameter paramPhone = new SqlParameter("@PhoneNumber", PhoneNumber);
                cmd.Parameters.Add(paramPhone);
                SqlParameter paramAddress = new SqlParameter("@userAddress", userAddress);
                cmd.Parameters.Add(paramAddress);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void userAccountDelete(int userId)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM UserAccount WHERE UserID = " + userId + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void userAccountInsert(int id, string Email, string userPassword, string FirstName, string LastName, int PhoneNumber, string userAddress)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO UserAccount (userID, Email, userPassword, FirstName, LastName, PhoneNumber, userAddress) VALUES (" + id + ", @Email, @userPassword, @FirstName, @LastName, @PhoneNumber, @userAddress)", conn);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@userPassword", userPassword);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            cmd.Parameters.AddWithValue("@userAddress", userAddress);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }

}