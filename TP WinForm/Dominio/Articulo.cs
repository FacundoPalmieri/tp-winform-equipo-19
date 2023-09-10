using System;
using System.Collections.Generic;
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
        public int Marca { get; set; }
        public int Categoria { get; set; }
        public string Imagen { get; set; }
        public decimal Precio { get; set; }
    }
}
