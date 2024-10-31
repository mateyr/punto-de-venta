using punto_de_venta.Context;
using punto_de_venta.Controllers;
using punto_de_venta.Views;
using System.ComponentModel;

namespace punto_de_venta
{
    public partial class MainForm : Form
    {

        private PuntoDeVentaContext? dbContext;
        private static ToolStripMenuItem? MenuActivo;
        private static Form? FormularioActivo;

        public MainForm(PuntoDeVentaContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }

        private void ventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmVentas());
        }

        private void Productoos_Click(object sender, EventArgs e)
        {
            if (dbContext != null)
            {
                AbrirFormulario((ToolStripMenuItem)sender, new frmProductos(new ProductoController(new PuntoDeVentaContext()), new CategoryController(new PuntoDeVentaContext())));
            }
        }

        private void AbrirFormulario(ToolStripMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = SystemColors.Control;
            }

            menu.BackColor = SystemColors.MenuHighlight;
            MenuActivo = menu;

            //contenedor
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }
    }
}
