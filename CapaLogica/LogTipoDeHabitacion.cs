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
        #endregion metodos

    }
}
