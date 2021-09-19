using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class ReservaEntity
    {
        public int Co_Reserva { get; set; }
        public int Co_Cliente { get; set; }
        public int Co_Tipo_Habitacion { get; set; }
        public DateTime Fe_Ingreso { get; set; }
        public DateTime Fe_Salida { get; set; }
        public string Fl_Pago_Total { get; set; }
        public int Nu_Acompaniantes { get; set; }
        public double Nu_Monto_Adelanto { get; set; }
        public int Nu_Tipo_Pago { get; set; }
        public DateTime Fe_Registro { get; set; }
        public string Fl_Estado { get; set; }

    }
}
