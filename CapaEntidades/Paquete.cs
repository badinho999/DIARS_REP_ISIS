using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Paquete
    {
        private string descripcionpaquete;
        private string nombrepaquete;
        private double preciopaquete;
        private int paqueteID;
        private TipoDeHabitacion tipodehabitacion;
        private List<Alquiler> alquileres;

        public string Descripcionpaquete { get => descripcionpaquete; set => descripcionpaquete = value; }
        public string Nombrepaquete { get => nombrepaquete; set => nombrepaquete = value; }
        public double Preciopaquete { get => preciopaquete; set => preciopaquete = value; }
        public int PaqueteID { get => paqueteID; set => paqueteID = value; }
        internal TipoDeHabitacion Tipodehabitacion { get => tipodehabitacion; set => tipodehabitacion = value; }
        internal List<Alquiler> Alquileres { get => alquileres; set => alquileres = value; }
    }
}
