using EcommerceWithAngularWeb.Data;
using EcommerceWithAngularWeb.Models;
using EcommerceWithAngularWeb.Services.Infrastructures;

namespace EcommerceWithAngularWeb.Services.Repositories
{
    public class ProductRepository : IProduct
    {
        private ApplicationDbContext _context;

        public int Count()
        {
            int qtd_Products = _context.Products.Count();
            return qtd_Products;
        }

        public void Delete(int id)
        {
            var products = _context.Products.FirstOrDefault(c => c.Id == id);
            if (products != null)
            {
                _context.Products.Remove(products);
            }
        }

        public Product GetProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(c => c.Id == id);
            if (product != null)
            {
                return product;
            }
            else { return null; }
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        public void Insert(Product product)
        {
             _context.Add(product);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
        }
    }
}
