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

        public List<EntServicioadicional> listarServicios()
        {
            try
            {
                return DatServiciosadicionales.Instancia.listarServicios();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public Boolean insertarServicio(EntServicioadicional servicioadicional)
        {
            try
            {
                return DatServiciosadicionales.Instancia.insertarServicio(servicioadicional);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public EntServicioadicional buscarServicio(int ServicioadicionalID)
        {
            try
            {
                return DatServiciosadicionales.Instancia.buscarServicio(ServicioadicionalID);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public Boolean eliminarServicio(EntServicioadicional servicioadicional)
        {
            try
            {
                return DatServiciosadicionales.Instancia.eliminarServicio(servicioadicional);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public Boolean editarServicio(EntServicioadicional servicioadicional)
        {
            try
            {
                return DatServiciosadicionales.Instancia.editarServicio(servicioadicional);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        #endregion metodos
    }
}
