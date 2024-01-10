using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appHotel.Modelo;
using System.Data.SqlClient;
using System.Data;

namespace appHotel.Controlador
{
    public class controladorEmpleados
    {
        public void insertarEmpleado(modeloEmpleados empleado)
        {
			try
			{
				ConexionBD.abrirConexion();
				SqlCommand cmd = new SqlCommand("insertarEmpleados", ConexionBD.conexion);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@nombre",empleado.nombre);
				cmd.Parameters.AddWithValue("@apellido", empleado.apellido);
				cmd.Parameters.AddWithValue("@dni", empleado.dni);
                cmd.Parameters.AddWithValue("@area", empleado.area);


                cmd.Parameters.AddWithValue("@hora_entrada",empleado.hora_entrada.TimeOfDay);
				cmd.Parameters.AddWithValue("@hora_salida",empleado.hora_salida.TimeOfDay);
				cmd.ExecuteNonQuery();
                
            }
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				throw;
			}
			finally
			{
				ConexionBD.cerrarConexion();
			}
        }

        public void devolverEmpleado(ref DataTable dt)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("devolverEmpleados", ConexionBD.conexion);
                da.Fill(dt);
        
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        }

        public void eliminarEmpleado(int dni)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlCommand cmd = new SqlCommand("eliminarEmpleados", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        }
    }
}
