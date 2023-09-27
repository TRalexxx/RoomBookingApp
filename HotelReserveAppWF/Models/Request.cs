using HotelReserveAppWF.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReserveAppWF.Models
{
    public class Request
    {
        public RequestType RequestType { get; set; }
        public ICollection<Room>? Rooms { get; set; }
        public ICollection<User>? Users { get; set; }
        public ICollection<RoomReserve>? Reserves { get; set; }

        public RoomRequestParameters? Parameters { get; set; }
    }
}
