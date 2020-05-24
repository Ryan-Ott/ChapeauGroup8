using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace Logic
{
    public class OrderAndOrderItem_Service
    {
        private OrderAndOrderItem_DAO orderAndOrderItemDAO = new OrderAndOrderItem_DAO();
        public List<OrderItem> GetOrderItems()
        {
            try
            {
                return orderAndOrderItemDAO.DB_GetOrderItems();
            }
            catch (Exception)
            {
                List<OrderItem> items = new List<OrderItem>();
                OrderItem orderItem1 = new OrderItem(0, 0, new MenuItem(0, 0, "Test", 0.00, 0, false), 0, "none", "Not Ready", DateTime.Now);
                OrderItem orderItem2 = new OrderItem(0, 0, new MenuItem(0, 0, "Test2", 0.00, 0, true), 0, "none", "Not Ready", DateTime.Now);

                items.Add(orderItem1);
                items.Add(orderItem2);

                return items;
            }

        }

        public List<OrderItem> GetAllOrderItems(int id)
        {
            try
            {
                return orderAndOrderItemDAO.DB_GetAllOrderItems(id);
            }
            catch(Exception)
            {
                List<OrderItem> items = new List<OrderItem>();
                OrderItem orderItem1 = new OrderItem(0, 0, new MenuItem(0, 0, "Test", 0.00, 0, false), 0, "none", "Not Ready", DateTime.Now);
                OrderItem orderItem2 = new OrderItem(0, 0, new MenuItem(0, 0, "Test2", 0.00, 0, true), 0, "none", "Not Ready", DateTime.Now);

                items.Add(orderItem1);
                items.Add(orderItem2);

                return items;
            }

        }

        public OrderItem GetOrderItemByID(int id)
        {
            try
            {
                return orderAndOrderItemDAO.DB_GetOrderItemByID(id);
            }
            catch (Exception)
            {
                OrderItem orderItem = new OrderItem(0, 0, new MenuItem(0, 0, "Test", 0.00, 0, false), 0, "none", "Not Ready", DateTime.Now);

                return orderItem;
            }
        }
        public Order GetOrderByTableID(int tableID)
        {
            try
            {
                return orderAndOrderItemDAO.DB_GetOrderByTableID(tableID);
            }
            catch (Exception)
            {
                Order order = new Order(1, new Table(1, TableState.occupied),1, new Employee(1, "waiter", "Peter", "1234"), true, "none");

                return order;
            }
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            try
            {
                orderAndOrderItemDAO.DB_AddOrderItem(orderItem);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failure to add orderItem to db. Error: {e.Message}");
                throw;
            }
        }

        public void AddOrder(Order order)
        {
            try
            {
                orderAndOrderItemDAO.DB_AddOrder(order);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failure to add order to db. Error: {e.Message}");
                throw;
            }
        }

        public void EditOrder(Order order)
        {
            try
            {
                orderAndOrderItemDAO.DB_EditOrder(order);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failure to edit order with orderID {order.OrderID}. Error: {e.Message}");
                throw;
            }
        }

        public void DeleteOrder(Order order)
        {
            try
            {
                orderAndOrderItemDAO.DB_DeleteOrder(order);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failure to delete order with orderID {order.OrderID}. Error: {e.Message}");
                throw;
            }
        }
    }
}
