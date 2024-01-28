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

namespace Sol_PuntoVenta.Presentacion.Procesos
{
    public partial class Frm_Registro_Pedidos : Form
    {
        public Frm_Registro_Pedidos()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int nCodigo_pv = 0;
        #endregion

        #region "Mis Metodos
        private void Formato_pv()
        {
            Dgv_1.Columns[0].Visible = false;
            Dgv_1.Columns[1].Width = 750;
            Dgv_1.Columns[1].HeaderText = "PUNTO DE VENTA";
        }
        private void Listado_pv(string cTexto)
        {
            try
            {
                Dgv_1.DataSource = N_Registro_Pedidos.Listado_pv(cTexto);
                this.Formato_pv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }
        private void Selecciona_item_pv()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_1.CurrentRow.Cells["codigo_pv"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_puntoventa.Text = Convert.ToString(Dgv_1.CurrentRow.Cells["descripcion_pv"].Value);
                this.nCodigo_pv = Convert.ToInt32(Dgv_1.CurrentRow.Cells["codigo_pv"].Value);
            }
        }

        private void Estado_FechaTurno_pv(int nCodigo_pv)
        {
            DataTable Tablax = new DataTable();
            Tablax = N_Registro_Pedidos.Estado_turno_pv(nCodigo_pv);
            if (Tablax.Rows.Count>0)
            {
                string cFecha_ct = Convert.ToString(Tablax.Rows[0][0]);
                Txt_fechatrabajo.Text = cFecha_ct.Substring(0, cFecha_ct.Length -9);
                Txt_turno.Text = Convert.ToString(Tablax.Rows[0][2]);
                Txt_estado.Text = Convert.ToString(Tablax.Rows[0][4]);
                if (Txt_estado.Text.Trim()== "Cerrado")
                {
                    Lbl_mensaje.Visible = true;
                }
                else
                {
                    Lbl_mensaje.Visible = false;
                }
            }
            else
            {
                Txt_fechatrabajo.Text = "Ninguno";
                Txt_turno.Text = "Ninguno";
                Txt_estado.Text = "Ninguno";
                Lbl_mensaje.Visible = false;
            }
        }
        #endregion

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Lupa_1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_1.Visible = true;
        }

        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_1.Visible = false;
        }

        private void Dgv_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_pv();
            this.Estado_FechaTurno_pv(this.nCodigo_pv);
            Pnl_Listado_1.Visible = false;
        }

        private void Frm_Registro_Pedidos_Load(object sender, EventArgs e)
        {
            this.Listado_pv("%");
            Lbl_mensaje.Text = "* El turno del Punto de Venta se encuentra cerrado. Solicite al Administrador la apertura de una nueva fecha de trabajo y/o turno";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.nCodigo_pv>0)
            {
                this.Estado_FechaTurno_pv(this.nCodigo_pv);
            }

        }
    }
}
