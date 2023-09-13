using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_App
{
    public partial class AltaArticulo : Form
    {
        private Articulo articulo = null;
        public AltaArticulo()
        {
            InitializeComponent();
            Text = "Alta Artículo";
        }

        public AltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }
        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                
                articulo.CodigoArticulo = textBox_Codigo.Text;
                articulo.Nombre = textBox_Nombre.Text;
                articulo.Descripcion = textBox_Descripcion.Text;
                articulo.Precio = decimal.Parse(textBox_Precio.Text);
                articulo.marca =(Marca) comboBox_Marca.SelectedItem;
                articulo.categoria = (Categoria)comboBox_Categoria.SelectedItem;


                if (articulo.Id != 0)
                {
                    negocio.Modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }

                else
                {
                    negocio.Agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void AltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                comboBox_Marca.DataSource = marcaNegocio.listar();
                comboBox_Marca.ValueMember = "Id";
                comboBox_Marca.DisplayMember = "Descripcion";

                comboBox_Categoria.DataSource = categoriaNegocio.listar();
                comboBox_Categoria.ValueMember = "Id";
                comboBox_Categoria.DisplayMember = "Descripcion";

                if (articulo != null )
                {
                    textBox_Codigo.Text = articulo.CodigoArticulo;
                    textBox_Nombre.Text = articulo.Nombre;
                    textBox_Descripcion.Text = articulo.Descripcion;
                    textBox_Precio.Text = articulo.Precio.ToString();
                    comboBox_Marca.SelectedValue = articulo.marca.Id;
                    comboBox_Categoria.SelectedValue = articulo.categoria.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
