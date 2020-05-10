using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MenuItem
    {
        public MenuItem(int menuItemID, int categoryID, string dishName, double price, int stock, bool alcoholic)
        {
            MenuItemID = menuItemID;
            CategoryID = categoryID;
            DishName = dishName;
            Price = price;
            Stock = stock;
            Alcoholic = alcoholic;
        }

        public int MenuItemID { get; set; }
        public int CategoryID { get; set; }
        public string DishName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool Alcoholic { get; set; }

        public override string ToString()
        {
            return $"ID: {MenuItemID} - CatID: {CategoryID} - Name: {DishName} - {Price} - Stock: {Stock} - Alcoholic: {Alcoholic}";
        }
    }
}
