using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidades;

namespace CapaLogica
{
    public class LogAlquiler
    {
        #region singleton
        private static readonly LogAlquiler instancia = new LogAlquiler();
        public static LogAlquiler Instancia
        {
            get
            {
                return LogAlquiler.instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<EntHabitacion> ListarHabitacionesDisponibles(int cantidadPersonas,string fechaIngreso,DateTime fechaSalida)
        {
            try
            {
                DateTime _fechaIngreso = Convert.ToDateTime(fechaIngreso, CultureInfo.InvariantCulture);
                List<EntHabitacion> listaHabitacionesDisponibles = LogReserva.Instancia.ListarHabitacionesDisponibles(cantidadPersonas,_fechaIngreso, fechaSalida);
                List<EntHabitacion> alquilers = DatAlquiler.Instancia.ListarHabitacionesDisponibles(cantidadPersonas,fechaIngreso);


                LogMap.Instancia.EliminarHabitacionNoDisponible(listaHabitacionesDisponibles, alquilers);

                return listaHabitacionesDisponibles;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Boolean RealizarAlquiler(EntAlquiler alquiler)
        {
            try
            {
                return DatAlquiler.Instancia.RealizarAlquiler(alquiler);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        #endregion metodos

    }
}
