using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderItem
    {
        public OrderItem(int orderItemID, int orderID, MenuItem menuItem, int quantity, string requests, OrderState orderState, Table table, DateTime lastStateChange)
        {
            OrderItemID = orderItemID;
            OrderID = orderID;
            MenuItem = menuItem;
            Quantity = quantity;
            Requests = requests;
            OrderState = orderState;
            Table = table;
            LastStateChange = lastStateChange;
        }

        public OrderItem() : this(0, 0, new MenuItem(), 1, "", OrderState.ordered, new Table(), DateTime.Now)
        {
        }

        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }
        public string Requests { get; set; } //any special requests that were added to the order (e.g. extra salt)
        public OrderState OrderState { get; set; }
        public Table Table { get; set; }
        public DateTime LastStateChange { get; set; } //time when order state last changed
    }

    public enum OrderState
    {
        ordered = 1, preparing, ready, delivered
    }
}
