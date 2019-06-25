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
        public List<EntTipoDeHabitacion> ListarTiposH()
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

        public Boolean IngresarTipoH(EntTipoDeHabitacion tipoDeHabitacion)
        {
            try
            {
                Boolean insertaTipo = DatTipoDeHabitacion.Instancia.IngresarTipoH(tipoDeHabitacion);

                return insertaTipo;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public EntTipoDeHabitacion BuscarTipoH(int TipodehabitacionID)
        {
            try
            {
                return DatTipoDeHabitacion.Instancia.BuscarTipoH(TipodehabitacionID);
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

        public Boolean EliminarServicios(EntTipoDeHabitacion tipoDeHabitacion, EntServicioadicional serv)
        {
            try
            {
                return DatTipoDeHabitacion.Instancia.EliminarServicios(tipoDeHabitacion, serv);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Boolean EditarTipoH(EntTipoDeHabitacion tipoDeHabitacion)
        {
            try
            {
                return DatTipoDeHabitacion.Instancia.EditarTipoH(tipoDeHabitacion);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public Boolean EliminarTipoH(EntTipoDeHabitacion tipoDeHabitacion)
        {
            try
            {
                return DatTipoDeHabitacion.Instancia.EliminarTipoH(tipoDeHabitacion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion metodos

    }
}
