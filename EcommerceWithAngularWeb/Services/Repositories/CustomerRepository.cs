using EcommerceWithAngularWeb.Data;
using EcommerceWithAngularWeb.Models;
using EcommerceWithAngularWeb.Services.Infrastructures;

namespace EcommerceWithAngularWeb.Services.Repositories
{
    public class CustomerRepository : ICustomer
    {
        private ApplicationDbContext _context;

        public int Count()
        {
            int qtd_Customers = _context.Customers.Count();
            return qtd_Customers;
        }

        public void Delete(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers;
        }

        public Customer GetCustomer(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                return customer;
            }
            return null;
        }

        public void Insert(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
        }
    }
}
