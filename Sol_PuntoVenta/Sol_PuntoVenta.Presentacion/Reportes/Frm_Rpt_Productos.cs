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
    public partial class Frm_Rpt_Productos : Form
    {
        public Frm_Rpt_Productos()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Productos_Load(object sender, EventArgs e)
        {
            this.uSP_Listado_prTableAdapter.Fill(this.dataSet_DatosMaestros.USP_Listado_pr,
                                                cTexto: Txt_p1.Text.Trim());
            this.reportViewer1.RefreshReport();
        }
    }
}
