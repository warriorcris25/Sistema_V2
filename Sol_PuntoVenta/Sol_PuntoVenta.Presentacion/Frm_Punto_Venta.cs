using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_PuntoVenta.Entidades;
using Sol_PuntoVenta.Negocio;

namespace Sol_PuntoVenta.Presentacion
{
    public partial class Frm_Punto_Venta : Form
    {
        public Frm_Punto_Venta()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int nCodigo = 0;
        int Estadoguarda = 0;
        #endregion

        #region "Mis Métodos"
        private void Formato_pv()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].HeaderText = "CODIGO_PV";
            Dgv_Listado.Columns[1].Width = 250;
            Dgv_Listado.Columns[1].HeaderText = "PUNTO DE VENTA";
        }

        private void Listado_pv(string cTexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Punto_Venta.Listado_pv(cTexto);
                this.Formato_pv();
                Lbl_totalregistros.Text = "Total registros: " + Convert.ToString(Dgv_Listado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }
        #endregion

        private void Frm_Punto_Venta_Load(object sender, EventArgs e)
        {
            this.Listado_pv("%");
        }
    }
}
