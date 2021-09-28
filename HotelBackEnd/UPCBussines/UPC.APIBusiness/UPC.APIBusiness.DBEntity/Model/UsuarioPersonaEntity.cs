using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class UsuarioPersonaEntity
    {
        public int Co_Usuario { get; set; }
        public int Co_Persona { get; set; }
        public int Co_Perfil { get; set; }
        public string Fl_Estado { get; set; }
        public string Tx_Username { get; set; }
        public int Co_Situacion { get; set; }
        public int Co_Tipo_Persona { get; set; }
        public int Co_Tipo_Doc { get; set; }
        public string Tx_Numero_Documento { get; set; }
        public string Tx_Nombre_Completo { get; set; }
        public string Tx_Correo { get; set; }
        public string Tx_Telefono { get; set; }
        public string Tx_Direccion { get; set; }
        public string Fe_Naciemiento_Str { get; set; }
        public int Co_Genero { get; set; }
        public string Fe_registro_str { get; set; }
        public string Tx_nombre_perfil { get; set; }

        public string Tx_Situacion_Nombre { get; set; }
    }
}
