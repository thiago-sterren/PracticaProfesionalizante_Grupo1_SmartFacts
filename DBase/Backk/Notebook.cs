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
        public Notebook(string marca_producto, string nombre_producto, int stock, double precio, double almacenamiento, string idioma_teclado, double cm_alto, double cm_ancho) : base(marca_producto, nombre_producto, stock, precio, almacenamiento)
        {
            this.idioma_teclado = idioma_teclado;
            this.cm_alto = cm_alto;
            this.cm_ancho = cm_ancho;
        }
        public string info_list_box
        {
            get { return $"{marca_producto} {nombre_producto}. ID: {id}. Stock: {stock}. Almacenamiento: {almacenamiento}. Idioma teclado: {idioma_teclado}. Cm de altura: {cm_alto}. Cm de anchura: {cm_ancho}."; }
        }
    }
}
