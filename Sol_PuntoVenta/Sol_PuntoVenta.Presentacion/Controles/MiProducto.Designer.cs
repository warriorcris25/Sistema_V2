namespace Sol_PuntoVenta.Presentacion.Controles
{
    partial class MiProducto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiProducto));
            this.Pnl_producto = new System.Windows.Forms.Panel();
            this.Lbl_codigo_pr = new System.Windows.Forms.Label();
            this.Lbl_preciounitario_pr = new System.Windows.Forms.Label();
            this.Lbl_descripcion_pr = new System.Windows.Forms.Label();
            this.Pct_imagen_pr = new System.Windows.Forms.PictureBox();
            this.Lbl_impresora = new System.Windows.Forms.Label();
            this.Pnl_producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_imagen_pr)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_producto
            // 
            this.Pnl_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_producto.Controls.Add(this.Lbl_impresora);
            this.Pnl_producto.Controls.Add(this.Lbl_codigo_pr);
            this.Pnl_producto.Controls.Add(this.Lbl_preciounitario_pr);
            this.Pnl_producto.Controls.Add(this.Lbl_descripcion_pr);
            this.Pnl_producto.Controls.Add(this.Pct_imagen_pr);
            this.Pnl_producto.Location = new System.Drawing.Point(3, 4);
            this.Pnl_producto.Name = "Pnl_producto";
            this.Pnl_producto.Size = new System.Drawing.Size(174, 188);
            this.Pnl_producto.TabIndex = 0;
            // 
            // Lbl_codigo_pr
            // 
            this.Lbl_codigo_pr.Location = new System.Drawing.Point(0, 8);
            this.Lbl_codigo_pr.Name = "Lbl_codigo_pr";
            this.Lbl_codigo_pr.Size = new System.Drawing.Size(25, 25);
            this.Lbl_codigo_pr.TabIndex = 7;
            this.Lbl_codigo_pr.Text = "Lbl_codigo_pr";
            // 
            // Lbl_preciounitario_pr
            // 
            this.Lbl_preciounitario_pr.Location = new System.Drawing.Point(0, 147);
            this.Lbl_preciounitario_pr.Name = "Lbl_preciounitario_pr";
            this.Lbl_preciounitario_pr.Size = new System.Drawing.Size(180, 41);
            this.Lbl_preciounitario_pr.TabIndex = 6;
            this.Lbl_preciounitario_pr.Text = "Precio x";
            this.Lbl_preciounitario_pr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_descripcion_pr
            // 
            this.Lbl_descripcion_pr.Location = new System.Drawing.Point(0, 106);
            this.Lbl_descripcion_pr.Name = "Lbl_descripcion_pr";
            this.Lbl_descripcion_pr.Size = new System.Drawing.Size(180, 40);
            this.Lbl_descripcion_pr.TabIndex = 5;
            this.Lbl_descripcion_pr.Text = "Producto x";
            this.Lbl_descripcion_pr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pct_imagen_pr
            // 
            this.Pct_imagen_pr.Image = ((System.Drawing.Image)(resources.GetObject("Pct_imagen_pr.Image")));
            this.Pct_imagen_pr.Location = new System.Drawing.Point(31, 6);
            this.Pct_imagen_pr.Name = "Pct_imagen_pr";
            this.Pct_imagen_pr.Size = new System.Drawing.Size(114, 97);
            this.Pct_imagen_pr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pct_imagen_pr.TabIndex = 4;
            this.Pct_imagen_pr.TabStop = false;
            // 
            // Lbl_impresora
            // 
            this.Lbl_impresora.Location = new System.Drawing.Point(148, 8);
            this.Lbl_impresora.Name = "Lbl_impresora";
            this.Lbl_impresora.Size = new System.Drawing.Size(25, 25);
            this.Lbl_impresora.TabIndex = 8;
            this.Lbl_impresora.Text = "Lbl_impresora";
            // 
            // MiProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pnl_producto);
            this.Name = "MiProducto";
            this.Size = new System.Drawing.Size(180, 195);
            this.Pnl_producto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pct_imagen_pr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_producto;
        private System.Windows.Forms.Label Lbl_codigo_pr;
        private System.Windows.Forms.Label Lbl_preciounitario_pr;
        private System.Windows.Forms.Label Lbl_descripcion_pr;
        private System.Windows.Forms.PictureBox Pct_imagen_pr;
        private System.Windows.Forms.Label Lbl_impresora;
    }
}
