using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string  Marca { get; set; }
        public string Imagen { get; set; }
        public decimal Precio { get; set; }
        public Categoria Tipo { get; set; }


    }
}
