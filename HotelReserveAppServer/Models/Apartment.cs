using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReserveAppServer.Enums;

namespace HotelReserveAppServer.Models
{
    public class Apartment
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public bool IsReserved { get; set; }
        public ApartmentClass Class { get; set; }
        public string Description { get; set; } = string.Empty;

        public DateTime ReserveStart { get; set; }
        public DateTime ReserveEnd { get; set; }

        public Guid? UserId { get; set; }
        public User? User { get; set; }
    }
}
