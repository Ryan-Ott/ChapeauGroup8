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

            bill.Tax6 = 0.06 * total;
            bill.Tax21 = 0.21 * al_total;
            bill.Total = total + al_total + bill.Tax6 + bill.Tax21;

            return new Bill();

        }
    }
}
