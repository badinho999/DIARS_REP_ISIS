using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Habitacion
    {
        private string numeroHabitacion;
        private TipoDeHabitacion tipodehabitacion;

        public string NumeroHabitacion { get => numeroHabitacion; set => numeroHabitacion = value; }
        internal TipoDeHabitacion Tipodehabitacion { get => tipodehabitacion; set => tipodehabitacion = value; }
    }
}
