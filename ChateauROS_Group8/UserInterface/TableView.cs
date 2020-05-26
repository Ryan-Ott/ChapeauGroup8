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
    public partial class Form1 : Form
    {
        Table_Service table_Service = new Table_Service();
        List<Models.Table> table = table_Service.GetAllTables();


        public Form1()
        {
            InitializeComponent();
           
        }

      

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void table1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void table2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void table3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void table4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


        private void table5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // if statement 
            table5.BackColor = Color.AntiqueWhite;
        }
        private void table6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void table7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void table8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void table9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void table10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
