using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panaroma.Entities.Concrete;

namespace Panaroma.Bussiness.Abstract
{
    public interface IPlaceService
    {
        List<Place> GetAll();
        Place Get(int Id);
        void Add(Place place);
        void Delete(Place place);
        void Update(Place place);
    }
}
