namespace ZooApp
{
    partial class Form1
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
            this.lbAnimal = new System.Windows.Forms.Label();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbOjos = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbVisto = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbPiel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbRepro = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSonido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAnimal
            // 
            this.lbAnimal.AutoSize = true;
            this.lbAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimal.Location = new System.Drawing.Point(3, 109);
            this.lbAnimal.Name = "lbAnimal";
            this.lbAnimal.Size = new System.Drawing.Size(65, 20);
            this.lbAnimal.TabIndex = 0;
            this.lbAnimal.Text = "Animal: ";
            this.lbAnimal.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtAnimal
            // 
            this.txtAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimal.Location = new System.Drawing.Point(132, 106);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(132, 26);
            this.txtAnimal.TabIndex = 1;
            this.txtAnimal.TextChanged += new System.EventHandler(this.TxtAnimal_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(132, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 3;
            // 
            // lbOjos
            // 
            this.lbOjos.AutoSize = true;
            this.lbOjos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOjos.Location = new System.Drawing.Point(-1, 165);
            this.lbOjos.Name = "lbOjos";
            this.lbOjos.Size = new System.Drawing.Size(83, 20);
            this.lbOjos.TabIndex = 2;
            this.lbOjos.Text = "Color ojos:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(132, 273);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 26);
            this.textBox2.TabIndex = 7;
            // 
            // lbVisto
            // 
            this.lbVisto.AutoSize = true;
            this.lbVisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVisto.Location = new System.Drawing.Point(-1, 273);
            this.lbVisto.Name = "lbVisto";
            this.lbVisto.Size = new System.Drawing.Size(121, 20);
            this.lbVisto.TabIndex = 6;
            this.lbVisto.Text = "Puede ser visto:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(132, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 26);
            this.textBox3.TabIndex = 5;
            // 
            // lbPiel
            // 
            this.lbPiel.AutoSize = true;
            this.lbPiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPiel.Location = new System.Drawing.Point(3, 217);
            this.lbPiel.Name = "lbPiel";
            this.lbPiel.Size = new System.Drawing.Size(78, 20);
            this.lbPiel.TabIndex = 4;
            this.lbPiel.Text = "Color piel:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(132, 335);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 26);
            this.textBox4.TabIndex = 9;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(-1, 341);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(115, 20);
            this.lbTipo.TabIndex = 8;
            this.lbTipo.Text = "Tipo de animal:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(132, 405);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 26);
            this.textBox5.TabIndex = 11;
            // 
            // lbRepro
            // 
            this.lbRepro.AutoSize = true;
            this.lbRepro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRepro.Location = new System.Drawing.Point(-1, 411);
            this.lbRepro.Name = "lbRepro";
            this.lbRepro.Size = new System.Drawing.Size(108, 20);
            this.lbRepro.TabIndex = 10;
            this.lbRepro.Text = "Reproduccion";
            this.lbRepro.Click += new System.EventHandler(this.LbRepro_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(529, 39);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 48);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(642, 39);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 48);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(753, 39);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 48);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(404, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 302);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnSonido
            // 
            this.btnSonido.Location = new System.Drawing.Point(642, 411);
            this.btnSonido.Name = "btnSonido";
            this.btnSonido.Size = new System.Drawing.Size(105, 48);
            this.btnSonido.TabIndex = 16;
            this.btnSonido.Text = "Reproducir sonido";
            this.btnSonido.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 512);
            this.Controls.Add(this.btnSonido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lbRepro);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbVisto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbPiel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbOjos);
            this.Controls.Add(this.txtAnimal);
            this.Controls.Add(this.lbAnimal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAnimal;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbOjos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbVisto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbPiel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbRepro;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSonido;
    }
}

