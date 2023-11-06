
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backk
{
    public class Pedido
    {
        public int id { get; set; }
        public DateTime fecha_pedido { get; set; }
        public int cantidad_productos { get; set; }
        public List<PedidoProducto>? productos { get; set; }
        public Cliente cliente { get; set; }
    }
}
