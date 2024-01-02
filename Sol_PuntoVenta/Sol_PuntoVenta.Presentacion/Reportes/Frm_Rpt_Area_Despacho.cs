using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_PuntoVenta.Presentacion.Reportes
{
    public partial class Frm_Rpt_Area_Despacho : Form
    {
        public Frm_Rpt_Area_Despacho()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Area_Despacho_Load(object sender, EventArgs e)
        {
            this.uSP_Listado_adTableAdapter.Fill(this.dataSet_DatosMaestros.USP_Listado_ad,
                                                cTexto: Txt_p1.Text.Trim());
            this.reportViewer1.RefreshReport();
        }
    }
}
