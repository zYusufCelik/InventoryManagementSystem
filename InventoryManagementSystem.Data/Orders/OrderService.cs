using InventoryManagementSystem.Core.Entities;

namespace InventoryManagementSystem.Data.Orders
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _context; 

        public void CreateOrder(Order order)
        {
            _context.Add(order);
            _context.SaveChanges();
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders.Find(orderId);
        }


        public List<Order> GetAllOrders()
        {
            if (_context == null)
            {
                throw new NullReferenceException("Database context (_context) is null.");
            }

            return _context.Orders.ToList();
        }




        public void UpdateOrder(Order order)
        {
            var existingOrder = GetOrderById(order.Id);
            if (existingOrder != null)
            {
               
                existingOrder.OrderDate = order.OrderDate;
                
            }
        }

        public void DeleteOrder(int orderId)
        {
            var order = GetOrderById(orderId);
            if (order != null)
            {
                _context.Remove(order);
                _context.SaveChanges();
            }
        }

       
    }
}
