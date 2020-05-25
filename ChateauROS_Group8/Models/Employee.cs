using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employee
    {
        public Employee(int employeeID, Type type, string username, string password)
        {
            EmployeeID = employeeID;
            Type = type;
            Username = username;
            Password = password;
        }

        public Employee() : this(99, 0, "testmanager", "password")
        {
        }

        public int EmployeeID { get; set; } //DB primary key (so not the username used to log into the system)
        public Type Type { get; set; } //used to identify user permissions (e.g. barman, chef, waiter etc.) //also enum
        public string Username { get; set; } //username used to log into the system
        public string Password { get; set; }

        public override string ToString()
        {
            return $"EmployeeID: {EmployeeID} - Type: {Type} - Username: {Username} - Password: {Password}";
        }
    }

    public enum Type
    {
        manager = 0, bar, kitchen, waiter
    }
}
