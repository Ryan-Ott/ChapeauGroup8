using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class Bill_DAO : DAOBase
    {
        public List<MenuItem> GetAllItems()
        {
            string query = "SELECT MenuItems.menuItemID, MenuItems.dishName, MenuItems.price, MenuItems.alcoholic FROM Orders JOIN OrderItems ON OrderItems.orderID = [Orders].orderID JOIN MenuItems ON OrderItems.menuItemID = MenuItems.menuItemID;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Order GetById(int tableId)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("SELECT orderID, taleID, billID, employeeID, [completed], [comment] FROM Orders WHERE tableID = @tableId;", dbConnection);
            command.Parameters.AddWithValue("@tableId", tableId);
            SqlDataReader reader = command.ExecuteReader();
            Order order = null;

            if (reader.Read())
            {
                order = ReadOrder(reader);
            }

            reader.Close();
            CloseConnection();

            return order;
        }
        private Order ReadOrder(SqlDataReader reader)
        {
            int orderId = (int)reader["orderID"];
            int tableId = (int)reader["tableID"];
            int billId = (int)reader["billID"];
            int employeeID = (int)reader["employeeID"];
            bool completed = (bool)reader["completed"];
            string comment = (string)reader["comment"];

            return new Order(orderId, tableId, billId, employeeID, completed, comment);
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> items = new List<MenuItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem item = new MenuItem()
                {
                    MenuItemID = (int)dr["menuItemID"],
                    DishName = (string)dr["dishName"].ToString(),
                    Price = (int)dr["price"],
                    Alcoholic = (bool)dr["alcoholic"],
                };
                items.Add(item);
            }
            return items;
        }

        public void AddToBill(Bill bill)
        {
            string query = "INSERT INTO Bills VALUES (" + bill.BillID + ",'" + bill.PaymentMethod + "'," + bill.Tax6 + "," + bill.Tax21 + "," + drink.VAT + "," + bill.Tip + "," + bill.Total + "); ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
