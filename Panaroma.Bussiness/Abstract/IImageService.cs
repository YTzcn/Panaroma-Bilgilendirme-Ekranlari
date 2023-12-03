using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panaroma.Entities.Concrete;

namespace Panaroma.Bussiness.Abstract
{
    public interface IImageService
    {
        List<Image> GetAll();
        Image GetImage(int Id);
        List<Image> GetImagesByCorporationId(int Id);
        void Add(Image image);
        void Update(Image image);
        void Delete(Image image);
    }
}
