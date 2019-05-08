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
        public List<EntHabitacion> listarHabitaciones()
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

        public Boolean insertarHabitacion(EntHabitacion habitacion)
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
        #endregion metodos

    }
}
