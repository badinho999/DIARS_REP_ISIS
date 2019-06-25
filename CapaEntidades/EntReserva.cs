using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EntReserva
    {

        public string Fechadereserva { get; set; }
        public int CantidaAdultos { get; set; }
        public int CantidadKids { get; set; }
        public string FechadeIngreso { get; set; }
        public string FechadeSalida { get; set; }
        public int ReservaID { get; set; }
        public EntHuesped Huesped { get; set; }
        public EntHabitacion Habitacion { get; set; }


    }
}
