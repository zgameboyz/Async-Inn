using HotelApi.Data;
using HotelApi.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Models.Services
{
    public class RoomServices : IRooms
    {
        private HotelDbContext _context;

        public RoomServices(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<Hotel> Create(Hotel hotel)
        {
            _context.Entry(hotel).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return hotel;
        }

        public Task<Room> Create(Room student)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Room>> GetStudents()
        {
            throw new NotImplementedException();
        }

        public Task<Room> UpdateStudent(int id, Room student)
        {
            throw new NotImplementedException();
        }
    }
}
