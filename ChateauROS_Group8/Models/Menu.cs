using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Menu
    {
        public int MenuID { get; set; }
        public string MenuName { get; set; }
        public TimeSpan StartTime { get; set; } //Time after which menu is planned to be offered
        public TimeSpan EndTime { get; set; } //Time after which menu is not planned to be offered anymore
    }
}
