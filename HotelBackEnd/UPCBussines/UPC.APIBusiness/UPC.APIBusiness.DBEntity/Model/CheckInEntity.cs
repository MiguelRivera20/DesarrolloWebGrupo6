using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class CheckInEntity : BaseEntity
    {
        public int Co_Check_In { get; set; }
        public int Co_Cliente { get; set; }
        public int Co_Habitacion { get; set; }
        public int Co_Reserva { get; set; }
        public int Nu_Acompaniantes { get; set; }
        public DateTime Fe_Ingreso { get; set; }
        public DateTime Fe_Salida { get; set; }
        public double Nu_Monto_Adelantado { get; set; }
        public double Nu_Precio_Total { get; set; }
    }
}
