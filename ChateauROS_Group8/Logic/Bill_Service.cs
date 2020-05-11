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
            try
            {
                return bill_DAO.DB_GetAllItems();
            }
            catch
            {
                //add a fake menu item to the list in case database connection is not working;
                List<MenuItem> items = new List<MenuItem>();
                MenuItem item1 = new MenuItem(1, 1, "Test", 0.00, 0, false);
                MenuItem item2 = new MenuItem(2, 2, "Test2", 0.00, 0, true);
                items.Add(item1);
                items.Add(item2);
                return items;
            }
        }

        public Order GetByID(int tableId)
        {
            try
            {
                return bill_DAO.DB_GetOrderById(tableId);
            }
            catch
            {
                //return fake order information in case database connection is not working;
                return new Order(1, new Table(1, "available"), 001, new Employee(1, "waiter", "username", "password"), true, "none");
            }
        }
        //public void AddToBill(Bill bill)
        //{
        //    return bill_DAO.AddToBill(bill);
        //
    }
}
