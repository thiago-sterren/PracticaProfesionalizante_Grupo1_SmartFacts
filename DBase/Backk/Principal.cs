using Backk;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Identity.Client;

namespace Backk
{
    public class Principal
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public List<Cliente> DevolverListaClientes()
        {
            return context.Clients.ToList();
        }
        public List<CelularNuevo> DevolverListaCelusNuevos()
        {
            return context.CelusNuevos.ToList();
        }
        public List<CelularUsado> DevolverListaCelusUsados()
        {
            return context.CelusUsados.ToList();
        }
        public List<Notebook> DevolverListaNotebooks()
        {
            return context.Notebooks.ToList();
        }
        public List<Producto> DevolverListaProductos()
        {
            return context.Producto.ToList();
        }
        public List<CelularNuevo> DevolverCNCatalogo()
        {
            List<CelularNuevo> lista = new List<CelularNuevo>();
            foreach (CelularNuevo cn in context.CelusNuevos)
            {
                if (cn.disponibilidad == Producto.DispStock.Disponible)
                {
                    lista.Add(cn);
                }
            }
            return lista;
        }
        public List<CelularUsado> DevolverCUCatalogo()
        {
            List<CelularUsado> lista = new List<CelularUsado>();
            foreach (CelularUsado cu in context.CelusUsados)
            {
                if (cu.disponibilidad == Producto.DispStock.Disponible)
                {
                    lista.Add(cu);
                }
            }
            return lista;
        }
        public List<Notebook> DevolverNoteCatalogo()
        {
            List<Notebook> lista = new List<Notebook>();
            foreach (Notebook n in context.Notebooks)
            {
                if (n.disponibilidad == Producto.DispStock.Disponible)
                {
                    lista.Add(n);
                }
            }
            return lista;
        }
        public void AltaCliente(Cliente cliente)
        {
            context.Clients.Add(cliente);
            context.SaveChanges();
        }
        public void BajaCliente(Cliente cliente)
        {
            var clienteBuscado = context.Clients.Find(cliente.id);
            if (clienteBuscado != null)
            {
                context.Clients.Remove(cliente);
                context.SaveChanges();
            }
        }
        public void ModificacionCliente(Cliente clienteMod)
        {
            var clienteBuscado = context.Clients.Find(clienteMod.id);
            if (clienteBuscado != null)
            {
                clienteBuscado.nombre = clienteMod.nombre;
                clienteBuscado.contrasenia = clienteMod.contrasenia;
                clienteBuscado.apellido = clienteMod.apellido;
                clienteBuscado.usuario = clienteMod.usuario;
                context.SaveChanges();
            }
        }
        public void AltaPedido(Pedido pedido)
        {
            context.Pedidos.Add(pedido);
            context.SaveChanges();
        }
        public bool AgregarProducto(List<PedidoProducto> lista, PedidoProducto pedido_producto)
        {
            Producto producto_real = pedido_producto.producto;
            if (producto_real.disponibilidad == Producto.DispStock.Disponible)
            {
                producto_real.stock -= 1;
                if (producto_real.stock == 0)
                {
                    producto_real.disponibilidad = Producto.DispStock.NoDisponible;
                }
                lista.Add(pedido_producto);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DevolucionProductos(List<PedidoProducto> lista)
        {
            foreach (PedidoProducto pp in lista)
            {
                Producto producto_real = pp.producto;
                producto_real.stock += 1;
                if (producto_real.disponibilidad == Producto.DispStock.NoDisponible)
                {
                    producto_real.disponibilidad = Producto.DispStock.Disponible;
                }
                context.SaveChanges();
            }
        }
        public void AltaCeluNuevo(CelularNuevo celu)
        {
            context.CelusNuevos.Add(celu);
            context.SaveChanges();
        }
        public void BajaCeluNuevo(CelularNuevo celu)
        {
            var celuBuscado = context.CelusNuevos.Find(celu.id);
            if (celuBuscado != null)
            {
                context.CelusNuevos.Remove(celu);
                context.SaveChanges();
            }
        }
        public void ModificacionCeluNuevo(CelularNuevo celuMod)
        {
            var celuBuscado = context.CelusNuevos.Find(celuMod.id);
            if (celuBuscado != null)
            {
                celuBuscado.marca_producto = celuMod.marca_producto;
                celuBuscado.nombre_producto = celuMod.nombre_producto;
                celuBuscado.precio = celuMod.precio;
                celuBuscado.almacenamiento = celuMod.almacenamiento;
                celuBuscado.garantia = celuMod.garantia;
                context.SaveChanges();
            }
        }
        public void AltaCeluUsado(CelularUsado celu)
        {
            context.CelusUsados.Add(celu);
            context.SaveChanges();
        }
        public void BajaCeluUsado(CelularUsado celu)
        {
            var celuBuscado = context.CelusUsados.Find(celu.id);
            if (celuBuscado != null)
            {
                context.CelusUsados.Remove(celu);
                context.SaveChanges();
            }
        }
        public void ModificacionCeluUsado(CelularUsado celuMod)
        {
            var celuBuscado = context.CelusUsados.Find(celuMod.id);
            if (celuBuscado != null)
            {
                celuBuscado.marca_producto = celuMod.marca_producto;
                celuBuscado.nombre_producto = celuMod.nombre_producto;
                celuBuscado.precio = celuMod.precio;
                celuBuscado.almacenamiento = celuMod.almacenamiento;
                celuBuscado.detalles = celuMod.detalles;
                celuBuscado.uso = celuMod.uso;
                celuBuscado.condicion_bat = celuMod.condicion_bat;
                context.SaveChanges();
            }
        }
        public void AltaNotebook(Notebook note)
        {
            context.Notebooks.Add(note);
            context.SaveChanges();

        }
        public void BajaNotebook(Notebook note)
        {
            var noteBuscada = context.Notebooks.Find(note.id);
            if (noteBuscada != null)
            {
                context.Notebooks.Remove(noteBuscada);
                context.SaveChanges();
            }
            
        }
        public void ModNote(Notebook noteMod)
        {
            var noteBuscada = context.Notebooks.Find(noteMod.id);
            if (noteBuscada != null)
            {
                noteBuscada.marca_producto = noteMod.marca_producto;
                noteBuscada.nombre_producto = noteMod.nombre_producto;
                noteBuscada.precio = noteMod.precio;
                noteBuscada.almacenamiento = noteMod.almacenamiento;
                noteBuscada.idioma_teclado = noteMod.idioma_teclado;
                noteBuscada.cm_ancho = noteMod.cm_ancho;
                noteBuscada.cm_alto = noteMod.cm_alto;
                context.SaveChanges();
            }
        }
        public void ModStock(Producto producto, int stock)
        {
            var prodBuscado = context.Producto.Find(producto.id);
            if (prodBuscado != null)
            {
                prodBuscado.stock = stock;
                context.SaveChanges();
                if (prodBuscado.disponibilidad == Producto.DispStock.Disponible)
                {
                    if (stock == 0)
                    {
                        prodBuscado.disponibilidad = Producto.DispStock.NoDisponible;
                        context.SaveChanges();
                    }
                }
                else
                {
                    if (stock != 0)
                    {
                        prodBuscado.disponibilidad = Producto.DispStock.Disponible;
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}