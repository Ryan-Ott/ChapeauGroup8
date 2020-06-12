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
        Table_Service table_Service = new Table_Service();

        Table table;
        Employee employee;
        TableView tableView;
        
        public TableView(Employee employee)
        {
            //table_Service.GetAllTables();
            InitializeComponent();

            table = new Table();
            this.employee = employee;
            IntializeTable();
        }

        private void IntializeTable()
        {
            List<Label> tableLabelList = new List<Label>
            {
                table1, table2, table3, table4, table5, table6, table7, table8, table9, table10
            };

            List<Table> tables = table_Service.GetAllTables();
            for (int i = 0; i < tables.Count; i++)
                switch (tables[i].TableState)
                {
                    case TableState.available:
                        tableLabelList[i].BackColor = Color.Green;
                        break;
                    case TableState.occupied:
                        tableLabelList[i].BackColor = Color.Red;
                        break;
                    case TableState.reserved:
                        tableLabelList[i].BackColor = Color.Yellow;
                        break;
                }
        }

        private void ChangeTableState(int tableID, Label tableLabel)
        {
            Hide();
            CustomDialogBoxforTableView dialogResult = new CustomDialogBoxforTableView(table, employee, this);
            table.TableID = tableID;
            dialogResult.ShowDialog();
            if (dialogResult.DialogResult.Equals(DialogResult.No))
            {
                tableLabel.BackColor = Color.Red;
                table.TableState = TableState.occupied;
            }
            else if (dialogResult.DialogResult.Equals(DialogResult.Yes))
            {
                
                tableLabel.BackColor = Color.Yellow;
                table.TableState = TableState.reserved;
            }
            else if (dialogResult.DialogResult.Equals(DialogResult.OK))
            {
                tableLabel.BackColor = Color.Green;
                table.TableState = TableState.available;
            }
            try
            {
                table_Service.EditTable(table);
                //Show();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to change table state " + e.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Hide();
            HomeScreen homeScreen = new HomeScreen(employee);
            homeScreen.ShowDialog();
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
            if (table.TableState != TableState.occupied)
            {
                ChangeTableState(4, table4);
            }
            else
            {
                this.Hide();
                CustomDialogBoxforTableView dialogResult = new CustomDialogBoxforTableView(table, employee, this);
                dialogResult.ShowDialog();
            }
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

        private void TableView_FormClosing(object sender, FormClosingEventArgs e)
        {
            exitButton_Click(sender, e);
        }

        private void TableView_Load_1(object sender, EventArgs e)
        {

            //table = new Table();

            // List<Table> tables = table_Service.GetAllTables();
            table_Service.GetAllTables();
            
            
            
           
        }

       
    }
}
