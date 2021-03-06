// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PedidosOrdenes.DAL;

namespace PedidosOrdenes.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("PedidosOrdenes.Models.Ordenes", b =>
                {
                    b.Property<int>("OrdenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<int>("SuplidorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrdenId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("PedidosOrdenes.Models.OrdenesDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrdenId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrdenId");

                    b.ToTable("OrdenesDetalle");
                });

            modelBuilder.Entity("PedidosOrdenes.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Inventario")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Costo = 60m,
                            Descripcion = "Coca-cola 1 Litro",
                            Inventario = 100m
                        },
                        new
                        {
                            ProductoId = 2,
                            Costo = 75m,
                            Descripcion = "Choclate Negro",
                            Inventario = 50m
                        },
                        new
                        {
                            ProductoId = 3,
                            Costo = 80m,
                            Descripcion = "Galletas Maria",
                            Inventario = 70m
                        },
                        new
                        {
                            ProductoId = 4,
                            Costo = 65m,
                            Descripcion = "Leche Familiar",
                            Inventario = 20m
                        },
                        new
                        {
                            ProductoId = 5,
                            Costo = 120m,
                            Descripcion = "Pan integral",
                            Inventario = 50m
                        });
                });

            modelBuilder.Entity("PedidosOrdenes.Models.Suplidores", b =>
                {
                    b.Property<int>("SuplidorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("SuplidorId");

                    b.ToTable("Suplidores");

                    b.HasData(
                        new
                        {
                            SuplidorId = 1,
                            Nombres = "Coca-Cola"
                        },
                        new
                        {
                            SuplidorId = 2,
                            Nombres = "Nestle"
                        },
                        new
                        {
                            SuplidorId = 3,
                            Nombres = "Cortes"
                        },
                        new
                        {
                            SuplidorId = 4,
                            Nombres = "Rica"
                        },
                        new
                        {
                            SuplidorId = 5,
                            Nombres = "Yoma"
                        });
                });

            modelBuilder.Entity("PedidosOrdenes.Models.OrdenesDetalle", b =>
                {
                    b.HasOne("PedidosOrdenes.Models.Ordenes", null)
                        .WithMany("OrdenesDetalle")
                        .HasForeignKey("OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PedidosOrdenes.Models.Ordenes", b =>
                {
                    b.Navigation("OrdenesDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
