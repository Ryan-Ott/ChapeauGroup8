using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Order_MenuSelect : Form
    {
        public Order_MenuSelect()
        {
            InitializeComponent();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            Hide();
            Order_Home orderHome = Order_Home.GetInstance();
            orderHome.Closed += (s, args) => Close();
            orderHome.Show();
        }

        private void btn_LunchMain_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(1);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_Specials_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(2);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_Bites_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(3);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_Starters_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(4);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_Mains_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(5);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_Desserts_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(6);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_SoftDrinks_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(7);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_HotDrinks_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(8);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_Beers_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(9);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_Wines_Click(object sender, EventArgs e)
        {
            Hide();
            Order_MenuItemSelect menuItemSelect = new Order_MenuItemSelect(10);
            menuItemSelect.Closed += (s, args) => Close();
            menuItemSelect.Show();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            //functionality to go back to homescreen here
        }
    }
}
