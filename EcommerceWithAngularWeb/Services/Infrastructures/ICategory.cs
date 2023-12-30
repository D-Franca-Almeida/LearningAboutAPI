using EcommerceWithAngularWeb.Models;
namespace EcommerceWithAngularWeb.Services.Infrastructures
{
    public interface ICategory
    {
        IEnumerable<Category> GetCategories();
        Category GetCategory(int id);
        void Insert(Category category);
        void Update(Category category);
        void Delete(int id);
        int Count();
        void Save();
    }
}
