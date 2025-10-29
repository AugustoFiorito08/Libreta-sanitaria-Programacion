using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioeta_de_Clases.Models;
using Microsoft.EntityFrameworkCore;
using Biblioeta_de_Clases.Repository;

namespace Biblioeta_de_Clases.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Vacuna> Vacunas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=LibretaSanitariaDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mascota>()
                .HasKey(m => m.Id);
            modelBuilder.Entity<Vacuna>()
                .HasKey(v => v.Id);
            modelBuilder.Entity<Mascota>()
                .HasMany(m => m.Vacunas)
                .WithOne(v => v.Mascota)
                .HasForeignKey(v => v.MascotaId);
        }


    }
}
