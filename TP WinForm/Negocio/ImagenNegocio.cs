using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetearConsulta("Select IdArticulo, ImagenUrl From Imagenes");
                Datos.EjecutarConsulta();

                while (Datos.lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.IdCodigoArticulo = (int)Datos.lector["IdArticulo"];
                    aux.ImagenUrl = (string)Datos.lector["ImagenUrl"];

                    lista.Add(aux);
                }

                return lista;
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

        public void Agregar(Articulo Nuevo, int id)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetearConsulta("Insert into IMAGENES(IdArticulo, ImagenUrl) values(@IdCodigoArticulo, @ImagenUrl)");
                Datos.SetearParametro("@IdCodigoArticulo", id);
                Datos.SetearParametro("@ImagenUrl", Nuevo.imagen.ImagenUrl);
                Datos.EjectuarAccion();
                Datos.CerrarConexion();

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

        public void Modificar(Articulo articulo, int articuloId)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {

                Datos.SetearConsulta("update IMAGENES set ImagenUrl = @ImagenUrl where IdArticulo = '" + articuloId + "'");
                Datos.SetearParametro("@ImagenUrl", articulo.imagen.ImagenUrl);


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



        public List<Articulo> ProximaImagen(Articulo articulo)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {

                Articulo aux1 = new Articulo();
                List <Articulo> articulosAux = new List<Articulo>();    
                Datos.SetearConsulta("SELECT a.Codigo, i.ImagenUrl  From ARTICULOS a inner join IMAGENES i on a.Id = i.IdArticulo order by a.Codigo");
                Datos.EjecutarConsulta();
                while (Datos.lector.Read())
                {
                    aux1.CodigoArticulo = (string)Datos.lector["Codigo"];

                    if (aux1.CodigoArticulo == articulo.CodigoArticulo )
                    {
                        Articulo aux = new Articulo();
                        aux.CodigoArticulo = articulo.CodigoArticulo;
                        aux.imagen = new Imagen();
                        aux.imagen.ImagenUrl = (string)Datos.lector["ImagenUrl"];
                        articulosAux.Add(aux);

                        
                    }

                }
                return articulosAux;
                throw new Exception("No se encontró ninguna imagen para el artículo especificado");





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
