using appHotel.Controlador;
using appHotel.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appHotel.Vistas
{
    public partial class formHabitaciones : Form
    {
        FormCargarHabitaciones cargarHabitaciones;
        public formHabitaciones()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
            this.Dispose();
        }

        private void btn_cargarHabitacion_Click(object sender, EventArgs e)
        {
            cargarHabitaciones = new FormCargarHabitaciones();
            cargarHabitaciones.Owner = this;
            cargarHabitaciones.Show();
            this.Hide();
        }
        private void mostrarHabitaciones()
        {
            controladorHabitciones funcion = new controladorHabitciones();
            DataTable dt = new DataTable();
            funcion.devolverHabitacion(ref dt);
            dgv_habitaciones.DataSource = dt;
        }
        private void formHabitaciones_Load(object sender, EventArgs e)
        {
            mostrarHabitaciones();
        }

        private void dgv_habitaciones_VisibleChanged(object sender, EventArgs e)
        {
            mostrarHabitaciones();
        }

        private void btn_darDeBaja_Click(object sender, EventArgs e)
        {
            if (dgv_habitaciones.SelectedRows.Count > 0)
            {
                controladorHabitciones funcion = new controladorHabitciones();
                DataGridViewRow filaSeleccionada = dgv_habitaciones.SelectedRows[0];
                int num_habitacion = Convert.ToInt32(filaSeleccionada.Cells["num_habitacion"].Value);

                DialogResult resultado = MessageBox.Show("¿Eliminar la habitacion " + num_habitacion.ToString() + "?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    funcion.eliminarHabitacion(num_habitacion);
                    mostrarHabitaciones();
                }

            }
            else
            {
                MessageBox.Show("Selecciona una fila en la tabla para eliminar");
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            formModificarHabitacion modificarHabitacion = new formModificarHabitacion();
            if (dgv_habitaciones.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_habitaciones.SelectedRows[0];
                modeloHabitaciones habitacion = new modeloHabitaciones();
                habitacion.num_habitacion = Convert.ToInt32(filaSeleccionada.Cells["num_habitacion"].Value);
                habitacion.cant_max_personas = Convert.ToInt32(filaSeleccionada.Cells["cant_max_personas"].Value);
                habitacion.aire_acondicionado = Convert.ToBoolean(filaSeleccionada.Cells["aire_acondicionado"].Value);
                modificarHabitacion.traerHabitacion(habitacion);
                modificarHabitacion.Owner = this;
                modificarHabitacion.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
            
        }
    }
}
