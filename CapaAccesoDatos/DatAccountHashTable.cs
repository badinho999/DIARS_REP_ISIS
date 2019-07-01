using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class DatAccountHashTable
    {
        #region Singleton

        static DatAccountHashTable()
        {

        }

        private DatAccountHashTable()
        {

        }

        public static DatAccountHashTable Instance { get; } = new DatAccountHashTable();

        #endregion Singleton

        public bool EnlazarHashCuenta(EntAccountHashTable accountHashTable)
        {
            SqlCommand cmd = null;
            bool enlazar;

            try
            {
                SqlConnection connection = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_EnlazarHashCuenta", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };


                cmd.Parameters.AddWithValue("@prmstrEmail", accountHashTable.Cuenta.Email);
                cmd.Parameters.AddWithValue("@prmstrHashCode", accountHashTable.Hashtable.HashCode);

                connection.Open();

                int result = cmd.ExecuteNonQuery();

                enlazar = result > 0 ? true : false;

            }
            catch (SqlException e)
            {

                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return enlazar;
        }

        public bool ActualizarEstado(EntAccountHashTable accountHashTable)
        {
            SqlCommand cmd = null;
            bool update;

            try
            {
                SqlConnection connection = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_ActualizarEstado", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@prmstrEmail", accountHashTable.Cuenta.Email);
                cmd.Parameters.AddWithValue("@prmstrHashCode", accountHashTable.Hashtable.HashCode);

                connection.Open();

                int result = cmd.ExecuteNonQuery();

                update = result > 0 ? true : false;

            }
            catch (SqlException e)
            {

                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return update;
        }

    }
}
