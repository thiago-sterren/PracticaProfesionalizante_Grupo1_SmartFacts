
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
        public Pedido(int id, DateTime fecha_pedido, int cantidad_productos, Cliente id_cliente_pedido, Producto id_producto_pedido)
        {
            this.id = id;
            this.fecha_pedido = fecha_pedido;
            this.cantidad_productos = cantidad_productos;
            this.id_cliente_pedido = id_cliente_pedido;
            this.id_producto_pedido = id_producto_pedido;
        }
    }
}
