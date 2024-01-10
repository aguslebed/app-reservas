using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace appHotel.Controlador
{
    public class ConexionBD
    {
        public static string cadenaConexion = @"Data source=DESKTOP-D0JCEAT; Initial Catalog=Hotel; Integrated Security=true";
        public static SqlConnection conexion = new SqlConnection(cadenaConexion);

        public static void abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public static void cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

    }
}
