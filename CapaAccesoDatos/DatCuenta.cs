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
        private static readonly DatCuenta instancia = new DatCuenta();
        public static DatCuenta Instancia
        {
            get
            {
                return DatCuenta.instancia;
            }
        }
        #endregion singleton

        #region metodos

        public Boolean RegistrarCuenta(EntCuenta cuenta)
        {
            SqlCommand cmd = null;
            Boolean registra;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_RegistrarCuenta", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmstrNombreUsuario", cuenta.NombreUsuario);
                cmd.Parameters.AddWithValue("@prmstrEmail", cuenta.Email);
                cmd.Parameters.AddWithValue("@prmstrPasswordAccount", cuenta.PasswordAccount);
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

        public EntCuenta BuscarCuenta(string NombreUsuario)
        {
            SqlCommand cmd = null;
            EntCuenta cuenta = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_BuscarCuenta", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmstrNombreUsuario", NombreUsuario);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cuenta = new EntCuenta();
                    cuenta.NombreUsuario = Convert.ToString(dr["NombreUsuario"]);
                    cuenta.Email = Convert.ToString(dr["Email"]);
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

        public Boolean CambiarEmail(EntCuenta cuenta)
        {
            SqlCommand cmd = null;
            Boolean edit = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EditarEmail", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmstrNombreUsuario", cuenta.NombreUsuario);
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

        public Boolean CambiarPassword(EntCuenta cuenta)
        {
            SqlCommand cmd = null;
            Boolean edit = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_CambiarPassword", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmstrNombreUsuario", cuenta.NombreUsuario);
                cmd.Parameters.AddWithValue("@prmstrPasswordAccount", cuenta.PasswordAccount);
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

        public Boolean EliminarCuenta(EntCuenta cuenta)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EliminarCuenta", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmstrNombreUsuario", cuenta.NombreUsuario);
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
