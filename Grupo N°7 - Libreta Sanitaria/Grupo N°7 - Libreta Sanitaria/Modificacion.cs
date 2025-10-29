using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioeta_de_Clases.Models;
using Biblioeta_de_Clases;
using Biblioeta_de_Clases.Repository;

namespace Grupo_N_7___Libreta_Sanitaria
{
    public partial class Modificacion : Form
    {
        public Modificacion(Menu_Principal menu)
        {
            InitializeComponent();
            menuPrincipal = menu; 
        }
        public Form menuPrincipal;

        private void textBox1_TextChanged(object sender, EventArgs e) // Nombre texto
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Peso texto int
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // Nombre check
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                textBox1.Show();

            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Hide();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // Peso check
        {
            if (checkBox2.Checked)
            {
                textBox2.Enabled = true;
                textBox2.Show();
            }
            else
            {

                textBox2.Enabled = false;
                textBox2.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idMascota;
            if (!int.TryParse(textBox3.Text, out idMascota))
            {
                MessageBox.Show("Debe ingresar un ID de mascota válido.");
                return;
            }
            var mascotas = MascotaRepository.verMascotas();
            var mascota = mascotas.FirstOrDefault(m => m.Id == idMascota);
            if (mascota == null)
            {
                MessageBox.Show("No se encontró una mascota con el ID proporcionado.");
                return;
            }
            string nuevoNombre = textBox1.Text.Trim();
            string nuevoPeso = textBox2.Text.Trim();
            if (checkBox1.Checked && !string.IsNullOrEmpty(nuevoNombre))
                mascota.Nombre = nuevoNombre;
            if (checkBox2.Checked && !string.IsNullOrEmpty(nuevoPeso) && float.TryParse(nuevoPeso, out float peso))
                mascota.Peso = peso;
            bool modificada = MascotaRepository.ModificarDatosMascota(mascota);
            if (modificada)
                MessageBox.Show("Modificación realizada con éxito");
            else
                MessageBox.Show("No se pudo modificar la mascota");

        }
       

        private void textBox3_TextChanged(object sender, EventArgs e) // ID Mascota
        {
            if (textBox3.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            menuPrincipal.Show();
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            textBox2.Hide();
        }
    }
}
