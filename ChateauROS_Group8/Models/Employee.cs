using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employee
    {
        public Employee(int employeeID, string type, string username, string password)
        {
            EmployeeID = employeeID;
            Type = type;
            Username = username;
            Password = password;
        }

        public int EmployeeID { get; set; } //DB primary key (so not the username used to log into the system)
        public string Type { get; set; } //used to identify user permissions (e.g. barman, chef, waiter etc.) //also enum
        public string Username { get; set; } //username used to log into the system
        public string Password { get; set; } 
    }
}
