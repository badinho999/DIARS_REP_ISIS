using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Huesped
    {
        private string apellidos;
        private string passwordHuesped;
        private string email;
        private string fechadenacimiento;
        private string nombre;
        private string dni;

        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string PasswordHuesped { get => passwordHuesped; set => passwordHuesped = value; }
        public string Email { get => email; set => email = value; }
        public string Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
    }
}
