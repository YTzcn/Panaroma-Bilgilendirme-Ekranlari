using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panaroma.Entities.Concrete;

namespace Panaroma.Bussiness.Abstract
{
    public interface ICorporationService
    {
        List<Corporation> GetAll();
        Corporation GetById(int CorporationId);
        void Add(Corporation corporation);
        void Update(Corporation corporation);
        void Delete(Corporation corporation);
    }
}
