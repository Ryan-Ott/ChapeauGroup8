using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MenuItem
    {
        public int MenuItemID { get; set; }
        public int CategoryID { get; set; }
        public string DishName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool Alcoholic { get; set; }
    }
}
