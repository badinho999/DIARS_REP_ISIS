using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EntTipoDeHabitacion
    {
        private int capacidad;
        private double costoadicional;
        private string descripciontipo;
        private string nombretipodehabitacion;
        private int numerodecamas;
        private double precio;
        private int tipodehabitacionID;

        public int Capacidad { get => capacidad; set => capacidad = value; }
        public string Descripciontipo { get => descripciontipo; set => descripciontipo = value; }
        public string Nombretipodehabitacion { get => nombretipodehabitacion; set => nombretipodehabitacion = value; }
        public int Numerodecamas { get => numerodecamas; set => numerodecamas = value; }
        public double Precio { get => precio; set => precio = value; }
        public int TipodehabitacionID { get => tipodehabitacionID; set => tipodehabitacionID = value; }
        public double Costoadicional { get => costoadicional; set => costoadicional = value; }
    }
}
