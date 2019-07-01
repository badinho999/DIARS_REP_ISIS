using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class DatReserva
    {
        #region singleton

        private static readonly DatReserva instancia = new DatReserva();
        public static DatReserva Instancia
        {
            get
            {
                return DatReserva.instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<EntReserva> ListarHabitacionesDisponibles(int cantidadPersonas)
        {
            SqlCommand cmd = null;
            List<EntReserva> lista = new List<EntReserva>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_HabitacionesDisponibles", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@prmintCantidadPersonas",cantidadPersonas);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {

                    EntHabitacion habitacion = new EntHabitacion
                    {
                        NumeroHabitacion = Convert.ToString(dr["NumeroHabitacion"])
                    };
                    EntReserva reserva = new EntReserva
                    {
                        FechadeIngreso = Convert.ToString(dr["FechaIngreso"]),
                        FechadeSalida = Convert.ToString(dr["FechaSalida"]),
                        Activa = Convert.ToBoolean(dr["Activa"]),
                        Habitacion = habitacion
                    };

                    lista.Add(reserva);
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

        public Boolean RealizarReserva(EntReserva reserva)
        {
            SqlCommand cmd = null;
            Boolean reservar;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_RealizarReserva", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };

                cmd.Parameters.AddWithValue("@prmintReservaID", reserva.ReservaID);
                cmd.Parameters.AddWithValue("@prmstrFechaReserva", reserva.Fechadereserva);
                cmd.Parameters.AddWithValue("@prmintCantidadAdultos", reserva.CantidaAdultos);
                cmd.Parameters.AddWithValue("@prmintCantidadKids", reserva.CantidadKids);
                cmd.Parameters.AddWithValue("@prmstrFechadeingreso", reserva.FechadeIngreso);
                cmd.Parameters.AddWithValue("@prmstrFechadesalida", reserva.FechadeSalida);
                cmd.Parameters.AddWithValue("@prmstrDni", reserva.Huesped.Dni);
                cmd.Parameters.AddWithValue("@prmstrNumeroHabitacion", reserva.Habitacion.NumeroHabitacion);
                cn.Open();
                int result = cmd.ExecuteNonQuery();
                reservar = result > 0 ? true : false;
            }
            catch (SqlException err)
            {
                throw err;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return reservar;
        }

        public List<EntReserva> BuscarReservaDeHueped(string dni)
        {
            SqlCommand cmd = null;
            List<EntReserva> lista = new List<EntReserva>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_BuscarReservaDeHuesped", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@prmstrDni", dni);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion
                    {
                        Capacidad = Convert.ToInt32(dr["Capacidad"]),
                        Nombretipodehabitacion = Convert.ToString(dr["Nombretipodehabitacion"]),
                        Costoadicional = Convert.ToInt32(dr["Costoadicional"]),
                        Numerodecamas = Convert.ToInt32(dr["Numerodecamas"]),
                        Precio = Convert.ToDouble(dr["Numerodecamas"]),
                        TipodehabitacionID = Convert.ToInt32(dr["TipodehabitacionID"]),
                    };

                    EntHabitacion habitacion = new EntHabitacion
                    {
                        NumeroHabitacion = Convert.ToString(dr["NumeroHabitacion"]),
                        Tipodehabitacion = tipoDeHabitacion
                    };
                    EntHuesped huesped = new EntHuesped
                    {
                        Dni = Convert.ToString(dr["Dni"])
                    };
                    EntReserva reserva = new EntReserva
                    {
                        ReservaID = Convert.ToInt32(dr["ReservaID"]),
                        FechadeIngreso = Convert.ToString(dr["FechaIngreso"]),
                        FechadeSalida = Convert.ToString(dr["FechaSalida"]),
                        CantidaAdultos = Convert.ToInt32(dr["CantidadAdultos"]),
                        CantidadKids = Convert.ToInt32(dr["CantidadKids"]),
                        Fechadereserva = Convert.ToString(dr["Fechadereserva"]),
                        Activa = Convert.ToBoolean(dr["Activa"]),
                        Habitacion = habitacion,
                        Huesped = huesped
                        
                    };

                    lista.Add(reserva);
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

        public List<EntReserva> MisReservas(string dni)
        {
            SqlCommand cmd = null;
            List<EntReserva> lista = new List<EntReserva>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MisReservas", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@prmstrDni", dni);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion
                    {
                        Capacidad = Convert.ToInt32(dr["Capacidad"]),
                        Nombretipodehabitacion = Convert.ToString(dr["Nombretipodehabitacion"]),
                        Costoadicional = Convert.ToInt32(dr["Costoadicional"]),
                        Numerodecamas = Convert.ToInt32(dr["Numerodecamas"]),
                        Precio = Convert.ToDouble(dr["Numerodecamas"]),
                        TipodehabitacionID = Convert.ToInt32(dr["TipodehabitacionID"]),
                    };

                    EntHabitacion habitacion = new EntHabitacion
                    {
                        NumeroHabitacion = Convert.ToString(dr["NumeroHabitacion"]),
                        Tipodehabitacion = tipoDeHabitacion
                    };
                    EntHuesped huesped = new EntHuesped
                    {
                        Dni = Convert.ToString(dr["Dni"])
                    };
                    EntReserva reserva = new EntReserva
                    {
                        ReservaID = Convert.ToInt32(dr["ReservaID"]),
                        FechadeIngreso = Convert.ToString(dr["FechaIngreso"]),
                        FechadeSalida = Convert.ToString(dr["FechaSalida"]),
                        CantidaAdultos = Convert.ToInt32(dr["CantidadAdultos"]),
                        CantidadKids = Convert.ToInt32(dr["CantidadKids"]),
                        Fechadereserva = Convert.ToString(dr["Fechadereserva"]),
                        Activa = Convert.ToBoolean(dr["Activa"]),
                        Habitacion = habitacion,
                        Huesped = huesped

                    };

                    lista.Add(reserva);
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

        public EntReserva BuscarReserva(int ReservaID)
        {
            SqlCommand cmd = null;
            EntReserva reserva = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_BuscarReserva", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@prmintReservaID", ReservaID);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion
                    {
                        Capacidad = Convert.ToInt32(dr["Capacidad"]),
                        Nombretipodehabitacion = Convert.ToString(dr["Nombretipodehabitacion"]),
                        Costoadicional = Convert.ToInt32(dr["Costoadicional"]),
                        Numerodecamas = Convert.ToInt32(dr["Numerodecamas"]),
                        Precio = Convert.ToDouble(dr["Precio"]),
                        TipodehabitacionID = Convert.ToInt32(dr["TipodehabitacionID"]),
                    };

                    EntHabitacion habitacion = new EntHabitacion
                    {
                        NumeroHabitacion = Convert.ToString(dr["NumeroHabitacion"]),
                        Tipodehabitacion = tipoDeHabitacion
                    };
                    EntHuesped huesped = new EntHuesped
                    {
                        Dni = Convert.ToString(dr["Dni"])
                    };
                    reserva = new EntReserva
                    {
                        ReservaID = Convert.ToInt32(dr["ReservaID"]),
                        FechadeIngreso = Convert.ToString(dr["FechaIngreso"]),
                        FechadeSalida = Convert.ToString(dr["FechaSalida"]),
                        CantidaAdultos = Convert.ToInt32(dr["CantidadAdultos"]),
                        CantidadKids = Convert.ToInt32(dr["CantidadKids"]),
                        Fechadereserva = Convert.ToString(dr["Fechadereserva"]),
                        Activa = Convert.ToBoolean(dr["Activa"]),
                        Habitacion = habitacion,
                        Huesped = huesped

                    };
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
            return reserva;

        }

        public bool EliminarReserva(int ReservaID)
        {
            SqlCommand cmd = null;
            bool elimina;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_EliminarReserva", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };

                cmd.Parameters.AddWithValue("@prmintReservaID", ReservaID);

                cn.Open();
                int result = cmd.ExecuteNonQuery();
                elimina = result > 0 ? true : false;
            }
            catch (SqlException err)
            {
                throw err;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return elimina;
        }

        public bool AnularReserva(int ReservaID)
        {
            SqlCommand cmd = null;
            bool anula;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_AnularReserva", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };

                cmd.Parameters.AddWithValue("@prmintReservaID", ReservaID);

                cn.Open();
                int result = cmd.ExecuteNonQuery();
                anula = result > 0 ? true : false;
            }
            catch (SqlException err)
            {
                throw err;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return anula;
        }

        #endregion metodos

    }
}
