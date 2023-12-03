using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panaroma.Core.DataAccess.EntityFramework;
using Panaroma.Core.Entities;
using Panaroma.DataAccess.Abstract;
using Panaroma.Entities.Concrete;

namespace Panaroma.DataAccess.Concrete.EntityFramewok
{
    public class EfImageDal : EfEntityRepositoryBase<Image, PanaromaContext>, IImageDal
    {
    }
}
