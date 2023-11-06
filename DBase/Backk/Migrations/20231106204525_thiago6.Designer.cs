﻿// <auto-generated />
using System;
using Backk;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backk.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231106204525_thiago6")]
    partial class thiago6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Backk.Administrador", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contrasenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("salario")
                        .HasColumnType("float");

                    b.Property<string>("usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Backk.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contrasenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Backk.Pedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("cantidad_productos")
                        .HasColumnType("int");

                    b.Property<int>("clienteid")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha_pedido")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("clienteid");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Backk.PedidoProducto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("Pedidoid")
                        .HasColumnType("int");

                    b.Property<int>("productoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Pedidoid");

                    b.HasIndex("productoid");

                    b.ToTable("PedidoProducto");
                });

            modelBuilder.Entity("Backk.Producto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("almacenamiento")
                        .HasColumnType("float");

                    b.Property<int>("disponibilidad")
                        .HasColumnType("int");

                    b.Property<string>("marca_producto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre_producto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Producto");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Producto");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Backk.CelularNuevo", b =>
                {
                    b.HasBaseType("Backk.Producto");

                    b.Property<string>("garantia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("CelularNuevo");
                });

            modelBuilder.Entity("Backk.CelularUsado", b =>
                {
                    b.HasBaseType("Backk.Producto");

                    b.Property<string>("condicion_bat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("detalles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("CelularUsado");
                });

            modelBuilder.Entity("Backk.Notebook", b =>
                {
                    b.HasBaseType("Backk.Producto");

                    b.Property<double>("cm_alto")
                        .HasColumnType("float");

                    b.Property<double>("cm_ancho")
                        .HasColumnType("float");

                    b.Property<string>("idioma_teclado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Notebook");
                });

            modelBuilder.Entity("Backk.Pedido", b =>
                {
                    b.HasOne("Backk.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("Backk.PedidoProducto", b =>
                {
                    b.HasOne("Backk.Pedido", null)
                        .WithMany("productos")
                        .HasForeignKey("Pedidoid");

                    b.HasOne("Backk.Producto", "producto")
                        .WithMany()
                        .HasForeignKey("productoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("producto");
                });

            modelBuilder.Entity("Backk.Pedido", b =>
                {
                    b.Navigation("productos");
                });
#pragma warning restore 612, 618
        }
    }
}
