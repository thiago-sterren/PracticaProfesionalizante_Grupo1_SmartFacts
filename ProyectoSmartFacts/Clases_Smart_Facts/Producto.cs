using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Smart_Facts
{
    public class Producto
    {
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        public int stock { get; set; }
        public string marca_producto { get; set; }
        public Proveedor cuit_prov_producto { get; set; }
    }
}
