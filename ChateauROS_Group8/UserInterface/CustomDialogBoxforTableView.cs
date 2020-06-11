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
    public partial class CustomDialogBoxforTableView : Form
    {
        Table table;
        Employee employee;

        public CustomDialogBoxforTableView(Table table, Employee employee)
        {
            InitializeComponent();
            this.table = table;
            this.employee = employee;
        }

        private void btn_TakeNewOrder_Click(object sender, EventArgs e)
        {
            Hide();
            Order_Home orderHome = Order_Home.GetInstance();
            orderHome.SetTableAndEmployee(table, employee);
            orderHome.ShowDialog();
        }

        private void btn_PayOrder_Click(object sender, EventArgs e)
        {
            Hide();
            Bill_Home bill_Home = new Bill_Home(table);
            bill_Home.ShowDialog();
        }
    }
}
