using EcommerceWithAngularWeb.Models;

namespace EcommerceWithAngularWeb.Services.Infrastructures
{
    public interface IPicture
    {
        IEnumerable<Picture> GetPictures();
        Picture GetPicture(int id);
        void Insert(Picture picture);
        void Update(Picture picture);
        void Delete(int id);
        int Count();
        void Save();
    }
}
