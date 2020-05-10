using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Logic;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu_Service menu_Service = new Menu_Service();
            List<Menu> menus = menu_Service.GetAllMenus();
            foreach (Menu menu in menus)
            {
                Console.WriteLine(menu.ToString());
            }
            Console.ReadKey();
        }
    }
}
