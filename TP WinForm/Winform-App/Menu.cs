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
               //dgv_Articulos.Columns["Id"].Visible = false; *Ver porqué no funciona
               dgv_Articulos.Columns["Imagen"].Visible = false;
               CargarImagen(ListaArticulo[0].imagen.ImagenUrl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgv_Articulos_SelectionChanged(object sender, EventArgs e)
        {
            
          Articulo Seleccionado = (Articulo) dgv_Articulos.CurrentRow.DataBoundItem;
          CargarImagen(Seleccionado.imagen.ImagenUrl);
        }

        private void CargarImagen(string Imagen)
        {
            try
            {
               pb_Articulos.Load(Imagen);

            }
            catch (Exception ex)
            {

                pb_Articulos.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            AltaArticulo Alta = new AltaArticulo();
            Alta.ShowDialog();
            Cargar();
        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            Articulo Seleccionado;
            Seleccionado = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;
            AltaArticulo Modificar = new AltaArticulo(Seleccionado);
            Modificar.ShowDialog();
            Cargar();

        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_Articulos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
