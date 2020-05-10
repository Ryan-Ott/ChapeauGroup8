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
        public List<Order> Db_Get_All_Orders()
        {
            OpenConnection();
            SqlCommand queryGetAll = new SqlCommand("SELECT orderID, taleID, billID, employeeID FROM Orders;", dbConnection);
            SqlDataReader reader = queryGetAll.ExecuteReader();
            List<Order> orders = new List<Order>();

            while (reader.Read())
            {
                Order order = ReadOrder(reader);
                orders.Add(order);
            }
            reader.Close();
            CloseConnection();

            return orders;
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
        public void AddToBill(Bill bill)
        {
            string query = "INSERT INTO Bills VALUES (" + bill.BillID + ",'" + bill.PaymentMethod + "'," + bill.Tax6 + "," + bill.Tax21 + "," + drink.VAT + "," + bill.Tip + "," + bill.Total + "); ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
