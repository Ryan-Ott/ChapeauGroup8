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
    public partial class Order_Home : Form, IObserver
    {
        OrderAndOrderItem_Service orderService = new OrderAndOrderItem_Service();
        Menu_Service menuService = new Menu_Service();
        Category_Service categoryService = new Category_Service();
        MenuItem_Service menuItemService = new MenuItem_Service();
        Table_Service tableService = new Table_Service();
        Employee_Service employeeService = new Employee_Service();
        Bill_Service billService = new Bill_Service();

        ISubject subject;

        Order currentOrder;

        static Order_Home order_Home;

        private Order_Home(ISubject subject)
        {
            InitializeComponent();
            InitNewOrderProcess();
            subject.AddObserver(this);
            //pass on employee obj
        }

        public static Order_Home GetInstance(ISubject subject)
        {
            if (order_Home == null)
                order_Home = new Order_Home(subject);
            return order_Home;
        }

        private void Order_Home_Load(object sender, EventArgs e)
        {
            ReloadForm();
        }

        private void ReloadForm()
        {
            DisplayCurrentOrder();
            //DisplayComment();
        }

        private void InitNewOrderProcess()
        {
            currentOrder = new Order();

            //billService.AddNewBill(new Bill(0));
            //Bill currentBill = billService.GetLastBill();
            //Employee employee = employeeService.GetByID(3);
            //orderService.AddOrder(new Order(currentBill, employee));
            //currentOrder = orderService.GetLastOrder();
        }

        private void DisplayComment()
        {
            ListViewItem selectedItem = liv_CurrentOrder.SelectedItems[0];

            if (selectedItem == null)
                selectedItem = liv_CurrentOrder.Items[0];

            string menuItemName = selectedItem.SubItems[0].Text;
            Models.MenuItem selectedMenuItem = menuItemService.GetMenuItemByName(menuItemName);

            OrderItem selectedOrderItem = new OrderItem();
            foreach (OrderItem orderItem in currentOrder.orderItems) //eeeeh not sure yet
            {
                if (orderItem.MenuItem == selectedMenuItem)
                {

                }
            }
            txtb_Requests.Text = selectedOrderItem.Requests;
        }

        private void DisplayCurrentOrder()
        {
            liv_CurrentOrder.Columns.Clear();
            liv_CurrentOrder.Items.Clear();
            liv_CurrentOrder.Columns.Add("Item", 150);
            liv_CurrentOrder.Columns.Add("Count", 48);

            try
            {
                foreach (OrderItem orderItem in currentOrder.orderItems)
                {
                    ListViewItem li = new ListViewItem(orderItem.MenuItem.Name);
                    li.SubItems.Add(orderItem.Quantity.ToString());
                    liv_CurrentOrder.Items.Add(li);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btn_Menus_Click(object sender, EventArgs e)
        {
            if (nud_TableID.Value == 0)
            {
                MessageBox.Show("Please select a table for which you wish to take an order.");
                return;
            }
            currentOrder.Table = tableService.GetByID((int)nud_TableID.Value);

            //orderService.EditOrder(currentOrder);
            //currentOrder = orderService.GetLastOrder();

            Hide();
            Order_MenuSelect menuSelect = Order_MenuSelect.GetInstance(currentOrder);
            menuSelect.Closed += (s, args) => Close();
            menuSelect.Show(); 
        }

        private void liv_CurrentOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnl_OrderHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            //reset currentOrder (reload the form)
            //foreach ordered menuItem reduce stock by count
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddComment_Click(object sender, EventArgs e)
        {
            if (txtb_Requests.TextLength == 0)
            {
                MessageBox.Show("Please first enter a comment.");
                return;
            }

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {

        }

        public void Update(Order currentOrder)
        {
            this.currentOrder = currentOrder;
            ReloadForm(); 
        }
    }
}
