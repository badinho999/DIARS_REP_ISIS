using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class DatServiciosadicionales
    {
        #region singleton
        private static readonly DatServiciosadicionales instancia = new DatServiciosadicionales();
        public static DatServiciosadicionales Instancia
        {
            get
            {
                return DatServiciosadicionales.instancia;
            }
        }
        #endregion singleton

        #region metodos

        //Listar servicios

        //Obtener servicios del tipo de habitacion
        public List<EntServicioadicional> obtenerServicios(int TipodehabitacionID)
        {
            SqlCommand cmd = null;
            List<EntServicioadicional> servicioadicionals = new List<EntServicioadicional>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Sp_ObtenerServicios", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmintTipodehabitacionID", TipodehabitacionID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    EntServicioadicional servicioadicional = new EntServicioadicional();

                    servicioadicional.NombreDeServicio = Convert.ToString(dr["NombreServicio"]);

                    servicioadicionals.Add(servicioadicional);
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
            return servicioadicionals;
        }

        #endregion metodos
    }
}
