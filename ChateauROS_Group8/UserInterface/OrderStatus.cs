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
            resultdialogbox.Hide();
            Checkmarkpic.Hide();
            Crossmarkpic.Hide();
            AutoRefresh(kitchenorbar);
            lbl_Username.Text = ep.Username;
            lbl_UserType.Text = ep.Type.ToString();
        }

        private void AutoRefresh(string kitchenorbar) // Extra method for refreshing the list every minute and chooses between Kitchen or bar view
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

        private void DisplayKitchenOrders() // Displays kitchen orders
        {
            Corderview.Items.Clear();
            Ordersview.Items.Clear();

            foreach (OrderItem order in Orderserv.GetKitchenOrders())
            {                  
                        ListViewItem item = new ListViewItem(order.MenuItem.Name);
                        item.SubItems.Add(order.Quantity.ToString());
                        item.SubItems.Add(order.Table.TableID.ToString());
                        item.SubItems.Add(order.OrderState.ToString());
                        item.SubItems.Add(TimeAgo(order.LastStateChange));
                        item.SubItems.Add(order.OrderItemID.ToString());
                        item.SubItems.Add(order.OrderID.ToString());
                        item.SubItems.Add(order.Requests);
                        if (order.OrderState == OrderState.ready)
                            Corderview.Items.Add(item);
                        else
                            Ordersview.Items.Add(item);
            }
        }
 

        private void DisplayBarOrders() // Displays Bar Orders
        {
            Corderview.Items.Clear();
            Ordersview.Items.Clear();

            foreach (OrderItem order in Orderserv.GetBarOrders())
            {
                ListViewItem item = new ListViewItem(order.MenuItem.Name);
                item.SubItems.Add(order.Quantity.ToString());
                item.SubItems.Add(order.Table.TableID.ToString());
                item.SubItems.Add(order.OrderState.ToString());
                item.SubItems.Add(TimeAgo(order.LastStateChange));
                item.SubItems.Add(order.OrderItemID.ToString());
                item.SubItems.Add(order.OrderID.ToString());
                item.SubItems.Add(order.Requests);
                if (order.OrderState == OrderState.ready)
                    Corderview.Items.Add(item);
                else
                    Ordersview.Items.Add(item);
            }
        }


        private void OrderStatus_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Corderview_SelectedIndexChanged(object sender, EventArgs e) // Displays requests in the Completed order list
        {
            foreach (ListViewItem item in Corderview.SelectedItems)
            {
                requeststxt.Text = item.SubItems[7].Text;
            }
        }
        private void Ordersview_SelectedIndexChanged(object sender, EventArgs e) // Displays requests in the not completed order list
        {
            foreach (ListViewItem item in Ordersview.SelectedItems)
            {
                requeststxt.Text = item.SubItems[7].Text;
            }
        }


        private void prepbtn_Click(object sender, EventArgs e) // Button to change order to preparing
        {
            currentorder.OrderState = OrderState.preparing;
            foreach (ListViewItem item in Ordersview.SelectedItems)
            {
                currentorder.OrderItemID = int.Parse(item.SubItems[5].Text);
                currentorder.MenuItem.Name = item.SubItems[0].Text;
                currentorder.Table.TableID = int.Parse(item.SubItems[2].Text);
            }
            Preparing(currentorder);
        }
        private void rdybtn_Click(object sender, EventArgs e) // Button to change order to ready
        {
            currentorder.OrderState = OrderState.ready;
            foreach (ListViewItem item in Ordersview.SelectedItems)
            {
                currentorder.OrderItemID = int.Parse(item.SubItems[5].Text);
                currentorder.MenuItem.Name = item.SubItems[0].Text;
                currentorder.Table.TableID = int.Parse(item.SubItems[2].Text);
            }
            Ready(currentorder);
        }

        private void Ready(OrderItem currentorder) // Change order to ready in database and refresh the tables
        {
            currentorder.LastStateChange = DateTime.Now;
            try
            {
                Orderserv.Changetordy(currentorder);
                AutoRefresh(kitchenorbar);
                resultdialogbox.Text = "The order of " + currentorder.MenuItem.Name + " for Table " + currentorder.Table.TableID + " was changed to Ready!";
                resultdialogbox.Show();
                Checkmarkpic.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                resultdialogbox.Text = currentorder.MenuItem.Name + "status could not be changed";
                resultdialogbox.Show();
                Crossmarkpic.Show();
            }
        }

        private void Preparing(OrderItem currentorder) // Change order to preparing in database and refresh the tables
        {
            currentorder.LastStateChange = DateTime.Now;
            try
            {
                Orderserv.Changetoprpred(currentorder);
                AutoRefresh(kitchenorbar);
                resultdialogbox.Text = "The order of " + currentorder.MenuItem.Name + " for Table " + currentorder.Table.TableID + " was changed to Preparing!";
                resultdialogbox.Show();
                Checkmarkpic.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                resultdialogbox.Text = currentorder.MenuItem.Name + "status could not be changed";
                resultdialogbox.Show();
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
            AutoRefresh(kitchenorbar);
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Hide();
            HomeScreen hs = new HomeScreen(employee);
            hs.ShowDialog();
        }
        private void OrderStatus_FormClosed(object sender, FormClosedEventArgs e)
        {
            exitbtn_Click(sender, e);
        }
        public static string TimeAgo(DateTime dateTime)
        {
            string result = string.Empty;
            var timeSpan = DateTime.Now.Subtract(dateTime);

            if (timeSpan <= TimeSpan.FromSeconds(60))
            {
                result = string.Format("a minute ago");
            }
            else if (timeSpan <= TimeSpan.FromMinutes(60))
            {
                result = timeSpan.Minutes > 1 ?
                    String.Format("{0} minutes ago", timeSpan.Minutes) :
                    "a minute ago";
            }
            else if (timeSpan <= TimeSpan.FromHours(24))
            {
                result = timeSpan.Hours > 1 ?
                    String.Format("{0} hours ago", timeSpan.Hours) :
                    "an hour ago";
            }
            else if (timeSpan <= TimeSpan.FromDays(30))
            {
                result = timeSpan.Days > 1 ?
                    String.Format("about {0} days ago", timeSpan.Days) :
                    "yesterday";
            }
            else if (timeSpan <= TimeSpan.FromDays(365))
            {
                result = timeSpan.Days > 30 ?
                    String.Format("about {0} months ago", timeSpan.Days / 30) :
                    "month ago";
            }
            else
            {
                result = timeSpan.Days > 365 ?
                    String.Format("about {0} years ago", timeSpan.Days / 365) :
                    "year ago";
            }

            return result;
        }

    }
    
}
