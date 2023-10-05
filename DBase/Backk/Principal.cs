using Backk;

namespace Backk
{
    public class Principal
    {
        ApplicationDbContext context = new ApplicationDbContext(); // instancia de la bd
        public List<Cliente> DevolverListaClientes()
        {
            return context.Clientes.ToList();
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
        public void AltaCliente(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }
        public void BajaCliente(Cliente cliente)
        {
            context.Clientes.Remove(cliente);
            context.SaveChanges();
        }
        public void ModificacionCliente(Cliente cliente_viejo, Cliente cliente_nuevo)
        {
            context.Clientes.Remove(cliente_viejo);
            context.Clientes.Add(cliente_nuevo);
            context.SaveChanges();
        }
        /*public void AltaPedido(Pedido pedido)
        {
            context.Pedidos.Add(pedido);
            context.SaveChanges();
        }
        public void BajaPedido(Pedido pedido)
        {
            context.Pedidos.Remove(pedido);
            context.SaveChanges();
        }
        public void ModificacionPedido(Pedido pedido_viejo, Pedido pedido_nuevo)
        {
            context.Pedidos.Remove(pedido_viejo);
            context.Pedidos.Add(pedido_nuevo);
            context.SaveChanges();
        }*/
        public void AltaCeluNuevo(CelularNuevo celu)
        {
            context.CelusNuevos.Add(celu);
            context.SaveChanges();
        }
        public void BajaCeluNuevo(CelularNuevo celu)
        {
            context.CelusNuevos.Remove(celu);
            context.SaveChanges();
        }
        public void ModificacionCeluNuevo(CelularNuevo celu_eliminado, CelularNuevo celu_agregado)
        {
            context.CelusNuevos.Remove(celu_eliminado);
            context.CelusNuevos.Add(celu_agregado);
            context.SaveChanges();
        }
        public void AltaCeluUsado(CelularUsado celu)
        {
            context.CelusUsados.Add(celu);
            context.SaveChanges();
        }
        public void BajaCeluUsado(CelularUsado celu)
        {
            context.CelusUsados.Remove(celu);
            context.SaveChanges();
        }
        public void ModificacionCeluUsado(CelularUsado celu_eliminado, CelularUsado celu_agregado)
        {
            context.CelusUsados.Remove(celu_eliminado);
            context.CelusUsados.Add(celu_agregado);
            context.SaveChanges();
        }
        public void AltaNotebook(Notebook note)
        {
            context.Notebooks.Add(note);
            context.SaveChanges();

        }
        public void BajaNotebook(Notebook note)
        {
            context.Notebooks.Remove(note);
            context.SaveChanges();
        }
        public void ModificacionNotebook(Notebook note_eliminada, Notebook note_agregada)
        {
            context.Notebooks.Remove(note_eliminada);
            context.Notebooks.Add(note_agregada);
            context.SaveChanges();
        }
    }
}