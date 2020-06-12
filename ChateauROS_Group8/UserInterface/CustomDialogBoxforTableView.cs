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
        TableView currentForm;
        public CustomDialogBoxforTableView(Table table, Employee employee, TableView tableView)
        {
            InitializeComponent();
            this.table = table;
            this.employee = employee;
            currentForm = tableView;
        }

        private void btn_TakeNewOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            currentForm.Hide();
            Order_Home orderHome = Order_Home.GetInstance();
            orderHome.SetTableAndEmployee(table, employee);
            orderHome.ShowDialog();
        }

        private void btn_PayOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            currentForm.Hide();
            Bill_Home bill_Home = new Bill_Home(table,employee);
            bill_Home.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
