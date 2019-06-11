using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class DatHabitacion
    {
        #region singleton
        private static readonly DatHabitacion instancia = new DatHabitacion();
        public static DatHabitacion Instancia
        {
            get
            {
                return DatHabitacion.instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<EntHabitacion> ListarHabitaciones()
        {
            SqlCommand cmd = null;
            List<EntHabitacion> lista = new List<EntHabitacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_ListarHabitaciones", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntHabitacion habitacion = new EntHabitacion();
                    EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion();

                    habitacion.NumeroHabitacion = Convert.ToString(dr["NumeroHabitacion"]);
                    tipoDeHabitacion.Nombretipodehabitacion = Convert.ToString(dr["Nombretipodehabitacion"]);
                    tipoDeHabitacion.Numerodecamas = Convert.ToInt32(dr["Numerodecamas"]);
                    tipoDeHabitacion.Precio = Convert.ToDouble(dr["Precio"]);
                    tipoDeHabitacion.Capacidad = Convert.ToInt32(dr["Capacidad"]);
                    tipoDeHabitacion.Costoadicional = Convert.ToDouble(dr["Costoadicional"]);
                    tipoDeHabitacion.TipodehabitacionID = Convert.ToInt32(dr["TipodehabitacionID"]);

                    habitacion.Tipodehabitacion = tipoDeHabitacion;
                    

                    lista.Add(habitacion);
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

        public Boolean InsertarHabitacion(EntHabitacion habitacion)
        {
            SqlCommand cmd = null;
            Boolean inserta;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_InsertarHabitacion", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmstrNumeroHabitacion", habitacion.NumeroHabitacion);
                cmd.Parameters.AddWithValue("@prmintTipodehabitacionID", habitacion.Tipodehabitacion.TipodehabitacionID);
                cn.Open();
                int result = cmd.ExecuteNonQuery();
                inserta = result > 0 ? true : false;
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return inserta;
        }

        public EntHabitacion buscarHabitacion(string NumeroHabitacion)
        {
            SqlCommand cmd = null;
            EntHabitacion habitacion = null;
            EntTipoDeHabitacion tipoHabitacion = null;

            try
            {
                SqlConnection connection = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_BuscarHabitacion", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmstrNumeroHabitacion", NumeroHabitacion);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    habitacion = new EntHabitacion();
                    tipoHabitacion = new EntTipoDeHabitacion();

                    habitacion.NumeroHabitacion = Convert.ToString(reader["NumeroHabitacion"]);
                    tipoHabitacion.Nombretipodehabitacion = Convert.ToString(reader["Nombretipodehabitacion"]);
                    tipoHabitacion.Numerodecamas = Convert.ToInt32(reader["Numerodecamas"]);
                    tipoHabitacion.Precio = Convert.ToDouble(reader["Precio"]);
                    tipoHabitacion.Capacidad = Convert.ToInt32(reader["Capacidad"]);
                    tipoHabitacion.Costoadicional = Convert.ToDouble(reader["Costoadicional"]);
                    tipoHabitacion.TipodehabitacionID = Convert.ToInt32(reader["TipodehabitacionID"]);
                    habitacion.Tipodehabitacion = tipoHabitacion;
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
            return habitacion;
        }

        public Boolean eliminarHabitacion(EntHabitacion habitacion)
        {
            SqlCommand cmd = null;
            Boolean delete;

            try
            {
                SqlConnection connection = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EliminarHabitacion", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmstrNumeroHabitacion", habitacion.NumeroHabitacion);
                connection.Open();

                int result = cmd.ExecuteNonQuery();
                delete = result > 0 ? true : false;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return delete;
        }

        public Boolean editarHabitacion(EntHabitacion habitacion)
        {
            SqlCommand cmd = null;
            Boolean edit;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EditarHabitacion", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmstrNumeroHabitacion", habitacion.NumeroHabitacion);
                cmd.Parameters.AddWithValue("@prmintTipodehabitacionID", habitacion.Tipodehabitacion.TipodehabitacionID);
                cn.Open();
                int result = cmd.ExecuteNonQuery();
                edit = result > 0 ? true : false;
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return edit;
        }

        #endregion metodos

    }
}
