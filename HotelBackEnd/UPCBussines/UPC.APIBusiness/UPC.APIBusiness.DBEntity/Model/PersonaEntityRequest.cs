using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class PersonaEntityRequest
    {
        public int Co_Persona { get; set; }
        public string Co_Tipo_Persona { get; set; }
        public string Co_Tipo_Doc { get; set; }
        public string Tx_Numero_Documento { get; set; }
        public string Tx_Nombre_Completo { get; set; }
        public string Tx_Correo { get; set; }
        public string Tx_Telefono { get; set; }
        public string Tx_Direccion { get; set; }
        public string Fe_Naciemiento { get; set; }

        public string Co_Genero { get; set; }
    }
}
