using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacturacion
{
    class Factura
    {
        public int id { get; set; }
        public DateTime fechaFacturacion { get; set; }
        public Cliente cliente { get; set; }
    }
}
