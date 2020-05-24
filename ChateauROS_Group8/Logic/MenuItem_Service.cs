using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace Logic
{
    public class MenuItem_Service
    {
        private MenuItem_DAO menuItemDAO = new MenuItem_DAO();

        public List<MenuItem> GetAllMenuItems()
        {
            try
            {
                return menuItemDAO.DB_GetAllMenuItems();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Could not get all menuItems: " + e.Message);
                List<MenuItem> errorMenuItems = new List<MenuItem>();
                errorMenuItems.Add(new MenuItem(666, 777, "errorMenuItem1", 69, 0, false));
                errorMenuItems.Add(new MenuItem(888, 999, "errorMenuItem2", 69, 0, false));
                return errorMenuItems;
            }
        }

        public MenuItem GetMenuItemByID(int id)
        {
            try
            {
                return menuItemDAO.DB_GetMenuItemByID(id);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Could not get menuItem by ID {id}: " + e.Message);
                throw;
            }
        }

        public List<MenuItem> GetMenuItemsByCategory(int categoryID)
        {
            try
            {
                return menuItemDAO.DB_GetMenuItemsByCategory(categoryID);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Could not get all menuItems by category: " + e.Message);
                List<MenuItem> errorMenuItems = new List<MenuItem>();
                errorMenuItems.Add(new MenuItem(666, 777, "errorMenuItem1", 69, 0, false));
                errorMenuItems.Add(new MenuItem(888, 999, "errorMenuItem2", 69, 0, false));
                return errorMenuItems;
            }
        }
    }
}
