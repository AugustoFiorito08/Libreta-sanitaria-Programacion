using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioeta_de_Clases.Models
{
    public class Vacuna
    {
        [Key] public int Id_Vacuna { get; set; }
        public string Nombre { get; set; }
        public string Dosis { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }

        // Relación con Mascota
        [ForeignKey("Mascota")] public int Id_Mascota { get; set; }
        public Mascota Mascota { get; set; }
    }
}
