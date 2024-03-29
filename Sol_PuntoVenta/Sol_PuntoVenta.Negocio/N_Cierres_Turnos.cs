using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_PuntoVenta.Datos;
using Sol_PuntoVenta.Entidades;

namespace Sol_PuntoVenta.Negocio
{
    public class N_Cierres_Turnos
    {
        public static string Abrir_turno(string cFecha_ct, int nCodigo_pv, int nCodigo_tu)
        {
            D_Cierre_Turnos Datos = new D_Cierre_Turnos();
            return Datos.Abrir_turno(cFecha_ct, nCodigo_pv, nCodigo_tu);
        }
        public static string Cerrar_turno(string cFecha_ct, int nCodigo_pv, int nCodigo_tu)
        {
            D_Cierre_Turnos Datos = new D_Cierre_Turnos();
            return Datos.Cerrar_turno(cFecha_ct, nCodigo_pv, nCodigo_tu);
        }
        public static DataTable Listado_pv(string cTexto)
        {
            D_Cierre_Turnos Datos = new D_Cierre_Turnos();
            return Datos.Listado_pv(cTexto);
        }
        public static DataTable Estado_gestion_turno_pv(int nCodigo_pv)
        {
            D_Cierre_Turnos Datos = new D_Cierre_Turnos();
            return Datos.Estado_gestion_turno_pv(nCodigo_pv);
        }
    }
}
