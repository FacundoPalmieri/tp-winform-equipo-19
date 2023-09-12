namespace Winform_App
{
    partial class AltaArticulo
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
            this.label_Código = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.textBox_Codigo = new System.Windows.Forms.TextBox();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label_Precio = new System.Windows.Forms.Label();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.label_Marca = new System.Windows.Forms.Label();
            this.label_Categoría = new System.Windows.Forms.Label();
            this.comboBox_Marca = new System.Windows.Forms.ComboBox();
            this.comboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_Código
            // 
            this.label_Código.AutoSize = true;
            this.label_Código.Location = new System.Drawing.Point(48, 21);
            this.label_Código.Name = "label_Código";
            this.label_Código.Size = new System.Drawing.Size(40, 13);
            this.label_Código.TabIndex = 0;
            this.label_Código.Text = "Código";
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Location = new System.Drawing.Point(44, 55);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 1;
            this.label_Nombre.Text = "Nombre";
            // 
            // label_Descripcion
            // 
            this.label_Descripcion.AutoSize = true;
            this.label_Descripcion.Location = new System.Drawing.Point(25, 97);
            this.label_Descripcion.Name = "label_Descripcion";
            this.label_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.label_Descripcion.TabIndex = 2;
            this.label_Descripcion.Text = "Descripción";
            // 
            // textBox_Codigo
            // 
            this.textBox_Codigo.Location = new System.Drawing.Point(109, 18);
            this.textBox_Codigo.Name = "textBox_Codigo";
            this.textBox_Codigo.Size = new System.Drawing.Size(121, 20);
            this.textBox_Codigo.TabIndex = 3;
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Location = new System.Drawing.Point(109, 90);
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.Size = new System.Drawing.Size(121, 20);
            this.textBox_Descripcion.TabIndex = 4;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(109, 52);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(121, 20);
            this.textBox_Nombre.TabIndex = 5;
            // 
            // label_Precio
            // 
            this.label_Precio.AutoSize = true;
            this.label_Precio.Location = new System.Drawing.Point(51, 133);
            this.label_Precio.Name = "label_Precio";
            this.label_Precio.Size = new System.Drawing.Size(37, 13);
            this.label_Precio.TabIndex = 6;
            this.label_Precio.Text = "Precio";
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Location = new System.Drawing.Point(109, 126);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(121, 20);
            this.textBox_Precio.TabIndex = 7;
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(47, 246);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_Aceptar.TabIndex = 8;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(210, 246);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 9;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // label_Marca
            // 
            this.label_Marca.AutoSize = true;
            this.label_Marca.Location = new System.Drawing.Point(51, 165);
            this.label_Marca.Name = "label_Marca";
            this.label_Marca.Size = new System.Drawing.Size(37, 13);
            this.label_Marca.TabIndex = 10;
            this.label_Marca.Text = "Marca";
            // 
            // label_Categoría
            // 
            this.label_Categoría.AutoSize = true;
            this.label_Categoría.Location = new System.Drawing.Point(34, 201);
            this.label_Categoría.Name = "label_Categoría";
            this.label_Categoría.Size = new System.Drawing.Size(54, 13);
            this.label_Categoría.TabIndex = 11;
            this.label_Categoría.Text = "Categoría";
            // 
            // comboBox_Marca
            // 
            this.comboBox_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Marca.FormattingEnabled = true;
            this.comboBox_Marca.Location = new System.Drawing.Point(109, 162);
            this.comboBox_Marca.Name = "comboBox_Marca";
            this.comboBox_Marca.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Marca.TabIndex = 12;
            // 
            // comboBox_Categoria
            // 
            this.comboBox_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Categoria.FormattingEnabled = true;
            this.comboBox_Categoria.Location = new System.Drawing.Point(109, 198);
            this.comboBox_Categoria.Name = "comboBox_Categoria";
            this.comboBox_Categoria.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Categoria.TabIndex = 13;
            // 
            // AltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 306);
            this.Controls.Add(this.comboBox_Categoria);
            this.Controls.Add(this.comboBox_Marca);
            this.Controls.Add(this.label_Categoría);
            this.Controls.Add(this.label_Marca);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.textBox_Precio);
            this.Controls.Add(this.label_Precio);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.textBox_Descripcion);
            this.Controls.Add(this.textBox_Codigo);
            this.Controls.Add(this.label_Descripcion);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.label_Código);
            this.Name = "AltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaArticulo";
            this.Load += new System.EventHandler(this.AltaArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Código;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Descripcion;
        private System.Windows.Forms.TextBox textBox_Codigo;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label_Precio;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Label label_Marca;
        private System.Windows.Forms.Label label_Categoría;
        private System.Windows.Forms.ComboBox comboBox_Marca;
        private System.Windows.Forms.ComboBox comboBox_Categoria;
    }
}