using HotelApi.Data;
using HotelApi.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Models.Services
{
    public class HotelServices : IHotel
    {
        private HotelDbContext _context;

        public HotelServices(HotelDbContext context)
        {
            _context = context;
        }

        //return View(await _context.Hotels.ToListAsync());
        public async Task<List<Hotel>> GetAllHotels()
        {
            return await _context.Hotels.ToListAsync();

        }
        public async Task<Hotel> Create(Hotel hotel)
        {
            Debug.WriteLine(hotel);
            _context.Entry(hotel).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return hotel;
        }

        public async Task<Hotel> GetHotel(int Id)
        {
            var hotelData = await _context.Hotels.FindAsync(Id);
            
            return hotelData;
        }
    }
}
