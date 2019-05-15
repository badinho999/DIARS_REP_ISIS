using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class EntComprobantedepagoalquiler
    {
        private string fechadeemision;
        private string ruc;
        private int numeroSerie;
        private EntAlquiler alquiler;

        public string Fechadeemision { get => fechadeemision; set => fechadeemision = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public int NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        internal EntAlquiler Alquiler { get => alquiler; set => alquiler = value; }
    }
}
