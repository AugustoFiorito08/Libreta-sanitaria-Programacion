namespace Grupo_N_7___Libreta_Sanitaria
{
    partial class Borrar_Mascota
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            label6 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(455, 179);
            button1.Name = "button1";
            button1.Size = new Size(150, 70);
            button1.TabIndex = 0;
            button1.Text = "Borrar Mascota";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(91, 53);
            label1.Name = "label1";
            label1.Size = new Size(230, 33);
            label1.TabIndex = 1;
            label1.Text = "Borrar Mascota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 137);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 2;
            label2.Text = "ID ";
            label2.Click += label2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(26, 179);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(338, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "¿Esta seguro de eliminar esta mascota?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 101);
            label6.Name = "label6";
            label6.Size = new Size(375, 20);
            label6.TabIndex = 7;
            label6.Text = "Ingrese el ID de la Mascota que desea eliminar";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(18, 12);
            button2.Name = "button2";
            button2.Size = new Size(80, 35);
            button2.TabIndex = 28;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Borrar_Mascota
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(682, 353);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Borrar_Mascota";
            Text = "Borrar_Mascota";
            Load += Borrar_Mascota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private Label label6;
        private TextBox textBox1;
        private Button button2;
    }
}