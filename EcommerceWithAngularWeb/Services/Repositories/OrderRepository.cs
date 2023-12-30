using EcommerceWithAngularWeb.Data;
using EcommerceWithAngularWeb.Models;
using EcommerceWithAngularWeb.Services.Infrastructures;

namespace EcommerceWithAngularWeb.Services.Repositories
{
    public class OrderRepository : IOrder
    {
        private ApplicationDbContext _context;

        public int Count()
        {
            int qtd_Orders = _context.Orders.Count();
            return qtd_Orders;
        }

        public void Delete(int id)
        {
            var orders = _context.Orders.FirstOrDefault(c => c.Id == id);
            if (orders != null)
            {
                _context.Orders.Remove(orders);
            }
        }

        public Order GetOrder(int id)
        {
            var order = _context.Orders.FirstOrDefault(c => c.Id == id);
            if (order != null)
            {
                return order;
            }
            return null;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
