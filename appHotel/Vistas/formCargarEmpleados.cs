using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appHotel.Controlador;
using appHotel.Modelo;

namespace appHotel.Vistas
{
    public partial class formCargarEmpleados : Form
    {

        public formCargarEmpleados()
        {
            InitializeComponent();

        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
            this.Dispose();
        }

        private bool verificarCamposLlenos()
        {
            if (txt_apellido.Text != null && txt_area.Text != null && txt_dni.Text != null && txt_nombre.Text != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (verificarCamposLlenos())
            {
                modeloEmpleados empleado = new modeloEmpleados();
                controladorEmpleados funcion = new controladorEmpleados();
                empleado.nombre = txt_nombre.Text;
                empleado.apellido = txt_apellido.Text;
                empleado.dni = Convert.ToInt32(txt_dni.Text);
                empleado.area = txt_area.Text;


                // Le agrego la fecha porque son variables DateTime, y el DateTimePicker me da solamente la hora.
                empleado.hora_entrada = DateTime.Today + dtp_horaEntrada.Value.TimeOfDay;
                empleado.hora_salida = DateTime.Today + dtp_horaSalida.Value.TimeOfDay;
                //Le saco los segundos
                empleado.hora_entrada = new DateTime(empleado.hora_entrada.Year, empleado.hora_entrada.Month, empleado.hora_entrada.Day, empleado.hora_entrada.Hour, empleado.hora_entrada.Minute, 0);
                empleado.hora_salida = new DateTime(empleado.hora_salida.Year, empleado.hora_salida.Month, empleado.hora_salida.Day, empleado.hora_salida.Hour, empleado.hora_salida.Minute, 0);

                funcion.insertarEmpleado(empleado);

                txt_apellido.Clear();
                txt_area.Clear();
                txt_dni.Clear();
                txt_nombre.Clear();
                dtp_horaEntrada.Value = DateTime.Now;
                dtp_horaSalida.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Rellena todos los campos");
            }      
        }

        private void formCargarEmpleados_Load(object sender, EventArgs e)
        {
            dtp_horaEntrada.Format = DateTimePickerFormat.Custom;
            dtp_horaEntrada.CustomFormat = "HH:mm";
            dtp_horaSalida.Format = DateTimePickerFormat.Custom;
            dtp_horaSalida.CustomFormat = "HH:mm";
        }
    }
}
