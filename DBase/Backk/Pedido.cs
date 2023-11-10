
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backk
{
    public class Pedido
    {
        [Key]
        public int id { get; set; }
        public DateTime fecha_pedido { get; set; }
        public int cantidad_productos { get; set; }
        public List<Producto> productos { get; set; }
        //public int clienteId { get; set; }
        public Cliente id_cliente { get; set; }
    }
}
