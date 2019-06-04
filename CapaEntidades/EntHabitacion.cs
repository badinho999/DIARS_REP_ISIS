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
        private string numeroHabitacion;
        private EntTipoDeHabitacion tipodehabitacion;
        [Required]
        [StringLength(4)]
        public string NumeroHabitacion { get => numeroHabitacion; set => numeroHabitacion = value; }
        [Required]
        public EntTipoDeHabitacion Tipodehabitacion { get => tipodehabitacion; set => tipodehabitacion = value; }
    }
}
