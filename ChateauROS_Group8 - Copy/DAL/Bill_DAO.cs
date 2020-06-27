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
        //storing bill information to Bills table in the database
        public void DB_AddNewBill(Bill bill)
        {
            OpenConnection();
            SqlCommand queryAddBill = new SqlCommand("INSERT INTO [dbo].[Bills] ([paymentMethod], [6tax], [21tax], [tip], [total], [AmountPaid]) VALUES (@paymentMethod, @6tax, @21tax, @tip, @total, @paid);", connection);
            queryAddBill.Parameters.AddWithValue("@paymentMethod", bill.PaymentMethod);
            queryAddBill.Parameters.AddWithValue("@6tax", bill.Tax6);
            queryAddBill.Parameters.AddWithValue("@21tax", bill.Tax21);
            queryAddBill.Parameters.AddWithValue("@tip", bill.Tip);
            queryAddBill.Parameters.AddWithValue("@total", bill.Total);
            queryAddBill.Parameters.AddWithValue("@paid", bill.AmountPaid);
            queryAddBill.ExecuteNonQuery();
            CloseConnection();
        }

        public void DB_EditBill(Bill bill)
        {
            OpenConnection();
            SqlCommand queryEditBill = new SqlCommand("UPDATE [Bills] SET [paymentMethod] = @paymentMethod, [6tax] = @6tax, [21tax] = @21tax, [tip] = @tip, [total] = @total, [amountPaid] = @paid WHERE [billID] = @billID;", connection);
            queryEditBill.Parameters.AddWithValue("@paymentMethod", bill.PaymentMethod);
            queryEditBill.Parameters.AddWithValue("@6tax", bill.Tax6);
            queryEditBill.Parameters.AddWithValue("@21tax", bill.Tax21);
            queryEditBill.Parameters.AddWithValue("@tip", bill.Tip);
            queryEditBill.Parameters.AddWithValue("@total", bill.Total);
            queryEditBill.Parameters.AddWithValue("@billID", bill.BillID);
            queryEditBill.Parameters.AddWithValue("@paid", bill.AmountPaid);
            queryEditBill.ExecuteNonQuery();
            CloseConnection();
        }

        public Bill DB_GetLastBill()
        {
            OpenConnection();
            SqlCommand queryMaxBillID = new SqlCommand("SELECT TOP 1 * FROM [Bills] ORDER BY [billID] DESC;", connection);
            SqlDataReader reader = queryMaxBillID.ExecuteReader();
            Bill bill = null;
            if (reader.Read())
            {
                bill = ReadBill(reader);
            }
            reader.Close();
            CloseConnection();
            return bill;
        }

        private Bill ReadBill(SqlDataReader reader)
        {
            int billID = (int)reader["billID"];
            int paymentMethod = (int)reader["paymentMethod"];
            double tax6 = (double)reader["6tax"];
            double tax21 = (double)reader["21tax"];
            double tip = (double)reader["tip"];
            double total = (double)reader["total"];
            double paid = (double)reader["AmountPaid"];

            return new Bill(billID, (PaymentMethod)paymentMethod, tax6, tax21, tip, total, paid);
        }
    }
}
