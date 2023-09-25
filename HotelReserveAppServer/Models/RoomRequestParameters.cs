using HotelReserveAppServer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReserveAppServer.Models
{
    public class RoomRequestParameters
    {
        public DateTime ReserveFrom { get; set; }
        public DateTime ReserveTo { get; set;}
        public RoomCategory Category { get; set; }
        public int AmountofPeople { get; set; }
    }
}
