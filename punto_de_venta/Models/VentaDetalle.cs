namespace punto_de_venta.Models
{
    public class VentaDetalle
    {
        public int VentaDetalleID { get; set; }
        public int VentaID { get; set; }
        public Venta Venta { get; set; } = null!;
        public int ProductooID { get; set; }
        public Producto Producto { get; set; } = null!;
    }
}
