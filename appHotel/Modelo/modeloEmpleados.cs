using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appHotel.Modelo
{
    public class modeloEmpleados
    {
        
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string area { get; set; }
        public DateTime hora_entrada { get; set; }
        public DateTime hora_salida { get; set; }

    }
}
