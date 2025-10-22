using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioeta_de_Clases.Models
{
    public class HistorialMedico
    {
        [Key] public int Id_HistorialMedico{ get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }


        [ForeignKey("Mascota")] public int Id_Mascota { get; set; }
        public Mascota Mascota { get; set; }

    }
}
