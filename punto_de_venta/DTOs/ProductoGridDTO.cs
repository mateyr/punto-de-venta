namespace punto_de_venta.DTOs
{
    public class ProductoGridDTO
    {
        public required int ProductoId { get; set; }
        public required string Nombre { get; set; }
        public required int Cantidad { get; set; }
        public required int CategoryId { get; set; }
        public required string CategoryName { get; set; }
        public required string Descripcion { get; set; }
    }
}
