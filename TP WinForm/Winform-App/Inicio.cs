using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Winform_App
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Bienvenido_Load(object sender, EventArgs e)
        {

        }

        private void button_Comenzar_Click(object sender, EventArgs e)
        {
            Menu Ventana = new Menu();
            Ventana.MdiParent = this;
            Ventana.Show();
            button_Comenzar.Visible= false;
            
           
     
                    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
