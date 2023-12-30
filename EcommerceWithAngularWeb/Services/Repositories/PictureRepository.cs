using EcommerceWithAngularWeb.Data;
using EcommerceWithAngularWeb.Models;
using EcommerceWithAngularWeb.Services.Infrastructures;

namespace EcommerceWithAngularWeb.Services.Repositories
{
    public class PictureRepository : IPicture
    {
        private ApplicationDbContext _context;

        public int Count()
        {
            int qtd_Pictures = _context.Pictures.Count();
            return qtd_Pictures;
        }

        public void Delete(int id)
        {
            var pictures = _context.Pictures.FirstOrDefault(c => c.Id == id);
            if (pictures != null)
            {
                _context.Pictures.Remove(pictures);
            }
        }

        public Picture? GetPicture(int id)
        {
            var picture = _context.Pictures.FirstOrDefault(c => c.Id == id);
            if (picture != null)
            {
                return picture;
            }
            else { return null; }
            
        }

        public IEnumerable<Picture> GetPictures()
        {
            return _context.Pictures;
        }

        public void Insert(Picture picture)
        {
            _context.Pictures.Add(picture);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Picture picture)
        {
            _context.Pictures.Update(picture);
        }
    }
}
