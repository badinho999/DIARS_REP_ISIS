using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Comprobantedepago
    {
        private string fechadeemision;
        private string ruc;
        private int numeroSerie;
        private Alquiler alquiler;
        private Reserva reserva;

        public string Fechadeemision { get => fechadeemision; set => fechadeemision = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public int NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        internal Alquiler Alquiler { get => alquiler; set => alquiler = value; }
        internal Reserva Reserva { get => reserva; set => reserva = value; }
    }
}
