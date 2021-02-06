using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options)
            :base (options)
        {

        }
        public DbSet<Cientifico> Cientificos { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Asignado_A> Asignado_As { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Asignado_A>()
                        .HasMany(a => a.Cientificos)
                        .WithOne(c => c.asignado);
            modelBuilder.Entity<Proyecto>()
                        .HasMany(p => p.asignados)
                        .WithOne(a => a.Proyecto);
            
        }
    }
}
