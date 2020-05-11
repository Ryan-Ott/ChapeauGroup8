using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace Logic
{
    public class Category_Service
    {
        private Category_DAO categoryDAO = new Category_DAO();

        public List<Category> GetAllCategories()
        {
            return categoryDAO.DB_GetAllCategories();
        }

        public Category GetCategoryByID(int id)
        {
            return categoryDAO.DB_GetCategoryByID(id);
        }

        public List<Category> GetCategoriesByMenu(int menuID)
        {
            return categoryDAO.DB_GetCategoriesByMenuID(menuID);
        }
    }
}
