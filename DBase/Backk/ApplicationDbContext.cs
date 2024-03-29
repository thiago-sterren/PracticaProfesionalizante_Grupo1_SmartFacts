﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backk
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CelularNuevo> CelusNuevos { get; set; }
        public DbSet<CelularUsado> CelusUsados { get; set; }
        public DbSet<Notebook> Notebooks { get; set; }
        public DbSet<Administrador> Admins { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Cliente> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-767BTASL;database=SmartFacts3;trusted_connection=true;Encrypt=False");
        }
    }
}
