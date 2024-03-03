using Sol_PuntoVenta.Entidades;
using Sol_PuntoVenta.Negocio;
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
        int nCodigo_us = 1;
        int nCodigo_tu = 0;
        #endregion

        #region "Mis Variables y Propiedades"
        private int Codigo_me;
        private string Descripcion_me;
        private Image Estado;
        private int Codigo_pv;
        private string Descripcion_pv;
        private int Codigo_us;
        private int Codigo_tu;

        public int Codigo_me1 { get => Codigo_me; set => Codigo_me = value; }
        public string Descripcion_me1 { get => Descripcion_me; set => Descripcion_me = value; }
        public Image Estado1 { get => Estado; set => Estado = value; }
        public int Codigo_pv1 { get => Codigo_pv; set => Codigo_pv = value; }
        public string Descripcion_pv1 { get => Descripcion_pv; set => Descripcion_pv = value; }
        public int Codigo_us1 { get => Codigo_us; set => Codigo_us = value; }
        public int Codigo_tu1 { get => Codigo_tu; set => Codigo_tu = value; }
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
                this.nCodigo_tu = Convert.ToInt32(Tablax.Rows[0][1]);
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

        public void LlenarPuntoVenta(FlowLayoutPanel Contenedor)
        {
            if (Txt_estado.Text.Trim()==("Abierto"))
            {
                Contenedor.Controls.Clear();
                byte[] bImagen1 = new byte[0];
                bImagen1 = N_Registro_Pedidos.imagen_estado_me(1);
                MemoryStream ms1 = new MemoryStream(bImagen1);

                byte[] bImagen2 = new byte[0];
                bImagen2 = N_Registro_Pedidos.imagen_estado_me(2);
                MemoryStream ms2 = new MemoryStream(bImagen2);

                DataTable Tabla = new DataTable();
                Tabla = N_Registro_Pedidos.Mostrar_me_rp(this.nCodigo_pv);

                for (int nFila = 0; nFila <= Tabla.Rows.Count-1; nFila++)
                {
                    Codigo_me = Convert.ToInt32(Tabla.Rows[nFila][0]);
                    Descripcion_me = Convert.ToString(Tabla.Rows[nFila][1]);

                    //verificamos si la mesa esta disponible
                    if (Convert.ToInt32(Tabla.Rows[nFila][2]) == 1) //Disponible
                    {
                        Estado = Image.FromStream(ms1);
                    }
                    else
                    {
                        Estado = Image.FromStream(ms2);
                    }

                    Codigo_pv = Convert.ToInt32(Tabla.Rows[nFila][3]);
                    Descripcion_pv= Convert.ToString(Tabla.Rows[nFila][4]);
                    Codigo_us = this.nCodigo_us;
                    Codigo_tu = this.nCodigo_tu;

                    //Creamos la mesa para cargar los datos
                    Controles.MiMesa oMesa = new Controles.MiMesa();
                    oMesa.Codigo = Codigo_me;
                    oMesa.Descripcion = Descripcion_me;
                    oMesa.Disponible = Estado;
                    oMesa.Codigo_pv = Codigo_pv;
                    oMesa.Descripcion_pv = Descripcion_pv;
                    oMesa.Codigo_us = Codigo_us;
                    oMesa.Codigo_tu = Codigo_tu;

                    //Añadimos la mesa al control
                    Contenedor.Controls.Add(oMesa);
                }
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
            this.LlenarPuntoVenta(flowLayoutPanel1);
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
