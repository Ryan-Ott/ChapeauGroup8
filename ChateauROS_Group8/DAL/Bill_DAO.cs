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
        public void AddToBill(Bill bill)
        {
            string query = "INSERT INTO Bills VALUES (" + bill.BillID + ",'" + bill.PaymentMethod + "'," + bill.Tax6 + "," + bill.Tax21 + "," + bill.Tip + "," + bill.Total + "); ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_AddNewBill(Bill bill)
        {
            OpenConnection();
            SqlCommand queryAddBill = new SqlCommand("INSERT INTO [dbo].[Bills] ([paymentMethod], [6tax], [21tax], [tip], [total]) VALUES (@paymentMethod, @6tax, @21tax, @tip, @total); SELECT SCOPE_IDENTITY();", connection);
            queryAddBill.Parameters.AddWithValue("@paymentMethod", bill.PaymentMethod);
            queryAddBill.Parameters.AddWithValue("@6tax", bill.Tax6);
            queryAddBill.Parameters.AddWithValue("@21tax", bill.Tax21);
            queryAddBill.Parameters.AddWithValue("@tip", bill.Tip);
            queryAddBill.Parameters.AddWithValue("@total", bill.Total);
            queryAddBill.ExecuteNonQuery();
            CloseConnection();
        }

        public void DB_EditBill(Bill bill)
        {
            OpenConnection();
            SqlCommand queryEditBill = new SqlCommand("UPDATE [Bills] SET [paymentMethod] = @paymentMethod, [6tax] = @6tax, [21tax] = @21tax, [tip] = @tip, [total] = @total WHERE [billID] = @billID", connection);
            queryEditBill.Parameters.AddWithValue("@paymentMethod", bill.PaymentMethod);
            queryEditBill.Parameters.AddWithValue("@6tax", bill.Tax6);
            queryEditBill.Parameters.AddWithValue("@21tax", bill.Tax21);
            queryEditBill.Parameters.AddWithValue("@tip", bill.Tip);
            queryEditBill.Parameters.AddWithValue("@total", bill.Total);
            queryEditBill.Parameters.AddWithValue("@billID", bill.BillID);
            queryEditBill.ExecuteNonQuery();
            CloseConnection();
        }

        //public object DB_GetLastIdentity()
        //{
        //    OpenConnection();
        //    SqlCommand scopeIdentity = new SqlCommand("SELECT SCOPE_IDENTITY();", connection);
        //    object lastID = scopeIdentity.ExecuteScalar();
        //    CloseConnection();
        //    return lastID;
        //}
    }
}
