using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.Models;
namespace HotelApi.Data
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        
        public DbSet<Room> Room { get; set; }
        public DbSet<HotelRoom> HotelRoom { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
        public HotelDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hotel>().HasData(new Hotel
            {
                Id = 1,
                City = "seattle",
                Country = "USA",
                Name = "Motel 6",
                Phone = "555-123-5678",
                State = "Washington",
                StreetAddress= "123 Motel st"


            });
        }
    }
}
