using EcommerceWithAngularWeb.Data;
using EcommerceWithAngularWeb.Models;
using EcommerceWithAngularWeb.Services.Infrastructures;

namespace EcommerceWithAngularWeb.Services.Repositories
{
    public class SubCategoryRepository : ISubCategory
    {
        private ApplicationDbContext _context;
        public SubCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Count()
        {
            int qtd_SubCategory = _context.SubCategories.Count();
            return qtd_SubCategory;
           
        }

        public void Delete(int id)
        {
            var subCategories = _context.SubCategories.FirstOrDefault(c => c.Id == id);
            if (subCategories != null)
            {
                _context.SubCategories.Remove(subCategories);
            }
        }

        public IEnumerable<SubCategory> GetSubCategories()
        {
            return _context.SubCategories;
        }

        public SubCategory GetSubCategory(int id)
        {
            var subCategory = _context.SubCategories.FirstOrDefault(c => c.Id == id);
            if (subCategory != null)
            {
                return subCategory;
            }
            else { return null; }
        }

        public void Insert(SubCategory subCategory)
        {
            _context.SubCategories.Add(subCategory);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(SubCategory subCategory)
        {
            _context.SubCategories.Update(subCategory);
        }
    }
}
