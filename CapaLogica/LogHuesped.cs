using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidades;


namespace CapaLogica
{
    public class LogHuesped
    {
        #region singleton
        private static readonly LogHuesped instancia = new LogHuesped();
        public static LogHuesped Instancia
        {
            get
            {
                return LogHuesped.instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<EntHuesped> listarHuesped()
        {
            try
            {
                List<EntHuesped> lista = DatHuesped.Instancia.ListarHuesped();
                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Boolean registrarHuesped(EntHuesped huesped)
        {
            try
            {
                return DatHuesped.Instancia.RegistrarHuesped(huesped);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public EntHuesped BuscarHuesped(string Dni)
        {
            try
            {
                return DatHuesped.Instancia.BuscarHuesped(Dni);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Boolean editarHuesped(EntHuesped huesped)
        {
            try
            {
                return DatHuesped.Instancia.EditarHuesped(huesped);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Boolean eliminarHuesped(EntHuesped huesped)
        {
            try
            {
                return DatHuesped.Instancia.EliminarHuesped(huesped);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        #endregion metodos
    }
}
