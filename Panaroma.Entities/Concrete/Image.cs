using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panaroma.Core.Entities;

namespace Panaroma.Entities.Concrete
{
    public class Image : IEntity
    {
        public int Id { get; set; }
        public int CorporationId { get; set; }
        public string ImageUrl { get; set; }
        public string Active { get; set; }
    }
}
