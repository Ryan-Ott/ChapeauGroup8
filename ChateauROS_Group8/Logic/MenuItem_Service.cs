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
                errorMenuItems.Add(new MenuItem(0, 1, "errorMenuItem1", 69, 1, false));
                errorMenuItems.Add(new MenuItem(0, 1, "errorMenuItem2", 69, 1, false));
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
                return new MenuItem(0, 1, "errorMenuItem3", 69, 1, false);
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
                errorMenuItems.Add(new MenuItem(0, 1, "errorMenuItem4", 69, 0, false));
                errorMenuItems.Add(new MenuItem(0, 1, "errorMenuItem5", 69, 0, false));
                return errorMenuItems;
            }
        }

        public MenuItem GetMenuItemByName(string menuItemName)
        {
            try
            {
                return menuItemDAO.DB_GetMenuItemByName(menuItemName);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Could not get menuItem with name {menuItemName}: " + e.Message);
                return new MenuItem(0, 1, "errorMenuItem5", 69, 0, false);
            }
        }

        public void UpdateStock(List<OrderItem> orderItems)
        {
            foreach (OrderItem orderItem in orderItems)
            {
                menuItemDAO.DB_EditMenuItemStock(orderItem.MenuItem);
            }
        }
    }
}
