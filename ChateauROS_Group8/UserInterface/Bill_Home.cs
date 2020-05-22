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
using DAL;

namespace UserInterface
{
    public partial class Bill_Home : Form
    {
        private int tableID;
        private OrderItem_Service orderItem_Service = new OrderItem_Service();
        private Bill_Service bill_Service = new Bill_Service();
        private Bill bill = new Bill();
        public Bill_Home()
        {
            InitializeComponent();
            //this.tableID = tableID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //make a display method and call
        private void Bill_Home_Load(object sender, EventArgs e)
        {
            pnl_Summary.Hide();
            pnl_cash_payment.Hide();
            pnl_pin_payment.Hide();

            ////Get bill data from database - from table with running order
            Order order = orderItem_Service.GetOrderByTableID(tableID);

            //fill out bill information
            FillBillInformation(order);

            List<OrderItem> items = orderItem_Service.GetAllOrderItems(order.OrderID);

            //fill all ordered items in the bill
            FillOrderItems(items);

            bill_Service.CalculateTax(items,bill);

            complete_btn.Hide();
        }
        private void FillBillInformation(Order order)
        {
            lbl_billID.Text = order.BillID.ToString();
            lbl_orderID.Text = order.OrderID.ToString();
            lbl_tableID.Text = order.Table.TableID.ToString();
            lbl_emID.Text = order.Employee.EmployeeID.ToString();
            lbl_Date.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
        private void FillOrderItems(List<OrderItem> items)
        {
            //clear items before filling the list
            listView_Items.Items.Clear();

            //filling the list view wih each item
            foreach (OrderItem item in items)
            {
                ListViewItem list = new ListViewItem(item.MenuItemID.ToString());
                list.SubItems.Add(item.DishName);
                list.SubItems.Add(item.Price.ToString());
                listView_Items.Items.Add(list);
            }
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            pnl_Summary.Show();
            complete_btn.Show();
            complete_btn.Enabled = false;
        }
        private void FillSummary()
        {
            lbl_Sum_Total.Text = bill.Total.ToString("'0' €");
            lbl_Sum_VAT.Text = (bill.Tax21 + bill.Tax6).ToString("'0' €");
            lbl_Sum_TotalNoVAT.Text = (bill.Total - (bill.Tax21 + bill.Tax6)).ToString();
        }

        private void listView_Items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cash_rb_CheckedChanged(object sender, EventArgs e)
        {
            //hide all other panels
            pnl_pin_payment.Hide();
            pnl_card_payment.Hide();

            //show cash payment details panel
            pnl_cash_payment.Show();

            complete_btn.Enabled = true;
        }
        private void CashPayment()
        {
            bill.PaymentMethod = "cash";

            int received = int.Parse(txt_received.Text);
            lbl_changes_amount.Text = (received - bill.Total).ToString("'0' €");

            if (cb_tips.Checked == true)
                bill.Tip = int.Parse(lbl_changes_amount.Text);
            else
                bill.Tip = 0;

            complete_btn.Enabled = true;
        }
        private void CardPayment()
        {
            string cardType = cardType_combo.SelectedItem.ToString();
            bill.PaymentMethod = "Credit card;" + cardType;
            bill.Tip = int.Parse(txt_card_tips.Text);
        }
        private void PinPayment()
        {
            bill.PaymentMethod = "Pin";
            bill.Tip = int.Parse(txt_pin_tips.Text);
        }

        private void Pin_rb_CheckedChanged(object sender, EventArgs e)
        {
            //hide all other panels
            pnl_cash_payment.Hide();
            pnl_card_payment.Hide();

            //show pin payment details panel
            pnl_pin_payment.Show();

            complete_btn.Enabled = true;
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            CashPayment();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            pnl_Summary.Hide();
            pnl_pin_payment.Hide();
            pnl_cash_payment.Hide();
            pnl_card_payment.Hide();
            complete_btn.Hide();
        }

        private void card_rb_CheckedChanged(object sender, EventArgs e)
        {
            //hide all other panels
            pnl_cash_payment.Hide();
            pnl_pin_payment.Hide();

            //show card payment details panel
            pnl_card_payment.Show();
        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            if (Pin_rb.Checked == true)
                PinPayment();
            else if (card_rb.Checked == true)
                CardPayment();
        }
    }
}
