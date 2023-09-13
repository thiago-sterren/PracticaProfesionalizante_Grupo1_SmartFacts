using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Smart_Facts
{
    public class Notebook : Producto
    {
        public string idioma_teclado { get; set; }
        public double cm_alto { get; set; }
        public double cm_ancho { get; set; }
        public Notebook(int ID_producto, string Marca_producto, string Nombre_producto, int Stock, double Precio, double Almacenamiento, Proveedor Cuit_prov_producto, string Idioma_teclado, double CM_alto, double CM_ancho) : base(ID_producto, Marca_producto, Nombre_producto, Stock, Precio, Almacenamiento, Cuit_prov_producto)
        {
            this.idioma_teclado = Idioma_teclado;
            this.cm_alto = CM_alto;
            this.cm_ancho = CM_ancho;
        }
    }
}
