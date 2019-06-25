using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidades;

namespace CapaLogica
{
    public class LogCuenta
    {
        #region singleton
        private static readonly LogCuenta instancia = new LogCuenta();
        public static LogCuenta Instancia
        {
            get
            {
                return LogCuenta.instancia;
            }
        }
        #endregion singleton

        #region metodos

        public Boolean Registrarcuenta(EntCuenta cuenta)
        {
            try
            {
                return DatCuenta.Instancia.RegistrarCuenta(cuenta);
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public EntCuenta BuscarCuenta(String NombreUsuario)
        {
            try
            {
                return DatCuenta.Instancia.BuscarCuenta(NombreUsuario);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Boolean CambiarEmail(EntCuenta cuenta)
        {
            try
            {
                return DatCuenta.Instancia.CambiarEmail(cuenta);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Boolean CambiarPassword(EntCuenta cuenta)
        {
            try
            {
                return DatCuenta.Instancia.CambiarPassword(cuenta);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Boolean EliminarCuenta(EntCuenta cuenta)
        {
            try
            {
                return DatCuenta.Instancia.EliminarCuenta(cuenta);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public EntCuenta VerificarAcceso(string NombreUsuario, string Password)
        {
            try
            {
                return DatCuenta.Instancia.VerificarAcceso(NombreUsuario, Password);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion metodos

    }
}
