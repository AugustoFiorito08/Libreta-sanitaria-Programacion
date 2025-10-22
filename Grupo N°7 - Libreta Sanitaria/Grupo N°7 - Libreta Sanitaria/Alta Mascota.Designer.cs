namespace Grupo_N_7___Libreta_Sanitaria
{
    partial class Alta_Mascota : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(488, 127);
            button1.Name = "button1";
            button1.Size = new Size(150, 70);
            button1.TabIndex = 0;
            button1.Text = "Cargar Mascota";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(83, 70);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(83, 122);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Especie";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(83, 177);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Raza";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(83, 225);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Peso";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(192, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(192, 223);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 27);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(87, 346);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 11;
            label5.Text = "Sexo";
            label5.Click += label5_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            checkBox1.ForeColor = SystemColors.ControlLightLight;
            checkBox1.Location = new Point(195, 346);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 22);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Macho";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            checkBox2.ForeColor = SystemColors.ControlLightLight;
            checkBox2.Location = new Point(317, 346);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(90, 22);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "Hembra";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.MenuHighlight;
            label6.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(254, 17);
            label6.Name = "label6";
            label6.Size = new Size(236, 33);
            label6.TabIndex = 14;
            label6.Text = "Alta de Mascota";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Gainsboro;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(192, 275);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(177, 25);
            textBox5.TabIndex = 15;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(8, 277);
            label7.Name = "label7";
            label7.Size = new Size(166, 23);
            label7.TabIndex = 16;
            label7.Text = "Nombre del dueño ";
            label7.Click += label7_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightGray;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Rockwell", 9F);
            comboBox1.ForeColor = SystemColors.ActiveCaptionText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(192, 171);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 25);
            comboBox1.TabIndex = 17;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.LightGray;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Popup;
            comboBox2.Font = new Font("Rockwell", 9F);
            comboBox2.ForeColor = SystemColors.ActiveCaptionText;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(192, 119);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(177, 25);
            comboBox2.TabIndex = 18;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(296, 203);
            label8.Name = "label8";
            label8.Size = new Size(0, 23);
            label8.TabIndex = 19;
            // 
            // Alta_Mascota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(682, 353);
            Controls.Add(label8);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Alta_Mascota";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label8;
    }
}
