using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioeta_de_Clases.Models
{
    public class HistorialMedico
    {
        public int ID_Historial { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        // Relaciones
        public int ID_Mascota { get; set; }
        public Mascota Mascota { get; set; }

        public int ID_Veterinario { get; set; }
    }
}
