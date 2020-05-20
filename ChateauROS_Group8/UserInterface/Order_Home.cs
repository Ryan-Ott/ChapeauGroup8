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
    public partial class Order_Home : Form
    {
        Menu_Service menu_Service = new Menu_Service();
        Category_Service category_Service = new Category_Service();
        MenuItem_Service menuItem_Service = new MenuItem_Service();

        public Order_Home()
        {
            InitializeComponent();
        }

        private void Order_Home_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Menus_Click(object sender, EventArgs e)
        {

        }
    }
}
