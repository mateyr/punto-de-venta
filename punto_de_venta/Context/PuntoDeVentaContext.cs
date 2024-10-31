using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using punto_de_venta.Models;
using System.ComponentModel.DataAnnotations;

namespace punto_de_venta.Context
{
    public class PuntoDeVentaContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<VentaDetalle> VentaDetalles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=Tv-236;Initial Catalog=punto_de_venta;Integrated Security=True; TrustServerCertificate=true;", options => options.EnableRetryOnFailure(maxRetryCount: 2,
                    maxRetryDelay: System.TimeSpan.FromSeconds(5),
                    errorNumbersToAdd: null))
            .LogTo(Console.WriteLine, LogLevel.Information);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Cheese" },
                new Category { CategoryId = 2, Name = "Meat" },
                new Category { CategoryId = 3, Name = "Fish" },
                new Category { CategoryId = 4, Name = "Bread" });

            modelBuilder.Entity<Producto>().HasData(
                new Producto { ProductoId = 2, CategoryId = 1, Nombre = "Brie", Cantidad = 100, Descripcion = "Producto de Prueba" },
                new Producto { ProductoId = 3, CategoryId = 1, Nombre = "Stilton", Cantidad = 100, Descripcion = "Producto de Prueba" });
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            var serviceProvider = this.GetService<IServiceProvider>();
            var items = new Dictionary<object, object>();

            foreach (var entry in this.ChangeTracker.Entries().Where(e => (e.State == EntityState.Added) || (e.State == EntityState.Modified)))
            {
                var entity = entry.Entity;
                var context = new ValidationContext(entity, serviceProvider, items);
                var results = new List<ValidationResult>();

                if (Validator.TryValidateObject(entity, context, results, true) == false)
                {
                    foreach (var result in results)
                    {
                        if (result != ValidationResult.Success)
                        {
                            throw new ValidationException(result.ErrorMessage);
                        }
                    }
                }
            }

            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
    }
}

