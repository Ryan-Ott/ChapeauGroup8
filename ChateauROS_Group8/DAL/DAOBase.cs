using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DAL
{
    public abstract class DAOBase
    {
        //private SqlDataAdapter adapter;
        private SqlConnection connection;

        public DAOBase()
        {
            //adapter = new SqlDataAdapter();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString);
        }

        protected SqlConnection OpenConnection()
        {
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
                connection.Open();
            return connection;
        }

        protected void CloseConnection()
        {
            connection.Close();
        }

        //protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
        //{
        //    SqlCommand command = new SqlCommand;
        //    try
        //    {
        //        command.Connection = OpenConnection();
        //        command.CommandText = query;
        //        command.Parameters.AddRange(sqlParameters); //find out what this actually does!
        //        adapter.InsertCommand = command;
        //        command.ExecuteNonQuery();
        //    }
        //    catch (SqlException e)
        //    {
        //        MessageBox.Show(e.Message);
        //        throw;
        //    }
        //    finally
        //    {
        //        CloseConnection();
        //    }
        //}
    }
}
