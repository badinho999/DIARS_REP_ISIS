﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EntHuesped
    {
        private string apellidos;
        private string fechadenacimiento;
        private string nombre;
        private string dni;
        private EntCuenta cuenta;

        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public EntCuenta Cuenta { get => cuenta; set => cuenta = value; }
    }
}
