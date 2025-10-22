using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioeta_de_Clases.Migrations;
using Biblioeta_de_Clases.Models;
using Biblioeta_de_Clases.Data;

namespace Grupo_N_7___Libreta_Sanitaria
{
    public partial class PerfilMascota : Form
    {
        public PerfilMascota()
        {
            InitializeComponent();
        }
        public PerfilMascota(Mascota mascota)
        {
            InitializeComponent();
            label1.Text = mascota.Nombre;
            label2.Text = mascota.Especie;
            label3.Text = mascota.Raza;
            label4.Text = mascota.NombreDuenio;
            foreach (var historial in mascota.Historial)
            {
                listBox1.Items.Add($"Fecha: {historial.Fecha.ToShortDateString()}, Descripción: {historial.Descripcion}");
            }
        }
        private void InitializeComponent()
        {
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            label8 = new Label();
            this.button2 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.MenuHighlight;
            label6.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(220, 21);
            label6.Name = "label6";
            label6.Size = new Size(273, 33);
            label6.TabIndex = 16;
            label6.Text = "Ver Perfil Mascota";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(12, 98);
            label7.Name = "label7";
            label7.Size = new Size(28, 23);
            label7.TabIndex = 20;
            label7.Text = "ID";
            label7.Click += label7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 147);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 196);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 22;
            label2.Text = "Especie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 250);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 23;
            label3.Text = "Raza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 293);
            label4.Name = "label4";
            label4.Size = new Size(166, 23);
            label4.TabIndex = 24;
            label4.Text = "Nombre del dueño ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(397, 72);
            label5.Name = "label5";
            label5.Size = new Size(142, 23);
            label5.TabIndex = 25;
            label5.Text = "Historial Medico";
            label5.Click += label5_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaption;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.ForeColor = SystemColors.MenuText;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(276, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(394, 160);
            listBox1.TabIndex = 26;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(397, 271);
            button1.Name = "button1";
            button1.Size = new Size(150, 70);
            button1.TabIndex = 27;
            button1.Text = "Agregar Vacuna";
            button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(12, 147);
            label8.Name = "label8";
            label8.Size = new Size(191, 23);
            label8.TabIndex = 28;
            label8.Text = "Nombre de la Mascota";
            // 
            // button2
            // 
            this.button2.BackColor = SystemColors.MenuHighlight;
            this.button2.FlatStyle = FlatStyle.Popup;
            this.button2.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button2.ForeColor = SystemColors.ControlLightLight;
            this.button2.Location = new Point(21, 19);
            this.button2.Name = "button2";
            this.button2.Size = new Size(80, 35);
            this.button2.TabIndex = 29;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += this.button2_Click;
            // 
            // PerfilMascota
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(682, 353);
            Controls.Add(this.button2);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "PerfilMascota";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();

        }
        public Label label6;
        public Label label7;
        public Label label1;

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        private ListBox listBox1;

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private Button button1;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (label1.Text == "Nombre de la mascota")
            {

            }
        }
        public Label label8;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
