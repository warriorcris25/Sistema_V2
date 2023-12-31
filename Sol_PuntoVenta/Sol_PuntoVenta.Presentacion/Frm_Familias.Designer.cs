namespace Sol_PuntoVenta.Presentacion
{
    partial class Frm_Familias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Familias));
            this.Tbc_principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Lbl_totalregistros = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_listado = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_Retornar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Pnl_titulo_form = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbc_principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Pnl_titulo_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbc_principal
            // 
            this.Tbc_principal.Controls.Add(this.tabPage1);
            this.Tbc_principal.Controls.Add(this.tabPage2);
            this.Tbc_principal.ItemSize = new System.Drawing.Size(100, 30);
            this.Tbc_principal.Location = new System.Drawing.Point(12, 82);
            this.Tbc_principal.Name = "Tbc_principal";
            this.Tbc_principal.SelectedIndex = 0;
            this.Tbc_principal.Size = new System.Drawing.Size(1365, 716);
            this.Tbc_principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Lbl_totalregistros);
            this.tabPage1.Controls.Add(this.Btn_Buscar);
            this.tabPage1.Controls.Add(this.Txt_Buscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Dgv_listado);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1357, 678);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Lbl_totalregistros
            // 
            this.Lbl_totalregistros.AutoSize = true;
            this.Lbl_totalregistros.Location = new System.Drawing.Point(854, 580);
            this.Lbl_totalregistros.Name = "Lbl_totalregistros";
            this.Lbl_totalregistros.Size = new System.Drawing.Size(112, 16);
            this.Lbl_totalregistros.TabIndex = 4;
            this.Lbl_totalregistros.Text = "Total Registros: 0";
            this.Lbl_totalregistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Location = new System.Drawing.Point(377, 50);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(100, 34);
            this.Btn_Buscar.TabIndex = 3;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Location = new System.Drawing.Point(81, 55);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(267, 22);
            this.Txt_Buscar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // Dgv_listado
            // 
            this.Dgv_listado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(145)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_listado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_listado.ColumnHeadersHeight = 35;
            this.Dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_listado.EnableHeadersVisualStyles = false;
            this.Dgv_listado.Location = new System.Drawing.Point(29, 99);
            this.Dgv_listado.Name = "Dgv_listado";
            this.Dgv_listado.RowHeadersWidth = 51;
            this.Dgv_listado.RowTemplate.Height = 24;
            this.Dgv_listado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_listado.Size = new System.Drawing.Size(965, 464);
            this.Dgv_listado.TabIndex = 0;
            this.Dgv_listado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_listado_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_Retornar);
            this.tabPage2.Controls.Add(this.Btn_Guardar);
            this.tabPage2.Controls.Add(this.Btn_Cancelar);
            this.tabPage2.Controls.Add(this.Txt_Descripcion);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1357, 678);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_Retornar
            // 
            this.Btn_Retornar.BackColor = System.Drawing.Color.ForestGreen;
            this.Btn_Retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Retornar.ForeColor = System.Drawing.Color.White;
            this.Btn_Retornar.Location = new System.Drawing.Point(332, 143);
            this.Btn_Retornar.Name = "Btn_Retornar";
            this.Btn_Retornar.Size = new System.Drawing.Size(100, 34);
            this.Btn_Retornar.TabIndex = 6;
            this.Btn_Retornar.Text = "Retornar";
            this.Btn_Retornar.UseVisualStyleBackColor = false;
            this.Btn_Retornar.Visible = false;
            this.Btn_Retornar.Click += new System.EventHandler(this.Btn_Retornar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.Blue;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_Guardar.Location = new System.Drawing.Point(227, 142);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(100, 34);
            this.Btn_Guardar.TabIndex = 5;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Visible = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancelar.Location = new System.Drawing.Point(121, 143);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(100, 34);
            this.Btn_Cancelar.TabIndex = 4;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Visible = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(115, 105);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(351, 22);
            this.Txt_Descripcion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Familia: (*)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.Cyan;
            this.Btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.ForeColor = System.Drawing.Color.Black;
            this.Btn_Nuevo.ImageKey = "nuevo.png";
            this.Btn_Nuevo.ImageList = this.imageList1;
            this.Btn_Nuevo.Location = new System.Drawing.Point(16, 812);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(94, 75);
            this.Btn_Nuevo.TabIndex = 1;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
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
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.Cyan;
            this.Btn_Actualizar.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Actualizar.ImageKey = "actualizar.png";
            this.Btn_Actualizar.ImageList = this.imageList1;
            this.Btn_Actualizar.Location = new System.Drawing.Point(116, 812);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(94, 75);
            this.Btn_Actualizar.TabIndex = 2;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.Cyan;
            this.Btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Eliminar.ImageKey = "eliminar.png";
            this.Btn_Eliminar.ImageList = this.imageList1;
            this.Btn_Eliminar.Location = new System.Drawing.Point(216, 812);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(94, 75);
            this.Btn_Eliminar.TabIndex = 3;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackColor = System.Drawing.Color.Cyan;
            this.Btn_Reporte.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Btn_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reporte.ForeColor = System.Drawing.Color.Black;
            this.Btn_Reporte.ImageKey = "reporte.png";
            this.Btn_Reporte.ImageList = this.imageList1;
            this.Btn_Reporte.Location = new System.Drawing.Point(316, 812);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(94, 75);
            this.Btn_Reporte.TabIndex = 4;
            this.Btn_Reporte.Text = "Reporte";
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Cyan;
            this.Btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.ForeColor = System.Drawing.Color.Black;
            this.Btn_Salir.ImageKey = "salir.png";
            this.Btn_Salir.ImageList = this.imageList1;
            this.Btn_Salir.Location = new System.Drawing.Point(416, 812);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(94, 75);
            this.Btn_Salir.TabIndex = 5;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            // 
            // Pnl_titulo_form
            // 
            this.Pnl_titulo_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(145)))), ((int)(((byte)(194)))));
            this.Pnl_titulo_form.Controls.Add(this.label3);
            this.Pnl_titulo_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo_form.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo_form.Name = "Pnl_titulo_form";
            this.Pnl_titulo_form.Size = new System.Drawing.Size(2315, 80);
            this.Pnl_titulo_form.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(42, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Familias ";
            // 
            // Frm_Familias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2315, 1318);
            this.Controls.Add(this.Pnl_titulo_form);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Tbc_principal);
            this.Name = "Frm_Familias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Familias";
            this.Load += new System.EventHandler(this.Frm_Familias_Load);
            this.Tbc_principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Pnl_titulo_form.ResumeLayout(false);
            this.Pnl_titulo_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbc_principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Dgv_listado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Retornar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel Pnl_titulo_form;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_totalregistros;
    }
}