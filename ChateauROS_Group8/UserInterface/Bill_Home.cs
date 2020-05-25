﻿using System;
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
            pnl_cash_payment.Hide();
            pnl_pin_payment.Hide();
            pnl_card_payment.Hide();
            pnl_order_complete.Hide();
            complete_btn.Hide();
            btn_back_to_tbview.Hide();
            txt_comment.Hide();

            //Get bill data from database - from table with running order
            order = order_Service.GetOrderByTableID(table.TableID);
            //bill = new Bill(order.BillID);

            bill.BillID = 1;//the bill id is hardcoded since there is no order stored in the database yet

            //Get all order items from specific order 
            items = order_Service.GetAllOrderItems(order.OrderID);

            //calculate total prices and taxes
            bill = bill_Service.CalculateTax(items, bill);

            //fill out bill information
            FillBillInformation(order, bill);

            //fill all ordered items in the bill
            FillOrderItems(items);
        }
        private void FillBillInformation(Order order,Bill bill)
        {
            lbl_billID.Text = order.BillID.ToString();
            lbl_orderID.Text = order.OrderID.ToString();
            lbl_tableID.Text = order.Table.TableID.ToString();
            lbl_emID.Text = order.Employee.EmployeeID.ToString();
            lbl_Date.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lbl_totalNoVAT.Text = (bill.Total - (bill.Tax21 + bill.Tax6)).ToString() + " €";
            lbl_VAT.Text = (bill.Tax21 + bill.Tax6).ToString() + " €";
            lbl_total.Text = bill.Total.ToString() + " €";
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
            complete_btn.Show();

            //fill out summary data
            FillSummary(bill);
        }
        private void FillSummary(Bill bill)
        {
            lbl_Sum_Total.Text = bill.Total.ToString() + " €";
            lbl_Sum_VAT.Text = (bill.Tax21 + bill.Tax6).ToString() + " €";
            lbl_Sum_TotalNoVAT.Text = (bill.Total - (bill.Tax21 + bill.Tax6)).ToString() + " €";
        }
        private void cash_rb_CheckedChanged(object sender, EventArgs e)
        {
            //hide all other panels
            pnl_pin_payment.Hide();
            pnl_card_payment.Hide();

            //show cash payment details panel
            pnl_cash_payment.Show();
        }
        private void CashPayment(Bill bill)
        {
            bill.PaymentMethod = "cash";

            if (cb_tips.Checked == true)
                bill.Tip = double.Parse(lbl_changes_amount.Text);
            else
                bill.Tip = 0;
        }
        private void CardPayment(Bill bill)
        {
            string cardType = cardType_combo.SelectedItem.ToString();
            bill.PaymentMethod = "Credit card;" + cardType;
            bill.Tip = double.Parse(txt_card_tips.Text);
        }
        private void PinPayment(Bill bill)
        {
            bill.PaymentMethod = "Pin";
            bill.Tip = double.Parse(txt_pin_tips.Text);
        }

        private void Pin_rb_CheckedChanged(object sender, EventArgs e)
        {
            //hide all other panels
            pnl_cash_payment.Hide();
            pnl_card_payment.Hide();

            //show pin payment details panel
            pnl_pin_payment.Show();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            double received = double.Parse(txt_received.Text);
            lbl_changes_amount.Text = (received - bill.Total).ToString($"{received} €");
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
                PinPayment(bill);
            else if (card_rb.Checked == true)
                CardPayment(bill);
            else if (cash_rb.Checked == true)
                CashPayment(bill);

            //hide all other buttons and panels
            complete_btn.Hide();
            cancel_btn.Hide();
            pnl_card_payment.Hide();
            pnl_cash_payment.Hide();
            pnl_pin_payment.Hide();
            pnl_Summary.Hide();

            //show order complete panel
            btn_back_to_tbview.Show();
            pnl_order_complete.Show();

            //store data to the database
            bill_Service.AddToBill(bill);

            //update order status to 'completed' in database
            order.Completed = true;
            order_Service.EditOrder(order);
        }

        private void btn_add_comment_Click(object sender, EventArgs e)
        {
            txt_comment.Show();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //save comment to the database
            order.Comment = txt_comment.Text;
            order_Service.EditOrder(order);

            //show confirmation message box
            MessageBox.Show("Comment saved!", "CONFIRM", MessageBoxButtons.OK);

            //hide textbox
            txt_comment.Hide();
        }
    }
}
