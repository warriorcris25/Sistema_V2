using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_PuntoVenta.Entidades
{
    public class E_Productos
    {
        public int Codigo_pr { get; set; }
        public string Descripcion_pr { get; set;}
        public int Codigo_ma { get; set; }
        public int Codigo_um { get; set; }
        public int Codigo_sf { get; set; }
        public decimal Precio_Unitario { get; set; }
        public int Codigo_ad {  get; set; }
        public string Observacion { get; set; }
        public byte[] Imagen {  get; set; }
    }
}
