using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Reserva
    {
        private string fechadereserva;
	    private double montodereserva;
	    private int reservaID;
        Alquiler alquiler;

        public string Fechadereserva { get => fechadereserva; set => fechadereserva = value; }
        public double Montodereserva { get => montodereserva; set => montodereserva = value; }
        public int ReservaID { get => reservaID; set => reservaID = value; }
        internal Alquiler Alquiler { get => alquiler; set => alquiler = value; }
    }
}
