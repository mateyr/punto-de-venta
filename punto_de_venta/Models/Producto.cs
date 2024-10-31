using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace punto_de_venta.Models
{
    [Index(nameof(Nombre), IsUnique = true)]
    public class Producto
    {
        public int ProductoId { get; set; }
        [Required]
        public required string Nombre { get; set; }
        [Range(1, 1000, ErrorMessage = "La cantidad debe ser mayor que cero.")]
        public int Cantidad { get; set; }
        public string? Descripcion { get; set; }
        public int CategoryId { get; set; }
        [NotMapped]
        public string CategoryName { get; set; } = null!;
        public virtual Category Category { get; set; } = null!;
        public ICollection<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();
    }
}
