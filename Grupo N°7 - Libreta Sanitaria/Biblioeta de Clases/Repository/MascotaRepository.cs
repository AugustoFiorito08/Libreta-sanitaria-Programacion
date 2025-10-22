using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioeta_de_Clases.Data;
using Biblioeta_de_Clases.Models;

namespace Biblioeta_de_Clases.Repository
{
    public class MascotaRepository
    {
        public static void GuardarMascota(Mascota mascota)
        {
            using var context = new ApplicationDbContext();
            context.Mascotas.Add(mascota);
            context.SaveChanges();
        }
        public static List<Mascota> verMascotas()
        {
            using var context = new ApplicationDbContext();
            return context.Mascotas.ToList();
        }
        public static void BorrarMascota(Mascota mascota)
        {
            using var context = new ApplicationDbContext();

                context.Mascotas.Remove(mascota);
                context.SaveChanges();
        }
        public static void guardarCambios()
        {
            using var context = new ApplicationDbContext();
            context.SaveChanges();
        }

    }
}
