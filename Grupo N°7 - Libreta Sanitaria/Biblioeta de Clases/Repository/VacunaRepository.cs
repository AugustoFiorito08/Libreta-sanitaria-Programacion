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
        public static void GuardarVacuna(Vacuna vacuna, Mascota mascota)
        {
            using var context = new ApplicationDbContext();

            vacuna.MascotaId = mascota.Id;

            context.Vacunas.Add(vacuna);
            context.SaveChanges();
        }

        public static List<Vacuna> BuscarVacunaPorMascota(Mascota mascota)
        {
            using var context = new ApplicationDbContext();
            return context.Vacunas
                .Where(v => v.MascotaId == mascota.Id)
                .ToList();
        }
        public static List<Vacuna> verVacunas()
        {
            using var context = new ApplicationDbContext();
            return context.Vacunas.ToList();
        }
        public static void Actualizar()
        {
            using var context = new ApplicationDbContext();            
                context.SaveChanges();
        }
    }
}

