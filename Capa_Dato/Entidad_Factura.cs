using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dato
{
   public class Entidad_Factura
    {


        public int ID_Fctura { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Producto { get; set; }
        public float Total { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public float Subtotal { get; set; }

    }
}
