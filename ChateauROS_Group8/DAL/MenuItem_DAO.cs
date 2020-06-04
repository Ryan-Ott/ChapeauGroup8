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
            SqlCommand queryGetAll = new SqlCommand("SELECT menuItemID, categoryID, name, price, stock, alcoholic FROM [MenuItems]", connection);
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
            SqlCommand queryGetByID = new SqlCommand("SELECT menuItemID, categoryID, name, price, stock, alcoholic FROM [MenuItems] WHERE menuItemID = @id", connection);
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

        public List<MenuItem> DB_GetMenuItemsByCategory(int categoryID)
        {
            OpenConnection();
            SqlCommand queryGetByID = new SqlCommand("SELECT menuItemID, categoryID, name, price, stock, alcoholic FROM [MenuItems] WHERE categoryID = @id", connection);
            queryGetByID.Parameters.AddWithValue("@id", categoryID);
            SqlDataReader reader = queryGetByID.ExecuteReader();
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

        public MenuItem DB_GetMenuItemByName(string menuItemName)
        {
            OpenConnection();
            SqlCommand queryGetByID = new SqlCommand("SELECT menuItemID, categoryID, name, price, stock, alcoholic FROM [MenuItems] WHERE name = @name", connection);
            queryGetByID.Parameters.AddWithValue("@name", menuItemName);
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

        public void DB_EditMenuItemStock(MenuItem newMenuItem)
        {
            MenuItem oldMenuItem = DB_GetMenuItemByID(newMenuItem.MenuItemID);

            OpenConnection();
            SqlCommand queryEdit = new SqlCommand("UPDATE [MenuItems] SET [categoryID] = @categoryID, [name] = @name, [price] = @price, [stock] = @stock, [alcoholic] = @alcoholic WHERE [menuItemID] = @menuItemID;", connection);
            queryEdit.Parameters.AddWithValue("@categoryID", newMenuItem.CategoryID);
            queryEdit.Parameters.AddWithValue("@name", newMenuItem.Name);
            queryEdit.Parameters.AddWithValue("@price", newMenuItem.Price);
            queryEdit.Parameters.AddWithValue("@stock", oldMenuItem.Stock - newMenuItem.Stock);
            queryEdit.Parameters.AddWithValue("@alcoholic", newMenuItem.Alcoholic);
            queryEdit.Parameters.AddWithValue("@menuItemID", newMenuItem.MenuItemID);
            queryEdit.ExecuteNonQuery();
            CloseConnection();
        }

        private MenuItem ReadMenuItem(SqlDataReader reader)
        {
            int menuItemID = (int)reader["menuItemID"];
            int categoryID = (int)reader["categoryID"];
            string name = (string)reader["name"];
            double price = (double)reader["price"];
            int stock = (int)reader["stock"];
            bool alcoholic = (bool)reader["alcoholic"];

            return new MenuItem(menuItemID, categoryID, name, price, stock, alcoholic);
        }
    }
}
