using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    class Conexion
    {
        #region singleton
        private static readonly Conexion UnicaInstancia = new Conexion();
        public static Conexion Instancia
        {
            get
            {
                return Conexion.UnicaInstancia;
            }
        }
        #endregion singleton

        #region metodos
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=BADINHO\\SQLEXPRESS;initial Catalog=Proyecto_DIARS_ISIS;" + "Integrated Security=true";
            return cn;
        }
        #endregion metodos
    }
}
