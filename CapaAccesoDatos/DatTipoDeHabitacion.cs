using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class DatTipoDeHabitacion
    {
        #region singleton
        private static readonly DatTipoDeHabitacion instancia = new DatTipoDeHabitacion();
        public static DatTipoDeHabitacion Instancia
        {
            get
            {
                return DatTipoDeHabitacion.instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<EntTipoDeHabitacion> ListarTiposH()
        {
            SqlCommand cmd = null;
            List<EntTipoDeHabitacion> lista = new List<EntTipoDeHabitacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_ListarTiposH", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion();
                    EntServicioadicional servicioadicional = new EntServicioadicional();

                    tipoDeHabitacion.Capacidad = Convert.ToInt32(dr["Capacidad"]);
                    tipoDeHabitacion.Costoadicional = Convert.ToDouble(dr["Costoadicional"]);
                    tipoDeHabitacion.Nombretipodehabitacion = Convert.ToString  (dr["Nombretipodehabitacion"]);
                    tipoDeHabitacion.Numerodecamas = Convert.ToInt32(dr["Numerodecamas"]);
                    tipoDeHabitacion.Precio = Convert.ToInt32(dr["Precio"]);
                    tipoDeHabitacion.TipodehabitacionID = Convert.ToInt32(dr["TipodehabitacionID"]);

                    lista.Add(tipoDeHabitacion);
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

        public Boolean ingresarTipoH(EntTipoDeHabitacion tipoDeHabitacion)
        {
            SqlCommand cmd = null;
            Boolean inserta;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_InsertarTipoH",cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmintCapacidad",tipoDeHabitacion.Capacidad);
                cmd.Parameters.AddWithValue("@prmdoubleCostoadicional", tipoDeHabitacion.Costoadicional);
                cmd.Parameters.AddWithValue("@prmstrNombretipodehabitacion", tipoDeHabitacion.Nombretipodehabitacion);
                cmd.Parameters.AddWithValue("@prmintNumerodecamas", tipoDeHabitacion.Numerodecamas);
                cmd.Parameters.AddWithValue("@prmdoublePrecio", tipoDeHabitacion.Precio);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                inserta = i > 0 ? true:false;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return inserta;
        }

        #endregion metodos

    }
}
