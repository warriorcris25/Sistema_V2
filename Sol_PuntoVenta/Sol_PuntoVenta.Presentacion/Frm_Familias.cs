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
    public partial class Frm_Familias : Form
    {
        public Frm_Familias()
        {
            InitializeComponent();
        }
                 
        #region "Mis Variables"
        int nCodigo = 0;
        int Estadoguarda = 0;
        #endregion

        #region "Mis Métodos"
        private void Formato_fa()
        {
            Dgv_listado.Columns[0].Width = 100;
            Dgv_listado.Columns[0].HeaderText = "CODIGO_FA";
            Dgv_listado.Columns[1].Width = 750;
            Dgv_listado.Columns[1].HeaderText = "FAMILIA";
        }

        private void Listado_fa(string cTexto)
        {
            try
            {
                Dgv_listado.DataSource = N_Familias.Listado_fa(cTexto);
                this.Formato_fa();
                Lbl_totalregistros.Text = "Total registros: " + Convert.ToString(Dgv_listado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }
        private void Limpia_Texto()
        {
            Txt_Descripcion.Text = "";
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
            Txt_Descripcion.ReadOnly = !lEstado;
        }

        private void Estado_BotonesProcesos(bool lestado)
        {
            Btn_Cancelar.Visible = lestado;
            Btn_Guardar.Visible = lestado;
            Btn_Retornar.Visible = !lestado;
        }
        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_listado.CurrentRow.Cells["codigo_fa"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo = Convert.ToInt32(Dgv_listado.CurrentRow.Cells["codigo_fa"].Value);
                Txt_Descripcion.Text = Convert.ToString(Dgv_listado.CurrentRow.Cells["descripcion_fa"].Value);
            }
        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Familias_Load(object sender, EventArgs e)
        {
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
            Txt_Descripcion.Focus();
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
                if (Txt_Descripcion.Text == String.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)",
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                else
                {
                    string Rpta = "";
                    E_Familias oPropiedad = new E_Familias();
                    oPropiedad.Codigo_fa = this.nCodigo;
                    oPropiedad.Descripcion_fa = Txt_Descripcion.Text.Trim();
                    Rpta = N_Familias.Guardar_fa(this.Estadoguarda, oPropiedad);
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
                        this.Listado_fa("%");
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
                Txt_Descripcion.Focus();
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
                    Rpta = N_Familias.Eliminar_fa(this.nCodigo);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_fa("%");
                        MessageBox.Show("El registro ha sido eliminado",
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
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
            this.Listado_fa(Txt_Buscar.Text.Trim());
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            if (Dgv_listado.Rows.Count > 0)
            {
               Reportes.Frm_Rpt_Familias oRpt_fa = new Reportes.Frm_Rpt_Familias();
               oRpt_fa.Txt_p1.Text = Txt_Buscar.Text.Trim();
               oRpt_fa.ShowDialog();
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
