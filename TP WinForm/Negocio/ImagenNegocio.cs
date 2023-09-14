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
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("Select IdArticulo, ImagenUrl From Imagenes");
                datos.EjecutarConsulta();

                while (datos.lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.IdCodigoArticulo = (int)datos.lector["IdArticulo"];
                    aux.ImagenUrl = (string)datos.lector["ImagenUrl"];

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
                datos.CerrarConexion();
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

    }
}
