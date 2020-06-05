using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //private void loginBtn_Click(object sender, EventArgs e)
        //{
        //    SqlConnection sqlcon = new SqlConnection("@Data Source=den1.mssql8.gear.host;Initial Catalog=dbchapeau08;Persist Security Info=True;User ID=dbchapeau08;Password=***********");
        //    string query = "Select * from TABLE Employees where username = '" + userBox.Text.Trim() + "'and password = '" + passBox.Text.Trim() + "'";
        //    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
        //    DataTable dbtbl = new DataTable();
        //    sda.Fill(dbtbl);
        //    if (dbtbl.Rows.Count == 1)
        //    {
        //        Main main = new Main();
        //        this.Hide();
        //        main.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("User name or password incorrect");
        //    }
        //}

        private void exitButton_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtUser.Text;
            pass = txtPass.Text;
            if (user == "testmanager" && pass == "password")
            {
                MessageBox.Show("Succesfully logged in");
            }
            else
                MessageBox.Show("Error, check username or password.");
        }
    }
}
