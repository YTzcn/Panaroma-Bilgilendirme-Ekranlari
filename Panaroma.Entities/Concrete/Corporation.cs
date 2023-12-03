using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panaroma.Core.Entities;

namespace Panaroma.Entities.Concrete
{
    public class Corporation : IEntity
    {
        public int Id { get; set; }
        public string CorporationName { get; set; }
        public string CorporationTitle { get; set; }
        public string Address { get; set; }
        public string LogoUrl { get; set; }
        public string Announcements { get; set; }
        public bool Active { get; set; }
    }
}
