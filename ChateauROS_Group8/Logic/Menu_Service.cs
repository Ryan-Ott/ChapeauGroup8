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
            return menuDAO.DB_GetAllMenus();
        }

        public Menu GetMenuByID(int id)
        {
            return menuDAO.DB_GetMenuByID(id);
        }
    }
}
