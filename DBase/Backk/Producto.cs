﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backk
{
    public class Producto
    {
        public int id { get; set; }
        public string marca_producto { get; set; }
        public string nombre_producto { get; set; }
        public int stock { get; set; } = 0;
        public enum DispStock
        {
            Disponible, NoDisponible
        }
        public DispStock disponibilidad { get; set; } = DispStock.NoDisponible;
        public double precio { get; set; }
        public double almacenamiento { get; set; }
        public Producto(string marca_producto, string nombre_producto, double precio, double almacenamiento)
        {
            this.marca_producto = marca_producto;
            this.nombre_producto = nombre_producto;
            this.disponibilidad = disponibilidad;
            this.precio = precio;
            this.almacenamiento = almacenamiento;
        }
    }
}
