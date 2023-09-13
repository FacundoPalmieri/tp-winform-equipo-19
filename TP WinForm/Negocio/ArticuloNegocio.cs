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

                datos.SetearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id As IdMarca, M.Descripcion As Marca, I.ImagenUrl, A.Precio, C.Id As IdCategoria, C.Descripcion As Categoria from ARTICULOS A left join MARCAS M on A.IdMarca = M.Id left join CATEGORIAS C on A.IdCategoria = C.Id  left join IMAGENES I on I.IdArticulo = A.Id");
                datos.EjecutarConsulta();

                while (datos.lector.Read())
                {
                    Articulo Aux = new Articulo();
                    Aux.Id = (int)datos.lector["Id"];
                    Aux.CodigoArticulo = (string)datos.lector["Codigo"];
                    Aux.Nombre = (string)datos.lector["Nombre"];
                    Aux.Descripcion = (string)datos.lector["Descripcion"];
                    Aux.marca = new Marca();
                    Aux.marca.Id = (int)datos.lector["IdMarca"]; 
                    Aux.marca.Descripcion = (string)datos.lector["Marca"];

                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("ImagenUrl"))))
                    {
                       Aux.Imagen = (string)datos.lector["ImagenUrl"];

                    }
                    Aux.Precio = (decimal) datos.lector["Precio"];
                    Aux.categoria = new Categoria();
                    

                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Categoria"))))
                    {
                        Aux.categoria.Descripcion = (string)datos.lector["Categoria"];
                        Aux.categoria.Id = (int)datos.lector["IdCategoria"];
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

        public void Modificar(Articulo articulo)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetearConsulta("update ARTICULOS set Codigo = @CodigoArticulo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio where Id = @Id");
                Datos.SetearParametro("@CodigoArticulo", articulo.CodigoArticulo);
                Datos.SetearParametro("@Nombre", articulo.Nombre);
                Datos.SetearParametro("@Descripcion", articulo.Descripcion);
                Datos.SetearParametro("@IdMarca", articulo.marca.Id);
                Datos.SetearParametro("@IdCategoria", articulo.categoria.Id);
                Datos.SetearParametro("@Precio", articulo.Precio);
                Datos.SetearParametro("@Id", articulo.Id);

                Datos.EjectuarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                Datos.CerrarConexion();
                
            }
        }

    }
}
