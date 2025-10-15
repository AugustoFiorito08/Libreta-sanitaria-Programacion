using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioeta_de_Clases.Data;
using Biblioeta_de_Clases.Models;

namespace Biblioeta_de_Clases.Repository
{
    public class HistorialMedicoRepository
    {

        public static void GuardarHistorial(HistorialMedico historial)
        {
            using var context = new ApplicationDbContext();
            context.Historiales.Add(historial);
            context.SaveChanges();
        }
        public static List<HistorialMedico> verHistoriales()
        {
            using var context = new ApplicationDbContext();
            return context.Historiales.ToList();
        }
        public static void guardarCambios()
        {
            using var context = new ApplicationDbContext();
            context.SaveChanges();
        }
    }
}
