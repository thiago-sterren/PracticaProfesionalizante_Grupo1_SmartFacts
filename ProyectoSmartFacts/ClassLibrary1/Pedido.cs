using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pedido
    {
        public DateTime fecha_pedido { get; set; }
        public int cantidad_productos { get; set; }
        public int id_pedido { get; set; }
    }
}
