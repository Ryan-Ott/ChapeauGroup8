using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace Logic
{
    public class OrderItem_Service
    {
        private OrderItem_DAO orderItemDAO = new OrderItem_DAO();

        public List<OrderItem> GetAllOrderItems(int id)
        {
            try
            {
                return orderItemDAO.DB_GetAllOrderItems(id);
            }
            catch(Exception)
            {
                List<OrderItem> items = new List<OrderItem>();
                OrderItem orderItem1 = new OrderItem(0, 0, new MenuItem(0, 0, "Test", 0.00, 0, false), 0, "none", "Not Ready", TimeSpan.Zero);
                OrderItem orderItem2 = new OrderItem(0, 0, new MenuItem(0, 0, "Test2", 0.00, 0, true), 0, "none", "Not Ready", TimeSpan.Zero);

                items.Add(orderItem1);
                items.Add(orderItem2);

                return items;
            }

        }

        public OrderItem GetOrderItemByID(int id)
        {
            try
            {
                return orderItemDAO.DB_GetOrderItemByID(id);
            }
            catch (Exception)
            {
                OrderItem orderItem = new OrderItem(0, 0, new MenuItem(0, 0, "Test", 0.00, 0, false), 0, "none", "Not Ready", TimeSpan.Zero);

                return orderItem;
            }
        }
        public Order GetOrderByTableID(int tableID)
        {
            try
            {
                return orderItemDAO.DB_GetOrderByTableID(tableID);
            }
            catch (Exception)
            {
                Order order = new Order(1, new Table(1, "occupied"),1, new Employee(1, "waiter", "Peter", "1234"), true, "none");

                return order;
            }
        }
    }
}
