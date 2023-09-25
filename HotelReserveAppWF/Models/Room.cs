using HotelReserveAppWF.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReserveAppWF.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int MaxAmountOfPeople { get; set; }
        public RoomCategory Class { get; set; }
        public string Description { get; set; } = string.Empty;

        public ICollection<ReserveDateInterval>? BookedDates { get; set; }
    }
}
