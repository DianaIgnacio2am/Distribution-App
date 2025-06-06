﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelo;

#nullable disable

namespace Modelo.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241016232600_RefactorNombre")]
    partial class RefactorNombre
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Entidades.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categoria", (string)null);
                });

            modelBuilder.Entity("Entidades.Cliente", b =>
                {
                    b.Property<long>("Cuit")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Habilitado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Cuit");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("Entidades.DetalleFactura", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdFactura")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id", "IdFactura");

                    b.HasIndex("IdFactura");

                    b.HasIndex("ProductoId");

                    b.ToTable("DetallesFacturas", (string)null);
                });

            modelBuilder.Entity("Entidades.DetalleOrdenDeCompra", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdOrdenDeCompra")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdPresupuesto")
                        .HasColumnType("INTEGER");

                    b.Property<double>("MontoCU")
                        .HasColumnType("REAL");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id", "IdOrdenDeCompra");

                    b.HasIndex("IdOrdenDeCompra");

                    b.HasIndex("ProductoId");

                    b.ToTable("DetalleOrdenDeCompras");
                });

            modelBuilder.Entity("Entidades.DetallePresupuesto", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdPresupuesto")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<double>("MontoCUPropuesto")
                        .HasColumnType("REAL");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id", "IdPresupuesto");

                    b.HasIndex("IdPresupuesto");

                    b.HasIndex("ProductoId");

                    b.ToTable("DetallePresupuestos");
                });

            modelBuilder.Entity("Entidades.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("ClienteCuit")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<long>("IdCliente")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Total")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("ClienteCuit");

                    b.ToTable("Facturas", (string)null);
                });

            modelBuilder.Entity("Entidades.Lote", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdRemito")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantRecibida")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id", "IdRemito");

                    b.HasIndex("IdRemito");

                    b.HasIndex("ProductoId");

                    b.ToTable("Lotes");
                });

            modelBuilder.Entity("Entidades.OrdenDeCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Entregado")
                        .HasColumnType("INTEGER");

                    b.Property<long>("IdProveedor")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ProveedorCuit")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProveedorCuit");

                    b.ToTable("OrdenDeCompras");
                });

            modelBuilder.Entity("Entidades.Presupuesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Aceptado")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("INTEGER");

                    b.Property<long>("IdProveedor")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ProveedorCuit")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProveedorCuit");

                    b.ToTable("Presupuestos");
                });

            modelBuilder.Entity("Entidades.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EsPerecedero")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Habilitado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Producto");

                    b.HasDiscriminator().HasValue("Producto");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Entidades.Proveedor", b =>
                {
                    b.Property<long>("Cuit")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Habilitado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("Cuit");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("Entidades.Remito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("ProveedorCuit")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProveedorCuit");

                    b.ToTable("Remitos");
                });

            modelBuilder.Entity("ProductoCategoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoriaId", "ProductoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("ProductoCategoria");
                });

            modelBuilder.Entity("ProductoProveedor", b =>
                {
                    b.Property<long>("ProveedorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProveedorId", "ProductoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("ProductoProveedor");
                });

            modelBuilder.Entity("Entidades.ProductoNoPercedero", b =>
                {
                    b.HasBaseType("Entidades.Producto");

                    b.Property<string>("TipoDeEnvase")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("ProductoNoPercedero");
                });

            modelBuilder.Entity("Entidades.ProductoPercedero", b =>
                {
                    b.HasBaseType("Entidades.Producto");

                    b.Property<int>("MesesHastaConsumoPreferente")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MesesHastaVencimiento")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("ProductoPercedero");
                });

            modelBuilder.Entity("Entidades.DetalleFactura", b =>
                {
                    b.HasOne("Entidades.Factura", null)
                        .WithMany("Detalles")
                        .HasForeignKey("IdFactura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Entidades.DetalleOrdenDeCompra", b =>
                {
                    b.HasOne("Entidades.OrdenDeCompra", null)
                        .WithMany("detalles")
                        .HasForeignKey("IdOrdenDeCompra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Entidades.DetallePresupuesto", b =>
                {
                    b.HasOne("Entidades.Presupuesto", null)
                        .WithMany("detalles")
                        .HasForeignKey("IdPresupuesto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Entidades.Factura", b =>
                {
                    b.HasOne("Entidades.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteCuit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Entidades.Lote", b =>
                {
                    b.HasOne("Entidades.Remito", null)
                        .WithMany("Lotes")
                        .HasForeignKey("IdRemito")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Entidades.OrdenDeCompra", b =>
                {
                    b.HasOne("Entidades.Proveedor", "Proveedor")
                        .WithMany()
                        .HasForeignKey("ProveedorCuit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Entidades.Presupuesto", b =>
                {
                    b.HasOne("Entidades.Proveedor", "Proveedor")
                        .WithMany()
                        .HasForeignKey("ProveedorCuit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Entidades.Remito", b =>
                {
                    b.HasOne("Entidades.Proveedor", "Proveedor")
                        .WithMany()
                        .HasForeignKey("ProveedorCuit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("ProductoCategoria", b =>
                {
                    b.HasOne("Entidades.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Producto", null)
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductoProveedor", b =>
                {
                    b.HasOne("Entidades.Producto", null)
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Proveedor", null)
                        .WithMany()
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entidades.Factura", b =>
                {
                    b.Navigation("Detalles");
                });

            modelBuilder.Entity("Entidades.OrdenDeCompra", b =>
                {
                    b.Navigation("detalles");
                });

            modelBuilder.Entity("Entidades.Presupuesto", b =>
                {
                    b.Navigation("detalles");
                });

            modelBuilder.Entity("Entidades.Remito", b =>
                {
                    b.Navigation("Lotes");
                });
#pragma warning restore 612, 618
        }
    }
}
