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
    public partial class Order_Home : Form
    {
        OrderAndOrderItem_Service orderService = new OrderAndOrderItem_Service();
        Menu_Service menu_Service = new Menu_Service();
        Category_Service category_Service = new Category_Service();
        MenuItem_Service menuItem_Service = new MenuItem_Service();
        private static Order_Home order_Home;

        private Order_Home()
        {
            InitializeComponent();
        }

        public static Order_Home GetInstance()
        {
            if (order_Home == null)
                order_Home = new Order_Home();
            return order_Home;
        }

        private void Order_Home_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Menus_Click(object sender, EventArgs e)
        {
            if (nud_TableID.Value == 0)
            {
                MessageBox.Show("Please select a table for which you wish to take an order.");
                return;
            }
            Order tempOrder = new Order()
            Hide();
            Order_MenuSelect menuSelect = new Order_MenuSelect();
            menuSelect.Closed += (s, args) => Show();
            menuSelect.Show();
        }

        private void liv_CurrentOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnl_OrderHome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
