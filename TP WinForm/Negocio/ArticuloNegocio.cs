<<<<<<< HEAD
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
                    Aux.Precio = (decimal) datos.lector["Precio"];
                    Aux.marca = new Marca();
                    Aux.marca.Id = (int)datos.lector["IdMarca"]; 
                    Aux.marca.Descripcion = (string)datos.lector["Marca"];
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
                Datos.SetearConsulta("update ARTICULOS set Codigo = @CodigoArticulo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio where Id = @Id");
                Datos.SetearParametro("@CodigoArticulo", articulo.CodigoArticulo);
                Datos.SetearParametro("@Nombre", articulo.Nombre);
                Datos.SetearParametro("@Descripcion", articulo.Descripcion);
                Datos.SetearParametro("@IdMarca", articulo.marca.Id);

                if (articulo.categoria != null)
                {
                    Datos.SetearParametro("@IdCategoria", articulo.categoria.Id);
                }

                else
                {
                    Datos.SetearParametro("@IdCategoria", DBNull.Value);
                }


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

        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearConsulta("delete from ARTICULOS where Id = @id");
                datos.SetearParametro("@id", id);
                datos.EjectuarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id As IdMarca, M.Descripcion As Marca, I.IdArticulo as IdImagen, I.ImagenUrl, A.Precio, C.Id As IdCategoria, C.Descripcion As Categoria from ARTICULOS A left join MARCAS M on A.IdMarca = M.Id left join CATEGORIAS C on A.IdCategoria = C.Id  left join IMAGENES I on I.IdArticulo = A.Id Where ";

                switch (campo)
                {
                    case "Código Artículo":
                        switch (criterio)
                        {
                            case "Comienza con ":
                                consulta += "A.Codigo like '" + filtro + "%' ";
                                break;

                            case "Termina con ":
                                consulta += "A.Codigo like '%" + filtro + "'";
                                break;

                            case "Contiene ":
                                consulta += "A.Codigo like '%" + filtro + "%'";
                                break;

                        }
                        break;

                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con ":
                                consulta += "A.Nombre like '" + filtro + "%' ";
                                break;

                            case "Termina con ":
                                consulta += "A.Nombre like '%" + filtro + "'";
                                break;

                            case "Contiene ":
                                consulta += "A.Nombre like '%" + filtro + "%'";
                                break;

                        }
                        break;

                    case "Descripción":
                        switch (criterio)
                        {
                            case "Comienza con ":
                                consulta += "A.Descripcion like '" + filtro + "%' ";
                                break;

                            case "Termina con ":
                                consulta += "A.Descripcion like '%" + filtro + "'";
                                break;

                            case "Contiene ":
                                consulta += "A.Descripcion like '%" + filtro + "%'";
                                break;
                           
                        }
                        break;

                    case "Categoría":
                        switch (criterio)
                        {
                            case "Comienza con ":
                                consulta += "C.Descripcion like '" + filtro + "%' ";
                                break;

                            case "Termina con ":
                                consulta += "C.Descripcion like '%" + filtro + "'";
                                break;

                            case "Contiene ":
                                consulta += "C.Descripcion like '%" + filtro + "%'";
                                break;

                        }
                        break;

                    case "Marca":
                        switch (criterio)
                        {
                            case "Comienza con ":
                                consulta += "M.Descripcion like '" + filtro + "%' ";
                                break;

                            case "Termina con ":
                                consulta += "M.Descripcion like '%" + filtro + "'";
                                break;

                            case "Contiene ":
                                consulta += "M.Descripcion like '%" + filtro + "%'";
                                break;

                        }
                        break;

                    case "Precio":
                        switch (criterio)
                        {
                            case "Menor a ":

                                consulta += "A.Precio < " + filtro;
                              
                                break;

                            case "Mayor a ":
                                
                                consulta += "A.Precio > " + filtro;
                                
                                break;
                        }
                        break;
                }

                datos.SetearConsulta(consulta);
                datos.EjecutarConsulta();

                while (datos.lector.Read())
                {
                    Articulo Aux = new Articulo();
                    Aux.Id = (int)datos.lector["Id"];
                    Aux.CodigoArticulo = (string)datos.lector["Codigo"];
                    Aux.Nombre = (string)datos.lector["Nombre"];
                    Aux.Descripcion = (string)datos.lector["Descripcion"];
                    Aux.Precio = (decimal)datos.lector["Precio"];
                    Aux.marca = new Marca();
                    Aux.marca.Id = (int)datos.lector["IdMarca"];
                    Aux.marca.Descripcion = (string)datos.lector["Marca"];
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

                    lista.Add(Aux);
                }

                    return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
=======
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
                    Aux.Precio = (decimal) datos.lector["Precio"];
                    Aux.marca = new Marca();
                    Aux.marca.Id = (int)datos.lector["IdMarca"]; 
                    Aux.marca.Descripcion = (string)datos.lector["Marca"];
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
                Datos.SetearConsulta("update ARTICULOS set Codigo = @CodigoArticulo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio where Id = @Id");
                Datos.SetearParametro("@CodigoArticulo", articulo.CodigoArticulo);
                Datos.SetearParametro("@Nombre", articulo.Nombre);
                Datos.SetearParametro("@Descripcion", articulo.Descripcion);
                Datos.SetearParametro("@IdMarca", articulo.marca.Id);

                if (articulo.categoria != null)
                {
                    Datos.SetearParametro("@IdCategoria", articulo.categoria.Id);
                }

                else
                {
                    Datos.SetearParametro("@IdCategoria", DBNull.Value);
                }


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

        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearConsulta("delete from ARTICULOS where Id = @id");
                datos.SetearParametro("@id", id);
                datos.EjectuarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id As IdMarca, M.Descripcion As Marca, I.IdArticulo as IdImagen, I.ImagenUrl, A.Precio, C.Id As IdCategoria, C.Descripcion As Categoria from ARTICULOS A left join MARCAS M on A.IdMarca = M.Id left join CATEGORIAS C on A.IdCategoria = C.Id  left join IMAGENES I on I.IdArticulo = A.Id Where ";

                switch (campo)
                {
                    case "Código Artículo":
                        switch (criterio)
                        {
                            case "Comienza con ":
                                consulta += "A.Codigo like '" + filtro + "%' ";
                                break;

                            case "Termina con ":
                                consulta += "A.Codigo like '%" + filtro + "'";
                                break;

                            case "Contiene ":
                                consulta += "A.Codigo like '%" + filtro + "%'";
                                break;

                        }
                        break;

                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con ":
                                consulta += "A.Nombre like '" + filtro + "%' ";
                                break;

                            case "Termina con ":
                                consulta += "A.Nombre like '%" + filtro + "'";
                                break;

                            case "Contiene ":
                                consulta += "A.Nombre like '%" + filtro + "%'";
                                break;

                        }
                        break;

                    case "Descripción":
                        switch (criterio)
                        {
                            case "Comienza con ":
                                consulta += "A.Descripcion like '" + filtro + "%' ";
                                break;

                            case "Termina con ":
                                consulta += "A.Descripcion like '%" + filtro + "'";
                                break;

                            case "Contiene ":
                                consulta += "A.Descripcion like '%" + filtro + "%'";
                                break;
                           
                        }
                        break;
                }

                datos.SetearConsulta(consulta);
                datos.EjecutarConsulta();

                while (datos.lector.Read())
                {
                    Articulo Aux = new Articulo();
                    Aux.Id = (int)datos.lector["Id"];
                    Aux.CodigoArticulo = (string)datos.lector["Codigo"];
                    Aux.Nombre = (string)datos.lector["Nombre"];
                    Aux.Descripcion = (string)datos.lector["Descripcion"];
                    Aux.Precio = (decimal)datos.lector["Precio"];
                    Aux.marca = new Marca();
                    Aux.marca.Id = (int)datos.lector["IdMarca"];
                    Aux.marca.Descripcion = (string)datos.lector["Marca"];
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

                    lista.Add(Aux);
                }

                    return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
>>>>>>> 8b47854438650f06fcb9d761e983e0e72f348f9e
