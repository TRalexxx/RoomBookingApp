using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReserveAppServer.Enums
{
    public enum RequestType
    {
        CheckFreeRooms,
        BookRoom,
        FindOrderByUser,
        FindOrderByNumber,
        CancelOrder,
        RoomReserved,
        ServerError,
        CloseApp
    }
}
