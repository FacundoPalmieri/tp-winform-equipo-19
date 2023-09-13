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
            this.dgv_Articulos = new System.Windows.Forms.DataGridView();
            this.pb_Articulos = new System.Windows.Forms.PictureBox();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Articulos
            // 
            this.dgv_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Articulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Articulos.Location = new System.Drawing.Point(21, 49);
            this.dgv_Articulos.MultiSelect = false;
            this.dgv_Articulos.Name = "dgv_Articulos";
            this.dgv_Articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Articulos.Size = new System.Drawing.Size(655, 200);
            this.dgv_Articulos.TabIndex = 0;
            this.dgv_Articulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Articulos_CellContentClick_1);
            this.dgv_Articulos.SelectionChanged += new System.EventHandler(this.dgv_Articulos_SelectionChanged);
            // 
            // pb_Articulos
            // 
            this.pb_Articulos.Location = new System.Drawing.Point(682, 84);
            this.pb_Articulos.Name = "pb_Articulos";
            this.pb_Articulos.Size = new System.Drawing.Size(200, 124);
            this.pb_Articulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Articulos.TabIndex = 1;
            this.pb_Articulos.TabStop = false;
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(21, 255);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(75, 23);
            this.button_Agregar.TabIndex = 2;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // button_modificar
            // 
            this.button_modificar.Location = new System.Drawing.Point(102, 255);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(75, 23);
            this.button_modificar.TabIndex = 3;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = true;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(183, 255);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 4;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 365);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_Agregar);
            this.Controls.Add(this.pb_Articulos);
            this.Controls.Add(this.dgv_Articulos);
            this.MaximumSize = new System.Drawing.Size(910, 404);
            this.MinimumSize = new System.Drawing.Size(910, 404);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Articulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Articulos;
        private System.Windows.Forms.PictureBox pb_Articulos;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_cerrar;
    }
}