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

            comboBox_filtro_campo.Items.Add("Código Artículo");
            comboBox_filtro_campo.Items.Add("Nombre");
            comboBox_filtro_campo.Items.Add("Descripción");
            comboBox_filtro_campo.Items.Add("Marca");
            comboBox_filtro_campo.Items.Add("Categoría");
            comboBox_filtro_campo.Items.Add("Precio");

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
               ocultarColumnas();
               CargarImagen(ListaArticulo[0].imagen.ImagenUrl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            if (dgv_Articulos.CurrentRow != null) //se verifica porque entra en conflicto con SelectionChanged
            {
                dgv_Articulos.Columns["Id"].Visible = false;
                dgv_Articulos.Columns["Imagen"].Visible = false;

            }
        }

        private void dgv_Articulos_SelectionChanged(object sender, EventArgs e)
        {
          if (dgv_Articulos.CurrentRow != null) 
           {
                Articulo Seleccionado = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;
                CargarImagen(Seleccionado.imagen.ImagenUrl);
           }
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

        private void button1_eliminarFisico_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminarlo?","Eliminando",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.Id);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool validarFiltro()
        {
            if (comboBox_filtro_campo.SelectedIndex < 0) 
            {
                MessageBox.Show("Seleccione un campo a Filtrar");
                return true;
            }

            if (comboBox_filtro_criterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un campo a Filtrar");
                return true;
            }

            if (textBox_filtro_avanzado.Text == "")
            {
                MessageBox.Show("Indique un valor a filtrar");
                return true;
            }
            if (comboBox_filtro_campo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(textBox_filtro_avanzado.Text)) //verifica que no esté vacío
                {
                    MessageBox.Show("Cargar un valor a filtrar");
                    return true;
                }

                if (!(soloNumeros(textBox_filtro_avanzado.Text))) //verifica que no sean letras
                {
                    MessageBox.Show("Sólo números permitidos");
                    return true;
                }
            }

            
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;

        }


        private void button_filtro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarFiltro())
                    return; //si da false, termina la función sin realizar el filtro

                string campo = comboBox_filtro_campo.SelectedItem.ToString();
                string criterio = comboBox_filtro_criterio.SelectedItem.ToString();
                string filtro = textBox_filtro_avanzado.Text;
                dgv_Articulos.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void textBox_filtro_rapido_KeyPress(object sender, EventArgs e)
        {

        }

        private void textBox_filtro_rapido_TextChanged(object sender, EventArgs e) //permite filtras automáticamente, sin necesidad de botón buscar
        {
            List<Articulo> listaFiltrada;
            string filtro = textBox_filtro_rapido.Text; //articulo a buscar

            if (filtro.Length >= 3) //filtra a partir de 3 caracteres
            {                                        //x => es un for (foreach), contains es para buscar el artículo que contenga algo de lo que paso por filtro
                listaFiltrada = ListaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.CodigoArticulo.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.categoria.Descripcion.ToUpper().Contains(filtro.ToUpper())); //ToUpper convierte todo en mayúscula, para que filtre indistintamente por minúscula y mayúscula
            }
            else
            {
                listaFiltrada = ListaArticulo;
            }

            dgv_Articulos.DataSource = null; //primero lo limpiamos
            dgv_Articulos.DataSource = listaFiltrada; //le sobreescribimos la lista pero filtrada
            ocultarColumnas();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox_filtro_campo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBox_filtro_campo.SelectedItem.ToString();

            switch (opcion)
            {
                case "Código Artículo":

                    comboBox_filtro_criterio.Items.Clear();
                    comboBox_filtro_criterio.Items.Add("Comienza con ");
                    comboBox_filtro_criterio.Items.Add("Termina con ");
                    comboBox_filtro_criterio.Items.Add("Contiene ");

                    break;
                
                case "Nombre":

                    comboBox_filtro_criterio.Items.Clear();
                    comboBox_filtro_criterio.Items.Add("Comienza con ");
                    comboBox_filtro_criterio.Items.Add("Termina con ");
                    comboBox_filtro_criterio.Items.Add("Contiene ");

                    break;

                case "Descripción":

                    comboBox_filtro_criterio.Items.Clear();
                    comboBox_filtro_criterio.Items.Add("Comienza con ");
                    comboBox_filtro_criterio.Items.Add("Termina con ");
                    comboBox_filtro_criterio.Items.Add("Contiene ");

                    break;

                case "Marca":

                    comboBox_filtro_criterio.Items.Clear();
                    comboBox_filtro_criterio.Items.Add("Comienza con ");
                    comboBox_filtro_criterio.Items.Add("Termina con ");
                    comboBox_filtro_criterio.Items.Add("Contiene ");

                    break;

                case "Categoría":

                    comboBox_filtro_criterio.Items.Clear();
                    comboBox_filtro_criterio.Items.Add("Comienza con ");
                    comboBox_filtro_criterio.Items.Add("Termina con ");
                    comboBox_filtro_criterio.Items.Add("Contiene ");
                    break;

                case "Precio":

                    comboBox_filtro_criterio.Items.Clear();
                    comboBox_filtro_criterio.Items.Add("Menor a ");
                    comboBox_filtro_criterio.Items.Add("Mayor a ");
            

                    break;

            }
        }

        private void textBox_filtro_avanzado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
