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
using System.Runtime.Serialization;

namespace UserInterface
{
    public partial class Order_Home : Form
    {
        OrderAndOrderItem_Service orderOrderItemService = new OrderAndOrderItem_Service();
        MenuItem_Service menuItemService = new MenuItem_Service();
        Table_Service tableService = new Table_Service();
        Employee_Service employeeService = new Employee_Service();
        Bill_Service billService = new Bill_Service();

        Order currentOrder;
        OrderItem currentOrderItem;

        static Order_Home order_Home;

        private Order_Home(/*Employee employee*/)
        {
            InitializeComponent();
            InitNewOrderProcess();
            Employee orderTaker = employeeService.GetByID(4); //temporary whilst login is in works
            currentOrder.Employee = orderTaker/*employee*/;
        }

        public static Order_Home GetInstance()
        {
            if (order_Home == null)
                order_Home = new Order_Home();
            return order_Home;
        }

        private void Order_Home_Load(object sender, EventArgs e)
        {
            ReloadForm();
        }

        private void ReloadForm()
        {
            DisplayCurrentOrder();
            DisplayComment();
        }

        private void InitNewOrderProcess()
        {
            currentOrder = new Order();
            Order lastOrder = orderOrderItemService.GetLastOrder();
            if (lastOrder == null)
                currentOrder.OrderID = 1;
            else
                currentOrder.OrderID = lastOrder.OrderID + 1;
            ReloadForm();
        }

        private void DisplayComment() 
        {
            txtb_Requests.Clear();
            if (liv_CurrentOrder.SelectedItems.Count == 0)
            {
                txtb_Requests.Text = "No orderItem selected";
            }
            else
            {
                OrderItem selectedOrderItem = FindOrderItemByLVI(liv_CurrentOrder.SelectedItems[0]);
                txtb_Requests.Text = selectedOrderItem.Requests;
            }
        }

        private void DisplayCurrentOrder()
        {
            liv_CurrentOrder.Columns.Clear();
            liv_CurrentOrder.Items.Clear();
            liv_CurrentOrder.Columns.Add("Item", 150);
            liv_CurrentOrder.Columns.Add("Count", 48);

            try
            {
                foreach (OrderItem orderItem in currentOrder.orderItems)
                {
                    ListViewItem li = new ListViewItem(orderItem.MenuItem.Name);
                    li.SubItems.Add(orderItem.Quantity.ToString());
                    liv_CurrentOrder.Items.Add(li);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btn_Menus_Click(object sender, EventArgs e)
        {
            if (nud_TableID.Value == 0)
            {
                MessageBox.Show("Please select a table for which you wish to take an order.");
                return;
            }
            currentOrder.Table = tableService.GetByID((int)nud_TableID.Value);

            Hide();
            Order_MenuSelect menuSelect = Order_MenuSelect.GetInstance();
            menuSelect.CurrentOrder = currentOrder;
            menuSelect.Closed += (s, args) => Close();
            menuSelect.ShowDialog();
        }
        
        private void liv_CurrentOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OrderItem selectedOrderItem = FindOrderItemByLVI(liv_CurrentOrder.SelectedItems[0]);
                if (selectedOrderItem == null)
                    nud_ItemCount.Value = 0;
                else
                    nud_ItemCount.Value = selectedOrderItem.Quantity;
                DisplayComment();
            }
            catch (Exception)
            {
                txtb_Requests.Text = "No orderItem selected";
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentOrder.orderItems.Count == 0)
                {
                    MessageBox.Show("Please add items to an order to be submitted.");
                    return;
                }
                else
                {
                    orderOrderItemService.AddOrder(currentOrder);
                    menuItemService.UpdateStock(currentOrder.orderItems);
                    MessageBox.Show("Order has been successfully added! Returning go table view.");
                    //return to table view HERE
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("An error occured when attempting to add the order. " + x.Message);
            }
            InitNewOrderProcess();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this order being taken right now?", "Delete Order?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                InitNewOrderProcess();
                ReloadForm();
                nud_ItemCount.Value = 0;
            }
        }

        private void btn_AddComment_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtb_Requests.TextLength == 0)
                    MessageBox.Show("Please enter a comment to save.");
                else
                {
                    currentOrderItem = FindOrderItemByLVI(liv_CurrentOrder.SelectedItems[0]);
                    currentOrderItem.Requests = txtb_Requests.Text;
                    MessageBox.Show("Request has been saved.");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Please make sure a menu item is selected. " + x.Message);
                return;
            }
        }

        private OrderItem FindOrderItemByLVI(ListViewItem selectedLVI)
        {
            string menuItemName = selectedLVI.SubItems[0].Text;
            foreach (OrderItem orderItem in currentOrder.orderItems)
            {
                if (orderItem.MenuItem.Name == menuItemName)
                    return orderItem;
            }
            return null;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {

        }

        private void Order_Home_Shown(object sender, EventArgs e)
        {
            ReloadForm();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }

        private void nud_TableID_ValueChanged(object sender, EventArgs e)
        {
            //DELETE THIS OBJECT IN DESIGNER
        }

        private void nud_ItemCount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                currentOrderItem = FindOrderItemByLVI(liv_CurrentOrder.SelectedItems[0]);

                if (nud_ItemCount.Value == 0) //if item quantity is being set to 0, ask if waiter is sure they want to remove the item, if not, set value to 1
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to set the quantity to 0?", "Remove item", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        currentOrder.orderItems.Remove(currentOrderItem);
                    else if (dialogResult == DialogResult.No)
                        currentOrderItem.Quantity = 1;
                    ReloadForm();
                    return;
                }
                currentOrderItem.Quantity = (int)nud_ItemCount.Value;
                ReloadForm();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select the desired item again.");
            }
        }
    }
}
