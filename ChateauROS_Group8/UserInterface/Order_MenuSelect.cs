using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Order_MenuSelect : Form
    {
        public Order_MenuSelect()
        {
            InitializeComponent();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            Hide();
            Order_Home orderHome = Order_Home.GetInstance();
            orderHome.Closed += (s, args) => Close();
            orderHome.Show();
        }
    }
}
