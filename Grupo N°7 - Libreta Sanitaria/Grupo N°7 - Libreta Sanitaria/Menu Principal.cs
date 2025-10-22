using System;
using Grupo_N_7___Libreta_Sanitaria; 


namespace Grupo_N_7___Libreta_Sanitaria
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e) // No funciona
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) // Alta Mascota
        {
            {
                Alta_Mascota Carga_Mascota= new Alta_Mascota();
                Carga_Mascota.Show();
                this.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e) // Moficar Mascota
        {
            Modificacion altaForm = new Modificacion();
            altaForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) // Eliminar Mascota
        {

        }

        private void button4_Click(object sender, EventArgs e) // agregar vacuna
        {

        }
    }
}
