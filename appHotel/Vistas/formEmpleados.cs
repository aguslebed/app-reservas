using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appHotel.Modelo;
using appHotel.Controlador;

namespace appHotel.Vistas
{
    public partial class formEmpleados : Form
    {
        public formEmpleados()
        {
            InitializeComponent();

        }

        private void formEmpleados_Load(object sender, EventArgs e)
        {
            mostrarEmpleados();
        }

        private void mostrarEmpleados()
        {

            controladorEmpleados funcion = new controladorEmpleados();
            DataTable dt = new DataTable();
            funcion.devolverEmpleado(ref dt);
            dgv_empleados.DataSource = dt;
        }

        private void btn_cargarEmpleado_Click(object sender, EventArgs e)
        {
            formCargarEmpleados cargarEmpleados = new formCargarEmpleados();
            cargarEmpleados.Owner = this;
            this.Hide();
            cargarEmpleados.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
            this.Dispose();
        }

        private void dgv_empleados_VisibleChanged(object sender, EventArgs e)
        {
            mostrarEmpleados();
        }

        private void btn_darDeBaja_Click(object sender, EventArgs e)
        {
            if (dgv_empleados.SelectedRows.Count > 0)
            {
                controladorEmpleados funcion = new controladorEmpleados();
                DataGridViewRow filaSeleccionada = dgv_empleados.SelectedRows[0];
                int dni = Convert.ToInt32(filaSeleccionada.Cells["dni"].Value);

                DialogResult resultado = MessageBox.Show("¿Eliminar a " + filaSeleccionada.Cells["nombre"].Value.ToString() + " " + filaSeleccionada.Cells["apellido"].Value.ToString(), "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    funcion.eliminarEmpleado(dni);
                    mostrarEmpleados();
                }

            }
            else
            {
                MessageBox.Show("Selecciona una fila en la tabla para eliminar");
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }
    }

}
