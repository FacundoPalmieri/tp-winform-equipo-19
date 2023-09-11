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
                datos.SetearConsulta("select Codigo, Nombre, Descripcion from ARTICULOS");
                datos.EjecutarConsulta();

                while(datos.lector.Read())
                {
                    Articulo Aux = new Articulo();
                    Aux.CodigoArticulo = (string)datos.lector["Codigo"];
                    Aux.Nombre = (string)datos.lector["Nombre"];
                    Aux.Descripcion = (string)datos.lector["Descripcion"];

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
