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
    public partial class formModificarHabitacion : Form
    {
        modeloHabitaciones habitacionGlobal;

        public formModificarHabitacion()
        {
            InitializeComponent();
        }

        public void traerHabitacion(modeloHabitaciones habitacion)
        {
            habitacionGlobal = habitacion;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            controladorHabitciones funcion = new controladorHabitciones();
            modeloHabitaciones habitaciones = new modeloHabitaciones();
            habitaciones.num_habitacion = Convert.ToInt32(txt_numeroHabitacion.Text);
            habitaciones.cant_max_personas = Convert.ToInt32(num_cantPersonas.Value);
            habitaciones.aire_acondicionado = cb_aire.Checked;

            funcion.modificarHabitacion(habitaciones);

            volverAtras();
        }

        private void formModificarHabitacion_Load(object sender, EventArgs e)
        {
            txt_numeroHabitacion.Text = habitacionGlobal.num_habitacion.ToString();
            num_cantPersonas.Value = habitacionGlobal.cant_max_personas;
            cb_aire.Checked = habitacionGlobal.aire_acondicionado;

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            volverAtras();
        }

        private void volverAtras()
        {
            this.Owner.Show();
            this.Close();
            this.Dispose();
        }
    }
}
