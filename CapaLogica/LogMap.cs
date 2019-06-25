using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaLogica
{
    public class LogMap
    {
        #region singleton
        private static readonly LogMap instancia = new LogMap();
        public static LogMap Instancia
        {
            get
            {
                return LogMap.instancia;
            }
        }
        #endregion singleton

        public EntHabitacion BuscarHabitacionRepetida(List<EntHabitacion> listaHabitaciones, string numeroDeHabitacion)
        {
            EntHabitacion habitacionRet = new EntHabitacion();
            bool encontrado = false;

            foreach (EntHabitacion habitacion in listaHabitaciones)
            {
                if (habitacion.NumeroHabitacion.Equals(numeroDeHabitacion))
                {
                    encontrado = true;
                    habitacionRet = habitacion;
                }
                else
                {
                    encontrado = false;
                }
            }

            if (encontrado)
            {
                return habitacionRet;
            }
            else
            {
                return null;
            }
        }

        public void AgregarAlista(List<EntHabitacion> listaHabitaciones, string numeroDeHabitacion)
        {
            if (BuscarHabitacionRepetida(listaHabitaciones, numeroDeHabitacion) == null)
                listaHabitaciones.Add(LogHabitacion.Instancia.BuscarHabitacion(numeroDeHabitacion));
        }

        public void EliminarHabitacionNoDisponible(List<EntHabitacion> listaHabitacionesDisponibles, List<EntHabitacion> listaHabitacionesNoDisponibles)
        {

            foreach (EntHabitacion habitacion in listaHabitacionesNoDisponibles)
            {
                listaHabitacionesDisponibles.RemoveAll(x => x.NumeroHabitacion == habitacion.NumeroHabitacion);
            }
        }

    }
}
