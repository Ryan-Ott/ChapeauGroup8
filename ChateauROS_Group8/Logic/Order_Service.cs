using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace Logic
{
    public class MenuItem_Service
    {
        private Order_DAO orderDAO = new Order_DAO();

        public List<Order> GetAllOrders()
        {
            return orderDAO.DB_GetAllOrders();
        }

        public Order GetOrderByID(int orderID)
        {
            return orderDAO.DB_GetOrderByID(orderID);
        }
    }
}
