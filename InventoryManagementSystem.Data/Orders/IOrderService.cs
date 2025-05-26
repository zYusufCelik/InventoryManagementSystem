using InventoryManagementSystem.Core.Entities;

namespace InventoryManagementSystem.Data.Orders
{
    public interface IOrderService
    {
        void CreateOrder(Order order);
        Order GetOrderById(int orderId);
        List<Order> GetAllOrders();
        void UpdateOrder(Order order);
        void DeleteOrder(int orderId);
        
    }

}
