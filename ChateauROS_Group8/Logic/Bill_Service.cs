using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace Logic
{
    public class Bill_Service
    {
        private Bill_DAO bill_DAO = new Bill_DAO();

        public List<MenuItem> GetAllItems()
        {
            return bill_DAO.GetAllItems();
        }

        public Order GetByID(int tableId)
        {
            return bill_DAO.GetById(tableId);
        }
        public void AddToBill(Bill bill)
        {
            return bill_DAO.AddToBill(bill);
        }
    }
}
