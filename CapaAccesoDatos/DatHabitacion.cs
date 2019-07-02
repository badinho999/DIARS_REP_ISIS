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
                cmd = new SqlCommand("Sp_ListarHabitaciones", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion
                    {
                        Nombretipodehabitacion = Convert.ToString(dr["Nombretipodehabitacion"]),
                        Numerodecamas = Convert.ToInt32(dr["Numerodecamas"]),
                        Precio = Convert.ToDouble(dr["Precio"]),
                        Capacidad = Convert.ToInt32(dr["Capacidad"]),
                        Costoadicional = Convert.ToDouble(dr["Costoadicional"]),
                        TipodehabitacionID = Convert.ToInt32(dr["TipodehabitacionID"])
                    };

                    EntHabitacion habitacion = new EntHabitacion
                    {
                        NumeroHabitacion = Convert.ToString(dr["NumeroHabitacion"]),
                        Tipodehabitacion = tipoDeHabitacion
                    };
                 

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
                cmd = new SqlCommand("Sp_InsertarHabitacion", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
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

        public EntHabitacion BuscarHabitacion(string NumeroHabitacion)
        {
            SqlCommand cmd = null;
            EntHabitacion habitacion = null;
            EntTipoDeHabitacion tipoHabitacion = null;

            try
            {
                SqlConnection connection = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_BuscarHabitacion", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrNumeroHabitacion", NumeroHabitacion);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    
                    tipoHabitacion = new EntTipoDeHabitacion
                    {
                        Nombretipodehabitacion = Convert.ToString(reader["Nombretipodehabitacion"]),
                        Numerodecamas = Convert.ToInt32(reader["Numerodecamas"]),
                        Precio = Convert.ToDouble(reader["Precio"]),
                        Capacidad = Convert.ToInt32(reader["Capacidad"]),
                        Costoadicional = Convert.ToDouble(reader["Costoadicional"]),
                        TipodehabitacionID = Convert.ToInt32(reader["TipodehabitacionID"])
                    };
                    habitacion = new EntHabitacion
                    {
                        NumeroHabitacion = Convert.ToString(reader["NumeroHabitacion"]),

                        Tipodehabitacion = tipoHabitacion
                    };
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

        public Boolean EliminarHabitacion(EntHabitacion habitacion)
        {
            SqlCommand cmd = null;
            Boolean delete;

            try
            {
                SqlConnection connection = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EliminarHabitacion", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
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

        public Boolean EditarHabitacion(EntHabitacion habitacion)
        {
            SqlCommand cmd = null;
            Boolean edit;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EditarHabitacion", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
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

        public List<EntHabitacion> MasOcupadas()
        {
            SqlCommand cmd = null;
            List<EntHabitacion> lista = new List<EntHabitacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_HabitacionesMasOcupadas", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion
                    {
                        Nombretipodehabitacion = Convert.ToString(dr["Nombretipodehabitacion"]),
                    };

                    EntHabitacion habitacion = new EntHabitacion
                    {
                        NumeroHabitacion = Convert.ToString(dr["NumeroHabitacion"]),
                        Tipodehabitacion = tipoDeHabitacion,
                        Alojamientos = Convert.ToInt32(dr["Cantidad"])
                    };


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

        #endregion metodos

    }
}
