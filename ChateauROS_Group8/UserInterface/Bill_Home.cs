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
using System.Net.Mail;

namespace UserInterface
{
    public partial class Bill_Home : Form
    {
        private Table table;
        private OrderAndOrderItem_Service order_Service = new OrderAndOrderItem_Service();
        private Bill_Service bill_Service = new Bill_Service();
        private Bill bill;
        private Order order;
        private List<OrderItem> items;
        public Bill_Home()
        {
            InitializeComponent();
            //this.table = table;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Bill_Home_Load(object sender, EventArgs e)
        {
            //hide all other panels and buttons
            pnl_Summary.Hide();
            pnl_cash.Hide();
            pnl_card.Hide();
            pnl_tip.Hide();
            pnl_comment.Hide();
            complete_btn.Hide();

            //Get bill data from database - from table with running order
            order = order_Service.GetOrderByTableID(4);
            bill = new Bill(order.BillID);

            items = order_Service.GetAllOrderItems(order.OrderID);

            //calculate total prices and taxes
            bill_Service.CalculateTax(items, bill);

            //fill out bill information
            DisplayBillInformation(order, bill);

            //fill all ordered items in the bill
            FillOrderItems(items);
        }
        private void DisplayBillInformation(Order order,Bill bill)
        {
            lbl_billID.Text = order.BillID.ToString();
            lbl_orderID.Text = order.OrderID.ToString();
            lbl_tableID.Text = order.Table.TableID.ToString();
            lbl_emID.Text = order.Employee.EmployeeID.ToString();
            lbl_Date.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lbl_totalNoVAT.Text = (bill.Total - (bill.Tax21 + bill.Tax6)).ToString("0.00") + " €";
            lbl_VAT.Text = (bill.Tax21 + bill.Tax6).ToString("0.00") + " €";
            lbl_total.Text = bill.Total.ToString("0.00") + " €";
        }
        private void FillOrderItems(List<OrderItem> items)
        {
            //clear items before filling the list
            listView_Items.Items.Clear();

            //filling the list view wih each item
            foreach (OrderItem item in items)
            {
                ListViewItem list = new ListViewItem(item.OrderItemID.ToString());
                list.SubItems.Add(item.MenuItem.Name);
                list.SubItems.Add(item.Quantity.ToString());
                list.SubItems.Add(item.MenuItem.Price.ToString());
                listView_Items.Items.Add(list);
            }
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            pnl_Summary.Show();
            pnl_tip.Show();
            complete_btn.Show();

            //fill out summary data
            DisplaySummary(bill);
        }
        private void DisplaySummary(Bill bill)
        {
            lbl_Sum_Total.Text = bill.Total.ToString("0.00") + " €";
            lbl_Sum_VAT.Text = (bill.Tax21 + bill.Tax6).ToString("0.00") + " €";
            lbl_Sum_TotalNoVAT.Text = (bill.Total - (bill.Tax21 + bill.Tax6)).ToString("0.00") + " €";
        }
        private void cash_rb_CheckedChanged(object sender, EventArgs e)
        {
            pnl_card.Hide();

            pnl_cash.Show();
        }

        private void CashPayment(Bill bill)
        {
            bill.PaymentMethod = PaymentMethod.cash;
        }

        private void CardPayment(Bill bill)
        {
            string cardType = cardType_combo.SelectedItem.ToString();
            if (PaymentMethod.VISA.ToString() == cardType)
                bill.PaymentMethod = PaymentMethod.VISA;
            else
                bill.PaymentMethod = PaymentMethod.AMEX;
        }

        private void PinPayment(Bill bill)
        {
            bill.PaymentMethod = PaymentMethod.pin;
        }

        private void Pin_rb_CheckedChanged(object sender, EventArgs e)
        {
            //hide all other panels
            pnl_cash.Hide();
            pnl_card.Hide();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
        }

        private void card_rb_CheckedChanged(object sender, EventArgs e)
        {
            //hide all other panels
            pnl_cash.Hide();

            pnl_card.Show();
        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            if (Pin_rb.Checked == true)
                PinPayment(bill);
            else if (card_rb.Checked == true)
                CardPayment(bill);
            else if (cash_rb.Checked == true)
                CashPayment(bill);

            bill.Tip = double.Parse(txt_tips.Text);

            //store data to the database and update order and table status
            bill_Service.EditBill(bill,order);
        }

        private void btn_add_comment_Click(object sender, EventArgs e)
        {
            pnl_comment.Show();
        }

        private void confirm_btn_Click_1(object sender, EventArgs e)
        {
            lbl_changes.Text = (double.Parse(txt_received.Text) - bill.Total).ToString(); 
        }

        private void save_btn_Click_1(object sender, EventArgs e)
        {
            //save comment to the database
            order.Comment = txt_comment.Text;
            order_Service.EditOrder(order);

            //show confirmation message box
            MessageBox.Show("comment has been saved!", "CONFIRM", MessageBoxButtons.OK);

            //hide textbox
            pnl_comment.Hide();
        }

        private void add_comment_btn_Click(object sender, EventArgs e)
        {
            pnl_comment.Show();
        }
    }
}
