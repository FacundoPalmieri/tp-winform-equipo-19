namespace Winform_App
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button_Listado = new System.Windows.Forms.Button();
            this.button_Modificar = new System.Windows.Forms.Button();
            this.button_Busqueda = new System.Windows.Forms.Button();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.button_VerDetalle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button_Listado
            // 
            this.button_Listado.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Listado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Listado.Location = new System.Drawing.Point(94, 101);
            this.button_Listado.Name = "button_Listado";
            this.button_Listado.Size = new System.Drawing.Size(165, 60);
            this.button_Listado.TabIndex = 1;
            this.button_Listado.Text = "Listado ";
            this.button_Listado.UseVisualStyleBackColor = false;
            // 
            // button_Modificar
            // 
            this.button_Modificar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Modificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Modificar.Location = new System.Drawing.Point(339, 197);
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.Size = new System.Drawing.Size(165, 60);
            this.button_Modificar.TabIndex = 2;
            this.button_Modificar.Text = "Modificar ";
            this.button_Modificar.UseVisualStyleBackColor = false;
            // 
            // button_Busqueda
            // 
            this.button_Busqueda.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Busqueda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Busqueda.Location = new System.Drawing.Point(339, 101);
            this.button_Busqueda.Name = "button_Busqueda";
            this.button_Busqueda.Size = new System.Drawing.Size(165, 60);
            this.button_Busqueda.TabIndex = 3;
            this.button_Busqueda.Text = "Búsqueda ";
            this.button_Busqueda.UseVisualStyleBackColor = false;
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Eliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Eliminar.Location = new System.Drawing.Point(94, 197);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(165, 60);
            this.button_Eliminar.TabIndex = 4;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = false;
            // 
            // button_Agregar
            // 
            this.button_Agregar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Agregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Agregar.Location = new System.Drawing.Point(591, 101);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(165, 60);
            this.button_Agregar.TabIndex = 5;
            this.button_Agregar.Text = "Agregar ";
            this.button_Agregar.UseVisualStyleBackColor = false;
            // 
            // button_VerDetalle
            // 
            this.button_VerDetalle.BackColor = System.Drawing.Color.SteelBlue;
            this.button_VerDetalle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_VerDetalle.Location = new System.Drawing.Point(591, 197);
            this.button_VerDetalle.Name = "button_VerDetalle";
            this.button_VerDetalle.Size = new System.Drawing.Size(165, 60);
            this.button_VerDetalle.TabIndex = 6;
            this.button_VerDetalle.Text = "Ver detalle ";
            this.button_VerDetalle.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 365);
            this.Controls.Add(this.button_VerDetalle);
            this.Controls.Add(this.button_Agregar);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.button_Busqueda);
            this.Controls.Add(this.button_Modificar);
            this.Controls.Add(this.button_Listado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(910, 404);
            this.MinimumSize = new System.Drawing.Size(910, 404);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Articulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button_Listado;
        private System.Windows.Forms.Button button_Modificar;
        private System.Windows.Forms.Button button_Busqueda;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.Button button_VerDetalle;
    }
}