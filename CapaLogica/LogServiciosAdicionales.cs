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

        public List<EntServicioadicional> ObtenerServicios(int TipodehabitacionID)
        {
            try
            {
                return DatServiciosadicionales.Instancia.ObtenerServicios(TipodehabitacionID);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<EntServicioadicional> ListarServicios()
        {
            try
            {
                return DatServiciosadicionales.Instancia.ListarServicios();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public Boolean InsertarServicio(EntServicioadicional servicioadicional)
        {
            try
            {
                return DatServiciosadicionales.Instancia.InsertarServicio(servicioadicional);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public EntServicioadicional BuscarServicio(int ServicioadicionalID)
        {
            try
            {
                return DatServiciosadicionales.Instancia.BuscarServicio(ServicioadicionalID);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public Boolean EliminarServicio(EntServicioadicional servicioadicional)
        {
            try
            {
                return DatServiciosadicionales.Instancia.EliminarServicio(servicioadicional);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public Boolean EditarServicio(EntServicioadicional servicioadicional)
        {
            try
            {
                return DatServiciosadicionales.Instancia.EditarServicio(servicioadicional);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        #endregion metodos
    }
}
