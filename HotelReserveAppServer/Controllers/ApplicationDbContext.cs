using HotelReserveAppServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReserveAppServer.Controllers
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ReserveDateInterval> ReserveDateIntervals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O6O2RKO;Database=Hotel_res_db;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            // For testing purposes and seeding demo data we have to call fluent configurations manually in a specified order
            builder.ApplyConfiguration(new UserFluentConfiguration());
            builder.ApplyConfiguration(new RoomFluentConfiguration());
            builder.ApplyConfiguration(new ReserveDateIntervalFluentConfiguration());
        }
    }
}
