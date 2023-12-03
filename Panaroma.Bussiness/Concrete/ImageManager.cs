using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panaroma.Bussiness.Abstract;
using Panaroma.DataAccess.Abstract;
using Panaroma.Entities.Concrete;

namespace Panaroma.Bussiness.Concrete
{
    public class ImageManager : IImageService
    {
        private readonly IImageDal _imageDal;
        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }
        public void Add(Image image)
        {
            _imageDal.Add(image);
        }

        public void Delete(Image image)
        {
            _imageDal.Delete(image);
        }

        public List<Image> GetAll()
        {
            return _imageDal.GetList();
        }

        public Image GetImage(int Id)
        {
            return _imageDal.Get(x => x.Id == Id);

        }

        public List<Image> GetImagesByCorporationId(int Id)
        {
            return _imageDal.GetList(x => x.CorporationId == Id);
        }

        public void Update(Image image)
        {
            _imageDal.Update(image);
        }
    }
}
