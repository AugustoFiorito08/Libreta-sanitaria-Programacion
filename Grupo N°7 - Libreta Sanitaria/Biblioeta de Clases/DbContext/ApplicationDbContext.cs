using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioeta_de_Clases.Models;
using Microsoft.EntityFrameworkCore;


namespace Biblioeta_de_Clases.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<HistorialMedico> Historiales { get; set; }
        public DbSet<Vacuna> Vacunas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LibretaSanitariaDB;Trusted_Connection=True;");
            }
        }

    }    
}
