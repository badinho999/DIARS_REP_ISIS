using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class DatComprobantePagoAlquiler
    {
        #region singleton
        private static readonly DatComprobantePagoAlquiler instancia = new DatComprobantePagoAlquiler();
        public static DatComprobantePagoAlquiler Instancia
        {
            get
            {
                return DatComprobantePagoAlquiler.instancia;
            }
        }
        #endregion singleton

        public Boolean GenerarComprobanteAlquiler(EntComprobantedepagoalquiler fact)
        {
            SqlCommand cmd = null;
            Boolean generar;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_GenerarCompAlquiler", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };

                cmd.Parameters.AddWithValue("@prmintAlquilerID", fact.Alquiler.AlquilerID);
                cmd.Parameters.AddWithValue("@prmdoubleMonto", fact.Monto);
                cmd.Parameters.AddWithValue("@prmintserie", fact.NumeroSerie);

                cn.Open();
                int result = cmd.ExecuteNonQuery();
                generar = result > 0 ? true : false;
            }
            catch (SqlException err)
            {
                throw err;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return generar;
        }

        public List<EntComprobantedepagoalquiler> IngresosAlquiler()
        {
            SqlCommand cmd = null;
            List<EntComprobantedepagoalquiler> lista = new List<EntComprobantedepagoalquiler>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_IngresosAlquiler", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };


                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntComprobantedepagoalquiler ca = new EntComprobantedepagoalquiler
                    {
                        Fechadeemision = Convert.ToString(dr["Fechadeemision"]),
                        Monto = Convert.ToDouble(dr["Cantidad"])
                    };


                    lista.Add(ca);
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

    }
}
