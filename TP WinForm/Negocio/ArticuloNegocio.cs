using System;
using System.Collections;
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

                datos.SetearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id As IdMarca, M.Descripcion As Marca, I.IdArticulo as IdImagen, I.ImagenUrl, A.Precio, C.Id As IdCategoria, C.Descripcion As Categoria from ARTICULOS A left join MARCAS M on A.IdMarca = M.Id left join CATEGORIAS C on A.IdCategoria = C.Id  left join IMAGENES I on I.IdArticulo = A.Id");
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

                    Aux.imagen = new Imagen();
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("ImagenUrl"))))
                    {
                        Aux.imagen.ImagenUrl = (string)datos.lector["ImagenUrl"];
                        Aux.imagen.IdCodigoArticulo = (int)datos.lector["IdImagen"];
                    }
                    else
                    {
                        Aux.imagen.ImagenUrl = "";
                        Aux.imagen.IdCodigoArticulo = Aux.Id;
                        
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
                Datos.SetearConsulta("Insert into ARTICULOS(Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) values('" + Nuevo.CodigoArticulo + "', '" + Nuevo.Nombre + "', '" + Nuevo.Descripcion + "', '" + Nuevo.Precio + "' ,@IdMarca,@IdCategoria)");
                Datos.SetearParametro("@IdMarca", Nuevo.marca.Id);
                Datos.SetearParametro("@IdCategoria", Nuevo.categoria.Id);
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

        public void Modificar(Articulo articulo)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetearConsulta("update ARTICULOS set Codigo = @CodigoArticulo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio, IdArticulo = @IdImagen where Id = @Id");
                Datos.SetearParametro("@CodigoArticulo", articulo.CodigoArticulo);
                Datos.SetearParametro("@Nombre", articulo.Nombre);
                Datos.SetearParametro("@Descripcion", articulo.Descripcion);
                Datos.SetearParametro("@IdMarca", articulo.marca.Id);
                Datos.SetearParametro("@IdCategoria", articulo.categoria.Id);
                Datos.SetearParametro("@Precio", articulo.Precio);
                Datos.SetearParametro("@IdImagen", articulo.imagen.Id);
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

        public int BuscarId(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearConsulta("SELECT Id from Articulos");
            datos.EjecutarConsulta();

            int IdArticulo_Buscar = 0;


            while (datos.lector.Read())
            {

                IdArticulo_Buscar = Convert.ToInt32(datos.lector["Id"]);

            }

            datos.CerrarConexion();

            return IdArticulo_Buscar;

        }

    }
}
