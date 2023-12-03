using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panaroma.Core.Entities;

namespace Panaroma.Entities.Concrete
{
    public class Place : IEntity
    {
        public int Id { get; set; }
        public string PlaceId { get; set; }
        public bool Active { get; set; }
    }
}
