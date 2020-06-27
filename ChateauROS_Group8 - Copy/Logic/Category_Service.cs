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
            try
            {
                return categoryDAO.DB_GetAllCategories();
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not get all categories: " + e.Message);
                List<Category> errorCats = new List<Category>();
                errorCats.Add(new Category(69, 420, "errorCategory1"));
                errorCats.Add(new Category(66, 666, "errorCategory2"));
                return errorCats;
            }
        }

        public Category GetCategoryByID(int id)
        {
            try
            {
                return categoryDAO.DB_GetCategoryByID(id);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Could not get category by ID: " + e.Message);
                return new Category(1738, 111, "errorCategory1");
            }
        }

        public List<Category> GetCategoriesByMenu(int menuID)
        {
            try
            {
                return categoryDAO.DB_GetCategoriesByMenuID(menuID);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not get all categories by menu: " + e.Message);
                List<Category> errorCats = new List<Category>();
                errorCats.Add(new Category(69, 420, "errorCategory1"));
                errorCats.Add(new Category(66, 666, "errorCategory2"));
                return errorCats;
            }
        }
    }
}
