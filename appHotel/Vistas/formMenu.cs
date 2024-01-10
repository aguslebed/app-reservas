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
    public partial class formMenu : Form
    {
        formEmpleados empleados;
        formHabitaciones habitaciones;
        formReservas reservas;

        public formMenu()
        {
            InitializeComponent();


        }


        private void formMenu_Load(object sender, EventArgs e)
        {

        }

        private void opcionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_habitaciones_Click(object sender, EventArgs e)
        {
            habitaciones = new formHabitaciones();
            habitaciones.Owner = this;
            habitaciones.Show();
            this.Hide();
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            empleados = new formEmpleados();
            empleados.Owner = this;
            empleados.Show();
            this.Hide();
        }

        private void btn_reservas_Click(object sender, EventArgs e)
        {
            reservas = new formReservas();
            reservas.Owner = this;
            reservas.Show();
            this.Hide();
        }
    }
}
