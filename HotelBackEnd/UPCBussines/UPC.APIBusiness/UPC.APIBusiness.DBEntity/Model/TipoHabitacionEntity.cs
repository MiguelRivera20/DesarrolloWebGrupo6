using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity 
{
    public class TipoHabitacionEntity : BaseEntity
    {
        public int Co_Tipo_Habitacion { get; set; }
        public string Tx_Tipo_Habitacion { get; set; }
        public string Tx_Descripcion { get; set; }
        public int Nu_Capacidad { get; set; }
        public double Nu_precio { get; set; }
    }
}
