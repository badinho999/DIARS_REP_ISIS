using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class LogReserva
    {
        #region singleton
        private static readonly LogReserva instancia = new LogReserva();
        public static LogReserva Instancia
        {
            get
            {
                return LogReserva.instancia;
            }
        }
        #endregion singleton

        #region metodos

        

        public List<EntHabitacion> ListarHabitacionesDisponibles(int cantidadPersonas,DateTime fechaIngreso, DateTime fechaSalida)
        {
            try
            {
                List<EntHabitacion> listaHabitacionesDisponibles = new List<EntHabitacion>();
                List<EntHabitacion> listaHabitacionesNoDisponibles = new List<EntHabitacion>();
                bool esMayor = false;

                List<EntReserva> reservas;

                reservas = DatReserva.Instancia.ListarHabitacionesDisponibles(cantidadPersonas);

                LogMap map = LogMap.Instancia;

                foreach (EntReserva reserva in reservas)
                {
                    DateTime fechaIngresoAux, fechaSalidaAux;

                    fechaIngresoAux = Convert.ToDateTime(reserva.FechadeIngreso);
                    fechaSalidaAux = Convert.ToDateTime(reserva.FechadeSalida);

                    if (DateTime.Compare(fechaIngreso, fechaSalidaAux) > 0)
                    {
                        esMayor = true;
                    }
                    else if (DateTime.Compare(fechaIngreso, fechaIngresoAux) < 0)
                    {
                        esMayor = false;
                    }

                    if (esMayor)
                    {
                        map.AgregarAlista(listaHabitacionesDisponibles, reserva.Habitacion.NumeroHabitacion);
                    }
                    else
                    {
                        if (DateTime.Compare(fechaSalida, fechaIngresoAux) < 0)
                        {
                            map.AgregarAlista(listaHabitacionesDisponibles, reserva.Habitacion.NumeroHabitacion);
                        }
                        else
                        {
                            map.AgregarAlista(listaHabitacionesNoDisponibles, reserva.Habitacion.NumeroHabitacion);
                        }
                    }
                }
                map.EliminarHabitacionNoDisponible(listaHabitacionesDisponibles, listaHabitacionesNoDisponibles);
                return listaHabitacionesDisponibles;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Boolean RealizarReserva(EntReserva reserva)
        {
            try
            {
                return DatReserva.Instancia.RealizarReserva(reserva);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public List<EntReserva> BuscarReservaDeHueped(string dni)
        {
            try
            {
                return DatReserva.Instancia.BuscarReservaDeHueped(dni);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<EntReserva> MisReservas(string dni)
        {
            try
            {
                return DatReserva.Instancia.MisReservas(dni);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public EntReserva BuscarReserva(int ReservaID)
        {
            try
            {
                return DatReserva.Instancia.BuscarReserva(ReservaID);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool EliminarReserva(int ReservaID)
        {
            try
            {
                return DatReserva.Instancia.EliminarReserva(ReservaID);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool AnularReserva(int ReservaID)
        {
            try
            {
                return DatReserva.Instancia.AnularReserva(ReservaID);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        #endregion metodos
    }
}
