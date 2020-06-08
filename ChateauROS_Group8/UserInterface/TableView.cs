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
            DialogResult dialogResult = MessageBox.Show("Reserve table", "Occupy table", MessageBoxButtons.YesNoCancel);
            currentTable.TableID = 2;
            if (dialogResult == DialogResult.Yes)
            {
                
                currentTable.TableState = TableState.occupied;
            }
            else if (dialogResult == DialogResult.No)
            {
                currentTable.TableState = TableState.reserved;
            }
            else
            {
                currentTable.TableState = TableState.available;
            }
            // call change table state method 
        }

        private void ChangeTableState(int tableID)
        {
            //this too
            currentTable.TableID = tableID;
            DialogResult dialogResult = MessageBox.Show("Reserve table", "Occupy table", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
               // object.BackColor = Color.Red();
                currentTable.TableState = TableState.occupied;
            }
            else if (dialogResult == DialogResult.No)
            {
                currentTable.TableState = TableState.reserved;
            }
            else
            {
                currentTable.TableState = TableState.available;
            }
        }

        // labelName.BackColor = Color.Blue
        private void table3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Reserve table", "Occupy table", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {

                currentTable.TableState = TableState.occupied;
            }
            else if (dialogResult == DialogResult.No)
            {
                currentTable.TableState = TableState.reserved;
            }
            else
            {
                currentTable.TableState = TableState.available;
            }
        }

        private void table4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Reserve table", "Occupy table", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {

                currentTable.TableState = TableState.occupied;
            }
            else if (dialogResult == DialogResult.No)
            {
                currentTable.TableState = TableState.reserved;
            }
            else
            {
                currentTable.TableState = TableState.available;
            }
        }

        private void table5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Reserve table", "Occupy table", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {

                currentTable.TableState = TableState.occupied;
            }
            else if (dialogResult == DialogResult.No)
            {
                currentTable.TableState = TableState.reserved;
            }
            else
            {
                currentTable.TableState = TableState.available;
            }
        }

        private void table6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Reserve table", "Occupy table", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {

                currentTable.TableState = TableState.occupied;
            }
            else if (dialogResult == DialogResult.No)
            {
                currentTable.TableState = TableState.reserved;
            }
            else
            {
                currentTable.TableState = TableState.available;
            }
        }

        private void table7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Reserve table", "Occupy table", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {

                currentTable.TableState = TableState.occupied;
            }
            else if (dialogResult == DialogResult.No)
            {
                currentTable.TableState = TableState.reserved;
            }
            else
            {
                currentTable.TableState = TableState.available;
            }
        }

        private void table8_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Reserve table", "Occupy table", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {

                currentTable.TableState = TableState.occupied;
            }
            else if (dialogResult == DialogResult.No)
            {
                currentTable.TableState = TableState.reserved;
            }
            else
            {
                currentTable.TableState = TableState.available;
            }
        }

        private void table10_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Reserve table", "Occupy table", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                table10.BackColor = Color.Red;
                currentTable.TableState = TableState.occupied;
            }
            else if (dialogResult == DialogResult.No)
            {
                table10.BackColor = Color.Yellow;
                currentTable.TableState = TableState.reserved;
            }
            else
            {
                table10.BackColor = Color.GreenYellow;
                currentTable.TableState = TableState.available;
            }
        }
    }
}
