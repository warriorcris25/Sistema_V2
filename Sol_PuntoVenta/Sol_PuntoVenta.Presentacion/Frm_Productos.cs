using Sol_PuntoVenta.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_PuntoVenta.Negocio;

namespace Sol_PuntoVenta.Presentacion
{
    public partial class Frm_Productos : Form
    {
        public Frm_Productos()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int nCodigo = 0;
        int nCodigo_ma = 0;
        int nCodigo_um = 0;
        int nCodigo_sf = 0;
        int nCodigo_ad = 0;
        int Estadoguarda = 0;
        DataTable Dtdetalle = new DataTable();
        #endregion

        #region "Mis Métodos"
        private void Formato_pr()
        {
            Dgv_listado.Columns[0].Width = 100;
            Dgv_listado.Columns[0].HeaderText = "CODIGO_PR";
            Dgv_listado.Columns[1].Width = 300;
            Dgv_listado.Columns[1].HeaderText = "PRODUCTO";
            Dgv_listado.Columns[2].Width = 180;
            Dgv_listado.Columns[2].HeaderText = "MARCA";
            Dgv_listado.Columns[3].Width = 180;
            Dgv_listado.Columns[3].HeaderText = "MEDIDA";
            Dgv_listado.Columns[4].Width = 180;
            Dgv_listado.Columns[4].HeaderText = "SUBFAMILIA";
            Dgv_listado.Columns[5].Width = 150;
            Dgv_listado.Columns[5].HeaderText = "P. UNITARIO";
            Dgv_listado.Columns[6].Width = 180;
            Dgv_listado.Columns[6].HeaderText = "AREA DESPACHO";
            Dgv_listado.Columns[7].Visible = false;
            Dgv_listado.Columns[8].Visible = false;
            Dgv_listado.Columns[9].Visible = false;
            Dgv_listado.Columns[10].Visible = false;
            Dgv_listado.Columns[11].Visible = false;
        }

        private void Formato_ma()
        {
            Dgv_1.Columns[0].Visible = false;
            Dgv_1.Columns[1].Width = 300;
            Dgv_1.Columns[1].HeaderText = "MARCA";
        }
        private void Formato_um()
        {
            Dgv_2.Columns[0].Visible = false;
            Dgv_2.Columns[1].Width = 300;
            Dgv_2.Columns[1].HeaderText = "MEDIDA";
        }
        private void Formato_sf()
        {
            Dgv_3.Columns[0].Visible = false;
            Dgv_3.Columns[1].Width = 250;
            Dgv_3.Columns[1].HeaderText = "SUBFAMILIA";
            Dgv_3.Columns[2].Width = 250;
            Dgv_3.Columns[2].HeaderText = "FAMILIA";
            Dgv_3.Columns[3].Visible = false;
        }
        private void Formato_ad()
        {
            Dgv_4.Columns[0].Visible = false;
            Dgv_4.Columns[1].Width = 300;
            Dgv_4.Columns[1].HeaderText = "AREA DE DESPACHO";
        }

        private void Listado_pr(string cTexto)
        {
            try
            {
                Dgv_listado.DataSource = N_Productos.Listado_pr(cTexto);
                this.Formato_pr();
                Lbl_totalregistros.Text = "Total registros: " + Convert.ToString(Dgv_listado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Listado_ma(string cTexto)
        {
            try
            {
                Dgv_1.DataSource = N_Productos.Listado_ma(cTexto);
                this.Formato_ma();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }
        private void Listado_um(string cTexto)
        {
            try
            {
                Dgv_2.DataSource = N_Productos.Listado_um(cTexto);
                this.Formato_um();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }
        private void Listado_sf(string cTexto)
        {
            try
            {
                Dgv_3.DataSource = N_Productos.Listado_sf(cTexto);
                this.Formato_sf();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }
        private void Listado_ad(string cTexto)
        {
            try
            {
                Dgv_4.DataSource = N_Productos.Listado_ad(cTexto);
                this.Formato_ad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }
        private void Limpia_Texto()
        {
            Txt_descripcion_pr.Text = "";
            Txt_descripcion_ma.Text = "";
            Txt_descripcion_um.Text = "";
            Txt_descripcion_sf.Text = "";
            Txt_precio_unitario.Text = "0.00";
            Txt_descripcion_ad.Text = "";
            Txt_observacion.Text = "";
        }

        private void Estado_BotonesPrincipales(bool lEstado)
        {
            Btn_Nuevo.Enabled = lEstado;
            Btn_Actualizar.Enabled = lEstado;
            Btn_Eliminar.Enabled = lEstado;
            Btn_Reporte.Enabled = lEstado;
            Btn_Salir.Enabled = lEstado;
        }

        private void Estado_Texto(bool lEstado)
        {
            Txt_descripcion_pr.ReadOnly = !lEstado;
            Txt_precio_unitario.ReadOnly = !lEstado;
            Txt_observacion.ReadOnly = !lEstado;
        }

        private void Estado_BotonesProcesos(bool lestado)
        {
            Btn_Cancelar.Visible = lestado;
            Btn_Guardar.Visible = lestado;
            Btn_Retornar.Visible = !lestado;
            Btn_lupa_ma.Visible = lestado;
            Btn_lupa_um.Visible = lestado;
            Btn_lupa_sf.Visible = lestado;
            Btn_lupa_ad.Visible = lestado;
            Btn_agregar_imagen.Visible = lestado;
        }

        private void Mostar_img(int nCodigo_pr)
        {
            Byte[] bImagen = new Byte[0];
            bImagen = N_Productos.Mostrar_img(nCodigo_pr);
            MemoryStream ms = new MemoryStream(bImagen);
            Pct_imagen.Image = System.Drawing.Bitmap.FromStream(ms);
        }
        private void Mostrar_img_prod_pred()
        {
            Byte[] bImagen = new Byte[0];
            bImagen = N_Productos.Mostrar_img_prod_pred();
            MemoryStream ms = new MemoryStream(bImagen);
            Pct_imagen.Image = System.Drawing.Bitmap.FromStream(ms);
        }

        private void Crear_Tabla_pv()
        {
            this.Dtdetalle = new DataTable("Detalle");
            this.Dtdetalle.Columns.Add("Descripcion_pv", System.Type.GetType("System.String"));
            this.Dtdetalle.Columns.Add("OK", System.Type.GetType("System.Boolean"));
            this.Dtdetalle.Columns.Add("Codigo_pv", System.Type.GetType("System.Int32"));

            Dgv_PuntosVentas.DataSource = this.Dtdetalle;

            Dgv_PuntosVentas.Columns[0].Width = 250;
            Dgv_PuntosVentas.Columns[0].HeaderText = "PUNTO DE VENTA";
            Dgv_PuntosVentas.Columns[0].ReadOnly = true;
            Dgv_PuntosVentas.Columns[1].Width = 100;
            Dgv_PuntosVentas.Columns[1].HeaderText = "OK";
            Dgv_PuntosVentas.Columns[1].ReadOnly = true;
            Dgv_PuntosVentas.Columns[2].Visible = false;
        }

        private void Agregar_pv(string Descripcion_pv, bool OK, int nCodigo_pv)
        {
            DataRow Fila = Dtdetalle.NewRow();
            Fila["Descripcion_pv"] = Descripcion_pv;
            Fila["OK"] = OK;
            Fila["Codigo_pv"] = nCodigo_pv;
            this.Dtdetalle.Rows.Add(Fila);
        }

        private void Puntos_Ventas_OK(int nOpcion, int nCodigo_pr)
        {
            try
            {
                DataTable TablaTemp = new DataTable();
                TablaTemp = N_Productos.Puntos_Ventas_OK(nOpcion, nCodigo_pr);
                Dtdetalle.Clear();
                for (int nFila=0; nFila<=TablaTemp.Rows.Count - 1; nFila++) 
                {
                    this.Agregar_pv(Convert.ToString(TablaTemp.Rows[nFila][0]),
                                    Convert.ToBoolean(TablaTemp.Rows[nFila][1]),
                                    Convert.ToInt32(TablaTemp.Rows[nFila][2]));
                }
                Dgv_PuntosVentas.DataSource = Dtdetalle;

                if (nOpcion>=1)
                {
                    Dgv_PuntosVentas.Columns["OK"].ReadOnly = false;
                }
                else
                {
                    Dgv_PuntosVentas.Columns["OK"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_listado.CurrentRow.Cells["codigo_pr"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo = Convert.ToInt32(Dgv_listado.CurrentRow.Cells["codigo_pr"].Value);
                Txt_descripcion_pr.Text = Convert.ToString(Dgv_listado.CurrentRow.Cells["descripcion_pr"].Value);
                Txt_descripcion_ma.Text = Convert.ToString(Dgv_listado.CurrentRow.Cells["descripcion_ma"].Value);
                Txt_descripcion_um.Text = Convert.ToString(Dgv_listado.CurrentRow.Cells["descripcion_um"].Value);
                Txt_descripcion_sf.Text = Convert.ToString(Dgv_listado.CurrentRow.Cells["descripcion_sf"].Value);
                Txt_precio_unitario.Text = Convert.ToString(Dgv_listado.CurrentRow.Cells["precio_unitario"].Value);
                Txt_descripcion_ad.Text = Convert.ToString(Dgv_listado.CurrentRow.Cells["descripcion_ad"].Value);
                Txt_observacion.Text = Convert.ToString(Dgv_listado.CurrentRow.Cells["observacion"].Value);
                
                this.nCodigo_ma = Convert.ToInt32(Dgv_listado.CurrentRow.Cells["codigo_ma"].Value);
                this.nCodigo_um = Convert.ToInt32(Dgv_listado.CurrentRow.Cells["codigo_um"].Value);
                this.nCodigo_sf = Convert.ToInt32(Dgv_listado.CurrentRow.Cells["codigo_sf"].Value);
                this.nCodigo_ad = Convert.ToInt32(Dgv_listado.CurrentRow.Cells["codigo_ad"].Value);
                this.Mostar_img(this.nCodigo);
                this.Puntos_Ventas_OK(this.Estadoguarda, this.nCodigo);
            }
        }



        private void Selecciona_item_ma()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_1.CurrentRow.Cells["codigo_ma"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_descripcion_ma.Text = Convert.ToString(Dgv_1.CurrentRow.Cells["descripcion_ma"].Value);
                this.nCodigo_ma = Convert.ToInt32(Dgv_1.CurrentRow.Cells["codigo_ma"].Value);
            }
        }
        private void Selecciona_item_um()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_2.CurrentRow.Cells["codigo_um"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_descripcion_um.Text = Convert.ToString(Dgv_2.CurrentRow.Cells["descripcion_um"].Value);
                this.nCodigo_um = Convert.ToInt32(Dgv_2.CurrentRow.Cells["codigo_um"].Value);
            }
        }
        private void Selecciona_item_sf()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_3.CurrentRow.Cells["codigo_sf"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_descripcion_sf.Text = Convert.ToString(Dgv_3.CurrentRow.Cells["descripcion_sf"].Value);
                this.nCodigo_sf = Convert.ToInt32(Dgv_3.CurrentRow.Cells["codigo_sf"].Value);
            }
        }
        private void Selecciona_item_ad()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_4.CurrentRow.Cells["codigo_ad"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_descripcion_ad.Text = Convert.ToString(Dgv_4.CurrentRow.Cells["descripcion_ad"].Value);
                this.nCodigo_ad = Convert.ToInt32(Dgv_4.CurrentRow.Cells["codigo_ad"].Value);
            }
        }
        #endregion

        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            this.Listado_pr("%");
            this.Listado_ma("%");
            this.Listado_um("%");
            this.Listado_sf("%");
            this.Listado_ad("%");
            this.Crear_Tabla_pv();
        }
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.Estadoguarda = 1; //Nuevo Registro significa el 1 
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
            this.Limpia_Texto();
            this.Estado_Texto(true);
            this.Puntos_Ventas_OK(this.Estadoguarda, this.nCodigo);
            this.Mostrar_img_prod_pred();
            this.nCodigo = 0;
            this.nCodigo_ma = 0;
            this.nCodigo_um = 0;
            this.nCodigo_sf = 0;
            this.nCodigo_ad = 0;
            Tbc_principal.SelectedIndex = 1;
            Txt_descripcion_pr.Focus();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Limpia_Texto();
            this.Estado_Texto(false);
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesProcesos(false);
            Tbc_principal.SelectedIndex = 0;
        }

        private void Btn_Retornar_Click(object sender, EventArgs e)
        {
            Tbc_principal.SelectedIndex = 0;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_descripcion_pr.Text == String.Empty ||
                    Txt_descripcion_ma.Text == String.Empty ||
                    Txt_descripcion_um.Text == String.Empty ||
                    Txt_descripcion_sf.Text == String.Empty ||
                    Txt_descripcion_ad.Text == String.Empty ||
                    Txt_precio_unitario.Text == String.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)",
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                else
                {
                    string Rpta = "";
                    E_Productos oPropiedad = new E_Productos();
                    oPropiedad.Codigo_pr = this.nCodigo;
                    oPropiedad.Descripcion_pr = Txt_descripcion_pr.Text.Trim();
                    oPropiedad.Codigo_ma = this.nCodigo_ma;
                    oPropiedad.Codigo_um = this.nCodigo_um;
                    oPropiedad.Codigo_sf = this.nCodigo_sf;
                    oPropiedad.Codigo_ad = this.nCodigo_ad;
                    oPropiedad.Precio_Unitario = Convert.ToDecimal(Txt_precio_unitario.Text.Trim());
                    oPropiedad.Observacion = Txt_observacion.Text.Trim();
                    System.IO.MemoryStream ms = new MemoryStream();
                    Pct_imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    oPropiedad.Imagen = ms.GetBuffer();

                    Rpta = N_Productos.Guardar_pr(this.Estadoguarda, oPropiedad, Dtdetalle);
                    if (Rpta.Equals("OK"))
                    {
                        MessageBox.Show("Los datos han sido guardados correctamente",
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        this.Limpia_Texto();
                        this.Estado_Texto(false);
                        this.Estado_BotonesPrincipales(true);
                        this.Estado_BotonesProcesos(false);
                        this.Estadoguarda = 0;
                        this.nCodigo = 0;
                        this.nCodigo_ma = 0;
                        this.nCodigo_um = 0;
                        this.nCodigo_sf = 0;
                        this.nCodigo_ad = 0;
                        this.Listado_pr("%");
                        Tbc_principal.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (Dgv_listado.Rows.Count > 0)
            {
                this.Estadoguarda = 2; //Actualizacion de los registros
                this.Estado_BotonesPrincipales(false);
                this.Estado_BotonesProcesos(true);
                this.Estado_Texto(true);
                this.Limpia_Texto();
                this.Selecciona_item();
                Tbc_principal.SelectedIndex = 1;
                Txt_descripcion_pr.Focus();
            }
        }

        private void Dgv_listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Estadoguarda == 0)
            {
                this.Selecciona_item();
                this.Estado_BotonesProcesos(false);
                Tbc_principal.SelectedIndex = 1;
            }

        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_listado.Rows.Count > 0)
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estas seguro de eliminar el registro seleccionado?",
                                         "Aviso del Sistema",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Rpta = "";
                    this.Selecciona_item();
                    Rpta = N_Productos.Eliminar_pr(this.nCodigo);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_pr("%");
                        MessageBox.Show("El registro ha sido eliminado",
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                        this.nCodigo = 0;
                        this.nCodigo_ma = 0;
                        this.nCodigo_um = 0;
                        this.nCodigo_sf = 0;
                        this.nCodigo_ad = 0;
                    }
                    else
                    {
                        MessageBox.Show(Rpta,
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    }
                    this.Limpia_Texto();
                }
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            this.Listado_pr(Txt_Buscar.Text.Trim());
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            if (Dgv_listado.Rows.Count > 0)
            {
                Reportes.Frm_Rpt_Productos oRpt_pr = new Reportes.Frm_Rpt_Productos();
                oRpt_pr.Txt_p1.Text = Txt_Buscar.Text.Trim();
                oRpt_pr.ShowDialog();
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_ma();
            Pnl_Listado_1.Visible = false;
        }

        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_1.Visible = false;
        }

        private void Btn_Buscar1_Click(object sender, EventArgs e)
        {
            this.Listado_ma(Txt_Buscar1.Text.Trim());
        }

        private void Btn_Lupa_1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_1.Location = Btn_lupa_ma.Location;
            Pnl_Listado_1.Visible = true;
            Txt_Buscar1.Focus();
        }

        private void Btn_lupa_um_Click(object sender, EventArgs e)
        {
            Pnl_Listado_2.Location = Btn_lupa_um.Location;
            Pnl_Listado_2.Visible = true;
            Txt_Buscar2.Focus();
        }

        private void Btn_retornar2_Click(object sender, EventArgs e)
        {
            Pnl_Listado_2.Visible = false;
        }

        private void Btn_Buscar2_Click(object sender, EventArgs e)
        {
            this.Listado_um(Txt_Buscar2.Text.Trim());
        }

        private void Dgv_2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_um();
            Pnl_Listado_2.Visible = false;
        }
        private void Btn_Buscar3_Click(object sender, EventArgs e)
        {
            this.Listado_sf(Txt_Buscar3.Text.Trim());
        }

        private void Dgv_3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_sf();
            Pnl_Listado_3.Visible = false;
            Txt_precio_unitario.Focus();
        }

        private void Btn_retornar3_Click(object sender, EventArgs e)
        {
            Pnl_Listado_3.Visible = false;
        }

        private void Btn_lupa_sf_Click(object sender, EventArgs e)
        {
            Pnl_Listado_3.Location = Btn_lupa_ma.Location;
            Pnl_Listado_3.Visible = true;
            Txt_Buscar3.Focus();
        }

        private void Btn_Buscar4_Click(object sender, EventArgs e)
        {
            this.Listado_ad(Txt_Buscar4.Text.Trim());
        }

        private void Btn_retornar4_Click(object sender, EventArgs e)
        {
            Pnl_Listado_4.Visible = false;
        }

        private void Dgv_4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_ad();
            Pnl_Listado_4.Visible = false;
            Txt_observacion.Focus();
        }

        private void Btn_lupa_ad_Click(object sender, EventArgs e)
        {
            Pnl_Listado_4.Location = Btn_lupa_ma.Location;
            Pnl_Listado_4.Visible = true;
            Txt_Buscar4.Focus();
        }

        private void Btn_agregar_imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog Foto = new OpenFileDialog();
            Foto.Filter = "Image files(*.jpg, *.jpe, *.jfif, *.png, *.jpeg) | *.jpg; *.jpe; *.jfif; *.png; *.jpeg";
            if (Foto.ShowDialog()== DialogResult.OK)
            {
                Pct_imagen.Image = Image.FromFile(Foto.FileName);
            }
        }
    }
}
