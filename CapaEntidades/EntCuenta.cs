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
        private string nombreUsuario;
        private string email;
        private string passwordAccount;
        private string fechaCreacion;
        private EntHuesped huesped;
        private EntAdministradorhotel admin;

        [Required]
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        [Required]
        [EmailAddress]
        public string Email { get => email; set => email = value; }
        [Required]
        public string PasswordAccount { get => passwordAccount; set => passwordAccount = value; }
        public string FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public EntHuesped Huesped { get => huesped; set => huesped = value; }
        public EntAdministradorhotel Admin { get => admin; set => admin = value; }
    }
}
