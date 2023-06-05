using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class HistorialPedido : Pedido
    {
        public DateTime fecha_reporte { get; set; }
        public DateTime fecha_cambio { get; set; }
        public string descrip_historial { get; set; }
    }
}
