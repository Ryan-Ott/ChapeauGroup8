using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        public Order(int orderID, Table table, int billID, Employee employee, bool completed, string comment)
        {
            OrderID = orderID;
            Table = table;
            BillID = billID;
            Employee = employee;
            Completed = completed;
            Comment = comment;
        }

        public Order(Bill bill, Employee employee) : this()
        {
            BillID = bill.BillID;
            Employee = employee;
        }

        public Order() : this(0, new Table(), 0, new Employee(), false, "")
        {
        }

        //public List<OrderItem> orderItems; //join SQL query

        public int OrderID { get; set; }
        public Table Table { get; set; } //from which restaurant table the order was taken
        public int BillID { get; set; } //which bill is associated with the order
        public Employee Employee { get; set; } //which waiter is responsible for the order
        public bool Completed { get; set; } //whether the order is completely finished
        public string Comment { get; set; } //place where customer comments are stored
    }
}
