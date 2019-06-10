using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.SessionState;
using System.Web.ui;
using System.ComponentModel;
using SodaPop.DL;
using System.Data.Configuration;


namespace SodaPop.DAL
{[DataObject(true)]
    public class ProdutsDAL
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefultConnection"].ConnectionString);
        List<DL.Product> List = new List<DL.Product>();
        List<CartList> cartItem = new List<CartList>();
        DataSet dataSet = new DataSet();

        public DataSet GetDataSet()
        {
            // oppen the connection string if it isnt open
            if (conn.state != ConnectionState.Open)
            { conn.Open();}
            // Get connection string and test
            SQLCommand command = new SQLCommand("SELECT * FROM Product", conn);
            SQLDataAdapter dataAdapter = new SQLDataAdapter(command);
            dataAdapter.Fill(dataSet); //Data set through the adpater 
            conn.Close();
            return dataSet;
             //returns the dataset with example from product
            
        }

        public DataSet getProductDetails(int ProductID)
        {

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SQLCommand command = new SqlCommand("SELECT * FROM Product WHERE productID = " + ProductID + "", conn);
            SQLDataAdapter dataAdapter = new SQLDataAdapter(cmd);
            dataAdapter.Fill(dataSet);
            conn.Close();
            return dataSet;
        }
        public List<DL.Product> getAllProductsDetails()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Product", conn);
            SqlDataReader reader = command.ExecuteReader();
            //reads in the data and reutrns values to list
            while (reader.Read())
            {
                DL.Product prod = new DL.Product();
                prod.productID = (int)reader["ProductID"];
                prod.Name = (string)reader["Name"];
                prod.imagefile = (string)reader["Image"];
                prod.price = Convert.ToDouble(reader["Price"]);
                prod.description = (string)reader["Description"];
                List.Add(prod);
            }
            conn.Close();
            return List;

        }

        public double getProductPrice(int ID)
        {//Grabs the product price
            SQLCommand command = new SqlCommand("SELECT ProductPrice FROM Product WHERE productID = " + ID + "", conn);
            SQLDataReader reader = cmd.ExecuteReader();
            Classes.Product prod = new Classes.Product();
            while (reader.Read())
            {
                prod.price = Convert.ToDouble(reader["Price"]);
                List.Add(prod);
            }
            reader.Close();
            return prod.price;
        }

        public void addToCart(int ProductID, DataTable dt)
        {
            conn.Open();
            SqlCommand cmdExists = new SqlCommand("SELECT COUNT(s.productID) FROM ShoppingCart s, Product p, Orders o WHERE o.OrderID = s.OrderID AND s.OrderID = "
            + getOrderID() + " AND p.productID = @productID AND p.productID = s.productID", conn);
            cmdExists.Parameters.AddWithValue("@productID", ProductID);
           

            //Update quantity if product already exist

            int Exists = (int)cmdExists.ExecuteScalar();
            if (Exists > 0)
            {
                int quantity = getQuantity(ProductID) + 1;
                setQuantity(ProductID, quantity);
                conn.Open();
                //gets subtotal by timesing price by quantity
                SqlCommand command = new SqlCommand("UPDATE ShoppingCart s, Orders o " +
                    "SET s.ItemQuantity = " + quantity + ", s.OrderID = " + getOrderID() + ", s.SubTotal = "
                    + (getProductPrice(ProductID) * getQuantity(ProductID)) + " " +
                    "WHERE o.OrderID = s.OrderID AND s.OrderID = " + geOrderID() + " s.productID = " + ProductID + "", conn);
                conn.Open();
                n.ExecuteNonQuery();
                conn.Close();
            }
            //if product doesn't exist insert into cart
            else
            {
                SqlCommand command = new SqlCommand("INSERT INTO ShoppingCart VALUES (" + getOrderID() + " ," + ProductID + "," + getProductPrice(ProductID) + ",1)", conn);
                cmdcommandExecuteNonQuery();
                //must execute cmd before cmdTotal is there are no nulls
                SqlCommand cmdTotal = new SqlCommand("UPDATE ShoppingCart SET SubTotal =" + (getProductPrice(ProductID) * getQuantity(ProductID)) + "WHERE productID = " + ProductID + "", conn);
                conn.Open();
                cmdTotal.ExecuteNonQuery();
                conn.Close();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void productDelete(int productID)
        {//Deletes product

            conn.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Product WHERE ProductID = " + productID + "", conn);
            //command.Execute();

            command.ExecuteNonQuery();
            con.Close();
        }

        //update a product. Finds the product through sql command and attempts to update that product
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void productUpdate(int productID, string Name, string Brand, string image, decimal price, string Description)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                string sql = "UPDATE Product SET Name = @Name, Image = @image,Price = @price, Description = @Description, WHERE ProductID = @productID";

                SqlCommand command = new SqlCommand(sql, command);
                try
                { SqlParameter paramID = new SqlParameter("@productID", productID);
                    command.Parameters.Add(paramID); }
                catch (Exception)
                {/* this is an exception. doesnt display anything. need to update */}
                SqlParameter paramName = new SqlParameter("@Name", Name);
                command.Parameters.Add(paramName);

                SqlParameter paramImage = new SqlParameter("@image", image);
                command.Parameters.Add(paramImage);

                SqlParameter paramPrice = new SqlParameter("@price", price);
                command.Parameters.Add(paramPrice);

                SqlParameter paramLong = new SqlParameter("@Description", description);
                command.Parameters.Add(paramDescription);



                conn.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable displayCart()
        {//Display products
            
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT p.productID, p.Name, p.Price, s.ItemQuantity, s.SubTotal FROM Product p, ShoppingCart s, Orders o" + " WHERE p.productID = s.productID AND o.OrderID = s.OrderID AND s.OrderID = +" + getOrderID() + "", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dt);
            conn.Close();
            return dt;
    
        }

        public void createOrderID()
        {
            //creates when an item is added to an empty cart
            conn.Open();
            int id = 0;
            SqlCommand cmdCount = new SqlCommand("SELECT MAX(OrderID) FROM Orders", conn);
            if (cmdCount.ExecuteScalar() is DBNull)
            {
                id = 1;
            }
            else
            {
                id = Convert.ToInt32(cmdCount.ExecuteScalar()) + 1;
            }
            //Adds just ID which then is updated when payment is complete
            SqlCommand command = new SqlCommand("INSERT INTO Orders (OrderID) VALUES (" + id + ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public int getOrdersID()
        {
            //get Invoice ID
            SqlCommand command = new SqlCommand("SELECT MAX(OrderID) FROM Orders", conn);
            int ID = Convert.ToInt32(cmd.ExecuteScalar());
            return ID;
        }


        public int getQuantity(int ProductID)
        {
            //returns the quantity
            SqlCommand command = new SqlCommand("SELECT ItemQuantity FROM ShoppingCart s, Orders o WHERE productID = " + ProductID + "", conn);
            int quantity = (int)command.ExecuteScalar();
            conn.Close();
            return quantity;
        }
        public string getItemQuantityCount()
        {
            //finds the sum of all quantity for view cart items
            int total = 0;
            conn.Open();
            using (var cmd = new SqlCommand("SELECT SUM(ItemQuantity) FROM ShoppingCart s, Invoice i WHERE i.InvoiceID = s.InvoiceID AND s.InvoiceID = " 
                + getOrderID() + "", conn))
            {
                if (cmd.ExecuteScalar() is DBNull)
                { total = 0;}
                else
                { total = Convert.ToInt32(cmd.ExecuteScalar());}
            } return total.ToString();
        }
        public int setQuantity(int ProductID, int Quantity)
        {
            //set quantity when new product added
            conn.Open();
            SqlCommand command = new SqlCommand("UPDATE ShoppingCart SET ItemQuantity =" + Quantity + " WHERE productID = " + ProductID + "", conn);
            command.ExecuteNonQuery();
            conn.Close();
            return Quantity;
        }

        public string getSumTotal()
        {
            //returns Total by adding the subtotals
            int total = 0;
            conn.Open();
            using (var cmd = new SqlCommand("SELECT SUM(SubTotal) FROM ShoppingCart s, Orders o WHERE s.OrdersID = o.OrdersID AND s.OrdersID = " + getOrderID() + "", conn))
            {
                //If Database value doesn't exist return 0
                if (cmd.ExecuteScalar() is DBNull)
                { total = 0;}
                else
                { total = Convert.ToInt32(cmd.ExecuteScalar());}
            }return " $" + total.ToString();
        }
        public void removeCart()
        {
            //Remvoesitesms from cart
            conn.Open();
            SqlCommand command = new SqlCommand("DELETE FROM ShoppingCart s, Orders i " +
                "WHERE o.OrderID = s.OrderID AND s.Orders = " + getOrderID() + "", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public DataSet search(String search)
        {
            //Using code from W3 school to look for product in search bar
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Product WHERE (Name like '%' + @Name + '%' )", conn);
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = search;
            command.ExecuteNonQuery();
            DataSet searchData = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(searchData, "Name");


            conn.Close();
            return searchData;
        }


        public DataTable purchaseHistory(int userID)
        {
            // Use data table to bring up purchase history
            con.Open();
            DataTable dt = new DataTable();
            //SQL COMMAND
        }
    }
}   