using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidades;

namespace CapaLogica
{
    public class LogTipoDeHabitacion
    {
        #region singleton
        private static readonly LogTipoDeHabitacion instancia = new LogTipoDeHabitacion();
        public static LogTipoDeHabitacion Instancia
        {
            get
            {
                return LogTipoDeHabitacion.instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<EntTipoDeHabitacion> listarTiposH()
        {
            try
            {
                List<EntTipoDeHabitacion> lista = DatTipoDeHabitacion.Instancia.ListarTiposH();
                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Boolean ingresarTipoH(EntTipoDeHabitacion tipoDeHabitacion)
        {
            try
            {
                Boolean insertaTipo = DatTipoDeHabitacion.Instancia.ingresarTipoH(tipoDeHabitacion);

                return insertaTipo;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public EntTipoDeHabitacion buscarTipoH(int TipodehabitacionID)
        {
            try
            {
                return DatTipoDeHabitacion.Instancia.buscarTipoH(TipodehabitacionID);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public Boolean TipoHServicio(EntTipoDeHabitacion tipoDeHabitacion, EntServicioadicional serv)
        {
            try
            {
                return DatTipoDeHabitacion.Instancia.TipoHServicio(tipoDeHabitacion, serv);
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        public Boolean eliminarServicios(EntTipoDeHabitacion tipoDeHabitacion, EntServicioadicional serv)
        {
            try
            {
                return DatTipoDeHabitacion.Instancia.eliminarServicios(tipoDeHabitacion, serv);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Boolean editarTipoH(EntTipoDeHabitacion tipoDeHabitacion)
        {
            try
            {
                return DatTipoDeHabitacion.Instancia.editarTipoH(tipoDeHabitacion);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public Boolean eliminarTipoH(EntTipoDeHabitacion tipoDeHabitacion)
        {
            try
            {
                return DatTipoDeHabitacion.Instancia.eliminarTipoH(tipoDeHabitacion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion metodos

    }
}
