namespace Sol_PuntoVenta.Presentacion.Procesos
{
    partial class Frm_Mesa_Abierta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Mesa_Abierta));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_superior = new System.Windows.Forms.Panel();
            this.Btn_visualizarpedido = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_nuevopedido = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Txt_puntoventa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_mesaseleccionada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbc_principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2.SuspendLayout();
            this.Pnl_superior.SuspendLayout();
            this.Tbc_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(145)))), ((int)(((byte)(194)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1544, 61);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = ".:. MESA ABIERTA";
            // 
            // Pnl_superior
            // 
            this.Pnl_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Pnl_superior.Controls.Add(this.Btn_visualizarpedido);
            this.Pnl_superior.Controls.Add(this.Btn_nuevopedido);
            this.Pnl_superior.Controls.Add(this.Btn_Salir);
            this.Pnl_superior.Controls.Add(this.Txt_puntoventa);
            this.Pnl_superior.Controls.Add(this.label3);
            this.Pnl_superior.Controls.Add(this.Txt_mesaseleccionada);
            this.Pnl_superior.Controls.Add(this.label2);
            this.Pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_superior.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_superior.ForeColor = System.Drawing.Color.Red;
            this.Pnl_superior.Location = new System.Drawing.Point(0, 61);
            this.Pnl_superior.Name = "Pnl_superior";
            this.Pnl_superior.Size = new System.Drawing.Size(1544, 132);
            this.Pnl_superior.TabIndex = 17;
            // 
            // Btn_visualizarpedido
            // 
            this.Btn_visualizarpedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_visualizarpedido.BackColor = System.Drawing.Color.Cyan;
            this.Btn_visualizarpedido.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Btn_visualizarpedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_visualizarpedido.ForeColor = System.Drawing.Color.Black;
            this.Btn_visualizarpedido.ImageKey = "visualizarpedido.png";
            this.Btn_visualizarpedido.ImageList = this.imageList1;
            this.Btn_visualizarpedido.Location = new System.Drawing.Point(879, 7);
            this.Btn_visualizarpedido.Name = "Btn_visualizarpedido";
            this.Btn_visualizarpedido.Size = new System.Drawing.Size(156, 116);
            this.Btn_visualizarpedido.TabIndex = 9;
            this.Btn_visualizarpedido.Text = "Visualizar Pedido";
            this.Btn_visualizarpedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_visualizarpedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_visualizarpedido.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "nuevo.png");
            this.imageList1.Images.SetKeyName(1, "actualizar.png");
            this.imageList1.Images.SetKeyName(2, "eliminar.png");
            this.imageList1.Images.SetKeyName(3, "reporte.png");
            this.imageList1.Images.SetKeyName(4, "salir.png");
            this.imageList1.Images.SetKeyName(5, "nuevopedido.png");
            this.imageList1.Images.SetKeyName(6, "reporte.png");
            this.imageList1.Images.SetKeyName(7, "visualizarpedido.png");
            // 
            // Btn_nuevopedido
            // 
            this.Btn_nuevopedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_nuevopedido.BackColor = System.Drawing.Color.Cyan;
            this.Btn_nuevopedido.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Btn_nuevopedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevopedido.ForeColor = System.Drawing.Color.Black;
            this.Btn_nuevopedido.ImageKey = "nuevopedido.png";
            this.Btn_nuevopedido.ImageList = this.imageList1;
            this.Btn_nuevopedido.Location = new System.Drawing.Point(699, 7);
            this.Btn_nuevopedido.Name = "Btn_nuevopedido";
            this.Btn_nuevopedido.Size = new System.Drawing.Size(156, 116);
            this.Btn_nuevopedido.TabIndex = 8;
            this.Btn_nuevopedido.Text = "Nuevo Pedido";
            this.Btn_nuevopedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_nuevopedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_nuevopedido.UseVisualStyleBackColor = false;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Salir.BackColor = System.Drawing.Color.Cyan;
            this.Btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.ForeColor = System.Drawing.Color.Black;
            this.Btn_Salir.ImageKey = "salir.png";
            this.Btn_Salir.ImageList = this.imageList1;
            this.Btn_Salir.Location = new System.Drawing.Point(1056, 7);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(156, 116);
            this.Btn_Salir.TabIndex = 7;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            // 
            // Txt_puntoventa
            // 
            this.Txt_puntoventa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_puntoventa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_puntoventa.Location = new System.Drawing.Point(268, 62);
            this.Txt_puntoventa.Name = "Txt_puntoventa";
            this.Txt_puntoventa.ReadOnly = true;
            this.Txt_puntoventa.Size = new System.Drawing.Size(325, 32);
            this.Txt_puntoventa.TabIndex = 4;
            this.Txt_puntoventa.Text = "PUNTO DE VENTA X";
            this.Txt_puntoventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(269, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "PUNTO DE VENTA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_mesaseleccionada
            // 
            this.Txt_mesaseleccionada.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_mesaseleccionada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_mesaseleccionada.Location = new System.Drawing.Point(28, 62);
            this.Txt_mesaseleccionada.Name = "Txt_mesaseleccionada";
            this.Txt_mesaseleccionada.ReadOnly = true;
            this.Txt_mesaseleccionada.Size = new System.Drawing.Size(219, 32);
            this.Txt_mesaseleccionada.TabIndex = 2;
            this.Txt_mesaseleccionada.Text = "MESA X";
            this.Txt_mesaseleccionada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(24, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "MESA SELECCIONADA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tbc_principal
            // 
            this.Tbc_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbc_principal.Controls.Add(this.tabPage1);
            this.Tbc_principal.Controls.Add(this.tabPage2);
            this.Tbc_principal.ItemSize = new System.Drawing.Size(100, 30);
            this.Tbc_principal.Location = new System.Drawing.Point(0, 199);
            this.Tbc_principal.Name = "Tbc_principal";
            this.Tbc_principal.SelectedIndex = 0;
            this.Tbc_principal.Size = new System.Drawing.Size(1544, 648);
            this.Tbc_principal.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1536, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo Pedido";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1399, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualizar Pedidos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Frm_Mesa_Abierta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 849);
            this.Controls.Add(this.Tbc_principal);
            this.Controls.Add(this.Pnl_superior);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_Mesa_Abierta";
            this.Text = "Frm_Mesa_Abierta";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Pnl_superior.ResumeLayout(false);
            this.Pnl_superior.PerformLayout();
            this.Tbc_principal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_superior;
        private System.Windows.Forms.TextBox Txt_mesaseleccionada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_puntoventa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_visualizarpedido;
        private System.Windows.Forms.Button Btn_nuevopedido;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.TabControl Tbc_principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}