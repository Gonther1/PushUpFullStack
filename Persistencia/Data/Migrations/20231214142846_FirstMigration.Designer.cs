﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia.Data;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(WebApiContext))]
    [Migration("20231214142846_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Entities.Categorium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Nombre" }, "Nombre")
                        .IsUnique();

                    b.ToTable("categoria", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("IdDepartamentoFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdDepartamentoFk" }, "IdDepartamentoFk");

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("IdContactoFk")
                        .HasColumnType("int");

                    b.Property<int?>("IdDireccionFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdContactoFk" }, "IdContactoFk");

                    b.HasIndex(new[] { "IdDireccionFk" }, "IdDireccionFk");

                    b.ToTable("cliente", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Nombre" }, "Nombre")
                        .IsUnique()
                        .HasDatabaseName("Nombre1");

                    b.ToTable("color", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Contacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Telefono" }, "Telefono")
                        .IsUnique();

                    b.ToTable("contacto", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("IdPaisFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPaisFk" }, "IdPaisFk");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Detallepedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CantidadVendida")
                        .HasColumnType("int");

                    b.Property<int?>("SubTotal")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("detallepedido", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Direccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CodigoPostal")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int?>("IdCiudadFk")
                        .HasColumnType("int");

                    b.Property<string>("LineaDireccion1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LineaDireccion2")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdCiudadFk" }, "IdCiudadFk");

                    b.HasIndex(new[] { "LineaDireccion1" }, "LineaDireccion1")
                        .IsUnique();

                    b.ToTable("direccion", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Estadopedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Nombre" }, "Nombre")
                        .IsUnique()
                        .HasDatabaseName("Nombre2");

                    b.ToTable("estadopedido", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CantidadAlmacenada")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("inventario", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Pai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaPedido")
                        .HasColumnType("datetime");

                    b.Property<int?>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<int?>("IdDetallePedidoFk")
                        .HasColumnType("int");

                    b.Property<int?>("IdEstadoPedidoFk")
                        .HasColumnType("int");

                    b.Property<int?>("IdProductoFk")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdClienteFk" }, "IdClienteFk");

                    b.HasIndex(new[] { "IdDetallePedidoFk" }, "IdDetallePedidoFk");

                    b.HasIndex(new[] { "IdEstadoPedidoFk" }, "IdEstadoPedidoFk");

                    b.ToTable("pedido", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CantidadVendida")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("IdCategoriaFk")
                        .HasColumnType("int");

                    b.Property<int?>("IdColorFk")
                        .HasColumnType("int");

                    b.Property<int?>("IdInventarioFk")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoMaterialFk")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoProductoFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<double?>("PrecioUnd")
                        .HasColumnType("double");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdCategoriaFk" }, "IdCategoriaFk");

                    b.HasIndex(new[] { "IdColorFk" }, "IdColorFk");

                    b.HasIndex(new[] { "IdInventarioFk" }, "IdInventarioFk");

                    b.HasIndex(new[] { "IdTipoMaterialFk" }, "IdTipoMaterialFk");

                    b.HasIndex(new[] { "IdTipoProductoFk" }, "IdTipoProductoFk");

                    b.HasIndex(new[] { "Nombre" }, "Nombre")
                        .IsUnique()
                        .HasDatabaseName("Nombre3");

                    b.ToTable("producto", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Tipomaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Nombre" }, "Nombre")
                        .IsUnique()
                        .HasDatabaseName("Nombre4");

                    b.ToTable("tipomaterial", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Tipopago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Nombre" }, "Nombre")
                        .IsUnique()
                        .HasDatabaseName("Nombre5");

                    b.ToTable("tipopago", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Tipoproducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Nombre" }, "Nombre")
                        .IsUnique()
                        .HasDatabaseName("Nombre6");

                    b.ToTable("tipoproducto", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Transaccione", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaTransaccion")
                        .HasColumnType("datetime");

                    b.Property<int?>("IdPedidoFk")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoPagoFk")
                        .HasColumnType("int");

                    b.Property<double?>("MontoTotal")
                        .HasColumnType("double");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPedidoFk" }, "IdPedidoFk");

                    b.HasIndex(new[] { "IdTipoPagoFk" }, "IdTipoPagoFk");

                    b.ToTable("transacciones", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Ciudad", b =>
                {
                    b.HasOne("Dominio.Entities.Departamento", "IdDepartamentoFkNavigation")
                        .WithMany("Ciudads")
                        .HasForeignKey("IdDepartamentoFk")
                        .HasConstraintName("ciudad_ibfk_1");

                    b.Navigation("IdDepartamentoFkNavigation");
                });

            modelBuilder.Entity("Dominio.Entities.Cliente", b =>
                {
                    b.HasOne("Dominio.Entities.Contacto", "IdContactoFkNavigation")
                        .WithMany("Clientes")
                        .HasForeignKey("IdContactoFk")
                        .HasConstraintName("cliente_ibfk_2");

                    b.HasOne("Dominio.Entities.Direccion", "IdDireccionFkNavigation")
                        .WithMany("Clientes")
                        .HasForeignKey("IdDireccionFk")
                        .HasConstraintName("cliente_ibfk_1");

                    b.Navigation("IdContactoFkNavigation");

                    b.Navigation("IdDireccionFkNavigation");
                });

            modelBuilder.Entity("Dominio.Entities.Departamento", b =>
                {
                    b.HasOne("Dominio.Entities.Pai", "IdPaisFkNavigation")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk")
                        .HasConstraintName("departamento_ibfk_1");

                    b.Navigation("IdPaisFkNavigation");
                });

            modelBuilder.Entity("Dominio.Entities.Direccion", b =>
                {
                    b.HasOne("Dominio.Entities.Ciudad", "IdCiudadFkNavigation")
                        .WithMany("Direccions")
                        .HasForeignKey("IdCiudadFk")
                        .HasConstraintName("direccion_ibfk_1");

                    b.Navigation("IdCiudadFkNavigation");
                });

            modelBuilder.Entity("Dominio.Entities.Pedido", b =>
                {
                    b.HasOne("Dominio.Entities.Cliente", "IdClienteFkNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdClienteFk")
                        .HasConstraintName("pedido_ibfk_1");

                    b.HasOne("Dominio.Entities.Detallepedido", "IdDetallePedidoFkNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdDetallePedidoFk")
                        .HasConstraintName("pedido_ibfk_2");

                    b.HasOne("Dominio.Entities.Estadopedido", "IdEstadoPedidoFkNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdEstadoPedidoFk")
                        .HasConstraintName("pedido_ibfk_3");

                    b.Navigation("IdClienteFkNavigation");

                    b.Navigation("IdDetallePedidoFkNavigation");

                    b.Navigation("IdEstadoPedidoFkNavigation");
                });

            modelBuilder.Entity("Dominio.Entities.Producto", b =>
                {
                    b.HasOne("Dominio.Entities.Categorium", "IdCategoriaFkNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdCategoriaFk")
                        .HasConstraintName("producto_ibfk_1");

                    b.HasOne("Dominio.Entities.Color", "IdColorFkNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdColorFk")
                        .HasConstraintName("producto_ibfk_3");

                    b.HasOne("Dominio.Entities.Inventario", "IdInventarioFkNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdInventarioFk")
                        .HasConstraintName("producto_ibfk_5");

                    b.HasOne("Dominio.Entities.Tipomaterial", "IdTipoMaterialFkNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdTipoMaterialFk")
                        .HasConstraintName("producto_ibfk_4");

                    b.HasOne("Dominio.Entities.Tipoproducto", "IdTipoProductoFkNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdTipoProductoFk")
                        .HasConstraintName("producto_ibfk_2");

                    b.Navigation("IdCategoriaFkNavigation");

                    b.Navigation("IdColorFkNavigation");

                    b.Navigation("IdInventarioFkNavigation");

                    b.Navigation("IdTipoMaterialFkNavigation");

                    b.Navigation("IdTipoProductoFkNavigation");
                });

            modelBuilder.Entity("Dominio.Entities.Transaccione", b =>
                {
                    b.HasOne("Dominio.Entities.Pedido", "IdPedidoFkNavigation")
                        .WithMany("Transacciones")
                        .HasForeignKey("IdPedidoFk")
                        .HasConstraintName("transacciones_ibfk_1");

                    b.HasOne("Dominio.Entities.Tipopago", "IdTipoPagoFkNavigation")
                        .WithMany("Transacciones")
                        .HasForeignKey("IdTipoPagoFk")
                        .HasConstraintName("transacciones_ibfk_2");

                    b.Navigation("IdPedidoFkNavigation");

                    b.Navigation("IdTipoPagoFkNavigation");
                });

            modelBuilder.Entity("Dominio.Entities.Categorium", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Dominio.Entities.Ciudad", b =>
                {
                    b.Navigation("Direccions");
                });

            modelBuilder.Entity("Dominio.Entities.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Dominio.Entities.Color", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Dominio.Entities.Contacto", b =>
                {
                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("Dominio.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudads");
                });

            modelBuilder.Entity("Dominio.Entities.Detallepedido", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Dominio.Entities.Direccion", b =>
                {
                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("Dominio.Entities.Estadopedido", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Dominio.Entities.Inventario", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Dominio.Entities.Pai", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Dominio.Entities.Pedido", b =>
                {
                    b.Navigation("Transacciones");
                });

            modelBuilder.Entity("Dominio.Entities.Tipomaterial", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Dominio.Entities.Tipopago", b =>
                {
                    b.Navigation("Transacciones");
                });

            modelBuilder.Entity("Dominio.Entities.Tipoproducto", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}