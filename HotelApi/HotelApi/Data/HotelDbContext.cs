using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace HotelApi.Data
{
    public class HotelDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Hotel> Hotels { get; set; }
        
        public DbSet<HotelApi.Models.Room> Room { get; set; }
        public DbSet<HotelApi.Models.HotelRoom> HotelRoom { get; set; }
        public DbSet<HotelApi.Models.Amenities> Amenities { get; set; }
        public DbSet<HotelApi.Models.RoomAmenities> RoomAmenities { get; set; }
        public HotelDbContext(DbContextOptions options) : base(options)
        {
        }

    }
}
