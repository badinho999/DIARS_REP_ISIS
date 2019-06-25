using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class DatHuesped
    {
        #region singleton
        private static readonly DatHuesped instancia = new DatHuesped();
        public static DatHuesped Instancia
        {
            get
            {
                return DatHuesped.instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<EntHuesped> ListarHuesped()
        {
            SqlCommand cmd = null;
            List<EntHuesped> lista = new List<EntHuesped>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_ListarHuesped", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    EntCuenta cuenta = new EntCuenta
                    {
                        NombreUsuario = Convert.ToString(dr["NombreUsuario"]),
                        Email = Convert.ToString(dr["Email"])
                    };
                    EntHuesped huesped = new EntHuesped
                    {
                        Dni = Convert.ToString(dr["Dni"]),
                        Nombre = Convert.ToString(dr["Nombre"]),
                        Apellidos = Convert.ToString(dr["Apellidos"]),
                        Fechadenacimiento = Convert.ToString(dr["Fechadenacimiento"]),

                        Cuenta = cuenta
                    };

                    lista.Add(huesped);
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

        public Boolean RegistrarHuesped(EntHuesped huesped)
        {
            SqlCommand cmd = null;
            Boolean registra;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_RegistrarHuesped", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrApellidos", huesped.Apellidos);
                cmd.Parameters.AddWithValue("@prmstrFechadenacimiento", huesped.Fechadenacimiento);
                cmd.Parameters.AddWithValue("@prmstrNombre", huesped.Nombre);
                cmd.Parameters.AddWithValue("@prmstrDni", huesped.Dni);
                cmd.Parameters.AddWithValue("@prmstrNombreUsuario", huesped.Cuenta.NombreUsuario);
                cn.Open();
                int result = cmd.ExecuteNonQuery();
                registra = result > 0 ? true : false;
            }
            catch (SqlException err)
            {
                throw err;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return registra;
        }

        public EntHuesped BuscarHuesped(string Dni)
        {
            SqlCommand cmd = null;
            EntHuesped huesped = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_BuscarHuesped", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrDni", Dni);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   
                    EntCuenta cuenta = new EntCuenta
                    {
                        NombreUsuario = Convert.ToString(dr["NombreUsuario"]),
                        Email = Convert.ToString(dr["Email"])
                    };
                    huesped = new EntHuesped
                    {
                        Dni = Convert.ToString(dr["Dni"]),
                        Nombre = Convert.ToString(dr["Nombre"]),
                        Apellidos = Convert.ToString(dr["Apellidos"]),
                        Fechadenacimiento = Convert.ToString(dr["Fechadenacimiento"]),

                        Cuenta = cuenta
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
            return huesped;
        }

        public Boolean EditarHuesped(EntHuesped huesped)
        {
            SqlCommand cmd = null;
            Boolean edit = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EditarHuesped", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrFechadenacimiento", huesped.Fechadenacimiento);
                cmd.Parameters.AddWithValue("@prmstrNombre", huesped.Nombre);
                cmd.Parameters.AddWithValue("@prmstrDni", huesped.Dni);
                cmd.Parameters.AddWithValue("@prmstrApellidos", huesped.Apellidos);
                cn.Open();
                int result = cmd.ExecuteNonQuery();
                edit = result > 0 ? true : false;
            }
            catch (SqlException err)
            {
                throw err;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return edit;
        }

        public Boolean EliminarHuesped(EntHuesped huesped)
        {
            SqlCommand cmd = null;
            Boolean delete;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EliminarHuesped", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrDni", huesped.Dni);
                cn.Open();
                int result = cmd.ExecuteNonQuery();
                delete = result > 0 ? true : false;
            }
            catch (SqlException err)
            {
                throw err;
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
