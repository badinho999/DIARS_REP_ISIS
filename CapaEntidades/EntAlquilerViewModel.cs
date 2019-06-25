using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaEntidades
{
    public class EntAlquilerViewModel
    {
        public EntAlquiler Alquiler { get; set; }
        public List<EntHabitacion> Habitaciones { get; set; }
        public List<EntReserva> Reservas { get; set; }
        public int ErrorID { get; set; }
    }
}
