using Backk;

namespace Backk
{
    public class Principal
    {
        ApplicationDbContext context = new ApplicationDbContext(); // instancia de la bd
        public List<Cliente> lista_clientes = new List<Cliente>();
        public List<Pedido> lista_pedidos = new List<Pedido>();
        public List<Producto> lista_productos = new List<Producto>();
        public List<Cliente> lista_clientes_hardcodeados = new List<Cliente>();
        public void AltaCliente(Cliente cliente)
        {
            lista_clientes.Add(cliente);
        }
        public void BajaCliente(Cliente cliente)
        {
            lista_clientes.Remove(cliente);
        }
        public void ModificacionCliente(Cliente cliente_viejo, Cliente cliente_nuevo)
        {
            lista_clientes.Remove(cliente_viejo);
            lista_clientes.Add(cliente_nuevo);
        }
        public void AltaPedido(Pedido pedido)
        {
            lista_pedidos.Add(pedido);
        }
        public void BajaPedido(Pedido pedido)
        {
            lista_pedidos.Remove(pedido);
        }
        public void ModificacionPedido(Pedido pedido_viejo, Pedido pedido_nuevo)
        {
            lista_pedidos.Remove(pedido_viejo);
            lista_pedidos.Add(pedido_nuevo);
        }
        public void AltaProducto(Producto producto)
        {
            lista_productos.Add(producto);
        }
        public void BajaProducto(Producto producto)
        {
            lista_productos.Remove(producto);
        }
        public void ModificacionProducto(Producto producto_viejo, Producto producto_nuevo)
        {
            lista_productos.Remove(producto_viejo);
            lista_productos.Add(producto_nuevo);
        }
        public List<Cliente> GenerarClientesHardcodeados()
        {
            Cliente cliente_1 = new Cliente(45953027, "Thiago", "Sterren", "ts2004");
            Cliente cliente_2 = new Cliente(45342920, "Fabrizio", "Failla", "ff2003");
            Cliente cliente_3 = new Cliente(45504354, "Alan", "Ferri", "af2004");
            Cliente cliente_4 = new Cliente(40928873, "Santiago", "Gutiérrez", "sg1998");
            lista_clientes_hardcodeados.Add(cliente_1);
            lista_clientes_hardcodeados.Add(cliente_2);
            lista_clientes_hardcodeados.Add(cliente_3);
            lista_clientes_hardcodeados.Add(cliente_4);
            return lista_clientes_hardcodeados;
        }
    }
}