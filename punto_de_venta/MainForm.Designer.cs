using punto_de_venta.Models;

namespace punto_de_venta
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel = new Panel();
            punto_de_venta = new Label();
            menuStrip1 = new MenuStrip();
            ventas = new ToolStripMenuItem();
            Productoos = new ToolStripMenuItem();
            categorias = new ToolStripMenuItem();
            contenedor = new Panel();
            panel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel.AutoSize = true;
            panel.BackColor = SystemColors.MenuHighlight;
            panel.Controls.Add(punto_de_venta);
            panel.Location = new Point(-2, 0);
            panel.Margin = new Padding(0);
            panel.Name = "panel";
            panel.Size = new Size(812, 63);
            panel.TabIndex = 9;
            // 
            // punto_de_venta
            // 
            punto_de_venta.AutoSize = true;
            punto_de_venta.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            punto_de_venta.ForeColor = Color.Transparent;
            punto_de_venta.Location = new Point(5, 8);
            punto_de_venta.Name = "punto_de_venta";
            punto_de_venta.Size = new Size(265, 46);
            punto_de_venta.TabIndex = 0;
            punto_de_venta.Text = "Punto de Venta";
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ventas, Productoos, categorias });
            menuStrip1.Location = new Point(0, 63);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(808, 57);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // ventas
            // 
            ventas.BackColor = Color.Red;
            ventas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ventas.ForeColor = Color.Black;
            ventas.Name = "ventas";
            ventas.Size = new Size(83, 53);
            ventas.Text = "Ventas";
            ventas.Click += ventas_Click;
            // 
            // Productoos
            // 
            Productoos.BackColor = SystemColors.Control;
            Productoos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Productoos.Name = "Productoos";
            Productoos.Size = new Size(115, 53);
            Productoos.Text = "Productos";
            Productoos.Click += Productoos_Click;
            // 
            // categorias
            // 
            categorias.BackColor = Color.Red;
            categorias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categorias.Name = "categorias";
            categorias.Size = new Size(119, 53);
            categorias.Text = "Categorias";
            // 
            // contenedor
            // 
            contenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contenedor.Location = new Point(0, 116);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(810, 335);
            contenedor.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 455);
            Controls.Add(contenedor);
            Controls.Add(panel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Productos and Categories";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel;
        private Label punto_de_venta;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Productoos;
        private ToolStripMenuItem ventas;
        private ToolStripMenuItem categorias;
        private Panel contenedor;
    }
}
