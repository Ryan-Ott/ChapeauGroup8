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
    public partial class Order_MenuItemSelect : Form
    {
        Category_Service categoryService = new Category_Service();
        MenuItem_Service menuItemService = new MenuItem_Service();
 
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

        private void CloseOtherWindows()
        {
            List<Form> openForms = new List<Form>();
            foreach (Form form in Application.OpenForms)
                openForms.Add(form);
            foreach (Form form in openForms)
                if (this != form)
                    form.Hide();
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

            foreach (OrderItem orderItem in currentOrder.orderItems)
            {
                ListViewItem li = new ListViewItem(orderItem.MenuItem.Name);
                li.SubItems.Add(orderItem.Quantity.ToString());
                liv_CurrentOrder.Items.Add(li);
            }
        }

        private void btn_Menus_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuSelect menuSelect = Order_MenuSelect.GetInstance();
            menuSelect.Closed += (s, args) => Close();
            menuSelect.Show();
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (nud_ItemCount.Value == 0)
                    MessageBox.Show("Please select the correct quantity of the menu item you wish to add.");
                else
                {
                    ListViewItem selectedLVI = liv_MenuItems.SelectedItems[0];
                    string menuItemName = selectedLVI.SubItems[0].Text;
                    Models.MenuItem selectedMenuItem = menuItemService.GetMenuItemByName(menuItemName);
                    nud_ItemCount.Maximum = selectedMenuItem.Stock;
                    UpdateOrderItems(selectedMenuItem);

                    DisplayCurrentOrder();
                    DisplayMenuItems();
                    nud_ItemCount.Value = 0;
                } 
            }
            catch (Exception x)
            {
                MessageBox.Show("Please make sure a menu item is selected. " + x.Message);
                return;
            }
        }

        private void UpdateOrderItems(Models.MenuItem selectedMenuItem)
        {
            bool itemPresent = false;
            foreach (OrderItem orderItem in currentOrder.orderItems) //determines whether this item is already being ordered, if yes, only increase order quantity
            {
                orderItem.OrderID = currentOrder.OrderID;
                if (orderItem.MenuItem.MenuItemID == selectedMenuItem.MenuItemID)
                {
                    itemPresent = true;
                    if ((orderItem.Quantity + (int)nud_ItemCount.Value) <= selectedMenuItem.Stock)
                        orderItem.Quantity += (int)nud_ItemCount.Value;
                    else
                    {
                        orderItem.Quantity = selectedMenuItem.Stock;
                        MessageBox.Show("Maximum current capacity for this menu item has been reached. Max stock amount has been added to order.");
                    }
                }
            }
            if (!itemPresent) //if menuItem not present in order already, create a new order item for it and add to orderItems of current order
            {
                OrderItem newOrderItem = new OrderItem(0, currentOrder.OrderID, selectedMenuItem, (int)nud_ItemCount.Value, "", OrderState.ordered, new Table(), TimeSpan.Zero);
                currentOrder.orderItems.Add(newOrderItem);
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Hide();
            Order_Home orderHome = Order_Home.GetInstance();
            orderHome.Closed += (s, args) => Show();
            orderHome.Show();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
