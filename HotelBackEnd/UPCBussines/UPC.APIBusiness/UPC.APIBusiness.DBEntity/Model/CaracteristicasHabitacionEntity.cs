using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class CaracteristicasHabitacionEntity
    {
        public int Co_Caracteristicas_Hab { get; set; }
        public string Tx_Descripcion { get; set; }
        public DateTime Fe_Registro { get; set; }
        public string Fl_Estado { get; set; }
        public int Co_Usuario { get; set; }
    }
}
