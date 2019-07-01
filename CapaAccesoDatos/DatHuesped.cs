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
            static DatHuesped()
            {

            }

            private DatHuesped()
            {

            }

            public static DatHuesped Instance { get; } = new DatHuesped();  
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
                        Email = Convert.ToString(dr["Email"])
                    };
                    EntHuesped huesped = new EntHuesped
                    {
                        UserName = Convert.ToString(dr["UserName"]),
                        Dni = Convert.ToString(dr["Dni"]),
                        Nombre = Convert.ToString(dr["Nombre"]),
                        Apellidos = Convert.ToString(dr["Apellidos"]),
                        FechaNacimiento = Convert.ToString(dr["Fechadenacimiento"]),

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

        public bool CrearUser(EntHuesped userHuesped)
        {
            SqlCommand cmd = null;
            bool crea;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_CrearUser", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrUserName", userHuesped.UserName);
                cmd.Parameters.AddWithValue("@prmstrFechaNacimiento", userHuesped.FechaNacimiento);
                cmd.Parameters.AddWithValue("@prmstrNombre", userHuesped.Nombre);
                cmd.Parameters.AddWithValue("@prmstrApellidos", userHuesped.Apellidos);

                cn.Open();
                int result = cmd.ExecuteNonQuery();
                crea = result > 0 ? true : false;
            }
            catch (SqlException err)
            {
                throw err;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return crea;
        }

        public bool RegistrarHuesped(EntHuesped huesped)
        {
            SqlCommand cmd = null;
            bool registra;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_RegistrarHuesped", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrDni", huesped.Dni);
                cmd.Parameters.AddWithValue("@prmstrUserName", huesped.UserName);

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

        public bool EliminarHuesped(EntHuesped huesped)
        {
            SqlCommand cmd = null;
            bool delete;

            try
            {
                SqlConnection conexion = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_EliminarUser", conexion)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@prmstrUserName", huesped.UserName);

                conexion.Open();
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
                        Email = Convert.ToString(dr["Email"]),
                    };
                    huesped = new EntHuesped
                    {

                        Dni = Convert.ToString(dr["Dni"]),
                        Nombre = Convert.ToString(dr["Nombre"]),
                        Apellidos = Convert.ToString(dr["Apellidos"]),
                        FechaNacimiento = Convert.ToString(dr["Fechadenacimiento"]),
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


        public EntHuesped BuscarDni(string Dni)
        {
            SqlCommand cmd = null;
            EntHuesped huesped = null;

            try
            {
                SqlConnection conexion = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_BuscarDni", conexion)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrDni", Dni);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    huesped = new EntHuesped
                    {
                        Dni = Convert.ToString(reader["Dni"])
                    };

                }
            }
            catch (SqlException err)
            {

                throw err;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return huesped;
        }

        public EntHuesped BuscarUsername(string UserName)
        {
            SqlCommand cmd = null;
            EntHuesped huesped = null;

            try
            {
                SqlConnection conexion = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_BuscarUsername", conexion)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrUserName", UserName);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    huesped = new EntHuesped
                    {
                        UserName = Convert.ToString(reader["UserName"])
                    };

                }
            }
            catch (SqlException err)
            {

                throw err;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return huesped;
        }

        /************************No se usa aún******************************/

        public bool EditarHuesped(EntHuesped huesped)
        {
            SqlCommand cmd = null;
            bool edit = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EditarHuesped", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrFechadenacimiento", huesped.FechaNacimiento);
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

        

        #endregion metodos
    }
}
