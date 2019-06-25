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
        [Required]
        public string NombreUsuario { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PasswordAccount { get; set; }
        public string FechaCreacion { get; set; }
        public EntHuesped Huesped { get; set; }
        public EntAdministradorhotel Admin { get; set; }

        public double Monto { get; set; }
        public int ReservaID { get; set; }
    }
}
