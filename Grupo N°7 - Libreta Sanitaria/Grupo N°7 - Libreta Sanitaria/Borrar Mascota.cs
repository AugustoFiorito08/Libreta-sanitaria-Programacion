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
        private Form menuPrincipal;
        public Borrar_Mascota(Form menu)
        {
            InitializeComponent();
            menuPrincipal = menu;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, complete el campo ID requerido");
                return;
            }
            else if(MascotaRepository.verMascotas().Exists(m => m.Id == int.Parse(textBox1.Text)))
            {
                var mascota = MascotaRepository.verMascotas().FirstOrDefault(m => m.Id == int.Parse(textBox1.Text));

                if (MessageBox.Show($"¿Está seguro que desea borrar la mascota {mascota.Nombre}?",
                        "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        MascotaRepository.BorrarMascota(mascota);
                        MessageBox.Show("Mascota borrada con éxito");
                    }
            }
            else
            {
                MessageBox.Show("No se encontró ninguna mascota con el ID proporcionado. Verifique el campo");
            }

        }

        private void Borrar_Mascota_Load(object sender, EventArgs e)
        {
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
            menuPrincipal.Show();
        }
    }
}
