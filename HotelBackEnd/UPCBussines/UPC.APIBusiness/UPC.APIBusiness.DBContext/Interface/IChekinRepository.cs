using System;
using System.Collections.Generic;
using System.Text;
using DBEntity

namespace DBContext
{
    public interface IChekinRepository
    {
        BaseResponse ChekinPersona(CheckInEntity checkIn);

        BaseResponse GetChekin(CheckInEntity checkIn);
    }
}
