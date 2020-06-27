using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace Logic
{
    public class Menu_Service
    {
        private Menu_DAO menuDAO = new Menu_DAO();

        public List<Menu> GetAllMenus()
        {
            try
            {
                return menuDAO.DB_GetAllMenus();
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not get all menus: " + e.Message);
                List<Menu> errorMenus = new List<Menu>();
                errorMenus.Add(new Menu(69, "errorMenu1", new TimeSpan(16, 20, 42), new TimeSpan(17, 21, 43)));
                errorMenus.Add(new Menu(70, "errorMenu2", new TimeSpan(18, 22, 44), new TimeSpan(19, 23, 45)));
                return errorMenus;
            }
        }

        public Menu GetMenuByID(int id)
        {
            try
            {
                return menuDAO.DB_GetMenuByID(id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not get menu by ID: " + e.Message);
                return new Menu(71, "errorMenu3", new TimeSpan(18, 22, 44), new TimeSpan(19, 23, 45));
            }
        }
    }
}
