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

        public bool CrearCuenta(EntCuenta cuenta)
        {
            try
            {
                EntCuenta emailAccountFinded = DatCuenta.Instance.BuscarEmail(cuenta.Email);
               

                if (emailAccountFinded != null)
                {
                    return false;
                }

                return DatCuenta.Instance.CrearCuenta(cuenta);
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public EntCuenta BuscarCuenta(string Email)
        {
            try
            {
                return DatCuenta.Instance.BuscarCuenta(Email);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public bool EliminarCuenta(EntCuenta cuenta)
        {
            try
            {
                return DatCuenta.Instance.EliminarCuenta(cuenta);
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
                return DatCuenta.Instance.VerificarAcceso(NombreUsuario, Password);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public EntCuenta VerifyEmail(string email)
        {
            try
            {
                return DatCuenta.Instance.BuscarEmail(email);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        #endregion metodos

    }
}
