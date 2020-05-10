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
    public class Menu_DAO : DAOBase
    {
        public List<Menu> DB_GetAllMenus()
        {
            OpenConnection();
            SqlCommand queryGetAll = new SqlCommand("SELECT menuID, menuName, startTime, endTime FROM [Menus]", connection);
            SqlDataReader reader = queryGetAll.ExecuteReader();
            List<Menu> menus = new List<Menu>();
            while (reader.Read())
            {
                Menu menu = ReadMenu(reader);
                menus.Add(menu);
            }
            reader.Close();
            CloseConnection();
            return menus;
        }

        public Menu DB_GetMenuByID(int id)
        {
            OpenConnection();
            SqlCommand queryGetByID = new SqlCommand("SELECT menuID, menuName, startTime, endTime FROM [Menus] WHERE menuID = @id");
            queryGetByID.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = queryGetByID.ExecuteReader();
            Menu menu = null;
            if (reader.Read())
            {
                menu = ReadMenu(reader);
            }
            reader.Close();
            CloseConnection();
            return menu;
        }

        private Menu ReadMenu(SqlDataReader reader)
        {
            int id = (int)reader["menuID"];
            string menuName = (string)reader["menuName"];
            TimeSpan startTime = (TimeSpan)reader["startTime"];
            TimeSpan endTime = (TimeSpan)reader["endTime"];

            return new Menu(id, menuName, startTime, endTime);
        }
    }
}