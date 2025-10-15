using Biblioeta_de_Clases.Models;
using Biblioeta_de_Clases.Repository;
using System;
using Biblioeta_de_Clases; 
namespace Grupo_N_7___Libreta_Sanitaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Alta
        {
            string sexo = "";
            if (checkBox1.Checked)
            {
                sexo = "Macho";
            }
            else if (checkBox2.Checked)
            {
                sexo = "Hembra";
            }
            string nombre  = textBox1.Text;
            string especie = textBox2.Text;
            string raza    = textBox3.Text;
            int peso       = int.Parse(textBox4.Text);
            string nombreDuenio = textBox5.Text;
            Mascota mascota = new Mascota(nombre, especie, raza, peso, sexo, nombreDuenio);
            MascotaRepository.GuardarMascota(mascota);  
        }

        private void button2_Click(object sender, EventArgs e) // No Funciona
        {

        }

        private void button3_Click(object sender, EventArgs e) // No funciona
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Nombre
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Especie
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) // Raza
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) // Peso
        {

        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e) // Otro
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // Hembra
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // Macho
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) // Nombre dueño
        {

        }
    }
}
