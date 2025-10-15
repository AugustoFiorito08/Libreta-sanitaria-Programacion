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
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // Crear (Agregar)
        public void Agregar(Vacuna vacuna)
        {
            _context.Vacunas.Add(vacuna);
            _context.SaveChanges();
        }

        // Obtener todas las vacunas
        public List<Vacuna> ObtenerTodas()
        {
            return _context.Vacunas
                .Include(v => v.Mascota)
                .ToList();
        }

        // Buscar por ID
        public Vacuna ObtenerPorId(int id)
        {
            return _context.Vacunas
                .Include(v => v.Mascota)
                .FirstOrDefault(v => v.ID_Vacuna == id);
        }

        // Actualizar
        public void Actualizar(Vacuna vacuna)
        {
            _context.Vacunas.Update(vacuna);
            _context.SaveChanges();
        }

        // Eliminar
        public void Eliminar(int id)
        {
            var vacuna = _context.Vacunas.Find(id);
            if (vacuna != null)
            {
                _context.Vacunas.Remove(vacuna);
                _context.SaveChanges();
            }
        }
    }
}
