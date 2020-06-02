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

namespace UserInterface
{
    public partial class Order_MenuSelect : Form
    {
        Order currentOrder;
        Order_MenuItemSelect menuItemSelect;
        static Order_MenuSelect order_MenuSelect;

        private Order_MenuSelect(Order currentOrder)
        {
            InitializeComponent();
            this.currentOrder = currentOrder;
        }

        public static Order_MenuSelect GetInstance(Order currentOrder)
        {
            if (order_MenuSelect == null)
                order_MenuSelect = new Order_MenuSelect(currentOrder);
            return order_MenuSelect;
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            Hide();
            Order_Home orderHome = Order_Home.GetInstance(menuItemSelect);
            orderHome.Closed += (s, args) => Show();
            orderHome.Show();
        }

        private void btn_LunchMain_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(1, currentOrder);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_Specials_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(2, currentOrder);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_Bites_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(3, currentOrder);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_Starters_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(4, currentOrder);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_Mains_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(5, currentOrder);
            menuItemSelect.Closed += (s, args) => Show();
            menuItemSelect.Show();
        }

        private void btn_Desserts_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(6, currentOrder);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_SoftDrinks_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(7, currentOrder);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_HotDrinks_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(8, currentOrder);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_Beers_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(9, currentOrder);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_Wines_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(10, currentOrder);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            //functionality to go back to homescreen here
        }
    }
}
