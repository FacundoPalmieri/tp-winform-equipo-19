using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo>Listar()
        {
           List<Articulo> Lista = new List<Articulo>();
           AccesoDatos datos = new AccesoDatos();   

            try
            {

                datos.SetearConsulta("SELECT A.Codigo, A.Nombre, A.Descripcion, M.Descripcion As Marca, I.ImagenUrl, A.Precio, C.Descripcion As Categoria from ARTICULOS A left join MARCAS M on A.IdMarca = M.Id left join CATEGORIAS C on A.IdCategoria = C.Id  left join IMAGENES I on I.IdArticulo = A.Id");
                datos.EjecutarConsulta();

                while (datos.lector.Read())
                {
                    Articulo Aux = new Articulo();
                    Aux.CodigoArticulo = (string)datos.lector["Codigo"];
                    Aux.Nombre = (string)datos.lector["Nombre"];
                    Aux.Descripcion = (string)datos.lector["Descripcion"];
                    Aux.marca = new Marca();
                    Aux.marca.Descripcion = (string)datos.lector["Marca"];
                    Aux.Imagen = (string)datos.lector["ImagenUrl"];
                    Aux.Precio = (decimal) datos.lector["Precio"];
                    Aux.categoria = new Categoria();

                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Categoria"))))
                    {
                        Aux.categoria.Descripcion = (string)datos.lector["Categoria"];
                    }
                    else
                    {
                        Aux.categoria.Descripcion = "";
                    }

                    Lista.Add(Aux);   
                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }

        public void Agregar (Articulo Nuevo)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetearConsulta("Insert into Articulos(Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) values('" + Nuevo.CodigoArticulo + "', '" + Nuevo.Nombre + "', '" + Nuevo.Descripcion + "', '" + Nuevo.Precio + "',@IdMarca,@IdCategoria)");
                Datos.SetearParametro("@IdMarca", Nuevo.marca.Id);
                Datos.SetearParametro("@IdCategoria", Nuevo.categoria.Id);
                Datos.EjectuarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }

    }
}
