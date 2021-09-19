using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class PersonaEntity : BaseEntity
    {
        public int Co_Persona { get; set; }
        public int Co_Tipo_Persona { get; set; }
        public int Co_Tipo_Doc { get; set; }
        public string Tx_Numero_Documento { get; set; }
        public string Tx_Nombre_Completo { get; set; }
        public string Tx_Correo { get; set; }
        public string Tx_Telefono { get; set; }
        public string Tx_Direccion { get; set; }
        public DateTime Fe_Nacimiento { get; set; }
        public DateTime Fe_Registro { get; set; }

    }
}
