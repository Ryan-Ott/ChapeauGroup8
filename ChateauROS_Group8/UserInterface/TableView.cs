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
        // make single object for table state 
        
        Table_Service table_Service = new Table_Service();
        Table currentTable;

        
        public TableView()
        {
            InitializeComponent();
            currentTable = new Table();
        }

        private void ChangeTableState(int tableID, Label tableLabel)
        {
            CustomDialogBoxforTableView dialogResult = new CustomDialogBoxforTableView();
            currentTable.TableID = tableID;
            dialogResult.ShowDialog();
            //DialogResult dialogResult = MessageBox.Show("Reserve table", "Occupy table", MessageBoxButtons.YesNoCancel);
            if (dialogResult.DialogResult.Equals(DialogResult.No))
            {
                tableLabel.BackColor = Color.Red;
                currentTable.TableState = TableState.occupied;
            }
            else if (dialogResult.DialogResult.Equals(DialogResult.Yes))
            {
                tableLabel.BackColor = Color.Yellow;
                currentTable.TableState = TableState.reserved;
            }
            else if (dialogResult.DialogResult.Equals(DialogResult.Cancel))
            {
                tableLabel.BackColor = Color.Green;
                currentTable.TableState = TableState.available;
            }
            try
            {
                table_Service.EditTable(currentTable);
                MessageBox.Show("Successfully changed table state.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to change table state " + e.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close(); //go back to homescreen once built
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ChangeTableState(1, table1);
        }

        private void table2_Click(object sender, EventArgs e)
        {
            ChangeTableState(2, table2);
        }

        private void table3_Click(object sender, EventArgs e)
        {
            ChangeTableState(3, table3);
        }

        private void table4_Click(object sender, EventArgs e)
        {
            ChangeTableState(4, table4);
        }

        private void table5_Click(object sender, EventArgs e)
        {
            ChangeTableState(5, table5);
        }

        private void table6_Click(object sender, EventArgs e)
        {
            ChangeTableState(6, table6);
        }

        private void table7_Click(object sender, EventArgs e)
        {
            ChangeTableState(7, table7);
        }

        private void table8_Click(object sender, EventArgs e)
        {
            ChangeTableState(8, table8);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ChangeTableState(9, table9);
        }

        private void table10_Click(object sender, EventArgs e)
        {
            ChangeTableState(10, table10);
        }
    }
}
