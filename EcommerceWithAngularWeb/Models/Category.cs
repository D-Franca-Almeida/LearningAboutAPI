namespace EcommerceWithAngularWeb.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public virtual ICollection<SubCategory> SubCategories { get; set; } = new HashSet<SubCategory>();

    }
}
