using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Logic;

namespace UserInterface
{
    public partial class OrderStatus : Form
    {

        private OrderAndOrderItem_Service Orderserv = new OrderAndOrderItem_Service();
        public OrderStatus()
        {
            InitializeComponent();
            DisplayAllOrders();

        }
        private void DisplayAllOrders()
        {
            Orderlistlbl.Items.Clear();
            foreach (OrderItem order in Orderserv.GetOrderItems())
            {
                ListViewItem item = new ListViewItem(order.OrderItemID.ToString());
                item.SubItems.Add(order.OrderID.ToString());
                item.SubItems.Add(order.MenuItem.Name);
                item.SubItems.Add(order.Quantity.ToString());
                item.SubItems.Add(order.Requests);
                item.SubItems.Add(order.OrderState);
                item.SubItems.Add(order.LastStateChange.ToString());
                Orderlistlbl.Items.Add(item);
            }
        }
        private void OrderStatus_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Orderlistlbl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
