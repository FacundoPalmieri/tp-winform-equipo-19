using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Winform_App
{
    public partial class Menu : Form
    {
        private List<Articulo> ListaArticulo;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Cargar();
            
        }

        private void dgv_Articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Cargar()
        {
            ArticuloNegocio Negocio = new ArticuloNegocio();
            try
            {
               ListaArticulo = Negocio.Listar();
                dgv_Articulos.DataSource = ListaArticulo;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
