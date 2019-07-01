using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class DatCuenta
    {
        #region singleton
            static DatCuenta()
            {

            }

            private DatCuenta()
            {

            }

            public static DatCuenta Instance { get; } = new DatCuenta();

        #endregion singleton

        #region metodos

        public bool CrearCuenta(EntCuenta cuenta)
        {
            SqlCommand cmd = null;
            bool registra;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_CrearCuenta", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrEmail", cuenta.Email);
                cmd.Parameters.AddWithValue("@prmstrUserName", cuenta.Huesped.UserName);
                
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

        public EntCuenta BuscarCuenta(string Email)
        {
            SqlCommand cmd = null;
            EntCuenta cuenta = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_BuscarCuenta", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrEmail", Email);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EntHuesped huesped = new EntHuesped
                    {
                        UserName = Convert.ToString(dr["UserName"])
                    };

                    cuenta = new EntCuenta
                    {
                        Email = Convert.ToString(dr["Email"]),
                        FechaCreacion = Convert.ToString(dr["FechaCreacion"]),
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
            return cuenta;
        }

        public bool EliminarCuenta(EntCuenta cuenta)
        {
            SqlCommand cmd = null;
            bool delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EliminarCuenta", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrUserName", cuenta.Huesped.UserName);
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

        public EntCuenta BuscarEmail(string Email)
        {
            SqlCommand cmd = null;
            EntCuenta cuenta = null;

            try
            {
                SqlConnection conexion = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_BuscarEmail", conexion)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrEmail", Email);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cuenta = new EntCuenta
                    {
                        Email = Convert.ToString(reader["Email"])
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
            return cuenta;
        }

        public EntCuenta VerificarAcceso(string NombreUsuario, string Password)
        {
            SqlCommand cmd = null;
            EntCuenta cuenta = null;

            try
            {
                bool isHuesped = true;
                string procedure = "Sp_BuscarUsuarioHuesped";

                if (NombreUsuario.Contains("HOSTALISIS."))
                {
                    procedure = "SP_BuscarUsuarioRecep";
                    isHuesped = false;
                }

                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand(procedure, cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrNombreUsuario", NombreUsuario);
                cmd.Parameters.AddWithValue("@prmstrHashCode", Password); 
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cuenta = new EntCuenta
                    {
                        Email = Convert.ToString(dr["Email"])
                    };

                    if (isHuesped)
                    {
                        EntHuesped huesped = new EntHuesped
                        {
                            UserName = Convert.ToString(dr["UserName"]),
                            Dni = Convert.ToString(dr["Dni"]),
                            Apellidos = Convert.ToString(dr["Apellidos"]),
                            Nombre = Convert.ToString(dr["Nombre"]),
                            FechaNacimiento = Convert.ToString(dr["FechaNacimiento"])
                        };
                        cuenta.Huesped = huesped;
                    }
                    else
                    {
                        EntRecepcionista r = new EntRecepcionista
                        {
                            UserName = Convert.ToString(dr["UserName"]),
                            RecepID = Convert.ToInt32(dr["RecepcionistaID"]),
                            Apellidos = Convert.ToString(dr["Apellidos"]),
                            Nombre = Convert.ToString(dr["Nombre"]),
                            FechaNacimiento = Convert.ToString(dr["FechaNacimiento"])
                        };
                        cuenta.Recep = r;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return cuenta;
        }

        /***************No se usa aún*******************/
        public bool CambiarEmail(EntCuenta cuenta)
        {
            SqlCommand cmd = null;
            bool edit = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EditarEmail", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@prmstrNombreUsuario", cuenta.Huesped.UserName);
                cmd.Parameters.AddWithValue("@prmstrEmail", cuenta.Email);
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
