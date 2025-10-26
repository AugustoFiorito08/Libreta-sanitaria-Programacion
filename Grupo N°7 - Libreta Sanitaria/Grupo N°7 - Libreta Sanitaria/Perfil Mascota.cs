using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioeta_de_Clases;
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
            label7.Text = mascota.Id_Mascota.ToString();
            label8.Text = mascota.Nombre;
            label2.Text = mascota.Especie;
            label3.Text = mascota.Raza;
            label4.Text = mascota.NombreDuenio;
            label14.Text = mascota.Peso.ToString();
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
            button2 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            this.label16 = new Label();
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
            label7.Location = new Point(41, 125);
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
            label2.Location = new Point(92, 163);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 22;
            label2.Text = "Especie";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(65, 202);
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
            label4.Location = new Point(174, 318);
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
            button1.Location = new Point(413, 271);
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
            label8.Location = new Point(203, 271);
            label8.Name = "label8";
            label8.Size = new Size(76, 23);
            label8.TabIndex = 28;
            label8.Text = "Nombre";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(21, 19);
            button2.Name = "button2";
            button2.Size = new Size(80, 35);
            button2.TabIndex = 29;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(13, 125);
            label9.Name = "label9";
            label9.Size = new Size(33, 23);
            label9.TabIndex = 30;
            label9.Text = "ID:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(12, 271);
            label10.Name = "label10";
            label10.Size = new Size(196, 23);
            label10.TabIndex = 31;
            label10.Text = "Nombre de la Mascota:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveCaption;
            label11.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(14, 163);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 32;
            label11.Text = "Especie:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ActiveCaption;
            label12.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(13, 202);
            label12.Name = "label12";
            label12.Size = new Size(56, 20);
            label12.TabIndex = 33;
            label12.Text = "Raza:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(12, 318);
            label13.Name = "label13";
            label13.Size = new Size(166, 23);
            label13.TabIndex = 34;
            label13.Text = "Nombre del dueño:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaption;
            label14.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(65, 238);
            label14.Name = "label14";
            label14.Size = new Size(49, 20);
            label14.TabIndex = 35;
            label14.Text = "Peso";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ActiveCaption;
            label15.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(13, 238);
            label15.Name = "label15";
            label15.Size = new Size(55, 20);
            label15.TabIndex = 36;
            label15.Text = "Peso:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = SystemColors.ActiveCaption;
            this.label16.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            this.label16.ForeColor = SystemColors.ControlLightLight;
            this.label16.Location = new Point(107, 238);
            this.label16.Name = "label16";
            this.label16.Size = new Size(33, 20);
            this.label16.TabIndex = 37;
            this.label16.Text = "Kg";
            // 
            // PerfilMascota
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(682, 353);
            Controls.Add(this.label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button2);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
