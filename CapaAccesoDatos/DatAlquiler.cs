using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class DatAlquiler
    {
        #region singleton

        private static readonly DatAlquiler instancia = new DatAlquiler();
        public static DatAlquiler Instancia
        {
            get
            {
                return DatAlquiler.instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<EntHabitacion> ListarHabitacionesDisponibles(int cantidadPersonas,string fechaIngreso)
        {
            SqlCommand cmd = null;
            List<EntHabitacion> lista = new List<EntHabitacion>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_HabitacionesDisponiblesAlquiler", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                cmd.Parameters.AddWithValue("@prmintCantidadPersonas", cantidadPersonas);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntHabitacion habitacion = new EntHabitacion
                    {
                        NumeroHabitacion = Convert.ToString(dr["NumeroHabitacion"])
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

        public Boolean RealizarAlquiler(EntAlquiler alquiler)
        {
            SqlCommand cmd = null;
            Boolean alquila;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_RealizarAlquiler", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@prmintAlquilerID",alquiler.AlquilerID);
                cmd.Parameters.AddWithValue("@prmintCantidadAdultos", alquiler.CantidaAdultos);
                cmd.Parameters.AddWithValue("@prmintCantidadKids", alquiler.CantidadKids);
                cmd.Parameters.AddWithValue("@prmstrFechadeingreso", alquiler.FechadeIngreso);
                cmd.Parameters.AddWithValue("@prmstrFechadesalida", alquiler.FechadeSalida);
                cmd.Parameters.AddWithValue("@prmstrDni", alquiler.Huesped.Dni);
                cmd.Parameters.AddWithValue("@prmstrNumeroHabitacion", alquiler.Habitacion.NumeroHabitacion);
                cn.Open();
                int result = cmd.ExecuteNonQuery();
                alquila = result > 0 ? true : false;
            }
            catch (SqlException err)
            {
                throw err;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return alquila;
        }

        #endregion metodos

    }
}
