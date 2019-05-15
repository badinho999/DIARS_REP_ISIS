using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class EntComprobantepagoreserva
    {
        private string fechadeemision;
        private string ruc;
        private int numeroSerie;
        private EntReserva reserva;

        public string Fechadeemision { get => fechadeemision; set => fechadeemision = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public int NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        internal EntReserva Reserva { get => reserva; set => reserva = value; }
    }
}
