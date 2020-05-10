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
        public Bill_Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bill_Home_Load(object sender, EventArgs e)
        {
            //set all total price and vat to 0
            double total = 0;
            double al_total = 0;
            double tax6 = 0;
            double tax21 = 0;

            //Get bill data from database
            Bill_Service bill_Service = new Bill_Service();
            Order order = bill_Service.GetByID(1);

            //fill out bill information
            lbl_billID.Text = order.BillID.ToString();
            lbl_orderID.Text = order.OrderID.ToString();
            lbl_tableID.Text = order.TableID.ToString();
            lbl_emID.Text = order.EmployeeID.ToString();
            lbl_Date.Text = DateTime.Now.ToString();

            //Get all items of each order to fill in the list view
            List<Models.MenuItem> items = bill_Service.GetAllItems();

            //clear items before filling the list
            listView_Items.Items.Clear();

            //filling the list view wih each item
            foreach (Models.MenuItem item in items)
            {
                ListViewItem list = new ListViewItem(item.MenuItemID.ToString());
                list.SubItems.Add(item.DishName);
                list.SubItems.Add(item.Price.ToString());
                listView_Items.Items.Add(list);

                //adding price of each item to total price
                if (item.Alcoholic == false)
                {
                    total += item.Price; 
                }
                else
                {
                    al_total += item.Price;
                }

            }

            //fill out the summary of the order
            lbl_totalNoVAT.Text = (total + al_total).ToString();
            tax6 = 0.06 * total;
            tax21 = 0.21 * al_total;
            lbl_VAT.Text = (tax6 + tax21).ToString();
            lbl_total.Text = (total + al_total + tax6 + tax21).ToString();

        }
    }
}
