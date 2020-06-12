using Logic;
using Models;
using System;
using System.Windows.Forms;
using Type = Models.Type;

namespace UserInterface
{
    public partial class OrderStatus : Form
    {

        private OrderAndOrderItem_Service Orderserv = new OrderAndOrderItem_Service();
        Employee_Service employeeserv = new Employee_Service();
        Employee employee;
        OrderItem currentorder;
        string kitchenorbar;
        public OrderStatus(string kob, Employee ep)
        {
            InitializeComponent();
            currentorder = new OrderItem();
            employee = ep;
            kitchenorbar = kob;
            kitchenlbl.Hide();
            Barlbl.Hide();
            serverlbl.Hide();
            Checkmarkpic.Hide();
            Crossmarkpic.Hide();
            Start(kitchenorbar);
        }

        private void Start(string kitchenorbar)
        {
            if (kitchenorbar == "kitchen")
            {
                kitchenlbl.Show();
                DisplayKitchenOrders();
            }
            if (kitchenorbar == "bar")
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
                        item.SubItems.Add(order.LastStateChange.ToString());
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
                        item.SubItems.Add(order.LastStateChange.ToString());
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
                        item.SubItems.Add(order.LastStateChange.ToString());
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
                        item.SubItems.Add(order.LastStateChange.ToString());
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
                        item.SubItems.Add(order.LastStateChange.ToString());
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
                        item.SubItems.Add(order.LastStateChange.ToString());
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

        private void Corderview_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Corderview.SelectedItems)
            {
                requeststxt.Text = item.SubItems[7].Text;
                currentorder.OrderItemID = Convert.ToInt32(item.SubItems[5].Text);
            }
        }
        private void Ordersview_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Ordersview.SelectedItems)
            {
                requeststxt.Text = item.SubItems[7].Text;
            }
        }


        private void prepbtn_Click(object sender, EventArgs e)
        {

            OrderState orderstate = OrderState.preparing;

            foreach (ListViewItem item in Ordersview.SelectedItems)
            {
                currentorder.OrderItemID = int.Parse(item.SubItems[5].Text);
            }
             
            Preparing(currentorder.OrderItemID, orderstate);
        }
        private void rdybtn_Click(object sender, EventArgs e)
        {
            OrderState orderstate = OrderState.ready;

            foreach (ListViewItem item in Ordersview.SelectedItems)
            {
                currentorder.OrderItemID = int.Parse(item.SubItems[5].Text);
            }

            Ready(currentorder.OrderItemID, orderstate);
        }

        private void Ready(int OrderItemID, OrderState orderstate)
        {
            currentorder.OrderState = orderstate;
            currentorder.OrderItemID = OrderItemID;
            TimeSpan myDateResult = DateTime.Now.TimeOfDay;
            currentorder.LastStateChange = myDateResult;
            try
            {
                Orderserv.Changetordy(currentorder);
                Start(kitchenorbar);
                Checkmarkpic.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Crossmarkpic.Show();
            }
        }

        private void Preparing(int OrderItemID, OrderState orderstate)
        {
            currentorder.OrderState = orderstate;
            currentorder.OrderItemID = OrderItemID;
            TimeSpan myDateResult = DateTime.Now.TimeOfDay;
            currentorder.LastStateChange = myDateResult;
            try
            {
                Orderserv.Changetoprpred(currentorder);
                Start(kitchenorbar);
                Checkmarkpic.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Crossmarkpic.Show();
            }

        }
        private void lbl_bill_Click(object sender, EventArgs e)
        {

        }

        private void requeststxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void autorefresh_Tick(object sender, EventArgs e)
        {
            Start(kitchenorbar);
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Hide();
            HomeScreen hs = new HomeScreen(employee);
            hs.ShowDialog();
        }
    }
}
