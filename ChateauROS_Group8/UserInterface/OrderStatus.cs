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
using System.Data.SqlClient;
using Type = Models.Type;

namespace UserInterface
{
    public partial class OrderStatus : Form
    {

        private OrderAndOrderItem_Service Orderserv = new OrderAndOrderItem_Service();
        Employee_Service employeeserv = new Employee_Service();

        public OrderStatus()
        {
            InitializeComponent();
            kitchenlbl.Hide();
            Barlbl.Hide();
            serverlbl.Hide();
            Employee orderTaker = employeeserv.GetByID(2); 
            if (orderTaker.Type == Type.waiter)
            {
                serverlbl.Show();
                DisplayAllOrders();
            }
            if (orderTaker.Type == Type.kitchen)
            {
                kitchenlbl.Show();
                DisplayKitchenOrders();
            }
            if (orderTaker.Type == Type.bar)
            {
                Barlbl.Show();
                DisplayBarOrders();
            }


        }

        private void DisplayKitchenOrders()
        {
            Corderview.Items.Clear();
            Ordersview.Items.Clear();

            foreach (OrderItem order in Orderserv.GetOrderItems())
            {
                int CategoryID = order.MenuItem.CategoryID;
                OrderState ostate = order.OrderState;
                if (CategoryID == 1 || CategoryID == 2 || CategoryID == 3 || CategoryID == 4 || CategoryID == 5 || CategoryID == 6)
                {
                    if (ostate == OrderState.ordered || ostate == OrderState.preparing)
                    {
                        ListViewItem item = new ListViewItem(order.MenuItem.Name);
                        item.SubItems.Add(order.Quantity.ToString());
                        item.SubItems.Add(order.OrderID.ToString());
                        item.SubItems.Add(order.OrderState.ToString());
                        item.SubItems.Add(TimeAgo(order.LastStateChange));
                        item.SubItems.Add(order.OrderItemID.ToString());
                        item.SubItems.Add(order.Table.TableID.ToString());
                        item.SubItems.Add(order.Requests);
                        Ordersview.Items.Add(item);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(order.MenuItem.Name);
                        item.SubItems.Add(order.Quantity.ToString());
                        item.SubItems.Add(order.OrderID.ToString());
                        item.SubItems.Add(order.OrderState.ToString());
                        item.SubItems.Add(TimeAgo(order.LastStateChange));
                        item.SubItems.Add(order.OrderItemID.ToString());
                        item.SubItems.Add(order.Table.TableID.ToString());
                        item.SubItems.Add(order.Requests);
                        Corderview.Items.Add(item);
                    }
                }
            }
        }

        private void DisplayBarOrders()
        {
            Corderview.Items.Clear();
            Ordersview.Items.Clear();

            foreach (OrderItem order in Orderserv.GetOrderItems())
            {
                int CategoryID = order.MenuItem.CategoryID;
                OrderState ostate = order.OrderState;
                if (CategoryID == 7 || CategoryID == 8 || CategoryID == 9 || CategoryID == 10)
                {
                    if (ostate == OrderState.ordered || ostate == OrderState.preparing)
                    {
                        ListViewItem item = new ListViewItem(order.MenuItem.Name);
                        item.SubItems.Add(order.Quantity.ToString());
                        item.SubItems.Add(order.OrderID.ToString());
                        item.SubItems.Add(order.OrderState.ToString());
                        item.SubItems.Add(TimeAgo(order.LastStateChange));
                        item.SubItems.Add(order.OrderItemID.ToString());
                        item.SubItems.Add(order.Table.TableID.ToString());
                        item.SubItems.Add(order.Requests);
                        Ordersview.Items.Add(item);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(order.MenuItem.Name);
                        item.SubItems.Add(order.Quantity.ToString());
                        item.SubItems.Add(order.OrderID.ToString());
                        item.SubItems.Add(order.OrderState.ToString());
                        item.SubItems.Add(TimeAgo(order.LastStateChange));
                        item.SubItems.Add(order.OrderItemID.ToString());
                        item.SubItems.Add(order.Table.TableID.ToString());
                        item.SubItems.Add(order.Requests);
                        Corderview.Items.Add(item);
                    }
                }
            }
        }

        private void DisplayAllOrders()
        {
            Corderview.Items.Clear();
            Ordersview.Items.Clear();
            
                foreach (OrderItem order in Orderserv.GetOrderItems())
                {
                    OrderState ostate = order.OrderState;
                    if (ostate == OrderState.ordered || ostate == OrderState.preparing)
                    {
                        ListViewItem item = new ListViewItem(order.MenuItem.Name);
                        item.SubItems.Add(order.Quantity.ToString());
                        item.SubItems.Add(order.OrderID.ToString());
                        item.SubItems.Add(order.OrderState.ToString());
                        item.SubItems.Add(TimeAgo(order.LastStateChange));
                        item.SubItems.Add(order.OrderItemID.ToString());
                        item.SubItems.Add(order.Table.TableID.ToString());
                        item.SubItems.Add(order.Requests);
                        Ordersview.Items.Add(item);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(order.MenuItem.Name);
                        item.SubItems.Add(order.Quantity.ToString());
                        item.SubItems.Add(order.OrderID.ToString());
                        item.SubItems.Add(order.OrderState.ToString());
                        item.SubItems.Add(TimeAgo(order.LastStateChange));
                        item.SubItems.Add(order.OrderItemID.ToString());
                        item.SubItems.Add(order.Table.TableID.ToString());
                        item.SubItems.Add(order.Requests);
                        Corderview.Items.Add(item);
                    }
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
            foreach (ListViewItem item in Corderview.SelectedItems)
            {
                requeststxt.Text = item.SubItems[7].Text;
            }
        }

        private void lbl_bill_Click(object sender, EventArgs e)
        {

        }

        private void requeststxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void prepbtn_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;
            connetionString = "Data Source=den1.mssql8.gear.host; initial Catalog = dbchapeau08; User ID = dbchapeau08;Password =Oe2w768_oK!m";
            sql = "UPDATE dbchapeau08.dbo.OrderItems ([orderState]) values(@OS)";
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@OS", SqlDbType.Int).Value = 2;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Corderview.SelectedItems)
            {
                requeststxt.Text = item.SubItems[7].Text;
            }
        }
        public static string TimeAgo(DateTime dt)
        {
            if (dt > DateTime.Now)
                return "about sometime from now";
            TimeSpan span = DateTime.Now - dt;

            if (span.Days > 365)
            {
                int years = (span.Days / 365);
                if (span.Days % 365 != 0)
                    years += 1;
                return String.Format("{0} {1} ago", years, years == 1 ? "year" : "years");
            }

            if (span.Days > 30)
            {
                int months = (span.Days / 30);
                if (span.Days % 31 != 0)
                    months += 1;
                return String.Format("{0} {1} ago", months, months == 1 ? "month" : "months");
            }

            if (span.Days > 0)
                return String.Format("{0} {1} ago", span.Days, span.Days == 1 ? "day" : "days");

            if (span.Hours > 0)
                return String.Format("{0} {1} ago", span.Hours, span.Hours == 1 ? "hour" : "hours");

            if (span.Minutes > 0)
                return String.Format("{0} {1} ago", span.Minutes, span.Minutes == 1 ? "minute" : "minutes");

            if (span.Seconds > 5)
                return String.Format("{0} seconds ago", span.Seconds);

            if (span.Seconds <= 5)
                return "just now";

            return string.Empty;
        }

    }
}
