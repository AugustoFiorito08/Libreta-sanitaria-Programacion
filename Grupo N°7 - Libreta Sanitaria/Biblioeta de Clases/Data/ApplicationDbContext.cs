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
        public DbSet<HistorialMedico> HistorialesMedicos { get; set; }
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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HistorialMedico>().HasKey(h => h.Id_HistorialMedico);
            modelBuilder.Entity<Vacuna>().HasKey(v => v.Id_Vacuna);
            modelBuilder.Entity<Mascota>().HasKey(m => m.Id_Mascota);

            modelBuilder.Entity<HistorialMedico>().HasKey(h => h.Id_HistorialMedico);
            modelBuilder.Entity<Vacuna>().HasKey(v => v.Id_Vacuna);
            modelBuilder.Entity<Mascota>().HasKey(m => m.Id_Mascota);
            modelBuilder.Entity<Mascota>()
            .HasOne(m => m.HistorialMedico)
            .WithOne(h => h.Mascota)
            .HasForeignKey<HistorialMedico>(h => h.Id_Mascota)
            .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<HistorialMedico>()
            .HasMany(h => h.Vacunas)
            .WithOne(v => v.HistorialMedico)
            .HasForeignKey(v => v.HistorialId)
            .OnDelete(DeleteBehavior.Cascade);
        }


    }    
}
