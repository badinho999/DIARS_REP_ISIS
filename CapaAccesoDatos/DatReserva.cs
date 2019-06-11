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

        public List<EntReserva> ListarHabitacionesDisponibles(int candidadPersonas)
        {
            SqlCommand cmd = null;
            List<EntReserva> lista = new List<EntReserva>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_HabitacionesDisponibles", cn);
                cmd.Parameters.AddWithValue("@cantidadPersonas",candidadPersonas);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    EntReserva reserva = new EntReserva();
                    EntHabitacion habitacion = new EntHabitacion();

                    reserva.FechadeIngreso = Convert.ToString(dr["FechaIngreso"]);
                    reserva.FechadeSalida = Convert.ToString(dr["FechaSalida"]);
                    habitacion.NumeroHabitacion = Convert.ToString(dr["NumeroHabitacion"]);
                    reserva.Habitacion = habitacion;

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
                cmd = new SqlCommand("Sp_RealizarReserva", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
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

        #endregion metodos

    }
}
