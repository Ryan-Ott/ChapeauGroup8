using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderItem
    {
        public OrderItem(int orderItemID, int orderID, MenuItem menuItem, int quantity, string requests, string orderState, DateTime lastStateChange)
        {
            OrderItemID = orderItemID;
            OrderID = orderID;
            MenuItem = menuItem;
            Quantity = quantity;
            Requests = requests;
            OrderState = orderState;
            LastStateChange = lastStateChange;
        }

        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }
        public string Requests { get; set; } //any special requests that were added to the order (e.g. extra salt)
        public string OrderState { get; set; } //whether order is ordered, in kitchen/bar(preparing), ready(to be served) or delivered -- could be enum
        public DateTime LastStateChange { get; set; } //time passed since order state last changed
    }
}
