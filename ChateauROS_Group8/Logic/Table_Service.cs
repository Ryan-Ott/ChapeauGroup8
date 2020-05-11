using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace Logic
{
    public class Table_Service
    {
        private Table_DAO tab_DAO = new Table_DAO();
        public List<Table> GetAllTables()
        {
            try
            {
                return tab_DAO.DB_GetAllTables();
            }
            catch
            {
                //add fake tables to the list in case database connection is not working;
                List<Table> tables = new List<Table>();
                Table tab1 = new Table(1, "free");
                Table tab2 = new Table(2, "free");
                tables.Add(tab1);
                tables.Add(tab2);
                return tables;
            }
        }

        public Table GetByID(int id)
        {
            try
            {
                return tab_DAO.DB_GetTableByID(id);
            }
            catch
            {
                //return a fake table information in case database connection is not working;
                return new Table(1, "free");
            }
        }
    }
}
