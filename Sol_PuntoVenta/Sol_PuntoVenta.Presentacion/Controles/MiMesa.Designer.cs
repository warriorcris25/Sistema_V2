namespace Sol_PuntoVenta.Presentacion.Controles
{
    partial class MiMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiMesa));
            this.Pnl_mesa = new System.Windows.Forms.Panel();
            this.Pct_imagenmesa = new System.Windows.Forms.PictureBox();
            this.Pct_estado = new System.Windows.Forms.PictureBox();
            this.Lbl_descricipcion_me = new System.Windows.Forms.Label();
            this.Lbl_codigo_me = new System.Windows.Forms.Label();
            this.Lbl_codigo_pv = new System.Windows.Forms.Label();
            this.Lbl_descripcion_pv = new System.Windows.Forms.Label();
            this.Lbl_codigo_us = new System.Windows.Forms.Label();
            this.Lbl_codigo_tu = new System.Windows.Forms.Label();
            this.Pnl_mesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_imagenmesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_estado)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_mesa
            // 
            this.Pnl_mesa.Controls.Add(this.Lbl_codigo_tu);
            this.Pnl_mesa.Controls.Add(this.Lbl_codigo_us);
            this.Pnl_mesa.Controls.Add(this.Lbl_descripcion_pv);
            this.Pnl_mesa.Controls.Add(this.Lbl_codigo_pv);
            this.Pnl_mesa.Controls.Add(this.Lbl_codigo_me);
            this.Pnl_mesa.Controls.Add(this.Lbl_descricipcion_me);
            this.Pnl_mesa.Controls.Add(this.Pct_estado);
            this.Pnl_mesa.Controls.Add(this.Pct_imagenmesa);
            this.Pnl_mesa.Location = new System.Drawing.Point(5, 9);
            this.Pnl_mesa.Name = "Pnl_mesa";
            this.Pnl_mesa.Size = new System.Drawing.Size(165, 173);
            this.Pnl_mesa.TabIndex = 0;
            // 
            // Pct_imagenmesa
            // 
            this.Pct_imagenmesa.Image = ((System.Drawing.Image)(resources.GetObject("Pct_imagenmesa.Image")));
            this.Pct_imagenmesa.Location = new System.Drawing.Point(24, 30);
            this.Pct_imagenmesa.Name = "Pct_imagenmesa";
            this.Pct_imagenmesa.Size = new System.Drawing.Size(104, 111);
            this.Pct_imagenmesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pct_imagenmesa.TabIndex = 0;
            this.Pct_imagenmesa.TabStop = false;
            // 
            // Pct_estado
            // 
            this.Pct_estado.Image = ((System.Drawing.Image)(resources.GetObject("Pct_estado.Image")));
            this.Pct_estado.Location = new System.Drawing.Point(61, 9);
            this.Pct_estado.Name = "Pct_estado";
            this.Pct_estado.Size = new System.Drawing.Size(31, 30);
            this.Pct_estado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pct_estado.TabIndex = 1;
            this.Pct_estado.TabStop = false;
            // 
            // Lbl_descricipcion_me
            // 
            this.Lbl_descricipcion_me.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descricipcion_me.Location = new System.Drawing.Point(3, 145);
            this.Lbl_descricipcion_me.Name = "Lbl_descricipcion_me";
            this.Lbl_descricipcion_me.Size = new System.Drawing.Size(159, 26);
            this.Lbl_descricipcion_me.TabIndex = 2;
            this.Lbl_descricipcion_me.Text = "Mesa X";
            this.Lbl_descricipcion_me.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_codigo_me
            // 
            this.Lbl_codigo_me.Location = new System.Drawing.Point(3, 2);
            this.Lbl_codigo_me.Name = "Lbl_codigo_me";
            this.Lbl_codigo_me.Size = new System.Drawing.Size(36, 27);
            this.Lbl_codigo_me.TabIndex = 3;
            this.Lbl_codigo_me.Text = "Lbl_codigo_me";
            this.Lbl_codigo_me.Visible = false;
            // 
            // Lbl_codigo_pv
            // 
            this.Lbl_codigo_pv.Location = new System.Drawing.Point(128, 2);
            this.Lbl_codigo_pv.Name = "Lbl_codigo_pv";
            this.Lbl_codigo_pv.Size = new System.Drawing.Size(36, 27);
            this.Lbl_codigo_pv.TabIndex = 4;
            this.Lbl_codigo_pv.Text = "Lbl_codigo_pv";
            this.Lbl_codigo_pv.Visible = false;
            // 
            // Lbl_descripcion_pv
            // 
            this.Lbl_descripcion_pv.Location = new System.Drawing.Point(131, 34);
            this.Lbl_descripcion_pv.Name = "Lbl_descripcion_pv";
            this.Lbl_descripcion_pv.Size = new System.Drawing.Size(31, 24);
            this.Lbl_descripcion_pv.TabIndex = 5;
            this.Lbl_descripcion_pv.Text = "Lbl_descripcion_pv";
            this.Lbl_descripcion_pv.Visible = false;
            // 
            // Lbl_codigo_us
            // 
            this.Lbl_codigo_us.Location = new System.Drawing.Point(129, 62);
            this.Lbl_codigo_us.Name = "Lbl_codigo_us";
            this.Lbl_codigo_us.Size = new System.Drawing.Size(33, 24);
            this.Lbl_codigo_us.TabIndex = 6;
            this.Lbl_codigo_us.Text = "Lbl_codigo_us";
            this.Lbl_codigo_us.Visible = false;
            // 
            // Lbl_codigo_tu
            // 
            this.Lbl_codigo_tu.Location = new System.Drawing.Point(129, 97);
            this.Lbl_codigo_tu.Name = "Lbl_codigo_tu";
            this.Lbl_codigo_tu.Size = new System.Drawing.Size(33, 24);
            this.Lbl_codigo_tu.TabIndex = 7;
            this.Lbl_codigo_tu.Text = "Lbl_codigo_tu";
            this.Lbl_codigo_tu.Visible = false;
            // 
            // MiMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pnl_mesa);
            this.Name = "MiMesa";
            this.Size = new System.Drawing.Size(175, 187);
            this.Pnl_mesa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pct_imagenmesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_estado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_mesa;
        private System.Windows.Forms.PictureBox Pct_imagenmesa;
        private System.Windows.Forms.PictureBox Pct_estado;
        private System.Windows.Forms.Label Lbl_descricipcion_me;
        private System.Windows.Forms.Label Lbl_codigo_me;
        private System.Windows.Forms.Label Lbl_descripcion_pv;
        private System.Windows.Forms.Label Lbl_codigo_pv;
        private System.Windows.Forms.Label Lbl_codigo_tu;
        private System.Windows.Forms.Label Lbl_codigo_us;
    }
}
