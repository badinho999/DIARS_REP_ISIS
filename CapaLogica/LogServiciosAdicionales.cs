using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidades;

namespace CapaLogica
{
    public class LogServiciosAdicionales
    {
        #region singleton
        private static readonly LogServiciosAdicionales instancia = new LogServiciosAdicionales();
        public static LogServiciosAdicionales Instancia
        {
            get
            {
                return LogServiciosAdicionales.instancia;
            }
        }
        #endregion singleton
        #region metodos

        public List<EntServicioadicional> obtenerServicios(int TipodehabitacionID)
        {
            try
            {
                return DatServiciosadicionales.Instancia.obtenerServicios(TipodehabitacionID);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion metodos
    }
}
