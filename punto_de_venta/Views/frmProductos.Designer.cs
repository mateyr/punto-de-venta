namespace punto_de_venta.Views
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            BtnLimpiar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            rtbDescripcion = new RichTextBox();
            label4 = new Label();
            cmbCategoria = new ComboBox();
            categoryBindingSource = new BindingSource(components);
            label3 = new Label();
            label2 = new Label();
            txbNombre = new TextBox();
            label1 = new Label();
            nudCantidad = new NumericUpDown();
            label5 = new Label();
            dgvProductos = new DataGridView();
            productoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            CategoryId = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            productoGridDTOBindingSource = new BindingSource(components);
            panel2 = new Panel();
            ProductoId = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoGridDTOBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BtnLimpiar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(rtbDescripcion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbNombre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nudCantidad);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 633);
            panel1.TabIndex = 0;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = SystemColors.Highlight;
            BtnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLimpiar.ForeColor = Color.Transparent;
            BtnLimpiar.Location = new Point(20, 555);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(225, 29);
            BtnLimpiar.TabIndex = 11;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Highlight;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Transparent;
            btnEliminar.Location = new Point(20, 584);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(225, 29);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Highlight;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.Transparent;
            btnGuardar.Location = new Point(20, 520);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(225, 29);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.Highlight;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = SystemColors.ButtonHighlight;
            btnNuevo.Location = new Point(20, 485);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(225, 29);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.Location = new Point(20, 348);
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.Size = new Size(225, 114);
            rtbDescripcion.TabIndex = 1;
            rtbDescripcion.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 316);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 7;
            label4.Text = "Descripción";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DataSource = categoryBindingSource;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(20, 267);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(225, 28);
            cmbCategoria.TabIndex = 6;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Models.Category);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 233);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 4;
            label3.Text = "Categoría";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 144);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Cantidad";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(20, 96);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(225, 27);
            txbNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 62);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // nudCantidad
            // 
            nudCantidad.AllowDrop = true;
            nudCantidad.BorderStyle = BorderStyle.FixedSingle;
            nudCantidad.Location = new Point(20, 182);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(225, 27);
            nudCantidad.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(21, 12);
            label5.Name = "label5";
            label5.Size = new Size(149, 38);
            label5.TabIndex = 11;
            label5.Text = "Productos ";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { productoIdDataGridViewTextBoxColumn, Nombre, Cantidad, CategoryId, CategoryName, Descripcion });
            dgvProductos.DataSource = productoGridDTOBindingSource;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new Point(269, 62);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(776, 575);
            dgvProductos.TabIndex = 1;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // productoIdDataGridViewTextBoxColumn
            // 
            productoIdDataGridViewTextBoxColumn.DataPropertyName = "ProductoId";
            productoIdDataGridViewTextBoxColumn.HeaderText = "ProductoId";
            productoIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productoIdDataGridViewTextBoxColumn.Name = "productoIdDataGridViewTextBoxColumn";
            productoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // CategoryId
            // 
            CategoryId.DataPropertyName = "CategoryId";
            CategoryId.HeaderText = "CategoryId";
            CategoryId.MinimumWidth = 6;
            CategoryId.Name = "CategoryId";
            CategoryId.ReadOnly = true;
            CategoryId.Visible = false;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "CategoryName";
            CategoryName.MinimumWidth = 6;
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // productoGridDTOBindingSource
            // 
            productoGridDTOBindingSource.DataSource = typeof(DTOs.ProductoGridDTO);
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(269, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 63);
            panel2.TabIndex = 2;
            // 
            // ProductoId
            // 
            ProductoId.DataPropertyName = "ProductoId";
            ProductoId.HeaderText = "ProductoId";
            ProductoId.MinimumWidth = 6;
            ProductoId.Name = "ProductoId";
            ProductoId.Width = 145;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1045, 635);
            Controls.Add(panel2);
            Controls.Add(dgvProductos);
            Controls.Add(panel1);
            Name = "frmProductos";
            Text = "Productos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoGridDTOBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txbNombre;
        private Label label1;
        private Label label3;
        private TextBox txbCantidad;
        private Label label2;
        private ComboBox cmbCategoria;
        private Label label4;
        private BindingSource puntoDeVentaContextBindingSource;
        private RichTextBox rtbDescripcion;
        private NumericUpDown nudCantidad;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn ProductooIdDataGridViewTextBoxColumn;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label label5;
        private Panel panel2;
        private Button BtnLimpiar;
        private DataGridViewTextBoxColumn CategoryId;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private BindingSource productoGridDTOBindingSource;
        private DataGridViewTextBoxColumn ProductoId;
        private DataGridViewTextBoxColumn productoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Descripcion;
        private BindingSource categoryBindingSource;
    }
}