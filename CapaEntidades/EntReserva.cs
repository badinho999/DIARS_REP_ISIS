using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EntReserva
    {
        private string fechadereserva;
        private int cantidaAdultos;
        private int cantidadKids;
        private string fechadeIngreso;
        private string fechadeSalida;
        private int reservaID;
        private EntHuesped huesped;
        private EntHabitacion habitacion;

        public string Fechadereserva { get => fechadereserva; set => fechadereserva = value; }
        public int CantidaAdultos { get => cantidaAdultos; set => cantidaAdultos = value; }
        public int CantidadKids { get => cantidadKids; set => cantidadKids = value; }
        public string FechadeIngreso { get => fechadeIngreso; set => fechadeIngreso = value; }
        public string FechadeSalida { get => fechadeSalida; set => fechadeSalida = value; }
        public int ReservaID { get => reservaID; set => reservaID = value; }
        public EntHuesped Huesped { get => huesped; set => huesped = value; }
        public EntHabitacion Habitacion { get => habitacion; set => habitacion = value; }
    }
}
