using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidades;

namespace CapaLogica
{
    public class LogComprobanteReserva
    {
        #region singleton
        private static readonly LogComprobanteReserva instancia = new LogComprobanteReserva();
        public static LogComprobanteReserva Instancia
        {
            get
            {
                return LogComprobanteReserva.instancia;
            }
        }
        #endregion singleton

        public Boolean GenerarComprobanteReserva(EntComprobantepagoreserva fact)
        {
            try
            {
                return DatComprobanteDePagoReserva.Instancia.GenerarComprobanteReserva(fact);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
