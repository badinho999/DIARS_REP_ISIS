using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EntHabitacion
    {
        private string numeroHabitacion;
        private EntTipoDeHabitacion tipodehabitacion;

        public string NumeroHabitacion { get => numeroHabitacion; set => numeroHabitacion = value; }
        public EntTipoDeHabitacion Tipodehabitacion { get => tipodehabitacion; set => tipodehabitacion = value; }
    }
}
