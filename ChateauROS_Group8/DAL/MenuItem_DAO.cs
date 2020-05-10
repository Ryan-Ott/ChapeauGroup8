using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class MenuItem_DAO : DAOBase
    {
        public List<MenuItem> DB_GetAllMenuItems()
        {
            OpenConnection();
            SqlCommand queryGetAll = new SqlCommand("SELECT menuItemID, categoryID, dishName, price, stock, alcoholic FROM [MenuItems]", connection);
            SqlDataReader reader = queryGetAll.ExecuteReader();
            List<MenuItem> menuItems = new List<MenuItem>();
            while (reader.Read())
            {
                MenuItem menuItem = ReadMenuItem(reader);
                menuItems.Add(menuItem);
            }
            reader.Close();
            CloseConnection();
            return menuItems;
        }

        public MenuItem DB_GetMenuItemByID(int id)
        {
            OpenConnection();
            SqlCommand queryGetByID = new SqlCommand("SELECT menuItemID, categoryID, dishName, price, stock, alcoholic FROM [MenuItems] WHERE menuItemID = @id", connection);
            queryGetByID.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = queryGetByID.ExecuteReader();
            MenuItem menuItem = null;
            if (reader.Read())
            {
                menuItem = ReadMenuItem(reader);
            }
            reader.Close();
            CloseConnection();
            return menuItem;
        }

        private MenuItem ReadMenuItem(SqlDataReader reader)
        {
            int menuItemID = (int)reader["menuItemID"];
            int categoryID = (int)reader["categoryID"];
            string dishName = (string)reader["dishName"];
            double price = (double)reader["price"];
            int stock = (int)reader["stock"];
            bool alcoholic = (bool)reader["alcoholic"];

            return new MenuItem(menuItemID, categoryID, dishName, price, stock, alcoholic);
        }
    }
}
