using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CapaEntidades
{
    public class EntHabitacion
    {

        [Required]
        [StringLength(4)]
        public string NumeroHabitacion { get; set; }
        [Required]
        public EntTipoDeHabitacion Tipodehabitacion { get; set; }

        #region methods

        public double AplicarDescuentoPorReserva()
        {
            return Tipodehabitacion.Precio *= 0.2;
        }


        public int Alojamientos { get; set; }

        #endregion methods

    }
}
