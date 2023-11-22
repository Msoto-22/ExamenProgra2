using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Examen_Progra2.Clases
{
        public class DBCONEXION
        {

            public static SqlConnection obtenerConexion()
            {
                string s = System.Configuration.ConfigurationManager.ConnectionStrings["CONEXION"].ConnectionString;
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();
                return conexion;
            }
        }
}
