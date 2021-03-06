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
            this.components = new System.ComponentModel.Container();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSonido = new System.Windows.Forms.Button();
            this.animalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zooAppDataSet1 = new ZooApp.zooAppDataSet();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new ZooApp.zooAppDataSetTableAdapters.animalTableAdapter();
            this.lbAnimal = new System.Windows.Forms.Label();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.lbOjos = new System.Windows.Forms.Label();
            this.txtOjos = new System.Windows.Forms.TextBox();
            this.txtRep = new System.Windows.Forms.TextBox();
            this.txtPiel = new System.Windows.Forms.TextBox();
            this.lbVisto = new System.Windows.Forms.Label();
            this.txtVisto = new System.Windows.Forms.TextBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lbRep = new System.Windows.Forms.Label();
            this.lbPiel = new System.Windows.Forms.Label();
            this.AnimalView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(669, 69);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 48);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(808, 198);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 48);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Buscar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1045, 198);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 48);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Agregar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnSonido
            // 
            this.btnSonido.Location = new System.Drawing.Point(490, 419);
            this.btnSonido.Name = "btnSonido";
            this.btnSonido.Size = new System.Drawing.Size(105, 48);
            this.btnSonido.TabIndex = 16;
            this.btnSonido.Text = "Reproducir sonido";
            this.btnSonido.UseVisualStyleBackColor = true;
            this.btnSonido.Click += new System.EventHandler(this.BtnSonido_Click);
            // 
            // animalBindingSource1
            // 
            this.animalBindingSource1.DataMember = "animal";
            this.animalBindingSource1.DataSource = this.zooAppDataSet1;
            // 
            // zooAppDataSet1
            // 
            this.zooAppDataSet1.DataSetName = "zooAppDataSet";
            this.zooAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "animal";
            this.animalBindingSource.DataSource = this.zooAppDataSet1;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // lbAnimal
            // 
            this.lbAnimal.AutoSize = true;
            this.lbAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimal.Location = new System.Drawing.Point(81, 31);
            this.lbAnimal.Name = "lbAnimal";
            this.lbAnimal.Size = new System.Drawing.Size(65, 20);
            this.lbAnimal.TabIndex = 0;
            this.lbAnimal.Text = "Animal: ";
            this.lbAnimal.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtAnimal
            // 
            this.txtAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimal.Location = new System.Drawing.Point(214, 22);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(132, 26);
            this.txtAnimal.TabIndex = 1;
            this.txtAnimal.TextChanged += new System.EventHandler(this.TxtAnimal_TextChanged);
            // 
            // lbOjos
            // 
            this.lbOjos.AutoSize = true;
            this.lbOjos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOjos.Location = new System.Drawing.Point(77, 87);
            this.lbOjos.Name = "lbOjos";
            this.lbOjos.Size = new System.Drawing.Size(83, 20);
            this.lbOjos.TabIndex = 2;
            this.lbOjos.Text = "Color ojos:";
            // 
            // txtOjos
            // 
            this.txtOjos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOjos.Location = new System.Drawing.Point(210, 81);
            this.txtOjos.Name = "txtOjos";
            this.txtOjos.Size = new System.Drawing.Size(132, 26);
            this.txtOjos.TabIndex = 3;
            // 
            // txtRep
            // 
            this.txtRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRep.Location = new System.Drawing.Point(210, 146);
            this.txtRep.Name = "txtRep";
            this.txtRep.Size = new System.Drawing.Size(132, 26);
            this.txtRep.TabIndex = 11;
            // 
            // txtPiel
            // 
            this.txtPiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiel.Location = new System.Drawing.Point(463, 25);
            this.txtPiel.Name = "txtPiel";
            this.txtPiel.Size = new System.Drawing.Size(132, 26);
            this.txtPiel.TabIndex = 5;
            // 
            // lbVisto
            // 
            this.lbVisto.AutoSize = true;
            this.lbVisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVisto.Location = new System.Drawing.Point(348, 84);
            this.lbVisto.Name = "lbVisto";
            this.lbVisto.Size = new System.Drawing.Size(121, 20);
            this.lbVisto.TabIndex = 6;
            this.lbVisto.Text = "Puede ser visto:";
            // 
            // txtVisto
            // 
            this.txtVisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisto.Location = new System.Drawing.Point(463, 84);
            this.txtVisto.Name = "txtVisto";
            this.txtVisto.Size = new System.Drawing.Size(132, 26);
            this.txtVisto.TabIndex = 7;
            this.txtVisto.TextChanged += new System.EventHandler(this.TxtVisto_TextChanged);
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(348, 152);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(115, 20);
            this.lbTipo.TabIndex = 8;
            this.lbTipo.Text = "Tipo de animal:";
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(463, 146);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(132, 26);
            this.txtTipo.TabIndex = 9;
            // 
            // lbRep
            // 
            this.lbRep.AutoSize = true;
            this.lbRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRep.Location = new System.Drawing.Point(77, 152);
            this.lbRep.Name = "lbRep";
            this.lbRep.Size = new System.Drawing.Size(108, 20);
            this.lbRep.TabIndex = 10;
            this.lbRep.Text = "Reproduccion";
            this.lbRep.Click += new System.EventHandler(this.LbRepro_Click);
            // 
            // lbPiel
            // 
            this.lbPiel.AutoSize = true;
            this.lbPiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPiel.Location = new System.Drawing.Point(352, 28);
            this.lbPiel.Name = "lbPiel";
            this.lbPiel.Size = new System.Drawing.Size(78, 20);
            this.lbPiel.TabIndex = 4;
            this.lbPiel.Text = "Color piel:";
            // 
            // AnimalView
            // 
            this.AnimalView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnimalView.Location = new System.Drawing.Point(25, 258);
            this.AnimalView.Name = "AnimalView";
            this.AnimalView.Size = new System.Drawing.Size(526, 187);
            this.AnimalView.TabIndex = 17;
            this.AnimalView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(776, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 185);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(929, 284);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(132, 26);
            this.txtPath.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(804, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "IMG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 710);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AnimalView);
            this.Controls.Add(this.btnSonido);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtRep);
            this.Controls.Add(this.lbRep);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.txtVisto);
            this.Controls.Add(this.lbVisto);
            this.Controls.Add(this.txtPiel);
            this.Controls.Add(this.lbPiel);
            this.Controls.Add(this.txtOjos);
            this.Controls.Add(this.lbOjos);
            this.Controls.Add(this.txtAnimal);
            this.Controls.Add(this.lbAnimal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSonido;
        private zooAppDataSet zooAppDataSet1;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private zooAppDataSetTableAdapters.animalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource animalBindingSource1;
        private System.Windows.Forms.Label lbAnimal;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.Label lbOjos;
        private System.Windows.Forms.TextBox txtOjos;
        private System.Windows.Forms.TextBox txtRep;
        private System.Windows.Forms.TextBox txtPiel;
        private System.Windows.Forms.Label lbVisto;
        private System.Windows.Forms.TextBox txtVisto;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lbRep;
        private System.Windows.Forms.Label lbPiel;
        private System.Windows.Forms.DataGridView AnimalView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
    }
}

