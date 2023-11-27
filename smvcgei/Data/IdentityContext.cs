using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using smvcgei.Data.Seed;
using smvcgei.Models;

namespace smvcgei.Data
{
    public class IdentityContext : IdentityDbContext<CustomIdentityUser>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {
        }
        // Este DbSet nos permitirá acceder a los usuarios en los controladores
        public DbSet<CustomIdentityUser> CustomIdentityUser { get; set; }

        // Esta función se llama al aplicar una migración
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Vamos a agregar 1 usuario al momento de crear la base de datos
            modelBuilder.SeedUserIdentityData();
        }
    }
}
