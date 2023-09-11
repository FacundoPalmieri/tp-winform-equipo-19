using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
                datos.SetearConsulta("SELECT  A.Codigo, A.Nombre,A.Descripcion,M.Descripcion,I.ImagenUrl,A.Precio,C.Descripcion from ARTICULOS A inner join MARCAS M on A.IdMarca = M.Id inner join CATEGORIAS C on A.IdCategoria = C.Id inner join IMAGENES I on I.IdArticulo = A.Id");
                datos.EjecutarConsulta();

                while (datos.lector.Read())
                {
                    Articulo Aux = new Articulo();
                    Aux.CodigoArticulo = (string)datos.lector["Codigo"];
                    Aux.Nombre = (string)datos.lector["Nombre"];
                    Aux.Descripcion = (string)datos.lector["Descripcion"];
                    Aux.Marca = (string)datos.lector["Descripcion"];
                    Aux.Imagen = (string)datos.lector["ImagenUrl"];
                    Aux.Precio = (decimal)datos.lector["Precio"];
                    Aux.Tipo = new Categoria();
                    Aux.Tipo.Descripcion = (string) datos.lector["Descripcion"];

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

    }
}
