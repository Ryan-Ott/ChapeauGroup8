using Logic;
using Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UserInterface;

namespace UserInterface
{
    public partial class LoginForm : Form
    {
        Employee_Service employeeService = new Employee_Service();
        Employee currentEmployee;

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
       
           
            HomeScreen home = new HomeScreen();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUser.Text;
            password = txtPass.Text;
            currentEmployee = employeeService.GetByUsername(username);

            if (username == currentEmployee.Username && password == currentEmployee.Password)
            {
                MessageBox.Show("Welcome " + currentEmployee.Username);
                Close();
                HomeScreen homeScreen = new HomeScreen(currentEmployee);
                homeScreen.ShowDialog();
            }
            else
                MessageBox.Show("Failure to verify, please check username or password.");
        }
    }
}
