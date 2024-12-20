using FragrantWorld.DatabaseContext;
using FragrantWorld.Interface;
using FragrantWorld.Mode1s;
using Microsoft.EntityFrameworkCore;

namespace FragrantWorld.Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _context;

        public OrderService(AppDbContext context)
        {
            _context = context;
        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders
                .Include(o => o.Client)
                .ToList();
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders
                .Include(o => o.Client)
                .FirstOrDefault(o => o.OrderId == orderId);
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }
    }
}
