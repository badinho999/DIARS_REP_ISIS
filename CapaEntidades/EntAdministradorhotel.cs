using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EntAdministradorhotel
    {
        private string apellidos;
        private string fechadenacimiento;
        private string nombre;
        private string administradorhotelID;
        private EntCuenta cuenta;

        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string AdministradorhotelID { get => administradorhotelID; set => administradorhotelID = value; }
        public EntCuenta Cuenta { get => cuenta; set => cuenta = value; }
    }
}
