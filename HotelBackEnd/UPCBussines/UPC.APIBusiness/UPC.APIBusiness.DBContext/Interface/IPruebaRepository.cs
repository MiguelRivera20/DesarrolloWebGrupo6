using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IPruebaRepository
    {
        BaseResponse registroC(HuespedesCheckInEntity usuario);
        BaseResponse GetUsuario(HuespedesCheckInEntity usuario);

    }
}
