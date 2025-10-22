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
            var mascotaAEliminar = context.Mascotas.Find(mascota.Id_Mascota);
            
            context.Mascotas.Remove(mascotaAEliminar);
            context.SaveChanges();
        }


        public static Mascota BuscarMascotaPorCampos(string nombreDueno, string nombreMascota, string especie, string raza)
        {
            using (var context = new ApplicationDbContext())
            {
                Mascota mascotaEncontrada = context.Mascotas
                    .FirstOrDefault(m =>
                        m.NombreDuenio.ToLower() == nombreDueno.ToLower() &&
                        m.Nombre.ToLower() == nombreMascota.ToLower() &&
                        m.Especie.ToLower() == especie.ToLower() &&
                        m.Raza.ToLower() == raza.ToLower());
                return mascotaEncontrada;
            }
        }

    }
}
