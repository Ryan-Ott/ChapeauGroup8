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

        public Order_MenuItemSelect(int categoryID)
        {
            InitializeComponent();
            SetCategoryLabel(categoryID);
            DisplayMenuItems(categoryID);
        }

        private void SetCategoryLabel(int categoryID)
        {
            Category selectedCat = categoryService.GetCategoryByID(categoryID);
            lbl_Menu_Category.Text = selectedCat.CategoryName;
        }

        private void DisplayMenuItems(int categoryID)
        {
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

        private void lbl_ItemSelect_Click(object sender, EventArgs e)
        {

        }

        private void btn_Menus_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuSelect menuSelect = new Order_MenuSelect();
            menuSelect.Closed += (s, args) => Close();
            menuSelect.Show();
        }
    }
}
