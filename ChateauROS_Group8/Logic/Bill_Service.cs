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
        private OrderAndOrderItem_DAO orderAndOrderItem_DAO = new OrderAndOrderItem_DAO();

        public void AddNewBill(Bill bill)
        {
            try
            {
                bill_DAO.DB_AddNewBill(bill);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void EditBill(Bill bill,Order order)
        {
            try
            {
                bill_DAO.DB_EditBill(bill);

                order.Completed = true;
                order.Table.TableState = TableState.available;
                orderAndOrderItem_DAO.DB_EditOrder(order);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void CalculateTax(List<OrderItem> items, Bill bill)
        {
            double total = 0;
            double al_total = 0;

            foreach (OrderItem item in items)
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
        }

        public Bill GetLastBill()
        {
            try
            {
                return bill_DAO.DB_GetLastBill();
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not retrieve last bill " + e.Message);
                return new Bill(0);
            }
        }

        //public object GetLastIdentity()
        //{
        //    try
        //    {
        //        return bill_DAO.DB_GetLastIdentity();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Could not retrieve scope identity. Possibly none exists: " + e.Message);
        //        return 0;
        //    }
        //}
    }
}
