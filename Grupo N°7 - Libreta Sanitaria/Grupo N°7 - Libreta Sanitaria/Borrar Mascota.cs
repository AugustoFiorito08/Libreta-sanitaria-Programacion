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
            bool borrar = false;
            Mascota mascota = MascotaRepository.verMascotas().FirstOrDefault(m => m.ID_Mascota == int.Parse(textBox1.Text));
            if (mascota.Nombre == textBox3.Text)
            {
                checkBox1.Enabled = true;
            }
            else if (mascota == null)
            {
                MessageBox.Show("No se encontró una mascota con el ID ingresado.");
                borrar = false;
            }
            else if (mascota.Nombre != textBox3.Text)
            {
                checkBox1.Cursor = Cursors.No;
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
            if (checkBox1.Checked && borrar)
            {
                MascotaRepository.BorrarMascota(mascota);
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
    }
}
