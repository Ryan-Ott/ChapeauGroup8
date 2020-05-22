using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MenuItem
    {
        public MenuItem(int menuItemID, int categoryID, string name, double price, int stock, bool alcoholic)
        {
            MenuItemID = menuItemID;
            CategoryID = categoryID;
            Name = name;
            Price = price;
            Stock = stock;
            Alcoholic = alcoholic;
        }

        public int MenuItemID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool Alcoholic { get; set; }

        public override string ToString()
        {
            return $"ID: {MenuItemID} - CatID: {CategoryID} - Name: {Name} - {Price} - Stock: {Stock} - Alcoholic: {Alcoholic}";
        }
    }
}
