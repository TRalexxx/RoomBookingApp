﻿using Bogus;
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
    public class RoomReserveFluentConfiguration : IEntityTypeConfiguration<RoomReserve>
    {
        public void Configure(EntityTypeBuilder<RoomReserve> builder)
        {
            var reserves = new Faker<RoomReserve>()
                .RuleFor(x => x.Id, f => f.UniqueIndex)
                .RuleFor(x => x.ReserveNumber, f => f.Random.Number(100000000, 999999999))
                .RuleFor(x => x.RoomId, f => f.PickRandom(SeedValues.RoomIds))
                .RuleFor(x => x.UserId, f => f.PickRandom(SeedValues.UserIds))
                .RuleFor(x => x.StartBookDate, f => f.Date.Between(DateTime.Now.AddDays(1), DateTime.Now.AddDays(5)))
                .RuleFor(x => x.EndBookDate, f => f.Date.Between(DateTime.Now.AddDays(6), DateTime.Now.AddDays(10)))
                .RuleFor(x=>x.AdditionalInfo, f=>f.Lorem.Sentence())
                .Generate(30);

            builder.HasData(reserves);
        }
    }
}
