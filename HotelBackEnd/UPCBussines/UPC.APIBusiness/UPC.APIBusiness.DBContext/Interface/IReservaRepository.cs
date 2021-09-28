using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IReservaRepository
    {
        BaseResponse ReservaPersona(ReservaEntity reserva);

        BaseResponse GetReserva(ReservaEntity reserva);
    }
}
