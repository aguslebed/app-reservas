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
    public partial class formReservas : Form
    {
        public formReservas()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
            this.Dispose();
        }
    }
}
