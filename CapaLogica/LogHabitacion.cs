using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidades;

namespace CapaLogica
{
    public class LogHabitacion
    {
        #region singleton
        private static readonly LogHabitacion instancia = new LogHabitacion();
        public static LogHabitacion Instancia
        {
            get
            {
                return LogHabitacion.instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<EntHabitacion> ListarHabitaciones()
        {
            try
            {
                List<EntHabitacion> lista = DatHabitacion.Instancia.ListarHabitaciones();
                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Boolean InsertarHabitacion(EntHabitacion habitacion)
        {
            try
            {
                return DatHabitacion.Instancia.InsertarHabitacion(habitacion);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public EntHabitacion BuscarHabitacion(string NumeroHabitacion)
        {
            try
            {
                return DatHabitacion.Instancia.BuscarHabitacion(NumeroHabitacion);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public Boolean EliminarHabitacion(EntHabitacion habitacion)
        {
            try
            {
                return DatHabitacion.Instancia.EliminarHabitacion(habitacion);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public Boolean EditarHabitacion(EntHabitacion habitacion)
        {
            try
            {
                return DatHabitacion.Instancia.EditarHabitacion(habitacion);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public List<EntHabitacion> MasOcupadas()
        {
            try
            {
                return DatHabitacion.Instancia.MasOcupadas();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        #endregion metodos

    }
}
