namespace Grupo_N_7___Libreta_Sanitaria
{
    partial class Ver_Perfil_Mascota
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
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.MenuHighlight;
            label6.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(254, 47);
            label6.Name = "label6";
            label6.Size = new Size(273, 33);
            label6.TabIndex = 15;
            label6.Text = "Ver Perfil Mascota";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(25, 168);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 16;
            label1.Text = "Nombre de la mascota";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(25, 232);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 17;
            label2.Text = "Especie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(25, 299);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 18;
            label3.Text = "Raza";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(25, 103);
            label7.Name = "label7";
            label7.Size = new Size(166, 23);
            label7.TabIndex = 19;
            label7.Text = "Nombre del dueño ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(264, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 27);
            textBox1.TabIndex = 20;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(264, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 27);
            textBox2.TabIndex = 21;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Rockwell", 10.2F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(479, 131);
            button1.Name = "button1";
            button1.Size = new Size(150, 70);
            button1.TabIndex = 24;
            button1.Text = "Buscar mascota";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightGray;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Rockwell", 9F);
            comboBox1.ForeColor = SystemColors.ActiveCaptionText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(264, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 25);
            comboBox1.TabIndex = 25;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.LightGray;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Popup;
            comboBox2.Font = new Font("Rockwell", 9F);
            comboBox2.ForeColor = SystemColors.ActiveCaptionText;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(264, 298);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(177, 25);
            comboBox2.TabIndex = 26;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(80, 35);
            button2.TabIndex = 27;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Ver_Perfil_Mascota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(682, 353);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ver_Perfil_Mascota";
            Text = "Ver_Perfil_Mascota";
            Load += Ver_Perfil_Mascota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button2;
    }
}