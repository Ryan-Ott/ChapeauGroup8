using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class LoginfForm : Form
    {
        public LoginfForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("@Data Source=den1.mssql8.gear.host;Initial Catalog=dbchapeau08;Persist Security Info=True;User ID=dbchapeau08;Password=***********");
            string query = "Select * from TABLE Employees where username = '" + userBox.Text.Trim() + "'and password = '" + passBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dbtbl = new DataTable();
            sda.Fill(dbtbl);
            if (dbtbl.Rows.Count == 1)
            {
                Main main = new Main();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("User name or password incorrect");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
