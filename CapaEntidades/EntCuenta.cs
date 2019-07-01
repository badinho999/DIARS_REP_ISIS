using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CapaEntidades
{
    public class EntCuenta
    {
        public string Email { get; set; }

        public string FechaCreacion { get; set; }

        public EntHuesped Huesped { get; set; }
        public EntRecepcionista Recep { get; set; }

        //Para guardar la reserva
        public int ReservaID { get; set; }
        public double Monto { get; set; }
    }
}
