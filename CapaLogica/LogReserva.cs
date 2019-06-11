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

        public List<EntReserva> ListarHabitacionesDisponibles(int candidadPersonas)
        {
            try
            {
                List<EntReserva> lista = DatReserva.Instancia.ListarHabitacionesDisponibles(candidadPersonas);
                return lista;
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

        #endregion metodos
    }
}
