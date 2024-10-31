using punto_de_venta.Context;
using punto_de_venta.Controllers;

namespace punto_de_venta.Views
{
    public partial class frmVentas : Form
    {
        ProductoController ProductoController = new ProductoController(new PuntoDeVentaContext());

        public frmVentas()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.productoBindingSource.DataSource = ProductoController.GetProductos();
            
            
            rtbDescripcion.Text = ProductoController.GetProductos().ToString();
            // TODO: Paginación
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
