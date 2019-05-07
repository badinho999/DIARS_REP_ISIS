using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Alquiler
    {
        private int cantidaddeadultos;
        private int cantidaddekids;
        private string fechadeingreso;
        private string fechadesalida;
        private double totalapagar;
        private int alquilerID;
        private Huesped huesped;
        private Habitacion habitacion;
        private List<Paquete> paquetes;

        public int Cantidaddeadultos { get => cantidaddeadultos; set => cantidaddeadultos = value; }
        public int Cantidaddekids { get => cantidaddekids; set => cantidaddekids = value; }
        public string Fechadeingreso { get => fechadeingreso; set => fechadeingreso = value; }
        public string Fechadesalida { get => fechadesalida; set => fechadesalida = value; }
        public double Totalapagar { get => totalapagar; set => totalapagar = value; }
        public int AlquilerID { get => alquilerID; set => alquilerID = value; }
        internal Huesped Huesped { get => huesped; set => huesped = value; }
        internal Habitacion Habitacion { get => habitacion; set => habitacion = value; }
        internal List<Paquete> Paquetes { get => paquetes; set => paquetes = value; }
    }
}
