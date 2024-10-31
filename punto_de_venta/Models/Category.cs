using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace punto_de_venta.Models
{
    public class Category

    {
        public int CategoryId { get; set; }

        public required string Name { get; set; }

        public virtual ObservableCollectionListSource<Producto> Productos { get; } = new();
    }
}
