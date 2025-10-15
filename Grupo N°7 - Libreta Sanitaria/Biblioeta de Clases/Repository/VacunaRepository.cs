using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioeta_de_Clases.Data;
using Biblioeta_de_Clases.Models;

namespace Biblioeta_de_Clases.Repository
{
    public class VacunaRepository
    {
        public static void GuardarVacuna(Vacuna vacuna)
        {
            using var context = new ApplicationDbContext();
            context.Vacunas.Add(vacuna);
            context.SaveChanges();
        }
        public static List<Vacuna> verVacunas()
        {
            using var context = new ApplicationDbContext();
            return context.Vacunas.ToList();
        }
        public static void guardarCambios()
        {
            using var context = new ApplicationDbContext();
            context.SaveChanges();
        }

        
    }
}
