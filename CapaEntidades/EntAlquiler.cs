using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class EntAlquiler
    {
        private int cantidaddeadultos;
        private int cantidaddekids;
        private string fechadeingreso;
        private string fechadesalida;
        private int alquilerID;
        private EntHuesped huesped;
        private EntHabitacion habitacion;

        public int Cantidaddeadultos { get => cantidaddeadultos; set => cantidaddeadultos = value; }
        public int Cantidaddekids { get => cantidaddekids; set => cantidaddekids = value; }
        public string Fechadeingreso { get => fechadeingreso; set => fechadeingreso = value; }
        public string Fechadesalida { get => fechadesalida; set => fechadesalida = value; }
        public int AlquilerID { get => alquilerID; set => alquilerID = value; }
        internal EntHuesped Huesped { get => huesped; set => huesped = value; }
        internal EntHabitacion Habitacion { get => habitacion; set => habitacion = value; }
    }
}
