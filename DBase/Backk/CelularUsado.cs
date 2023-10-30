using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backk
{
    public class CelularUsado : Producto
    {
        public string detalles { get; set; }
        public string uso { get; set; }
        public string condicion_bat { get; set; }
        public CelularUsado(string marca_producto, string nombre_producto, double precio, double almacenamiento, string detalles, string uso, string condicion_bat) : base(marca_producto, nombre_producto, precio, almacenamiento)
        {
            this.detalles = detalles;
            this.uso = uso;
            this.condicion_bat = condicion_bat;
        }
    }
}
