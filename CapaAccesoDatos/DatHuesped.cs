using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class DatHuesped
    {
        #region singleton
        private static readonly DatHuesped instancia = new DatHuesped();
        public static DatHuesped Instancia
        {
            get
            {
                return DatHuesped.instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<EntHuesped> ListarHuesped()
        {
            SqlCommand cmd = null;
            List<EntHuesped> lista = new List<EntHuesped>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_ListarHuesped", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntHuesped huesped = new EntHuesped();

                    huesped.Dni = Convert.ToString(dr["Dni"]);
                    huesped.Nombre = Convert.ToString(dr["Nombre"]);
                    huesped.Apellidos = Convert.ToString(dr["Apellidos"]);
                    huesped.Fechadenacimiento = Convert.ToString(dr["Fechadenacimiento"]);
                    huesped.Email = Convert.ToString(dr["Email"]);
                    lista.Add(huesped);
                }
            }
            catch (SqlException e)
            {

                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }


        #endregion metodos
    }
}
