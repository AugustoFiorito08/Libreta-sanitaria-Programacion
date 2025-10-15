using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioeta_de_Clases.Models
{
    public class Vacuna
    {
        public int ID_Vacuna { get; set; }
        public string Nombre { get; set; }
        public string Dosis { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }

        // Relación con Mascota
        public int ID_Mascota { get; set; }
        public Mascota Mascota { get; set; }
    }
}
