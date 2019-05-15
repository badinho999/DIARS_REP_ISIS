using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EntServicioadicional
    {
        private string nombreDeServicio;
        private int servicioID;

        public string NombreDeServicio { get => nombreDeServicio; set => nombreDeServicio = value; }
        public int ServicioID { get => servicioID; set => servicioID = value; }
    }
}
