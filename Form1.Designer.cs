namespace practica_programacion2
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_apellidos = new System.Windows.Forms.Label();
            this.label_sueldoActual = new System.Windows.Forms.Label();
            this.label_sueldoNuevo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_masDosHijos = new System.Windows.Forms.RadioButton();
            this.radioButton_dosHijos = new System.Windows.Forms.RadioButton();
            this.radioButton_unHijo = new System.Windows.Forms.RadioButton();
            this.radioButton_noHijos = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 23);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(191, 216);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 23);
            this.textBox4.TabIndex = 3;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(113, 97);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(56, 15);
            this.label_nombre.TabIndex = 4;
            this.label_nombre.Text = "Nombres";
            // 
            // label_apellidos
            // 
            this.label_apellidos.AutoSize = true;
            this.label_apellidos.Location = new System.Drawing.Point(113, 141);
            this.label_apellidos.Name = "label_apellidos";
            this.label_apellidos.Size = new System.Drawing.Size(56, 15);
            this.label_apellidos.TabIndex = 5;
            this.label_apellidos.Text = "Apellidos";
            // 
            // label_sueldoActual
            // 
            this.label_sueldoActual.AutoSize = true;
            this.label_sueldoActual.Location = new System.Drawing.Point(105, 179);
            this.label_sueldoActual.Name = "label_sueldoActual";
            this.label_sueldoActual.Size = new System.Drawing.Size(80, 15);
            this.label_sueldoActual.TabIndex = 6;
            this.label_sueldoActual.Text = "Sueldo Actual";
            // 
            // label_sueldoNuevo
            // 
            this.label_sueldoNuevo.AutoSize = true;
            this.label_sueldoNuevo.Location = new System.Drawing.Point(104, 219);
            this.label_sueldoNuevo.Name = "label_sueldoNuevo";
            this.label_sueldoNuevo.Size = new System.Drawing.Size(81, 15);
            this.label_sueldoNuevo.TabIndex = 7;
            this.label_sueldoNuevo.Text = "Sueldo Nuevo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(513, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_masDosHijos);
            this.groupBox1.Controls.Add(this.radioButton_dosHijos);
            this.groupBox1.Controls.Add(this.radioButton_unHijo);
            this.groupBox1.Controls.Add(this.radioButton_noHijos);
            this.groupBox1.Location = new System.Drawing.Point(383, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 207);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad de hijos";
            // 
            // radioButton_masDosHijos
            // 
            this.radioButton_masDosHijos.AutoSize = true;
            this.radioButton_masDosHijos.Location = new System.Drawing.Point(21, 151);
            this.radioButton_masDosHijos.Name = "radioButton_masDosHijos";
            this.radioButton_masDosHijos.Size = new System.Drawing.Size(130, 19);
            this.radioButton_masDosHijos.TabIndex = 3;
            this.radioButton_masDosHijos.TabStop = true;
            this.radioButton_masDosHijos.Text = "Mas de dos (2) hijos";
            this.radioButton_masDosHijos.UseVisualStyleBackColor = true;
            this.radioButton_masDosHijos.CheckedChanged += new System.EventHandler(this.radioButton_masDosHijos_CheckedChanged);
            // 
            // radioButton_dosHijos
            // 
            this.radioButton_dosHijos.AutoSize = true;
            this.radioButton_dosHijos.Location = new System.Drawing.Point(21, 112);
            this.radioButton_dosHijos.Name = "radioButton_dosHijos";
            this.radioButton_dosHijos.Size = new System.Drawing.Size(90, 19);
            this.radioButton_dosHijos.TabIndex = 2;
            this.radioButton_dosHijos.TabStop = true;
            this.radioButton_dosHijos.Text = "Dos (2) hijos";
            this.radioButton_dosHijos.UseVisualStyleBackColor = true;
            this.radioButton_dosHijos.CheckedChanged += new System.EventHandler(this.radioButton_dosHijos_CheckedChanged);
            // 
            // radioButton_unHijo
            // 
            this.radioButton_unHijo.AutoSize = true;
            this.radioButton_unHijo.Location = new System.Drawing.Point(21, 70);
            this.radioButton_unHijo.Name = "radioButton_unHijo";
            this.radioButton_unHijo.Size = new System.Drawing.Size(80, 19);
            this.radioButton_unHijo.TabIndex = 1;
            this.radioButton_unHijo.TabStop = true;
            this.radioButton_unHijo.Text = "Un (1) hijo";
            this.radioButton_unHijo.UseVisualStyleBackColor = true;
            this.radioButton_unHijo.CheckedChanged += new System.EventHandler(this.radioButton_unHijo_CheckedChanged);
            // 
            // radioButton_noHijos
            // 
            this.radioButton_noHijos.AutoSize = true;
            this.radioButton_noHijos.Location = new System.Drawing.Point(21, 31);
            this.radioButton_noHijos.Name = "radioButton_noHijos";
            this.radioButton_noHijos.Size = new System.Drawing.Size(69, 19);
            this.radioButton_noHijos.TabIndex = 0;
            this.radioButton_noHijos.TabStop = true;
            this.radioButton_noHijos.Text = "Sin hijos";
            this.radioButton_noHijos.UseVisualStyleBackColor = true;
            this.radioButton_noHijos.CheckedChanged += new System.EventHandler(this.radioButton_noHijos_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_sueldoNuevo);
            this.Controls.Add(this.label_sueldoActual);
            this.Controls.Add(this.label_apellidos);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label_nombre;
        private Label label_apellidos;
        private Label label_sueldoActual;
        private Label label_sueldoNuevo;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private RadioButton radioButton_masDosHijos;
        private RadioButton radioButton_dosHijos;
        private RadioButton radioButton_unHijo;
        private RadioButton radioButton_noHijos;
    }
}