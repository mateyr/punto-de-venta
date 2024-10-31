using Microsoft.EntityFrameworkCore;
using punto_de_venta.Context;
using punto_de_venta.DTOs;
using punto_de_venta.Models;

namespace punto_de_venta.Controllers
{
    public class ProductoController
    {
        readonly PuntoDeVentaContext dbContext;

        public ProductoController(PuntoDeVentaContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Producto> GetProductos()
        {
            return dbContext.Productos.Include(p => p.Category)
                            .Select(prod => new Producto
                            {
                                ProductoId = prod.ProductoId,
                                Nombre = prod.Nombre,
                                Cantidad = prod.Cantidad,
                                CategoryId = prod.CategoryId,
                                CategoryName = prod.Category.Name,
                                Descripcion = prod.Descripcion!
                            }).ToList();
        }

        public bool Crear(Producto producto)
        {
            dbContext.Productos.Add(producto);
            return dbContext.SaveChanges() > 0;
        }

        public bool Actualizar(Producto producto)
        {
            dbContext.Entry(producto).State = EntityState.Modified;
            return dbContext.SaveChanges() > 0;
        }

        public Producto encontrar(int ProductoID)
        {
            return dbContext.Productos.Find(ProductoID)!;
        }

        public bool eliminar(Producto producto)
        {
            dbContext.Productos.Remove(producto);
            return dbContext.SaveChanges() > 0;
        }

        public void Detached(Producto Producto)
        {
            dbContext.Entry(Producto).State = EntityState.Detached;
        }
    }
}
