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
                optionsBuilder.UseSqlServer("Server=localhost;Database=LibretaSanitariaDB;Trusted_Connection=True;TrustServerCertificate=False;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HistorialMedico>().HasNoKey();
            modelBuilder.Entity<Vacuna>().HasNoKey();
            modelBuilder.Entity<Mascota>().HasNoKey();

        }


    }    
}
