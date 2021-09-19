using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class DetalleHabitacionEntity 
    {
        public int Co_Tipo_Habitacion { get; set; }
        public int Co_Caracteristicas_Hab { get; set; }
        public DateTime Fe_registro { get; set; }
        public string Fl_estado { get; set; }
    }
}
