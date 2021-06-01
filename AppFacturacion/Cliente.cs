using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacturacion
{
    public class Cliente
    {
        public int id { get; set; }
        public string rfc { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }

        public string nombreCompleto()
        {
            return nombre + " " + apellidoPaterno + " " + apellidoMaterno;
        }
    }
}
