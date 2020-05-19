using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Category
    {
        public Category(int categoryID, int menuID, string categoryName)
        {
            CategoryID = categoryID;
            MenuID = menuID;
            CategoryName = categoryName;
        }
        //list of menuItems
        public int CategoryID { get; set; }
        public int MenuID { get; set; } //store as menu object
        public string CategoryName { get; set; }

        public override string ToString()
        {
            return $"{CategoryName} with ID: {CategoryID} and in menu {MenuID}";
        }
    }
}
