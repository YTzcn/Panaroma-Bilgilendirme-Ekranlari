using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Panaroma.Entities.Concrete;

namespace Panaroma.DataAccess.Concrete.EntityFramewok
{
    public class PanaromaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=Panaroma;Integrated Security=true;TrustServerCertificate=True;");
        }
        public DbSet<Place> Places { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Corporation> Corporations { get; set; }
    }
}
