using appHotel.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Intrinsics.X86;
using System.Linq.Expressions;


namespace appHotel.Controlador
{
    public class controladorHabitciones
    {
        public void insertarHabitacion(modeloHabitaciones habitacion)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlCommand cmd = new SqlCommand("insertarHabitaciones", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_habitacion", habitacion.num_habitacion);
                cmd.Parameters.AddWithValue("@cant_max_personas", habitacion.cant_max_personas);
                cmd.Parameters.AddWithValue("@aire_acondicionado", habitacion.aire_acondicionado);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Habitacion " + habitacion.num_habitacion + "registrada");
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

        public void devolverHabitacion(ref DataTable dt)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("devolverHabitaciones", ConexionBD.conexion);
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

        public void eliminarHabitacion(int num_habitacion)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlCommand cmd = new SqlCommand("eliminarHabitaciones", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_habitacion", num_habitacion);
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

        public bool buscarHabitacion(int num_habitacion)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlCommand cmd = new SqlCommand("buscarHabitaciones", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("num_habitacion", num_habitacion);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Si hay filas en el conjunto de resultados, la habitación existe
                    return reader.HasRows;
                }
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


        public void modificarHabitacion(modeloHabitaciones habitacion)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlCommand cmd = new SqlCommand("modificarHabitaciones", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_habitacion", habitacion.num_habitacion);
                cmd.Parameters.AddWithValue("@cant_max_personas", habitacion.cant_max_personas);
                cmd.Parameters.AddWithValue("@aire_acondicionado", habitacion.aire_acondicionado);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Habitacion modificada");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {

            }
        }

    }
}
