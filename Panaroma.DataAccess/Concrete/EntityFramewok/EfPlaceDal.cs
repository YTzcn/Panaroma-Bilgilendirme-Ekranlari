using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panaroma.Core.DataAccess.EntityFramework;
using Panaroma.DataAccess.Abstract;
using Panaroma.Entities.Concrete;

namespace Panaroma.DataAccess.Concrete.EntityFramewok
{
    public class EfPlaceDal : EfEntityRepositoryBase<Place,PanaromaContext>,IPlaceDal
    {
    }
}
