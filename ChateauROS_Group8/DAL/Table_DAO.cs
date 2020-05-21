using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class Table_DAO : DAOBase
    {
        //Getting all employees' information
        public List<Table> DB_GetAllTables()
        {
            OpenConnection();
            SqlCommand queryGetAll = new SqlCommand("SELECT tableID, tableState FROM [Tables]", connection);
            SqlDataReader reader = queryGetAll.ExecuteReader();
            List<Table> tables = new List<Table>();
            while (reader.Read())
            {
                Table table = ReadTable(reader);
                tables.Add(table);
            }
            reader.Close();
            CloseConnection();
            return tables;
        }
        //Getiing an employee information corresponding to a specific id
        public Table DB_GetTableByID(int id)
        {
            OpenConnection();
            SqlCommand queryGetByID = new SqlCommand("SELECT tableID, tableState FROM [Tables] WHERE tableID = @id", connection);
            queryGetByID.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = queryGetByID.ExecuteReader();
            Table table = null;
            if (reader.Read())
            {
                table = ReadTable(reader);
            }
            reader.Close();
            CloseConnection();
            return table;
        }

        private Table ReadTable (SqlDataReader reader)
        {
            int tableId = (int)reader["tableID"];
            int tableState = (int)reader["tableState"];

            return new Table(tableId, (TableState)tableState);
        }
    }
}


