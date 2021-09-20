using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IUsuarioRepository
    {
        BaseResponse RegistroUsuario(UsuarioEntity usuario);
        BaseResponse GetUsuario(UsuarioEntity usuario);

    }
}
