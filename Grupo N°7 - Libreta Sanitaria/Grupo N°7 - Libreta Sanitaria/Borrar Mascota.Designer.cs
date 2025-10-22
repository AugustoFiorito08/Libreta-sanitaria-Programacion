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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox2 = new ComboBox();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 186);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 229);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 4;
            label4.Text = "Especie";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 273);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 5;
            label5.Text = "Nombre del dueño";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(26, 308);
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
            label6.Size = new Size(408, 20);
            label6.TabIndex = 7;
            label6.Text = "Ingrese los datos de la mascota que desea eliminar";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(115, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(196, 270);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.White;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Popup;
            comboBox2.Font = new Font("Rockwell", 9F);
            comboBox2.ForeColor = SystemColors.ActiveCaptionText;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(115, 228);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(177, 25);
            comboBox2.TabIndex = 19;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
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
            Controls.Add(comboBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox2;
        private Button button2;
    }
}