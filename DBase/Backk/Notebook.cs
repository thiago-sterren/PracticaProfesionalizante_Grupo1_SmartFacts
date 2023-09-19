using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backk
{
    public class Notebook : Producto
    {
        public string idioma_teclado { get; set; }
        public double cm_alto { get; set; }
        public double cm_ancho { get; set; }
        public Notebook(int id, string marca_producto, string nombre_producto, int stock, double precio, double almacenamiento, string idioma_teclado, double cm_alto, double cm_ancho) : base(id, marca_producto, nombre_producto, stock, precio, almacenamiento)
        {
            this.idioma_teclado = idioma_teclado;
            this.cm_alto = cm_alto;
            this.cm_ancho = cm_ancho;
        }
    }
}
