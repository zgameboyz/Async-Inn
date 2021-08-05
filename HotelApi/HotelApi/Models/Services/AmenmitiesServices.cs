using HotelApi.Data;
using HotelApi.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Models.Services
{
    public class AmenitiesServices : IAmenities
    {
        private HotelDbContext _context;

        public AmenitiesServices(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<Hotel> Create(Hotel hotel)
        {
            _context.Entry(hotel).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return hotel;
        }

        public Task<Amenities> Create(Amenities student)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Amenities> GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Amenities>> GetStudents()
        {
            throw new NotImplementedException();
        }

        public Task<Amenities> UpdateStudent(int id, Amenities student)
        {
            throw new NotImplementedException();
        }
    }
}
