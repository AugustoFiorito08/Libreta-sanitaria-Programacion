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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.MenuHighlight;
            label6.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(303, 49);
            label6.Name = "label6";
            label6.Size = new Size(213, 27);
            label6.TabIndex = 16;
            label6.Text = "Ver Perfil Mascota";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(94, 119);
            label7.Name = "label7";
            label7.Size = new Size(23, 19);
            label7.TabIndex = 20;
            label7.Text = "ID";
            label7.Click += this.label7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(94, 168);
            label1.Name = "label1";
            label1.Size = new Size(164, 18);
            label1.TabIndex = 21;
            label1.Text = "Nombre de la mascota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(94, 217);
            label2.Name = "label2";
            label2.Size = new Size(62, 18);
            label2.TabIndex = 22;
            label2.Text = "Especie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(94, 271);
            label3.Name = "label3";
            label3.Size = new Size(41, 18);
            label3.TabIndex = 23;
            label3.Text = "Raza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(94, 323);
            label4.Name = "label4";
            label4.Size = new Size(140, 19);
            label4.TabIndex = 24;
            label4.Text = "Nombre del dueño ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(571, 119);
            label5.Name = "label5";
            label5.Size = new Size(144, 19);
            label5.TabIndex = 25;
            label5.Text = "Historial de vacunas";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(486, 141);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(302, 214);
            listBox1.TabIndex = 26;
            // 
            // Form1
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }
        private Label label6;
        private Label label7;
        private Label label1;

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
    }
}
