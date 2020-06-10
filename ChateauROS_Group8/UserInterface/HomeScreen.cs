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

        public HomeScreen()
        {
            InitializeComponent();
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
            Close();
            TableView tableView = new TableView();
            tableView.ShowDialog();
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
            //Kevin, do what you need to do here
            //(look at pnl_TableOverview_Click() if you need inspiration)
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
            //Kevin, do what you need to do here
            //(look at pnl_TableOverview_Click() if you need inspiration)
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
            MessageBox.Show("Group 8 has only got 4 members, therefor stock functionality is currently not present.");
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
            MessageBox.Show("Group 8 has only got 4 members, therefor notification functionality is currently not present.");
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
