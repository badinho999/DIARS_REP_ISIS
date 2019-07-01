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
        public List<EntHuesped> ListarHuesped()
        {
            try
            {
                List<EntHuesped> lista = DatHuesped.Instance.ListarHuesped();
                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public bool CrearUser(EntHuesped userHuesped)
        {
            try
            {
                EntHuesped userFinded = DatHuesped.Instance.BuscarUsername(userHuesped.UserName);

                if (userFinded != null)
                {
                    return false;
                }

                return DatHuesped.Instance.CrearUser(userHuesped);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool RegistrarHuesped(EntHuesped huesped)
        {
            try
            {
                EntHuesped dniFinded = DatHuesped.Instance.BuscarDni(huesped.Dni);

                if (dniFinded != null)
                {
                    return false;
                }

                return DatHuesped.Instance.RegistrarHuesped(huesped);
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
                return DatHuesped.Instance.BuscarHuesped(Dni);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public bool EliminarHuesped(EntHuesped huesped)
        {
            try
            {
                return DatHuesped.Instance.EliminarHuesped(huesped);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public EntHuesped BuscarDni(string Dni)
        {
            try
            {
                return DatHuesped.Instance.BuscarDni(Dni);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public EntHuesped BuscarUsername(string UserName)
        {
            try
            {
                return DatHuesped.Instance.BuscarUsername(UserName);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        #endregion metodos
    }
}
