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
    public class CorporationManager : ICorporationService
    {
        private readonly ICorporationDal _corporationDal;
        public CorporationManager(ICorporationDal corporationDal)
        {
            _corporationDal = corporationDal;
        }
        public void Add(Corporation corporation)
        {
            _corporationDal.Add(corporation);
        }

        public void Delete(Corporation corporation)
        {
            _corporationDal.Delete(corporation);
        }

        public List<Corporation> GetAll()
        {
            return _corporationDal.GetList();
        }

        public Corporation GetById(int CorporationId)
        {
            return _corporationDal.Get(x => x.Id == CorporationId);
        }

        public void Update(Corporation corporation)
        {
            _corporationDal.Update(corporation);
        }
    }
}
