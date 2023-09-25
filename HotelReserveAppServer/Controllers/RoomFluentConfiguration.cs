using Bogus;
using HotelReserveAppServer.Enums;
using HotelReserveAppServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReserveAppServer.Controllers
{
    public class RoomFluentConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasMany(x=>x.ReservedDates).WithOne(x=>x.Room).HasForeignKey(x=>x.RoomId);

            var rooms = new Faker<Room>()
                .RuleFor(x => x.Id, f => f.UniqueIndex)
                .RuleFor(x => x.Number, f => f.Random.Number(101, 520))
                .RuleFor(x => x.MaxAmountOfPeople, f => f.Random.Number(1, 6))
                .RuleFor(x => x.Class, f => f.PickRandom<RoomCategory>())
                .RuleFor(x => x.Description, f => f.Commerce.ProductDescription())
                .Generate(50);

            SeedValues.RoomIds = rooms.Select(x => x.Id).ToList();

            builder.HasData(rooms);
        }
    }
}
