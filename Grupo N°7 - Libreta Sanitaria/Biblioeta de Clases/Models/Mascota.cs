using Biblioeta_de_Clases.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioeta_de_Clases.Models
{
    public class Mascota
    {
        public int ID_Mascota { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }
        public int Peso { get; set; }        
        public string NombreDuenio { get; set; }

        public List<HistorialMedico> Historial { get; set; } 
        public Mascota( string nombre, string especie, string raza, int peso, string sexo, string nombreDuenio )
        {           
            Nombre = nombre;
            Especie = especie;
            Raza = raza;
            Sexo = sexo;
            Peso = peso;
            NombreDuenio = nombreDuenio;
            Historial = new List<HistorialMedico>();
        }
        public static void modificarDatosMascota(Mascota mascota, string nombre, int peso)
        {
            mascota.Nombre = nombre;
            mascota.Peso = peso;
        }

    }
}
