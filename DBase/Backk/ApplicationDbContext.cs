using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backk
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CelularNuevo> CelusNuevos{ get; set; }
        public DbSet<CelularUsado> CelusUsados { get; set; }
        public DbSet<Notebook> Notebooks { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Administrador> Admins { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-767BTASL;database=Smart_Facts;trusted_connection=true;Encrypt=False");
        }
        // public void agregarProducto (Producto producto)
    }
}
