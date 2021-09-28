using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class UsuarioEntityRequest : BaseEntityRequest
    {
        public int Co_Usuario { get; set; }
        public int Co_Persona { get; set; }
        public string Co_Perfil { get; set; }
        public PersonaEntityRequest Persona { get; set; }
      
      
        public string Tx_Username { get; set; }
        public string Co_Situacion { get; set; }
    }
}
