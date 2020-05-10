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

        public int CategoryID { get; set; }
        public int MenuID { get; set; }
        public string CategoryName { get; set; }

        public override string ToString()
        {
            return $"{CategoryName} with ID: {CategoryID} and in menu {MenuID}";
        }
    }
}
