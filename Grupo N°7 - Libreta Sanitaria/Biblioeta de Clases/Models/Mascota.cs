using Biblioeta_de_Clases.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioeta_de_Clases.Models
{
    public class Mascota
    {

        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }
        public float Peso { get; set; }
        public string NombreDuenio { get; set; }
        public List<Vacuna> Vacunas { get; set; } = new List<Vacuna>();


    }
}