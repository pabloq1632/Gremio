using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gremio.Models
{
    public class GremioContext : IdentityDbContext<IdentityUser>
    {
        public GremioContext (DbContextOptions<GremioContext> options)
            : base(options)
        {
        }
        public DbSet<Gremio.Models.Afiliado> Afiliado{ get; set; }
        public DbSet<Gremio.Models.Establecimiento> Establecimiento { get; set; }
     
        public DbSet<Gremio.Models.Cargo> Cargo { get; set; }
       
        public DbSet<Gremio.Models.Planta> Planta { get;set; }
        public DbSet<Gremio.Models.CargoEstablecimiento> CargoEstablecimiento { get;set; }
        


    }
}