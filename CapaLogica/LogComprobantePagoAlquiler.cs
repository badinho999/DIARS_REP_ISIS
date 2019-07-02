using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidades;


namespace CapaLogica
{
    public class LogComprobantePagoAlquiler
    {
        #region singleton
        private static readonly LogComprobantePagoAlquiler instancia = new LogComprobantePagoAlquiler();
        public static LogComprobantePagoAlquiler Instancia
        {
            get
            {
                return LogComprobantePagoAlquiler.instancia;
            }
        }
        #endregion singleton


        public Boolean GenerarComprobanteAlquiler(EntComprobantedepagoalquiler fact)
        {
            try
            {
                return DatComprobantePagoAlquiler.Instancia.GenerarComprobanteAlquiler(fact);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<EntComprobantedepagoalquiler> IngresosAlquiler()
        {
            try
            {
                return DatComprobantePagoAlquiler.Instancia.IngresosAlquiler();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

    }
}
