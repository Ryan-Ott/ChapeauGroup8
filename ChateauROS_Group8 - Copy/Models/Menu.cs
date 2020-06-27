using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Menu
    {
        public Menu(int menuID, string menuName, TimeSpan startTime, TimeSpan endTime)
        {
            MenuID = menuID;
            MenuName = menuName;
            StartTime = startTime;
            EndTime = endTime;
        }

        public int MenuID { get; set; }
        public string MenuName { get; set; }
        public TimeSpan StartTime { get; set; } //Time after which menu is planned to be offered
        public TimeSpan EndTime { get; set; } //Time after which menu is not planned to be offered anymore

        public override string ToString()
        {
            return $"{MenuName} with ID: {MenuID} - Start: {StartTime}  End: {EndTime}";
        }
    }
}
