using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReserveAppWF.Models
{
    public class ReserveDateInterval
    {
        public int Id { get; set; }
        public int ReserveNumber { get; set; }
        public int RoomId { get; set; }
        public Room? Room { get; set; }
        public DateTime StartBookDate { get; set; }
        public DateTime EndBookDate { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
    }
}
