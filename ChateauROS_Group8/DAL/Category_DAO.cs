using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class Category_DAO : DAOBase
    {
        public List<Category> DB_GetAllCategories()
        {
            OpenConnection();
            SqlCommand queryGetAll = new SqlCommand("SELECT categoryID, menuID, categoryName FROM [Categories]", connection);
            SqlDataReader reader = queryGetAll.ExecuteReader();
            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category category = ReadCategory(reader);
                categories.Add(category);
            }
            reader.Close();
            CloseConnection();
            return categories;
        }

        public List<Category> DB_GetCategoriesByMenuID(int menuID)
        {
            OpenConnection();
            SqlCommand queryGetByMenuID = new SqlCommand("SELECT categoryID, menuID, categoryName FROM [Categories] WHERE menuID = @menuID", connection);
            queryGetByMenuID.Parameters.AddWithValue("@menuID", menuID);
            SqlDataReader reader = queryGetByMenuID.ExecuteReader();
            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category category = ReadCategory(reader);
                categories.Add(category);
            }
            reader.Close();
            CloseConnection();
            return categories;
        }

        public Category DB_GetCategoryByID(int id)
        {
            OpenConnection();
            SqlCommand queryGetByID = new SqlCommand("SELECT categoryID, menuID, categoryName FROM [Categories] WHERE categoryID = @id", connection);
            queryGetByID.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = queryGetByID.ExecuteReader();
            Category category = null;
            if (reader.Read())
            {
                category = ReadCategory(reader);
            }
            reader.Close();
            CloseConnection();
            return category;
        }

        private Category ReadCategory(SqlDataReader reader)
        {
            int categoryID = (int)reader["categoryID"];
            int menuID = (int)reader["menuID"];
            string categoryName = (string)reader["categoryName"];

            return new Category(categoryID, menuID, categoryName);
        }
    }
}
