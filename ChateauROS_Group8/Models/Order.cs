using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        public Order(int orderID, int tableID, int billID, int employeeID, bool completed, string comment)
        {
            OrderID = orderID;
            TableID = tableID;
            BillID = billID;
            EmployeeID = employeeID;
            Completed = completed;
            Comment = comment;
        }

        public int OrderID { get; set; }
        public int TableID { get; set; } //from which restaurant table the order was taken
        public int BillID { get; set; } //which bill is associated with the order
        public int EmployeeID { get; set; } //which waiter is responsible for the order
        public bool Completed { get; set; } //whether the order is completely finished
        public string Comment { get; set; } //place where customer comments are stored
    }
}
