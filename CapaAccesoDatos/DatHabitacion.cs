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
                    tipoDeHabitacion.Descripciontipo = Convert.ToString(dr["Descripciontipo"]);
                    tipoDeHabitacion.Numerodecamas = Convert.ToInt32(dr["Numerodecamas"]);
                    tipoDeHabitacion.Precio = Convert.ToDouble(dr["Precio"]);
                    tipoDeHabitacion.Capacidad = Convert.ToInt32(dr["Capacidad"]);
                    tipoDeHabitacion.Costoadicional = Convert.ToDouble(dr["Costoadicional"]);

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
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_InsertarHabitacion", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmstrNumeroHabitacion", habitacion.NumeroHabitacion);
                cmd.Parameters.AddWithValue("@prmintTipodehabitacionID", habitacion.Tipodehabitacion.TipodehabitacionID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        #endregion metodos

    }
}
