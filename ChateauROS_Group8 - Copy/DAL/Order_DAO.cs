using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{

	public class Order_DAO : DAOBase
	{
		public Order_DAO()
		{
            List<Order> DB_GetAllOrders()
            {
                OpenConnection();
                SqlCommand queryGetAll = new SqlCommand("SELECT orderID, categoryID, price, stock FROM [Order]", connection);
                SqlDataReader reader = queryGetAll.ExecuteReader();
                List<Order> orders = new List<Order>();
                while (reader.Read())
                {
                    Order orders = ReadOrder(reader);
                    orders.Add(orders);
                }
                reader.Close();
                CloseConnection();
                return orders;
            }

            Order DB_GetMenuItemByID(int orderID)
            {
                OpenConnection();
                SqlCommand queryGetByID = new SqlCommand("SELECT orderID, categoryID, itemName, price, stock, FROM [Order] WHERE orderID = @OrderID", connection);
                queryGetByID.Parameters.AddWithValue("@OrderID", id);
                SqlDataReader reader = queryGetByID.ExecuteReader();
                Order order = null;
                if (reader.Read())
                {
                    order = ReadMenuItem(reader);
                }
                reader.Close();
                CloseConnection();
                return order;
            }

             MenuItem ReadMenuItem(SqlDataReader reader)
            {
                int menuItemID = (int)reader["orderID"];
                int categoryID = (int)reader["categoryID"];
                string dishName = (string)reader["dishName"];
                double price = (double)reader["price"];
                int stock = (int)reader["stock"];
                

                return new MenuItem(orderID, categoryID, dishName, price, stock);
            }
        }
	}

}
