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

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
