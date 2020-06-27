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
    public partial class CustomDialogBoxforTableView : Form
    {
        Table table;
        Employee employee;
        TableView currentForm;
        string kb;
        
        OrderAndOrderItem_Service orderServ = new OrderAndOrderItem_Service();
        

        public CustomDialogBoxforTableView(Table table, Employee employee, TableView tableView)
        {
            InitializeComponent();
            this.table = table;
            this.employee = employee;
            currentForm = tableView;
        }
        private void CustomDialogBoxforTableView_Load(object sender, EventArgs e)
        {

            lblTable.Text = this.table.TableID.ToString();
            if(this.table.TableState == TableState.available)
            {
                availBtn.Enabled = false;
                btn_PayOrder.Enabled = false;
            }
            else if(this.table.TableState == TableState.occupied)
            {
                busyBtn.Enabled = false;
            }
            else if(this.table.TableState == TableState.reserved)
            {
                resBtn.Enabled = false;
            }


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

            //hide the old table view form and show new one with the updated table status
            currentForm.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void displayOrderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            currentForm.Hide();
            orderServ.GetOrderByTableID(table.TableID);
            OrderStatus orderstat = new OrderStatus(kb, employee);
            orderstat.ShowDialog();


        }

        
    }
}
