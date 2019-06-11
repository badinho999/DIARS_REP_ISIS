using System;
using System.Collections.Generic;
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

        public List<EntHabitacion> ListarHabitacionesDisponibles(int candidadPersonas,string fechaIngreso)
        {
            try
            {
                List<EntHabitacion> lista = DatAlquiler.Instancia.ListarHabitacionesDisponibles(candidadPersonas,fechaIngreso);
                return lista;
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
