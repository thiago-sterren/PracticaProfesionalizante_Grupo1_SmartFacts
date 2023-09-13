using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Smart_Facts
{
    public class CelularNuevo : Producto
    {
        public string garantia { get; set; }
        public CelularNuevo(int ID_producto, string Marca_producto, string Nombre_producto, int Stock, double Precio, double Almacenamiento, Proveedor Cuit_prov_producto, string Garantia) : base(ID_producto, Marca_producto, Nombre_producto, Stock, Precio, Almacenamiento, Cuit_prov_producto)
        {
            this.garantia = Garantia;
        }
    }
}
