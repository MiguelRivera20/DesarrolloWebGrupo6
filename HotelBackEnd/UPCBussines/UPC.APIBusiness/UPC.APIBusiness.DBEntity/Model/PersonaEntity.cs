using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    class PersonaEntity : BaseEntity
    {
        private int Co_Persona { get; set; }
        private  int Co_Tipo_Persona { get; set; }
        private int Co_Tipo_Doc { get; set; }
        private string Tx_Numero_Documento { get; set; }
        private string Tx_Nombre_Completo { get; set; }
        private string Tx_Correo { get; set; }
        private string Tx_Telefono { get; set; }
        private string Tx_Direccion { get; set; }
        private DateTime Fe_Nacimiento { get; set; }
        private DateTime Fe_Registro { get; set; }

    }
}
