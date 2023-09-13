using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Smart_Facts
{
    public class CelularUsado : Producto
    {
        public string detalles { get; set; }
        public string uso { get; set; }
        public string estado { get; set; }
        public CelularUsado(int ID_producto, string Marca_producto, string Nombre_producto, int Stock, double Precio, double Almacenamiento, Proveedor Cuit_prov_producto, string Detalles, string Uso, string Estado) : base(ID_producto, Marca_producto, Nombre_producto, Stock, Precio, Almacenamiento, Cuit_prov_producto)
        {
            this.detalles = Detalles;
            this.uso = Uso;
            this.estado = Estado;
        }
    }
}
