namespace Grupo_N_7___Libreta_Sanitaria
{
    partial class Menu_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 65);
            label1.Name = "label1";
            label1.Size = new Size(242, 38);
            label1.TabIndex = 1;
            label1.Text = "Libreta Sanitaria";
            // 
            // button1
            // 
            button1.Location = new Point(68, 310);
            button1.Name = "button1";
            button1.Size = new Size(131, 29);
            button1.TabIndex = 2;
            button1.Text = "Cargar Mascota";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(237, 310);
            button2.Name = "button2";
            button2.Size = new Size(144, 29);
            button2.TabIndex = 3;
            button2.Text = "Modificar Mascota";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(413, 310);
            button3.Name = "button3";
            button3.Size = new Size(131, 29);
            button3.TabIndex = 4;
            button3.Text = "Borrar Mascota";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(584, 310);
            button4.Name = "button4";
            button4.Size = new Size(153, 29);
            button4.TabIndex = 5;
            button4.Text = "Agregar Vacunacion";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Menu_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Menu_Principal";
            Text = "Menu_Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}