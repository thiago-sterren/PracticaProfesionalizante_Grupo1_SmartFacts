
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
        public Cliente id_cliente_pedido { get; set; }
        public Producto id_producto_pedido { get; set; }
        public Producto? id_producto_pedido_2 { get; set; }
        public Producto? id_producto_pedido_3 { get; set; }
        public Producto? id_producto_pedido_4 { get; set; }
        public Producto? id_producto_pedido_5 { get; set; }
    }
}
