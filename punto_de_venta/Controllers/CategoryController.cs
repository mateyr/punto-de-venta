using punto_de_venta.Context;
using punto_de_venta.Models;

namespace punto_de_venta.Controllers
{
    public class CategoryController
    {
        readonly PuntoDeVentaContext dbContext;

        public CategoryController(PuntoDeVentaContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Category> GetCategories()
        {
            return dbContext.Categories
                              .Select(c => new Category { CategoryId = c.CategoryId, Name = c.Name })
                              .ToList();
        }
    }
}
