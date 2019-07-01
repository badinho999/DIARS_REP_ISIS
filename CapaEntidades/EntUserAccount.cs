using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EntUserAccount
    {
        public string UserName { get; set; }
        public string FechaNacimiento { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public EntCuenta Cuenta { get; set; }
    }
}
