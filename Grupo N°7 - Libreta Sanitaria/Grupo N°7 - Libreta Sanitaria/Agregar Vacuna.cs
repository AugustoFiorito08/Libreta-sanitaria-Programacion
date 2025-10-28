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

namespace Grupo_N_7___Libreta_Sanitaria
{
    public partial class Agregar_Vacuna : Form
    {
        public Agregar_Vacuna()
        {
            InitializeComponent();

        }
        public Agregar_Vacuna(Mascota mascota)
        {
            InitializeComponent();
            label5.Text = mascota.Id_Mascota.ToString();   

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // nombre vacuna
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Tipo
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) // Dosis
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                if (dateTimePicker1.Value > DateTime.Now)
                {
                    dateTimePicker1.Value = DateTime.Now;
                    return;
                }

                Vacuna vacuna = new Vacuna
                {
                    Nombre = textBox1.Text.Trim(),
                    Tipo = textBox2.Text.Trim(),
                    Dosis = textBox3.Text.Trim(),
                    Fecha = dateTimePicker1.Value

                };
                VacunaRepository.GuardarVacuna(vacuna);
                var mascota = MascotaRepository.verMascotas().FirstOrDefault(m => m.Id_Mascota == int.Parse(label5.Text));
                mascota.HistorialMedico.Vacunas.Add(vacuna);
                MessageBox.Show("Vacuna agregada con éxito");
                return;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) // Fecha
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
