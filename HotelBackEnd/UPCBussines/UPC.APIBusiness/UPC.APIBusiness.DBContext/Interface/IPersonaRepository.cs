using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IPersonaRepository
    {
        BaseResponse RegistroPersona(PersonaEntity persona);
        BaseResponse GetPersona(PersonaEntity persona);
    }
}
