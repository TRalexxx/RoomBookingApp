using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReserveAppServer.Controllers
{
    public static class SeedValues
    {
        public static List<int> RoomIds { get; set; } = new List<int>();
        public static List<Guid> UserIds { get; set; } = new List<Guid>();
    }
}
