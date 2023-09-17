namespace Winform_App
{
    partial class DetalleArticulo
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
            this.pictureBox_Imagen_detalle = new System.Windows.Forms.PictureBox();
            this.label_Categoría_detalle = new System.Windows.Forms.Label();
            this.label_Marca_detalle = new System.Windows.Forms.Label();
            this.button_volver = new System.Windows.Forms.Button();
            this.textBox_Precio_detalle = new System.Windows.Forms.TextBox();
            this.label_Precio_detalle = new System.Windows.Forms.Label();
            this.textBox_Nombre_detalle = new System.Windows.Forms.TextBox();
            this.textBox_Descripcion_detalle = new System.Windows.Forms.TextBox();
            this.textBox_Codigo_detalle = new System.Windows.Forms.TextBox();
            this.label_Descripcion_detalle = new System.Windows.Forms.Label();
            this.label_Nombre_detalle = new System.Windows.Forms.Label();
            this.label_Código_detalle = new System.Windows.Forms.Label();
            this.textBox_Marca_detalle = new System.Windows.Forms.TextBox();
            this.textBox_Categoria_detalle = new System.Windows.Forms.TextBox();
            this.label_Imagen_detalle = new System.Windows.Forms.Label();
            this.textBox_URLimagen_detalle = new System.Windows.Forms.TextBox();
            this.button_SiguienteFoto = new System.Windows.Forms.Button();
            this.button_AnteriorFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Imagen_detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Imagen_detalle
            // 
            this.pictureBox_Imagen_detalle.Location = new System.Drawing.Point(295, 26);
            this.pictureBox_Imagen_detalle.Name = "pictureBox_Imagen_detalle";
            this.pictureBox_Imagen_detalle.Size = new System.Drawing.Size(205, 218);
            this.pictureBox_Imagen_detalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Imagen_detalle.TabIndex = 33;
            this.pictureBox_Imagen_detalle.TabStop = false;
            this.pictureBox_Imagen_detalle.Click += new System.EventHandler(this.pictureBox_Imagen_detalle_Click);
            // 
            // label_Categoría_detalle
            // 
            this.label_Categoría_detalle.AutoSize = true;
            this.label_Categoría_detalle.Location = new System.Drawing.Point(46, 236);
            this.label_Categoría_detalle.Name = "label_Categoría_detalle";
            this.label_Categoría_detalle.Size = new System.Drawing.Size(54, 13);
            this.label_Categoría_detalle.TabIndex = 28;
            this.label_Categoría_detalle.Text = "Categoría";
            // 
            // label_Marca_detalle
            // 
            this.label_Marca_detalle.AutoSize = true;
            this.label_Marca_detalle.Location = new System.Drawing.Point(63, 200);
            this.label_Marca_detalle.Name = "label_Marca_detalle";
            this.label_Marca_detalle.Size = new System.Drawing.Size(37, 13);
            this.label_Marca_detalle.TabIndex = 27;
            this.label_Marca_detalle.Text = "Marca";
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(425, 279);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 9;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // textBox_Precio_detalle
            // 
            this.textBox_Precio_detalle.Location = new System.Drawing.Point(121, 133);
            this.textBox_Precio_detalle.Name = "textBox_Precio_detalle";
            this.textBox_Precio_detalle.Size = new System.Drawing.Size(121, 20);
            this.textBox_Precio_detalle.TabIndex = 3;
            // 
            // label_Precio_detalle
            // 
            this.label_Precio_detalle.AutoSize = true;
            this.label_Precio_detalle.Location = new System.Drawing.Point(63, 140);
            this.label_Precio_detalle.Name = "label_Precio_detalle";
            this.label_Precio_detalle.Size = new System.Drawing.Size(37, 13);
            this.label_Precio_detalle.TabIndex = 23;
            this.label_Precio_detalle.Text = "Precio";
            // 
            // textBox_Nombre_detalle
            // 
            this.textBox_Nombre_detalle.Location = new System.Drawing.Point(121, 59);
            this.textBox_Nombre_detalle.Name = "textBox_Nombre_detalle";
            this.textBox_Nombre_detalle.Size = new System.Drawing.Size(121, 20);
            this.textBox_Nombre_detalle.TabIndex = 1;
            // 
            // textBox_Descripcion_detalle
            // 
            this.textBox_Descripcion_detalle.Location = new System.Drawing.Point(121, 97);
            this.textBox_Descripcion_detalle.Name = "textBox_Descripcion_detalle";
            this.textBox_Descripcion_detalle.Size = new System.Drawing.Size(121, 20);
            this.textBox_Descripcion_detalle.TabIndex = 2;
            // 
            // textBox_Codigo_detalle
            // 
            this.textBox_Codigo_detalle.Location = new System.Drawing.Point(121, 25);
            this.textBox_Codigo_detalle.Name = "textBox_Codigo_detalle";
            this.textBox_Codigo_detalle.Size = new System.Drawing.Size(121, 20);
            this.textBox_Codigo_detalle.TabIndex = 0;
            // 
            // label_Descripcion_detalle
            // 
            this.label_Descripcion_detalle.AutoSize = true;
            this.label_Descripcion_detalle.Location = new System.Drawing.Point(37, 104);
            this.label_Descripcion_detalle.Name = "label_Descripcion_detalle";
            this.label_Descripcion_detalle.Size = new System.Drawing.Size(63, 13);
            this.label_Descripcion_detalle.TabIndex = 19;
            this.label_Descripcion_detalle.Text = "Descripción";
            // 
            // label_Nombre_detalle
            // 
            this.label_Nombre_detalle.AutoSize = true;
            this.label_Nombre_detalle.Location = new System.Drawing.Point(56, 62);
            this.label_Nombre_detalle.Name = "label_Nombre_detalle";
            this.label_Nombre_detalle.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre_detalle.TabIndex = 18;
            this.label_Nombre_detalle.Text = "Nombre";
            // 
            // label_Código_detalle
            // 
            this.label_Código_detalle.AutoSize = true;
            this.label_Código_detalle.Location = new System.Drawing.Point(60, 28);
            this.label_Código_detalle.Name = "label_Código_detalle";
            this.label_Código_detalle.Size = new System.Drawing.Size(40, 13);
            this.label_Código_detalle.TabIndex = 17;
            this.label_Código_detalle.Text = "Código";
            // 
            // textBox_Marca_detalle
            // 
            this.textBox_Marca_detalle.Location = new System.Drawing.Point(121, 200);
            this.textBox_Marca_detalle.Name = "textBox_Marca_detalle";
            this.textBox_Marca_detalle.Size = new System.Drawing.Size(121, 20);
            this.textBox_Marca_detalle.TabIndex = 5;
            // 
            // textBox_Categoria_detalle
            // 
            this.textBox_Categoria_detalle.Location = new System.Drawing.Point(121, 236);
            this.textBox_Categoria_detalle.Name = "textBox_Categoria_detalle";
            this.textBox_Categoria_detalle.Size = new System.Drawing.Size(121, 20);
            this.textBox_Categoria_detalle.TabIndex = 6;
            // 
            // label_Imagen_detalle
            // 
            this.label_Imagen_detalle.AutoSize = true;
            this.label_Imagen_detalle.Location = new System.Drawing.Point(56, 164);
            this.label_Imagen_detalle.Name = "label_Imagen_detalle";
            this.label_Imagen_detalle.Size = new System.Drawing.Size(42, 13);
            this.label_Imagen_detalle.TabIndex = 31;
            this.label_Imagen_detalle.Text = "Imagen";
            // 
            // textBox_URLimagen_detalle
            // 
            this.textBox_URLimagen_detalle.Location = new System.Drawing.Point(121, 164);
            this.textBox_URLimagen_detalle.Name = "textBox_URLimagen_detalle";
            this.textBox_URLimagen_detalle.Size = new System.Drawing.Size(121, 20);
            this.textBox_URLimagen_detalle.TabIndex = 4;
            // 
            // button_SiguienteFoto
            // 
            this.button_SiguienteFoto.Location = new System.Drawing.Point(506, 133);
            this.button_SiguienteFoto.Name = "button_SiguienteFoto";
            this.button_SiguienteFoto.Size = new System.Drawing.Size(30, 20);
            this.button_SiguienteFoto.TabIndex = 7;
            this.button_SiguienteFoto.Text = "->";
            this.button_SiguienteFoto.UseVisualStyleBackColor = true;
            this.button_SiguienteFoto.Click += new System.EventHandler(this.button_SiguienteFoto_Click);
            // 
            // button_AnteriorFoto
            // 
            this.button_AnteriorFoto.Location = new System.Drawing.Point(259, 132);
            this.button_AnteriorFoto.Name = "button_AnteriorFoto";
            this.button_AnteriorFoto.Size = new System.Drawing.Size(30, 20);
            this.button_AnteriorFoto.TabIndex = 8;
            this.button_AnteriorFoto.Text = "<-";
            this.button_AnteriorFoto.UseVisualStyleBackColor = true;
            this.button_AnteriorFoto.Click += new System.EventHandler(this.button_AnteriorFoto_Click);
            // 
            // DetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 314);
            this.Controls.Add(this.button_AnteriorFoto);
            this.Controls.Add(this.button_SiguienteFoto);
            this.Controls.Add(this.textBox_Categoria_detalle);
            this.Controls.Add(this.textBox_Marca_detalle);
            this.Controls.Add(this.pictureBox_Imagen_detalle);
            this.Controls.Add(this.textBox_URLimagen_detalle);
            this.Controls.Add(this.label_Imagen_detalle);
            this.Controls.Add(this.label_Categoría_detalle);
            this.Controls.Add(this.label_Marca_detalle);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.textBox_Precio_detalle);
            this.Controls.Add(this.label_Precio_detalle);
            this.Controls.Add(this.textBox_Nombre_detalle);
            this.Controls.Add(this.textBox_Descripcion_detalle);
            this.Controls.Add(this.textBox_Codigo_detalle);
            this.Controls.Add(this.label_Descripcion_detalle);
            this.Controls.Add(this.label_Nombre_detalle);
            this.Controls.Add(this.label_Código_detalle);
            this.Name = "DetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.Detalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Imagen_detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Imagen_detalle;
        private System.Windows.Forms.Label label_Categoría_detalle;
        private System.Windows.Forms.Label label_Marca_detalle;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.TextBox textBox_Precio_detalle;
        private System.Windows.Forms.Label label_Precio_detalle;
        private System.Windows.Forms.TextBox textBox_Nombre_detalle;
        private System.Windows.Forms.TextBox textBox_Descripcion_detalle;
        private System.Windows.Forms.TextBox textBox_Codigo_detalle;
        private System.Windows.Forms.Label label_Descripcion_detalle;
        private System.Windows.Forms.Label label_Nombre_detalle;
        private System.Windows.Forms.Label label_Código_detalle;
        private System.Windows.Forms.TextBox textBox_Marca_detalle;
        private System.Windows.Forms.TextBox textBox_Categoria_detalle;
        private System.Windows.Forms.Label label_Imagen_detalle;
        private System.Windows.Forms.TextBox textBox_URLimagen_detalle;
        private System.Windows.Forms.Button button_SiguienteFoto;
        private System.Windows.Forms.Button button_AnteriorFoto;
    }
}