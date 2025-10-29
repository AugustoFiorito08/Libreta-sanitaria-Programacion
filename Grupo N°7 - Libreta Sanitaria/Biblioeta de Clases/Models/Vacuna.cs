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
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public string Dosis { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }

        [ForeignKey("Mascota")]
        public int MascotaId { get; set; }
        public Mascota Mascota { get; set; }
    }
}
