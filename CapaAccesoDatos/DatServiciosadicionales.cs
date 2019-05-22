using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class DatServiciosadicionales
    {
        #region singleton
        private static readonly DatServiciosadicionales instancia = new DatServiciosadicionales();
        public static DatServiciosadicionales Instancia
        {
            get
            {
                return DatServiciosadicionales.instancia;
            }
        }
        #endregion singleton

        #region metodos

        //Listar servicios
        public List<EntServicioadicional> listarServicios()
        {
            SqlCommand cmd = null;
            List<EntServicioadicional> servicioadicionals = new List<EntServicioadicional>();

            try
            {
                SqlConnection connection = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_ListarServicios", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    EntServicioadicional servicioadicional = new EntServicioadicional();

                    servicioadicional.NombreDeServicio = Convert.ToString(reader["NombreServicio"]);
                    servicioadicional.ServicioID = Convert.ToInt32(reader["ServicioadicionalID"]);

                    servicioadicionals.Add(servicioadicional);
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return servicioadicionals;
        }

        public Boolean insertarServicio(EntServicioadicional servicioadicional)
        {
            SqlCommand cmd = null;
            Boolean insert;

            try
            {
                SqlConnection connection = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_InsertarServicios", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmstrNombreServicio", servicioadicional.NombreDeServicio);
                connection.Open();

                int result = cmd.ExecuteNonQuery();
                insert = result > 0 ? true : false;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return insert;
        }

        public EntServicioadicional buscarServicio(int ServicioadicionalID)
        {
            SqlCommand cmd = null;
            EntServicioadicional servicioadicional = null;

            try
            {
                SqlConnection connection = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_BuscarServicio", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmintServicioadicionalID", ServicioadicionalID);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    servicioadicional = new EntServicioadicional();
                    servicioadicional.NombreDeServicio = Convert.ToString(reader["NombreServicio"]);
                    servicioadicional.ServicioID = Convert.ToInt32(reader["ServicioadicionalID"]);
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return servicioadicional;
        }

        public Boolean eliminarServicio(EntServicioadicional servicioadicional)
        {
            SqlCommand cmd = null;
            Boolean delete;

            try
            {
                SqlConnection connection = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EliminarServicio", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmintServicioadicionalID", servicioadicional.ServicioID);
                connection.Open();

                int result = cmd.ExecuteNonQuery();
                delete = result > 0 ? true : false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return delete;
        }

        public Boolean editarServicio(EntServicioadicional servicioadicional)
        {
            SqlCommand cmd = null;
            Boolean edit;

            try
            {
                SqlConnection connection = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EditarServicio", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmintServicioadicionalID", servicioadicional.ServicioID);
                cmd.Parameters.AddWithValue("@prmstrNombreServicio", servicioadicional.NombreDeServicio);
                connection.Open();

                int result = cmd.ExecuteNonQuery();
                edit = result > 0 ? true : false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return edit;
        }



        //Obtener servicios del tipo de habitacion
        public List<EntServicioadicional> obtenerServicios(int TipodehabitacionID)
        {
            SqlCommand cmd = null;
            List<EntServicioadicional> servicioadicionals = new List<EntServicioadicional>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_ObtenerServicios", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmintTipodehabitacionID", TipodehabitacionID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    EntServicioadicional servicioadicional = new EntServicioadicional();

                    servicioadicional.NombreDeServicio = Convert.ToString(dr["NombreServicio"]);
                    servicioadicional.ServicioID = Convert.ToInt32(dr["ServicioadicionalID"]);

                    servicioadicionals.Add(servicioadicional);
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
            return servicioadicionals;
        }



        #endregion metodos
    }
}
