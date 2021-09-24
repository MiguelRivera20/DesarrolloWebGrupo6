using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class UsuarioEntity
    {
        public int Co_Usuario { get; set; }
        public int Co_Persona { get; set; }
        public int Co_Perfil { get; set; }
        public DateTime Fe_Registro { get; set; }
        public string Fl_Estado { get; set; }
        public string Username { get; set; }
    }
}
