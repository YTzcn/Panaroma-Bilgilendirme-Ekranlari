using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panaroma.Core.DataAccess;
using Panaroma.Entities.Concrete;

namespace Panaroma.DataAccess.Abstract
{
    public interface IPlaceDal : IEntityRepository<Place>
    {
    }
}
