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
    public partial class Frm_Cierres_turnos : Form
    {
        public Frm_Cierres_turnos()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int nCodigo_pv = 0;
        int nCodigo_tu = 0;
        #endregion

        #region "Mis Metodos"
        private void Formato_pv()
        {
            Dgv_1.Columns[0].Width = 100;
            Dgv_1.Columns[0].HeaderText = "CODIGO_PV";
            Dgv_1.Columns[1].Width = 750;
            Dgv_1.Columns[1].HeaderText = "PUNTO DE VENTA";
        }

        private void Listado_pv(string cTexto)
        {
            try
            {
                Dgv_1.DataSource = N_Cierres_Turnos.Listado_pv(cTexto);
                this.Formato_pv();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }
        private void Selecciona_item()
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
                //this.nCodigo = Convert.ToInt32(Dgv_1.CurrentRow.Cells["codigo_pv"].Value);
                //Txt_Descripcion.Text = Convert.ToString(Dgv_1.CurrentRow.Cells["descripcion_pv"].Value);
            }
        }
        #endregion

        private void Frm_Cierres_turnos_Load(object sender, EventArgs e)
        {
            this.Listado_pv("%");
        }

        private void Dgv_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable Tablax = new DataTable();
            nCodigo_pv = Convert.ToInt32(Dgv_1.CurrentRow.Cells["codigo_pv"].Value);

            Tablax = N_Cierres_Turnos.Estado_gestion_turno_pv(nCodigo_pv);
            if (Tablax.Rows.Count>0)
            {
                string cFecha_ct = Convert.ToString(Tablax.Rows[0][0]);
                Txt_fecha_trabajo.Text = cFecha_ct.Substring(0,cFecha_ct.Length - 9);
                this.nCodigo_tu = Convert.ToInt32(Tablax.Rows[0][1]);
                Txt_turno.Text = Convert.ToString(Tablax.Rows[0][2]);
                this.nCodigo_pv = Convert.ToInt32(Tablax.Rows[0][5]);
                Txt_estado.Text = Convert.ToString(Tablax.Rows[0][4]);
                Txt_puntoventa.Text = Convert.ToString(Tablax.Rows[0][6]);
                if (Txt_estado.Text.Trim() == "Abierto")
                {
                    Btn_abrirturno.Enabled = false;
                    Btn_cerrarturno.Enabled = true;
                }
                else
                {
                    Btn_abrirturno.Enabled = true;
                    Btn_cerrarturno.Enabled = false;
                }
            }
            else
            {
                Btn_abrirturno.Enabled = true;
                Btn_cerrarturno.Enabled = false;

                Txt_fecha_trabajo.Text = "";
                this.nCodigo_tu = 0;
                Txt_turno.Text = "";
                this.nCodigo_pv = 0;
                Txt_estado.Text = "";
                Txt_puntoventa.Text = "";
            }
        }

        private void Btn_abrirturno_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Abrir turno siguiente ahora?", 
                                        "Aviso del Sistema", 
                                        MessageBoxButtons.YesNo, 
                                        MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Rpta;
                    string cFecha_ct = Txt_fecha_trabajo.Text.Trim();
                    if (cFecha_ct == string.Empty) //Asigno fecha de hoy y turno 1 en caso de no tener historial de cierre del pv
                    {
                        cFecha_ct = DateTime.Now.ToString("dd-MM-yyyy");
                        this.nCodigo_tu = 1;
                    }
                    else
                    {
                        if (this.nCodigo_tu==1)
                        {
                            this.nCodigo_tu = 2;
                        }
                        else if(this.nCodigo_tu==2)
                        {
                            DateTime Nueva_fecha = Convert.ToDateTime(cFecha_ct);
                            Nueva_fecha = Nueva_fecha.AddDays(1);
                            cFecha_ct = Convert.ToString(Nueva_fecha);
                            cFecha_ct.Substring(0, cFecha_ct.Length - 9);
                            this.nCodigo_tu = 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
