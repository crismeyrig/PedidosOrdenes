using Microsoft.EntityFrameworkCore;
using PedidosOrdenes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosOrdenes.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Suplidores> Suplidores { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data/Ordenes.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>().HasData(new Productos { ProductoId = 1, Costo = 60, Descripcion = "Coca-cola 1 Litro", Inventario = 100 });
            modelBuilder.Entity<Productos>().HasData(new Productos { ProductoId = 2, Costo = 75, Descripcion = "Choclate Negro", Inventario = 50 });
            modelBuilder.Entity<Productos>().HasData(new Productos { ProductoId = 3, Costo = 80, Descripcion = "Galletas Maria", Inventario = 70 });
            modelBuilder.Entity<Productos>().HasData(new Productos { ProductoId = 4, Costo = 65, Descripcion = "Leche Familiar", Inventario = 20 });
            modelBuilder.Entity<Productos>().HasData(new Productos { ProductoId = 5, Costo = 120, Descripcion = "Pan integral", Inventario = 50 });

            modelBuilder.Entity<Suplidores>().HasData(new Suplidores { SuplidorId = 1, Nombres = "Coca-Cola" });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores { SuplidorId = 2, Nombres = "Nestle" });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores { SuplidorId = 3, Nombres = "Cortes" });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores { SuplidorId = 4, Nombres = "Rica" });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores { SuplidorId = 5, Nombres = "Yoma" });

        }

    }
}