﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backk
{
    public class Producto
    {
        public int id_producto { get; set; }
        public string marca_producto { get; set; }
        public string nombre_producto { get; set; }
        public int stock { get; set; }
        public double precio { get; set; }
        public double almacenamiento { get; set; }
        public Producto(int ID_producto, string Marca_producto, string Nombre_producto, int Stock, double Precio, double Almacenamiento)
        {
            this.id_producto = ID_producto;
            this.marca_producto = Marca_producto;
            this.nombre_producto = Nombre_producto;
            this.stock = Stock;
            this.precio = Precio;
            this.almacenamiento = Almacenamiento;
        }
    }
}
