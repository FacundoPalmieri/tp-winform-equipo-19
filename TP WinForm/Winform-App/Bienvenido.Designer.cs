namespace Winform_App
{
    partial class Bienvenido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenido));
            this.button_Comenzar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Comenzar
            // 
            this.button_Comenzar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Comenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Comenzar.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_Comenzar.Location = new System.Drawing.Point(380, 267);
            this.button_Comenzar.Name = "button_Comenzar";
            this.button_Comenzar.Size = new System.Drawing.Size(130, 32);
            this.button_Comenzar.TabIndex = 1;
            this.button_Comenzar.Text = "Comenzar  =)";
            this.button_Comenzar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox1.Location = new System.Drawing.Point(365, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 41);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Bienvenid@";
            // 
            // Bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(894, 365);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Comenzar);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(910, 404);
            this.MinimumSize = new System.Drawing.Size(910, 404);
            this.Name = "Bienvenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Comenzar;
        private System.Windows.Forms.TextBox textBox1;
    }
}

