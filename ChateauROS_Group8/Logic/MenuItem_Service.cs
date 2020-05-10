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
            return menuItemDAO.DB_GetAllMenuItems();
        }

        public MenuItem GetMenuItemByID(int id)
        {
            return menuItemDAO.DB_GetMenuItemByID(id);
        }
    }
}
