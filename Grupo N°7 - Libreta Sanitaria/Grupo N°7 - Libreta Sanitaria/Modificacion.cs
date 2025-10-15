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
    public partial class Modificacion : Form
    {
        public Modificacion()
        {
            InitializeComponent();
        }

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
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // Peso check
        {
            if (checkBox2.Checked)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mascota.nombre = textBox1.Text;
            // Mascota.peso = int.Parse(textBox2.Text);
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
           // Logica para modificar datos 

        }
    }
}
