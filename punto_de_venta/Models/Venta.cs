namespace punto_de_venta.Models
{
    public class Venta
    {
        public int VentaId { get; set; }

        public decimal Total { get; set; }

        public DateTime Fecha { get; set; }

        // TODO: Client model y Vendedor Model
        public ICollection<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();
    }
}
