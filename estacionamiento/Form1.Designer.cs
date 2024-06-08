namespace estacionamiento
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbGeneros = new System.Windows.Forms.ComboBox();
            this.cmbPeliculas = new System.Windows.Forms.ComboBox();
            this.lstPeliculas = new System.Windows.Forms.ListBox();
            this.cmbGeneros2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevaPelicula = new System.Windows.Forms.Button();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbGeneros
            // 
            this.cmbGeneros.FormattingEnabled = true;
            this.cmbGeneros.Location = new System.Drawing.Point(201, 104);
            this.cmbGeneros.Name = "cmbGeneros";
            this.cmbGeneros.Size = new System.Drawing.Size(121, 21);
            this.cmbGeneros.TabIndex = 0;
            this.cmbGeneros.SelectedIndexChanged += new System.EventHandler(this.cmbgeneros_SelectedIndexChanged);
            // 
            // cmbPeliculas
            // 
            this.cmbPeliculas.FormattingEnabled = true;
            this.cmbPeliculas.Location = new System.Drawing.Point(363, 104);
            this.cmbPeliculas.Name = "cmbPeliculas";
            this.cmbPeliculas.Size = new System.Drawing.Size(121, 21);
            this.cmbPeliculas.TabIndex = 1;
            // 
            // lstPeliculas
            // 
            this.lstPeliculas.FormattingEnabled = true;
            this.lstPeliculas.Location = new System.Drawing.Point(363, 178);
            this.lstPeliculas.Name = "lstPeliculas";
            this.lstPeliculas.Size = new System.Drawing.Size(120, 95);
            this.lstPeliculas.TabIndex = 2;
            // 
            // cmbGeneros2
            // 
            this.cmbGeneros2.FormattingEnabled = true;
            this.cmbGeneros2.Location = new System.Drawing.Point(201, 179);
            this.cmbGeneros2.Name = "cmbGeneros2";
            this.cmbGeneros2.Size = new System.Drawing.Size(121, 21);
            this.cmbGeneros2.TabIndex = 3;
            this.cmbGeneros2.SelectedIndexChanged += new System.EventHandler(this.cmbGeneros2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "GENEROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "PELICULAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "GENEROS";
            // 
            // btnNuevaPelicula
            // 
            this.btnNuevaPelicula.Location = new System.Drawing.Point(201, 245);
            this.btnNuevaPelicula.Name = "btnNuevaPelicula";
            this.btnNuevaPelicula.Size = new System.Drawing.Size(121, 23);
            this.btnNuevaPelicula.TabIndex = 8;
            this.btnNuevaPelicula.Text = "NUEVA PELICULA";
            this.btnNuevaPelicula.UseVisualStyleBackColor = true;
            this.btnNuevaPelicula.Click += new System.EventHandler(this.btnNuevaPelicula_Click);
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(201, 206);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(121, 20);
            this.txtPelicula.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPelicula);
            this.Controls.Add(this.btnNuevaPelicula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGeneros2);
            this.Controls.Add(this.lstPeliculas);
            this.Controls.Add(this.cmbPeliculas);
            this.Controls.Add(this.cmbGeneros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGeneros;
        private System.Windows.Forms.ComboBox cmbPeliculas;
        private System.Windows.Forms.ListBox lstPeliculas;
        private System.Windows.Forms.ComboBox cmbGeneros2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevaPelicula;
        private System.Windows.Forms.TextBox txtPelicula;
    }
}

