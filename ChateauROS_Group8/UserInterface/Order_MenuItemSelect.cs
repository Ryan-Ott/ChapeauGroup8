using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Models;

namespace UserInterface
{
    public partial class Order_MenuItemSelect : Form
    {
        Category_Service categoryService = new Category_Service();
        MenuItem_Service menuItemService = new MenuItem_Service();
        OrderAndOrderItem_Service orderAndOrderItemService = new OrderAndOrderItem_Service();
        Order currentOrder;
        int categoryID;

        public Order_MenuItemSelect(int categoryID, Order currentOrder)
        {
            InitializeComponent();
            this.currentOrder = currentOrder;
            this.categoryID = categoryID;
            SetCategoryLabel();
            DisplayMenuItems();
            DisplayCurrentOrder();
        }

        private void Order_MenuItemSelect_Load(object sender, EventArgs e)
        {

        }

        private void SetCategoryLabel()
        {
            Category selectedCat = categoryService.GetCategoryByID(categoryID);
            lbl_Menu_Category.Text = selectedCat.CategoryName;
        }

        private void DisplayMenuItems()
        {
            liv_MenuItems.Columns.Clear();
            liv_MenuItems.Items.Clear();
            liv_MenuItems.Columns.Add("Menu Item", 150);
            liv_MenuItems.Columns.Add("Stock", 48);

            List<Models.MenuItem> menuItems = menuItemService.GetMenuItemsByCategory(categoryID);
            foreach (Models.MenuItem menuItem in menuItems)
            {
                ListViewItem li = new ListViewItem(menuItem.Name);
                li.SubItems.Add(menuItem.Stock.ToString());
                liv_MenuItems.Items.Add(li);
            }
        }

        private void DisplayCurrentOrder()
        {
            liv_CurrentOrder.Columns.Clear();
            liv_CurrentOrder.Items.Clear();
            liv_CurrentOrder.Columns.Add("Item", 150);
            liv_CurrentOrder.Columns.Add("Count", 48);

            currentOrder.orderItems = orderAndOrderItemService.GetAllOrderItems(currentOrder.OrderID);

            foreach (OrderItem orderItem in currentOrder.orderItems)
            {
                ListViewItem li = new ListViewItem(orderItem.MenuItem.Name);
                li.SubItems.Add(orderItem.Quantity.ToString());
                liv_CurrentOrder.Items.Add(li);
            }
        }

        private void lbl_ItemSelect_Click(object sender, EventArgs e)
        {

        }

        private void btn_Menus_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuSelect menuSelect = Order_MenuSelect.GetInstance(currentOrder);
            menuSelect.Closed += (s, args) => Close();
            menuSelect.Show();
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (nud_ItemCount.Value == 0)
                {
                    MessageBox.Show("Please select the correct quantity of the menu item you wish to add.");
                    return;
                }
                ListViewItem selectedLVI = liv_MenuItems.SelectedItems[0];
                string menuItemName = selectedLVI.SubItems[0].Text;
                Models.MenuItem selectedMenuItem = menuItemService.GetMenuItemByName(menuItemName);

                nud_ItemCount.Maximum = selectedMenuItem.Stock;
                OrderItem newOrderItem = new OrderItem(0, currentOrder.OrderID, selectedMenuItem, (int)nud_ItemCount.Value, "", OrderState.ordered, DateTime.Now);
                orderAndOrderItemService.AddOrderItem(newOrderItem);
                newOrderItem = orderAndOrderItemService.GetLastOrderItem();
                DisplayCurrentOrder();
                DisplayMenuItems(); //REMEMBER TO ADD UPDATE STOCK FUNCTIONALTIY
            }
            catch (Exception x)
            {
                MessageBox.Show("Please make sure a menu item is selected. " + x.Message);
                return;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            //functionality to go back to homescreen here
        }
    }
}
