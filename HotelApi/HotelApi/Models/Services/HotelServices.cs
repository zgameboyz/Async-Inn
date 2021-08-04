using HotelApi.Data;
using HotelApi.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        public async Task<Hotel> Create(Hotel hotel)
        {
            // student is an instance of Sudent
            // the current state of the student object: raw

            _context.Entry(hotel).State = EntityState.Added;
            // the current state of the student object: added

            await _context.SaveChangesAsync();

            return hotel;
        }


        public async Task<List<Hotel>> GetHotels()
        {
            // var students = await _context.Students.ToListAsync();
            // return students;

            return await _context.Hotels
              .Include(s => s)
              .ThenInclude(e => e.Country)
              .ToListAsync();
        }

        public async Task<Hotel> GetHotel(int id)
        {

            // Student student = await _context.Students.FindAsync(id);
            // return student;

            // Student student = await _context.Students.FindAsync(id);
            // var enrollments = await _context.Enrollments.Where(x => x.StudentId == id)
            //                                            .Include(x => x.Course)
            //                                            .ToListAsync();

            // student.Enrollments = enrollments;
            // return student;

            // Now with a mondo linq query

            return await _context.Hotels
                                 .Include(s => s.Name)
                                 
                                 .FirstOrDefaultAsync(s => s.Id == id);


        }

        public async Task<Hotel> UpdateHotel(int id, Hotel hotel)
        {
            _context.Entry(hotel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return hotel;
        }

        public async Task Delete(int id)
        {
            Hotel hotel = await GetHotel(id);
            _context.Entry(hotel).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

    }
}
