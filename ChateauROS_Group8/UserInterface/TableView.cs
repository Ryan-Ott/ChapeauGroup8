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
using DAL;

namespace UserInterface
{
    public partial class TableView : Form
    {
        //Table currentTable;
        static TableView tableView;
        private Table_Service table_Service = new Table_Service();
        Table currentTable;

        private TableView()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void table2_Click(object sender, EventArgs e)
        {
            //This is the code from last meeting
            currentTable.TableID = 2;
            ChangeTableState();
            TableState state = TableState.available;
            if (state == TableState.reserved)
            {
                table2.BackColor = Color.DarkRed;
            }
            else if (state == TableState.occupied)
            {
                table2.BackColor = Color.LightGoldenrodYellow;
            }
            else
            {
                table2.BackColor = Color.Green;
            }
        }

        private void ChangeTableState()
        {
            //this too
            DialogResult dialogResult = MessageBox.Show("sjdvjsd", "shdhsd", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                currentTable.TableState = TableState.available;
            }
        }

        // labelName.BackColor = Color.Blue
        private void table3_Click(object sender, EventArgs e)
        {

        }

        private void table4_Click(object sender, EventArgs e)
        {

        }

        private void table5_Click(object sender, EventArgs e)
        {

        }

        private void table6_Click(object sender, EventArgs e)
        {

        }

        private void table7_Click(object sender, EventArgs e)
        {

        }

        private void table8_Click(object sender, EventArgs e)
        {

        }

        private void table10_Click(object sender, EventArgs e)
        {

        }
    }
}
