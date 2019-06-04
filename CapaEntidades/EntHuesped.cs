using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CapaEntidades
{
    public class EntHuesped
    {
        private string apellidos;
        private string fechadenacimiento;
        private string nombre;
        private string dni;
        private EntCuenta cuenta;

        [Required]
        public string Apellidos { get => apellidos; set => apellidos = value; }
        [Required]
        public string Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
        [Required]
        public string Nombre { get => nombre; set => nombre = value; }
        [Required]
        [StringLength(8)]
        public string Dni { get => dni; set => dni = value; }
        public EntCuenta Cuenta { get => cuenta; set => cuenta = value; }
    }
}
