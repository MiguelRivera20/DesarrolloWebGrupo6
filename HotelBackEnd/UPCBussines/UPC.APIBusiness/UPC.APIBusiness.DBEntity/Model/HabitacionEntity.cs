using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class HabitacionEntity : BaseEntity
    {
        public int Co_Habitacion { get; set; }
        public int Co_Tipo_habitacion { get; set; }
        public int Nu_Habitacion { get; set; }
        public int Nu_Piso { get; set; }
    }
}
