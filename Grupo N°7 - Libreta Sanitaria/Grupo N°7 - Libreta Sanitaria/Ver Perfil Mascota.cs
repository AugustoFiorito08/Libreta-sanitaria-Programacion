using Biblioeta_de_Clases;
using Biblioeta_de_Clases.Models;
using Biblioeta_de_Clases.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grupo_N_7___Libreta_Sanitaria;

namespace Grupo_N_7___Libreta_Sanitaria
{
    public partial class Ver_Perfil_Mascota : Form
    {
        public Ver_Perfil_Mascota(Menu_Principal menu)
        {
            InitializeComponent();
            menuPrincipal = menu;
        }
        public Form menuPrincipal;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombreDueno = textBox1.Text.ToLower().Trim();
            string nombreMascota = textBox2.Text.ToLower().Trim();
            string especie = comboBox1.Text.Trim();
            string raza = comboBox2.Text.Trim();

            if (string.IsNullOrEmpty(nombreDueno) ||
                string.IsNullOrEmpty(nombreMascota) ||
                string.IsNullOrEmpty(especie) ||
                string.IsNullOrEmpty(raza))
            {
                MessageBox.Show("Por favor, complete todos los campos para realizar la búsqueda");
                return;
            }

            Mascota mascotaEncontrada = MascotaRepository.BuscarMascotaPorCampos(
                nombreDueno,
                nombreMascota,
                especie,
                raza
            );

            if (mascotaEncontrada != null)
            {

                PerfilMascota perfilMascotaForm = new PerfilMascota(mascotaEncontrada);

                perfilMascotaForm.Show();

            }
            else
            {
                MessageBox.Show("No se encontró ninguna mascota con los datos proporcionados. Verifique los campos");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) // Especie
        {
            comboBox2.Items.Clear();

            string especieSeleccionada = comboBox1.SelectedItem.ToString();

            switch (especieSeleccionada)
            {
                case "Perro":
                    comboBox2.Items.AddRange(new string[]
                    {
                "Encontrado en la Calle","Labrador", "Bulldog", "Caniche", "Pastor Alemán", "Beagle"
                    });
                    break;

                case "Gato":
                    comboBox2.Items.AddRange(new string[]
                    {
                "Siames", "Persa", "Bengala"
                    });
                    break;

                case "Ave":
                    comboBox2.Items.AddRange(new string[]
                    {
                "Canario", "Perico", "Loro", "Agapornis", "Cacatúa"
                    });
                    break;

                case "Roedor":
                    comboBox2.Items.AddRange(new string[]
                    {
                "Hamster", "Cobayo", "Ratón", "Ardilla"
                    });
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) // Raza
        {

            
        }

        private void Ver_Perfil_Mascota_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Perro", "Gato", "Ave", "Roedor" });
            
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            menuPrincipal.Show();
        }
    }
}
