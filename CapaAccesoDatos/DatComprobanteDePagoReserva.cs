﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class DatComprobanteDePagoReserva
    {

        #region singleton

        private static readonly DatComprobanteDePagoReserva instancia = new DatComprobanteDePagoReserva();
        public static DatComprobanteDePagoReserva Instancia
        {
            get
            {
                return DatComprobanteDePagoReserva.instancia;
            }
        }

        #endregion singleton

        public Boolean GenerarComprobanteReserva(EntComprobantepagoreserva fact)
        {
            SqlCommand cmd = null;
            Boolean generar;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_GenerarCompReserva", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };

                cmd.Parameters.AddWithValue("@prmintReservaID", fact.Reserva.ReservaID);
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

        public List<EntComprobantepagoreserva> IngresosReserva()
        {
            SqlCommand cmd = null;
            List<EntComprobantepagoreserva> lista = new List<EntComprobantepagoreserva>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_IngresosReserva", cn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntComprobantepagoreserva cr = new EntComprobantepagoreserva
                    {
                        Fechadeemision = Convert.ToString(dr["Fechadeemision"]),
                        Monto = Convert.ToDouble(dr["Cantidad"])
                    };


                    lista.Add(cr);
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
