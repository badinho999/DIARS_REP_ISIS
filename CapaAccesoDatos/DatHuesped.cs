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
                cmd = new SqlCommand("Sp_ListarHuesped", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntHuesped huesped = new EntHuesped();

                    huesped.Dni = Convert.ToString(dr["Dni"]);
                    huesped.Nombre = Convert.ToString(dr["Nombre"]);
                    huesped.Apellidos = Convert.ToString(dr["Apellidos"]);
                    huesped.Fechadenacimiento = Convert.ToString(dr["Fechadenacimiento"]);
                    huesped.Email = Convert.ToString(dr["Email"]);
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
            Boolean registra = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_RegistrarHuesped", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmstrApellidos", huesped.Apellidos);
                cmd.Parameters.AddWithValue("@prmstrPasswordHuesped", huesped.PasswordHuesped);
                cmd.Parameters.AddWithValue("@prmstrEmail", huesped.Email);
                cmd.Parameters.AddWithValue("@prmstrFechadenacimiento", huesped.Fechadenacimiento);
                cmd.Parameters.AddWithValue("@prmstrNombre", huesped.Nombre);
                cmd.Parameters.AddWithValue("@prmstrDni", huesped.Dni);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    registra = true;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            finally { cmd.Connection.Close(); }
            return registra;
        }

        public EntHuesped BuscarHuesped(string Dni)
        {
            SqlCommand cmd = null;
            EntHuesped huesped = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_BuscarHuesped", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmstrDni", Dni);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    huesped = new EntHuesped();
                    huesped.Dni = Convert.ToString(dr["Dni"]);
                    huesped.Nombre = Convert.ToString(dr["Nombre"]);
                    huesped.Apellidos = Convert.ToString(dr["Apellidos"]);
                    huesped.Fechadenacimiento = Convert.ToString(dr["Fechadenacimiento"]);
                    huesped.Email = Convert.ToString(dr["Email"]);
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
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EditarHuesped", cn);
                cmd.Parameters.AddWithValue("@prmstrEmail", huesped.Email);
                cmd.Parameters.AddWithValue("@prmstrFechadenacimiento", huesped.Fechadenacimiento);
                cmd.Parameters.AddWithValue("@prmstrNombre", huesped.Nombre);
                cmd.Parameters.AddWithValue("@prmstrDni", huesped.Dni);
                cmd.Parameters.AddWithValue("@prmstrApellidos", huesped.Apellidos);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        public Boolean EliminarHuesped(EntHuesped huesped)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_EliminarHuesped", cn);
                cmd.Parameters.AddWithValue("@prmstrDni", huesped.Dni);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            finally { cmd.Connection.Close(); }
            return elimina;
        }

        #endregion metodos
    }
}
