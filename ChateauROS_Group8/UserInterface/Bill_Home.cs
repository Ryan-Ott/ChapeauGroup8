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
        private Employee currentEmployee;
        public Bill_Home(Table table, Employee employee)
        {
            InitializeComponent();
            this.table = table;
            currentEmployee = employee;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Bill_Home_Load(object sender, EventArgs e)
        {
            //hide all other panels and buttons
            pnl_Summary.Hide();
            card_grp.Hide();
            pnl_payment.Hide();
            pnl_comment.Hide();
            pnl_paymentComplete.Hide();
            complete_btn.Hide();

            try
            {
                //Get bill data from database - from table with running order
                order = order_Service.GetOrderByTableID(table.TableID);
                bill = new Bill(order.BillID);

                //calculate total prices and taxes
                bill_Service.CalculateTax(order.orderItems, bill);

                //fill out bill information
                DisplayBillInformation(order, bill);

                //fill all ordered items in the bill
                FillOrderItems(order.orderItems);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error", MessageBoxButtons.OK);
                Close();
            }
        }
        private void DisplayBillInformation(Order order, Bill bill)
        {
            lbl_billID.Text = order.BillID.ToString();
            lbl_orderID.Text = order.OrderID.ToString();
            lbl_tableID.Text = order.Table.TableID.ToString();
            lbl_emID.Text = currentEmployee.EmployeeID.ToString();
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
                list.SubItems.Add((item.MenuItem.Price * item.Quantity).ToString());
                listView_Items.Items.Add(list);
            }
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            pnl_Summary.Show();
            pnl_payment.Show();
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
            //hide all other panles
            card_grp.Hide();

            //show changes labels
            lbl_changes.Show();
            lbl_changesAmount.Show();
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
            //hide all other panels and labels
            card_grp.Hide();
            lbl_changes.Hide();
            lbl_changesAmount.Hide();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void card_rb_CheckedChanged(object sender, EventArgs e)
        {
            //hide all other panels and labels
            lbl_changes.Hide();
            lbl_changesAmount.Hide();

            card_grp.Show();
        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            if (Pin_rb.Checked == true)
                PinPayment(bill);
            else if (card_rb.Checked == true)
                CardPayment(bill);
            else if (cash_rb.Checked == true)
                CashPayment(bill);

            if (txt_tips.Text != null)
            {
                bill.Tip = double.Parse(txt_tips.Text);
            }
            else
            {
                bill.Tip = 0;
            }

            //if there is no comment received from the customer, the comment is set to "none"
            if (order.Comment == "")
                order.Comment = "none";

            //store data to the database and update order and table status
            bill_Service.EditBill(bill, order);

            pnl_paymentComplete.Show();
        }

        private void btn_add_comment_Click(object sender, EventArgs e)
        {
            pnl_comment.Show();
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
        private void backToTbView_btn_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            bill.AmountPaid = double.Parse(txt_received.Text);
            lbl_changesAmount.Text = (bill.AmountPaid - bill.Total).ToString("0.00") + " €";

            lbl_amountPaid.Text = txt_received.Text + " €";
            lbl_layout_changesAmount.Text = (bill.AmountPaid - bill.Total).ToString("0.00") + " €";
        }
        private void CloseForm()
        {
            //close this bill form
            Close();

            //generate new table view window with the updated table status
            TableView tableView = new TableView(currentEmployee);
            tableView.Show();
        }
        private void lbl_layout_changesAmount_Click(object sender, EventArgs e)
        {

        }

        private void lbl_totalNoVAT_Click(object sender, EventArgs e)
        {

        }

        private void lbl_VAT_Click(object sender, EventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void lbl_amountPaid_Click(object sender, EventArgs e)
        {

        }
    }
}
