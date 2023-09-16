namespace Winform_App
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.button_Comenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Comenzar
            // 
            this.button_Comenzar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Comenzar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Comenzar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Comenzar.ForeColor = System.Drawing.Color.Black;
            this.button_Comenzar.Location = new System.Drawing.Point(297, 379);
            this.button_Comenzar.Name = "button_Comenzar";
            this.button_Comenzar.Size = new System.Drawing.Size(341, 70);
            this.button_Comenzar.TabIndex = 1;
            this.button_Comenzar.Text = "Comenzar  =)";
            this.button_Comenzar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Comenzar.UseVisualStyleBackColor = false;
            this.button_Comenzar.Click += new System.EventHandler(this.button_Comenzar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.button_Comenzar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(950, 500);
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Bienvenido_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Comenzar;
    }
}

