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
    public partial class Borrar_Mascota : Form
    {
        public Borrar_Mascota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mascota mascota = null;
            bool borrar = false;

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return;
            }
            else if (MascotaRepository.verMascotas().Exists(m => m.Id_Mascota == int.Parse(textBox1.Text)))
            {
                mascota = MascotaRepository.verMascotas().FirstOrDefault(m => m.Id_Mascota == int.Parse(textBox1.Text));
                if (mascota.Nombre == textBox3.Text.ToLower())
                {
                    checkBox1.Enabled = true;
                    borrar = true; 
                }
                else if (mascota.Nombre != textBox3.Text.ToLower())
                {
                    MessageBox.Show("El nombre ingresado no coincide con la mascota seleccionada.");
                    checkBox1.Enabled = false;
                    checkBox1.Checked = false;
                    borrar = false;
                }
                else if (mascota != null && (checkBox1.Checked == false))
                {

                    if (MessageBox.Show($"¿Está seguro que desea borrar la mascota {mascota.Nombre}?",
                        "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        borrar = true;
                    }
                }
                
            }
            if (checkBox1.Checked && borrar)
            {
                MascotaRepository.BorrarMascota(mascota);
            }
        }

        private void Borrar_Mascota_Load(object sender, EventArgs e)
        {
            comboBox2.Items.AddRange(new string[] { "Perro", "Gato", "Ave", "Roedor" });
            comboBox2.SelectedIndex = -1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
