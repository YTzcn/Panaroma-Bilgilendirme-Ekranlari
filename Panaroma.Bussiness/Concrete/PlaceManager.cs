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
    public class PlaceManager : IPlaceService
    {
        private readonly IPlaceDal _placeDal;
        public PlaceManager(IPlaceDal placeDal)
        {
            _placeDal = placeDal;
        }
        public void Add(Place place)
        {
            _placeDal.Add(place);
        }

        public void Delete(Place place)
        {
            _placeDal.Delete(place);
        }

        public Place Get(int Id)
        {
            return _placeDal.Get(x => x.Id == Id);
        }

        public List<Place> GetAll()
        {
            return _placeDal.GetList();
        }

        public void Update(Place place)
        {
            _placeDal.Update(place);
        }
    }
}
