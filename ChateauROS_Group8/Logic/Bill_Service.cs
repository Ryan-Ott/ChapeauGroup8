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

        //public void AddToBill(Bill bill)
        //{
        //    return bill_DAO.AddToBill(bill);
        //
        public Bill CalculateTax(List<OrderItem> items,Bill bill)
        {
            double total = 0;
            double al_total = 0;

            foreach(OrderItem item in items)
            {
                if (item.MenuItem.Alcoholic == false)
                {
                    total += item.MenuItem.Price;
                }
                else
                {
                    al_total += item.MenuItem.Price;
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
    }
}
