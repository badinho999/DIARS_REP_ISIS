using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EntCuenta
    {
        private string nombreUsuario;
        private string email;
        private string passwordAccount;
        private string fechaCreacion;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Email { get => email; set => email = value; }
        public string PasswordAccount { get => passwordAccount; set => passwordAccount = value; }
        public string FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
    }
}
