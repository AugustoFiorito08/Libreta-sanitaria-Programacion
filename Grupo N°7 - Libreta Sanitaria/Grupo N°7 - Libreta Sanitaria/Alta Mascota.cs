using Biblioeta_de_Clases.Models;
using Biblioeta_de_Clases.Repository;
using System;
using Biblioeta_de_Clases; 
namespace Grupo_N_7___Libreta_Sanitaria
{
    public partial class Alta_Mascota : Form
    {
        public Alta_Mascota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Alta
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedItem.ToString() == "" ||
                comboBox1.SelectedItem.ToString() == "" || textBox5.Text == "" || (!checkBox1.Checked && !checkBox2.Checked))
            {
                button1.Cursor = Cursors.No;
                button1.Enabled = false;
                return;
            }
            string sexo = "";
            if (checkBox1.Checked)
            {
                sexo = "Macho";
                
                checkBox2.Enabled = false;
            }
            else if (checkBox2.Checked)
            {
                sexo = "Hembra";
                checkBox1.Enabled = false;
            }
            string nombre = textBox1.Text.ToLower().Trim();
            string especie = comboBox2.SelectedItem.ToString().ToLower().Trim();
            string raza = comboBox1.SelectedItem.ToString().ToLower().Trim();
            float peso = float.Parse(textBox2.Text);
            
            string nombreDuenio = textBox5.Text.ToLower();
            if (nombreDuenio == MascotaRepository.verMascotas().Find(m => m.NombreDuenio == nombreDuenio)?.NombreDuenio && 
                nombre == MascotaRepository.verMascotas().Find(m => m.NombreDuenio == nombreDuenio)?.Nombre)
            {
                MessageBox.Show("El dueño ya tiene una mascota registrada con este nombre");
                return;
            }
            Mascota mascota = new Mascota(nombre, especie, raza, peso, sexo, nombreDuenio);
            MascotaRepository.GuardarMascota(mascota);
            MessageBox.Show("Mascota cargada con éxito");
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Raza
        {



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) // Especie
        {

            comboBox1.Items.Clear();

            string especieSeleccionada = comboBox2.SelectedItem.ToString();

            switch (especieSeleccionada)
            {
                case "Perro":
                    comboBox1.Items.AddRange(new string[]
                    {
                "Encontrado en la Calle","Labrador", "Bulldog", "Caniche", "Pastor Alemán", "Beagle"
                    });
                    break;

                case "Gato":
                    comboBox1.Items.AddRange(new string[]
                    {
                "Siames", "Persa", "Bengala"
                    });
                    break;

                case "Ave":
                    comboBox1.Items.AddRange(new string[]
                    {
                "Canario", "Perico", "Loro", "Agapornis", "Cacatúa"
                    });
                    break;

                case "Roedor":
                    comboBox1.Items.AddRange(new string[]
                    {
                "Hamster", "Cobayo", "Ratón", "Chinchilla"
                    });
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox2.Items.AddRange(new string[] { "Perro", "Gato", "Ave", "Roedor" });
            comboBox1.Items.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
