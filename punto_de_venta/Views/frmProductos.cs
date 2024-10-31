using punto_de_venta.Controllers;
using punto_de_venta.Models;

namespace punto_de_venta.Views
{
    public partial class frmProductos : Form
    {
        ProductoController productoController;
        CategoryController categoryController;
        private bool esNuevo = true;

        public frmProductos(ProductoController productoController, CategoryController categoryController)
        {
            InitializeComponent();
            this.productoController = productoController;
            this.categoryController = categoryController;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.categoryBindingSource.DataSource = categoryController.GetCategories();
            this.cmbCategoria.ValueMember = "CategoryId";
            this.cmbCategoria.DisplayMember = "Name";

            this.productoGridDTOBindingSource.DataSource = productoController.GetProductos();
            // TODO: Paginación
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            esNuevo = true;
            btnGuardar.Text = "Guardar";
        }

        private void Limpiar()
        {
            txbNombre.Text = "";
            nudCantidad.Value = 0;
            cmbCategoria.SelectedIndex = 0;
            rtbDescripcion.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            productoController.eliminar((Producto)this.productoGridDTOBindingSource.Current);
            this.productoGridDTOBindingSource.DataSource = productoController.GetProductos();

            Limpiar();
            esNuevo = true;
            btnGuardar.Text = "Guardar";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                Producto Producto = new Producto
                {
                    CategoryId = (int)cmbCategoria.SelectedValue!,
                    Nombre = txbNombre.Text,
                    Cantidad = (int)nudCantidad.Value,
                    Descripcion = rtbDescripcion.Text
                };

                try
                {
                    if (productoController.Crear(Producto))
                    {
                        MessageBox.Show("Producto creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                productoController.Detached(Producto);
            }
            else
            {
                var Producto = (Producto)productoController.encontrar(((Producto)productoGridDTOBindingSource.Current).ProductoId) as Producto;

                Producto.CategoryId = (int)cmbCategoria.SelectedValue!;
                Producto.Nombre = txbNombre.Text;
                Producto.Cantidad = (int)nudCantidad.Value;
                Producto.Descripcion = rtbDescripcion.Text;

                productoController.Actualizar(Producto);

                esNuevo = true;
                btnGuardar.Text = "Guardar";

                productoController.Detached(Producto);
            }

            this.productoGridDTOBindingSource.DataSource = productoController.GetProductos();
            Limpiar();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txbNombre.Text = dgvProductos.Rows[RowIndex].Cells["Nombre"].Value.ToString();
            nudCantidad.Value = (int)dgvProductos.Rows[RowIndex].Cells["Cantidad"].Value;
            // TODO: Mejorar este número mágico aquí
            cmbCategoria.SelectedIndex = (int)dgvProductos.Rows[RowIndex].Cells["CategoryId"].Value - 1;
            rtbDescripcion.Text = dgvProductos.Rows[RowIndex].Cells["Descripcion"].Value.ToString();

            esNuevo = false;
            btnGuardar.Text = "Actualizar";
        }
    }
}