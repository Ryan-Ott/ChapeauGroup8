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
    public partial class HomeScreen : Form
    {
        Employee currentEmployee;

        public HomeScreen(Employee employee)
        {
            InitializeComponent();
            currentEmployee = employee;
            lbl_Username.Text = currentEmployee.Username;
            lbl_UserType.Text = currentEmployee.Type.ToString();
        }

        private void lbl_TableOverview_Click(object sender, EventArgs e)
        {
            pnl_TableOverview_Click(sender, e);
        }

        private void pbox_Tables_Click(object sender, EventArgs e)
        {
            pnl_TableOverview_Click(sender, e);
        }

        private void pnl_TableOverview_Click(object sender, EventArgs e)
        {
            Hide();
            TableView tableView = new TableView(currentEmployee);
            tableView.Show();
        }

        private void lbl_KitchenView_Click(object sender, EventArgs e)
        {
            pnl_KitchenView_Click(sender, e);
        }

        private void pbox_Kitchen_Click(object sender, EventArgs e)
        {
            pnl_KitchenView_Click(sender, e);
        }

        private void pnl_KitchenView_Click(object sender, EventArgs e)
        {
            Hide();
            string kob = "kitchen";
            OrderStatus orderstatus = new OrderStatus(kob, currentEmployee);
            orderstatus.ShowDialog();
        }

        private void lbl_BarView_Click(object sender, EventArgs e)
        {
            pnl_BarView_Click(sender, e);
        }

        private void pbox_Bar_Click(object sender, EventArgs e)
        {
            pnl_BarView_Click(sender, e);
        }

        private void pnl_BarView_Click(object sender, EventArgs e)
        {
            Hide();
            string kob = "bar";
            OrderStatus orderstatus = new OrderStatus(kob, currentEmployee);
            orderstatus.ShowDialog();
        }

        private void lbl_Stock_Click(object sender, EventArgs e)
        {
            pnl_Stock_Click(sender, e);
        }

        private void pbox_Stock_Click(object sender, EventArgs e)
        {
            pnl_Stock_Click(sender, e);
        }

        private void pnl_Stock_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Group 8 has only got 4 members, therefore stock functionality is currently not present.");
        }

        private void lbl_ReadyOrders_Click(object sender, EventArgs e)
        {
            pnl_ReadyOrders_Click(sender, e);
        }

        private void pbox_Bell_Click(object sender, EventArgs e)
        {
            pnl_ReadyOrders_Click(sender, e);
        }

        private void pnl_ReadyOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Group 8 has only got 4 members, therefore notification functionality is currently not present.");
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
        }

        private void HomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn_Logout_Click(sender, e);
        }
    }
}
