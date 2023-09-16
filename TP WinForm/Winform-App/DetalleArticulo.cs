using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_App
{
    public partial class DetalleArticulo : Form
    {
        Articulo articulo;
        public DetalleArticulo(Articulo seleccionado)
        {
            InitializeComponent();
            this.articulo = seleccionado;
            Text = "Detalle Artículo";
        }

        private void Detalle_Load(object sender, EventArgs e)
        {
            textBox_Codigo_detalle.Text = articulo.CodigoArticulo;
            textBox_Nombre_detalle.Text = articulo.Nombre;
            textBox_Descripcion_detalle.Text = articulo.Descripcion;
            textBox_Precio_detalle.Text = articulo.Precio.ToString();
            CargarImagen(articulo.imagen.ImagenUrl);
            textBox_URLimagen_detalle.Text = articulo.imagen.ImagenUrl.ToString();
            textBox_Marca_detalle.Text = articulo.marca.Descripcion.ToString();
            textBox_Categoria_detalle.Text = articulo.categoria.Descripcion.ToString();

        }

        private void textBox_URLimagen_detalle_Leave(object sender, EventArgs e)
        {
            CargarImagen(textBox_URLimagen_detalle.Text);

        }

        private void CargarImagen(string Imagen)
        {
            try
            {
                pictureBox_Imagen_detalle.Load(Imagen);

            }
            catch (Exception ex)
            {

                pictureBox_Imagen_detalle.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        // Código a desarrollar.
        private void button_SiguienteFoto_Click(object sender, EventArgs e)
        {
            Articulo aux = new Articulo();  
            ImagenNegocio imagen = new ImagenNegocio();
            Articulo articulo = new Articulo();
            articulo.CodigoArticulo = textBox_Codigo_detalle.Text;
            aux= imagen.ProximaImagen(articulo);
            CargarImagen(aux.imagen.ImagenUrl);


            

        }
    }
}
