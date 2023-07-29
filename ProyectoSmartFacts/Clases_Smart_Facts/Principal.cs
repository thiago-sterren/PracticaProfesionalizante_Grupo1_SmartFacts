using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Smart_Facts
{
    public class Principal
    {
        public List<Cliente> lista_clientes { get; set; } = new List<Cliente>();
        public List<Pedido> lista_pedidos { get; set; } = new List<Pedido>();
        public List<Producto> lista_productos { get; set; } = new List<Producto>();
        public void AltaCliente(Cliente cliente)
        {
            lista_clientes.Add(cliente);
        }
        public void BajaCliente(Cliente cliente)
        {
            lista_clientes.Remove(cliente);
        }
        public void ModificacionCliente(Cliente cliente, int DNI, string Nombre, string Apellido, string Contrasenia)
        {
            cliente.dni = DNI;
            cliente.nombre = Nombre;
            cliente.apellido = Apellido;
            cliente.contrasenia = Contrasenia;
        }
        public void AltaPedido(Pedido pedido)
        {
            lista_pedidos.Add(pedido);
        }
        public void BajaPedido(Pedido pedido)
        {
            lista_pedidos.Remove(pedido);
        }
        public void ModificacionPedido(Pedido pedido, DateTime Fecha_Pedido, int Cantidad_Productos, int ID_Pedido, Cliente ID_Cliente_Pedido, Producto ID_Producto_Pedido)
        {
            pedido.fecha_pedido = Fecha_Pedido;
            pedido.cantidad_productos = Cantidad_Productos;
            pedido.id_pedido = ID_Pedido;
            pedido.id_cliente_pedido = ID_Cliente_Pedido;
            pedido.id_producto_pedido = ID_Producto_Pedido;
        }
        public void AltaProducto(Producto producto)
        {
            lista_productos.Add(producto);
        }
        public void BajaProducto(Producto producto)
        {
            lista_productos.Remove(producto);
        }
        public void ModificacionProducto(Producto producto, int ID_Producto, string Nombre_Producto, int Stock, string Marca_Producto, Proveedor CUIT_Prov_Producto)
        {
            producto.id_producto = ID_Producto;
            producto.nombre_producto = Nombre_Producto;
            producto.stock = Stock;
            producto.marca_producto = Marca_Producto;
            producto.cuit_prov_producto = CUIT_Prov_Producto;
        }

    }
}
