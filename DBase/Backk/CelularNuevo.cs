using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backk
{
    public class CelularNuevo : Producto
    {
        public string garantia { get; set; }
        public CelularNuevo(int id, string marca_producto, string nombre_producto, int stock, double precio, double almacenamiento, string garantia) : base(id, marca_producto, nombre_producto, stock, precio, almacenamiento)
        {
            this.garantia = garantia;
        }
    }
}
