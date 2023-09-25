using Bogus;
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
    public class UserFluentConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(x=>x.Reserves).WithOne(x => x.User).HasForeignKey(x => x.UserId);

            var users = new Faker<User>()
                .RuleFor(x => x.Id, f => f.Random.Guid())
                .RuleFor(x => x.Name, f => f.Name.FullName())
                .RuleFor(x => x.Phone, f => f.Phone.Locale)
                .RuleFor(x => x.Email, f => f.Internet.Email())
                .RuleFor(x => x.UserDescription, f => f.Commerce.ProductDescription())
                .Generate(60);

            SeedValues.UserIds = users.Select(x => x.Id).ToList();

            builder.HasData(users);
        }
    }
}
