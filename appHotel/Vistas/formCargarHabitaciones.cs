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
    public partial class FormCargarHabitaciones : Form
    {
        public FormCargarHabitaciones()
        {
            InitializeComponent();
        }

        private void FormCargarHabitaciones_Load(object sender, EventArgs e)
        {

        }

        private void txt_numeroHabitacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            volverAtras();
        }

        private bool verificarCamposLlenos()
        {
            if (txt_numeroHabitacion.Text != "" && num_cantPersonas.Text != 0.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void volverAtras()
        {
            this.Owner.Show();
            this.Close();
            this.Dispose();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (verificarCamposLlenos())
            {
                modeloHabitaciones habitaciones = new modeloHabitaciones();
                controladorHabitciones funcion = new controladorHabitciones();
                int numeroHabitacion = Convert.ToInt32(txt_numeroHabitacion.Text);

                if (!funcion.buscarHabitacion(numeroHabitacion))
                {
                    habitaciones.num_habitacion = Convert.ToInt32(txt_numeroHabitacion.Text);
                    habitaciones.cant_max_personas = Convert.ToInt32(num_cantPersonas.Value);
                    habitaciones.aire_acondicionado = cb_aire.Checked;
                    funcion.insertarHabitacion(habitaciones);

                    txt_numeroHabitacion.Clear();
                    num_cantPersonas.Value = 1;
                    cb_aire.Checked = false;
                    volverAtras();
                }
                else
                {
                    MessageBox.Show("La habitacion nro " + txt_numeroHabitacion.Text + " ya esta registrada");
                }
            }
        }
    }
}
