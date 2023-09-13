using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backk
{
    public class HistorialPedido
    {
        public DateTime fecha_reporte { get; set; }
        public DateTime fecha_cambio { get; set; }
        public string descrip_historial { get; set; }
        public int id_hist_pedido { get; set; }
        public Pedido id_pedido_hist { get; set; }
        public Administrador dni_adm { get; set; }
    }
}
