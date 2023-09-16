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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Articulos = new System.Windows.Forms.DataGridView();
            this.pb_Articulos = new System.Windows.Forms.PictureBox();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.button1_eliminarFisico = new System.Windows.Forms.Button();
            this.button1_eliminarLogico = new System.Windows.Forms.Button();
            this.label_filtro_rapido = new System.Windows.Forms.Label();
            this.textBox_filtro_rapido = new System.Windows.Forms.TextBox();
            this.button_filtro = new System.Windows.Forms.Button();
            this.label_filtro_campo = new System.Windows.Forms.Label();
            this.comboBox_filtro_criterio = new System.Windows.Forms.ComboBox();
            this.label_filtro_criterio = new System.Windows.Forms.Label();
            this.comboBox_filtro_campo = new System.Windows.Forms.ComboBox();
            this.textBox_filtro_avanzado = new System.Windows.Forms.TextBox();
            this.label_filtro_avanzado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Articulos
            // 
            this.dgv_Articulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Articulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Articulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Articulos.GridColor = System.Drawing.Color.Black;
            this.dgv_Articulos.Location = new System.Drawing.Point(21, 49);
            this.dgv_Articulos.MultiSelect = false;
            this.dgv_Articulos.Name = "dgv_Articulos";
            this.dgv_Articulos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Articulos.ShowRowErrors = false;
            this.dgv_Articulos.Size = new System.Drawing.Size(655, 227);
            this.dgv_Articulos.TabIndex = 0;
            this.dgv_Articulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Articulos_CellContentClick_1);
            this.dgv_Articulos.SelectionChanged += new System.EventHandler(this.dgv_Articulos_SelectionChanged);
            // 
            // pb_Articulos
            // 
            this.pb_Articulos.Location = new System.Drawing.Point(682, 49);
            this.pb_Articulos.Name = "pb_Articulos";
            this.pb_Articulos.Size = new System.Drawing.Size(240, 227);
            this.pb_Articulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Articulos.TabIndex = 1;
            this.pb_Articulos.TabStop = false;
            // 
            // button_Agregar
            // 
            this.button_Agregar.ForeColor = System.Drawing.Color.Black;
            this.button_Agregar.Location = new System.Drawing.Point(21, 307);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(75, 23);
            this.button_Agregar.TabIndex = 2;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = false;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // button_modificar
            // 
            this.button_modificar.Location = new System.Drawing.Point(101, 307);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(75, 23);
            this.button_modificar.TabIndex = 3;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = false;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(847, 16);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 4;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // button1_eliminarFisico
            // 
            this.button1_eliminarFisico.Location = new System.Drawing.Point(182, 307);
            this.button1_eliminarFisico.Name = "button1_eliminarFisico";
            this.button1_eliminarFisico.Size = new System.Drawing.Size(119, 23);
            this.button1_eliminarFisico.TabIndex = 5;
            this.button1_eliminarFisico.Text = "Eliminar Físico";
            this.button1_eliminarFisico.UseVisualStyleBackColor = false;
            this.button1_eliminarFisico.Click += new System.EventHandler(this.button1_eliminarFisico_Click);
            // 
            // button1_eliminarLogico
            // 
            this.button1_eliminarLogico.Location = new System.Drawing.Point(307, 307);
            this.button1_eliminarLogico.Name = "button1_eliminarLogico";
            this.button1_eliminarLogico.Size = new System.Drawing.Size(119, 23);
            this.button1_eliminarLogico.TabIndex = 6;
            this.button1_eliminarLogico.Text = "Eliminar Lógico";
            this.button1_eliminarLogico.UseVisualStyleBackColor = false;
            // 
            // label_filtro_rapido
            // 
            this.label_filtro_rapido.AutoSize = true;
            this.label_filtro_rapido.Location = new System.Drawing.Point(18, 26);
            this.label_filtro_rapido.Name = "label_filtro_rapido";
            this.label_filtro_rapido.Size = new System.Drawing.Size(29, 13);
            this.label_filtro_rapido.TabIndex = 7;
            this.label_filtro_rapido.Text = "Filtro";
            this.label_filtro_rapido.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_filtro_rapido
            // 
            this.textBox_filtro_rapido.Location = new System.Drawing.Point(53, 23);
            this.textBox_filtro_rapido.Name = "textBox_filtro_rapido";
            this.textBox_filtro_rapido.Size = new System.Drawing.Size(258, 20);
            this.textBox_filtro_rapido.TabIndex = 8;
            this.textBox_filtro_rapido.TextChanged += new System.EventHandler(this.textBox_filtro_rapido_TextChanged);
            this.textBox_filtro_rapido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_filtro_rapido_KeyPress);
            // 
            // button_filtro
            // 
            this.button_filtro.Location = new System.Drawing.Point(632, 349);
            this.button_filtro.Name = "button_filtro";
            this.button_filtro.Size = new System.Drawing.Size(75, 23);
            this.button_filtro.TabIndex = 9;
            this.button_filtro.Text = "Buscar";
            this.button_filtro.UseVisualStyleBackColor = true;
            this.button_filtro.Click += new System.EventHandler(this.button_filtro_Click);
            // 
            // label_filtro_campo
            // 
            this.label_filtro_campo.AutoSize = true;
            this.label_filtro_campo.Location = new System.Drawing.Point(18, 354);
            this.label_filtro_campo.Name = "label_filtro_campo";
            this.label_filtro_campo.Size = new System.Drawing.Size(40, 13);
            this.label_filtro_campo.TabIndex = 10;
            this.label_filtro_campo.Text = "Campo";
            // 
            // comboBox_filtro_criterio
            // 
            this.comboBox_filtro_criterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filtro_criterio.FormattingEnabled = true;
            this.comboBox_filtro_criterio.Location = new System.Drawing.Point(284, 351);
            this.comboBox_filtro_criterio.Name = "comboBox_filtro_criterio";
            this.comboBox_filtro_criterio.Size = new System.Drawing.Size(121, 21);
            this.comboBox_filtro_criterio.TabIndex = 11;
            // 
            // label_filtro_criterio
            // 
            this.label_filtro_criterio.AutoSize = true;
            this.label_filtro_criterio.Location = new System.Drawing.Point(212, 354);
            this.label_filtro_criterio.Name = "label_filtro_criterio";
            this.label_filtro_criterio.Size = new System.Drawing.Size(39, 13);
            this.label_filtro_criterio.TabIndex = 12;
            this.label_filtro_criterio.Text = "Criterio";
            this.label_filtro_criterio.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox_filtro_campo
            // 
            this.comboBox_filtro_campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filtro_campo.FormattingEnabled = true;
            this.comboBox_filtro_campo.Location = new System.Drawing.Point(73, 351);
            this.comboBox_filtro_campo.Name = "comboBox_filtro_campo";
            this.comboBox_filtro_campo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_filtro_campo.TabIndex = 13;
            this.comboBox_filtro_campo.SelectedIndexChanged += new System.EventHandler(this.comboBox_filtro_campo_SelectedIndexChanged);
            // 
            // textBox_filtro_avanzado
            // 
            this.textBox_filtro_avanzado.Location = new System.Drawing.Point(504, 349);
            this.textBox_filtro_avanzado.Name = "textBox_filtro_avanzado";
            this.textBox_filtro_avanzado.Size = new System.Drawing.Size(100, 20);
            this.textBox_filtro_avanzado.TabIndex = 14;
            this.textBox_filtro_avanzado.TextChanged += new System.EventHandler(this.textBox_filtro_avanzado_TextChanged);
            // 
            // label_filtro_avanzado
            // 
            this.label_filtro_avanzado.AutoSize = true;
            this.label_filtro_avanzado.Location = new System.Drawing.Point(435, 354);
            this.label_filtro_avanzado.Name = "label_filtro_avanzado";
            this.label_filtro_avanzado.Size = new System.Drawing.Size(29, 13);
            this.label_filtro_avanzado.TabIndex = 15;
            this.label_filtro_avanzado.Text = "Filtro";
            this.label_filtro_avanzado.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.label_filtro_avanzado);
            this.Controls.Add(this.textBox_filtro_avanzado);
            this.Controls.Add(this.comboBox_filtro_campo);
            this.Controls.Add(this.label_filtro_criterio);
            this.Controls.Add(this.comboBox_filtro_criterio);
            this.Controls.Add(this.label_filtro_campo);
            this.Controls.Add(this.button_filtro);
            this.Controls.Add(this.textBox_filtro_rapido);
            this.Controls.Add(this.label_filtro_rapido);
            this.Controls.Add(this.button_Agregar);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button1_eliminarFisico);
            this.Controls.Add(this.button1_eliminarLogico);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.pb_Articulos);
            this.Controls.Add(this.dgv_Articulos);
            this.MaximumSize = new System.Drawing.Size(950, 500);
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Articulos;
        private System.Windows.Forms.PictureBox pb_Articulos;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.Button button1_eliminarFisico;
        private System.Windows.Forms.Button button1_eliminarLogico;
        private System.Windows.Forms.Label label_filtro_rapido;
        private System.Windows.Forms.TextBox textBox_filtro_rapido;
        private System.Windows.Forms.Button button_filtro;
        private System.Windows.Forms.Label label_filtro_campo;
        private System.Windows.Forms.ComboBox comboBox_filtro_criterio;
        private System.Windows.Forms.Label label_filtro_criterio;
        private System.Windows.Forms.ComboBox comboBox_filtro_campo;
        private System.Windows.Forms.TextBox textBox_filtro_avanzado;
        private System.Windows.Forms.Label label_filtro_avanzado;
    }
}