using Sol_PuntoVenta.Entidades;
using Sol_PuntoVenta.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        int nCodigo_fa = 0;
        int Estadoguarda = 0;
        #endregion

        #region "Mis Métodos"
        private void Formato_sf()
        {
            Dgv_listado.Columns[0].Width = 100;
            Dgv_listado.Columns[0].HeaderText = "CODIGO_SF";
            Dgv_listado.Columns[1].Width = 400;
            Dgv_listado.Columns[1].HeaderText = "SUBFAMILIA";
            Dgv_listado.Columns[2].Width = 400;
            Dgv_listado.Columns[2].HeaderText = "FAMILIA";
            Dgv_listado.Columns[3].Visible = false;
        }


        private void Formato_fa()
        {
            Dgv_1.Columns[0].Visible = false;
            Dgv_1.Columns[1].Width = 750;
            Dgv_1.Columns[1].HeaderText = "FAMILIA";
        }

        private void Listado_sf(string cTexto)
        {
            try
            {
                Dgv_listado.DataSource = N_SubFamilias.Listado_sf(cTexto);
                this.Formato_sf();
                Lbl_totalregistros.Text = "Total registros: " + Convert.ToString(Dgv_listado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Listado_fa(string cTexto)
        {
            try
            {
                Dgv_1.DataSource = N_SubFamilias.Listado_fa(cTexto);
                this.Formato_fa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }
        private void Limpia_Texto()
        {
            Txt_precio_unitario.Text = "";
            Txt_descripcion_sffamilia.Text = "";
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
            Txt_precio_unitario.ReadOnly = !lEstado;
        }

        private void Estado_BotonesProcesos(bool lestado)
        {
            Btn_Cancelar.Visible = lestado;
            Btn_Guardar.Visible = lestado;
            Btn_Retornar.Visible = !lestado;
            Btn_lupa_sf.Visible = lestado;
        }
        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_listado.CurrentRow.Cells["codigo_sf"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo = Convert.ToInt32(Dgv_listado.CurrentRow.Cells["codigo_sf"].Value);
                Txt_precio_unitario.Text = Convert.ToString(Dgv_listado.CurrentRow.Cells["descripcion_sf"].Value);
                Txt_descripcion_sffamilia.Text = Convert.ToString(Dgv_listado.CurrentRow.Cells["descripcion_fa"].Value);
                this.nCodigo_fa = Convert.ToInt32(Dgv_listado.CurrentRow.Cells["codigo_fa"].Value);
            }
        }



        private void Selecciona_item_fa()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_1.CurrentRow.Cells["codigo_fa"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_descripcion_sffamilia.Text = Convert.ToString(Dgv_1.CurrentRow.Cells["descripcion_fa"].Value);
                this.nCodigo_fa = Convert.ToInt32(Dgv_1.CurrentRow.Cells["codigo_fa"].Value);
            }
        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_SubFamilias_Load(object sender, EventArgs e)
        {
            this.Listado_sf("%");
            this.Listado_fa("%");
        }
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.Estadoguarda = 1; //Nuevo Registro significa el 1 
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
            this.Limpia_Texto();
            this.Estado_Texto(true);
            Tbc_principal.SelectedIndex = 1;
            Btn_lupa_sf.Focus();
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
                if (Txt_precio_unitario.Text == String.Empty ||
                    Txt_descripcion_sffamilia.Text == String.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)",
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                else
                {
                    string Rpta = "";
                    E_SubFamilias oPropiedad = new E_SubFamilias();
                    oPropiedad.Codigo_sf = this.nCodigo;
                    oPropiedad.Descripcion_sf = Txt_precio_unitario.Text.Trim();
                    oPropiedad.Codigo_fa = this.nCodigo_fa;
                    Rpta = N_SubFamilias.Guardar_sf(this.Estadoguarda, oPropiedad);
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
                        this.nCodigo_fa = 0;
                        this.Listado_sf("%");
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
                Btn_lupa_sf.Focus();
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
                    Rpta = N_SubFamilias.Eliminar_sf(this.nCodigo);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_sf("%");
                        MessageBox.Show("El registro ha sido eliminado",
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                        this.nCodigo = 0;
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
            this.Listado_sf(Txt_Buscar.Text.Trim());
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            if (Dgv_listado.Rows.Count > 0)
            {
                Reportes.Frm_Rpt_SubFamilias oRpt_sf = new Reportes.Frm_Rpt_SubFamilias();
                oRpt_sf.Txt_p1.Text = Txt_Buscar.Text.Trim();
                oRpt_sf.ShowDialog();
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_fa();
            Pnl_Listado_1.Visible = false;
        }

        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_1.Visible = false;
        }

        private void Btn_Buscar1_Click(object sender, EventArgs e)
        {
            this.Listado_fa(Txt_Buscar1.Text.Trim());
        }

        private void Btn_Lupa_1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_1.Location = Btn_lupa_sf.Location;
            Pnl_Listado_1.Visible = true;
            Txt_Buscar1.Focus();
        }

        private void Dgv_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_fa();
            Pnl_Listado_1.Visible = false;
            Txt_precio_unitario.Focus();
        }

        private void Frm_Productos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
