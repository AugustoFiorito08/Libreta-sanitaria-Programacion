using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioeta_de_Clases.Models
{
    public class Mascota
    {
        public int DniDuenio { get; set; }
        public string NombreDuenio { get; set; }
        public int ID_Mascota { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public float Peso { get; set; }

        // Relación: una mascota puede tener varios historiales médicos
        public List<HistorialMedico> Historiales { get; set; } = new List<HistorialMedico>();
    }
}
