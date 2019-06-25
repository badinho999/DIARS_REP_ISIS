using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EntComprobantedepagoalquiler
    {
        public string Fechadeemision { get; set; }
        public string Ruc { get; set; }
        public int NumeroSerie { get; set; }
        internal EntAlquiler Alquiler { get; set; }
    }
}
