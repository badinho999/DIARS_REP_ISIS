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
                cmd = new SqlCommand("Sp_ListarTiposH", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion
                    {
                        Capacidad = Convert.ToInt32(dr["Capacidad"]),
                        Costoadicional = Convert.ToDouble(dr["Costoadicional"]),
                        Nombretipodehabitacion = Convert.ToString(dr["Nombretipodehabitacion"]),
                        Numerodecamas = Convert.ToInt32(dr["Numerodecamas"]),
                        Precio = Convert.ToInt32(dr["Precio"]),
                        TipodehabitacionID = Convert.ToInt32(dr["TipodehabitacionID"])
                    };

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

        public Boolean IngresarTipoH(EntTipoDeHabitacion tipoDeHabitacion)
        {
            SqlCommand cmd = null;
            Boolean inserta;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_InsertarTipoH", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
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

        public bool TipoHServicio(EntTipoDeHabitacion tipoDeHabitacion, EntServicioadicional servicioadicional)
        {
            SqlCommand cmd = null;
            Boolean inserta;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_TipoHServicio", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmintTipodehabitacionID", tipoDeHabitacion.TipodehabitacionID);
                cmd.Parameters.AddWithValue("@prmintServicioadicionalID", servicioadicional.ServicioID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                inserta = i > 0 ? true : false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return inserta;
        }

        public bool EliminarServicios(EntTipoDeHabitacion tipoDeHabitacion, EntServicioadicional servicioadicional)
        {
            SqlCommand cmd = null;
            Boolean delete;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EliminarServicios", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmintTipodehabitacionID", tipoDeHabitacion.TipodehabitacionID);
                cmd.Parameters.AddWithValue("@prmintServicioadicionalID", servicioadicional.ServicioID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                delete = i > 0 ? true : false;
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

        public EntTipoDeHabitacion BuscarTipoH(int TipodehabitacionID)
        {
            SqlCommand cmd = null;
            EntTipoDeHabitacion tipoDeHabitacion = null;

            try
            {
                SqlConnection connection = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_BuscarTipoH", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmintTipodehabitacionID", TipodehabitacionID);
                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    tipoDeHabitacion = new EntTipoDeHabitacion
                    {
                        Capacidad = Convert.ToInt32(dr["Capacidad"]),
                        Costoadicional = Convert.ToDouble(dr["Costoadicional"]),
                        Nombretipodehabitacion = Convert.ToString(dr["Nombretipodehabitacion"]),
                        Numerodecamas = Convert.ToInt32(dr["Numerodecamas"]),
                        Precio = Convert.ToInt32(dr["Precio"]),
                        TipodehabitacionID = Convert.ToInt32(dr["TipodehabitacionID"])
                    };
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return tipoDeHabitacion;
        }

        public Boolean EditarTipoH(EntTipoDeHabitacion tipoDeHabitacion)
        {
            SqlCommand cmd = null;
            Boolean edit;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EditarTipoH", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmintCapacidad", tipoDeHabitacion.Capacidad);
                cmd.Parameters.AddWithValue("@prmdoubleCostoadicional", tipoDeHabitacion.Costoadicional);
                cmd.Parameters.AddWithValue("@prmstrNombretipodehabitacion", tipoDeHabitacion.Nombretipodehabitacion);
                cmd.Parameters.AddWithValue("@prmintNumerodecamas", tipoDeHabitacion.Numerodecamas);
                cmd.Parameters.AddWithValue("@prmdoublePrecio", tipoDeHabitacion.Precio);
                cmd.Parameters.AddWithValue("@prmintTipodehabitacionID", tipoDeHabitacion.TipodehabitacionID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                edit = i > 0 ? true : false;
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

        public Boolean EliminarTipoH(EntTipoDeHabitacion tipoDeHabitacion)
        {
            SqlCommand cmd = null;
            Boolean delete;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EliminarTipoH", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmintTipodehabitacionID", tipoDeHabitacion.TipodehabitacionID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                delete = i > 0 ? true : false;
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

        #endregion metodos

    }
}
