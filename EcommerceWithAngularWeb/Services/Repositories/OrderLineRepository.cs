using EcommerceWithAngularWeb.Data;
using EcommerceWithAngularWeb.Models;
using EcommerceWithAngularWeb.Services.Infrastructures;

namespace EcommerceWithAngularWeb.Services.Repositories
{
    public class OrderLineRepository : IOrderLine
    {
        private ApplicationDbContext _context;

        public int Count()
        {
            int qtd_OrderLines = _context.OrdersLine.Count();
            return qtd_OrderLines;
        }

        public OrderLine GetOrderLine(int id)
        {
            var orderLines = _context.OrdersLine.FirstOrDefault(c => c.Id == id);
            if (orderLines != null)
            {
                return orderLines;
            }
            return null;
        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
            return _context.OrdersLine;
        }

        public void Insert(OrderLine orderLine)
        {
            _context.OrdersLine.Add(orderLine);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(OrderLine orderLine)
        {
            _context.OrdersLine.Update(orderLine);
        }
    }
}
